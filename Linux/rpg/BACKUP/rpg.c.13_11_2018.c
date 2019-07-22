// chmod a+xs a.out
// history -a now.txt

//Check syntax
// bash -n now.txt

#include <stdio.h>
#include <stdlib.h> //System commands
#include <unistd.h> //Sleep();
#include <string.h> //strcat
#include <ctype.h>

//Check directory and mkdir
#include <sys/types.h>
#include <sys/stat.h>
#include <unistd.h>

#include <dirent.h>

#include <sys/ioctl.h>

#include <pwd.h>  //userExists
//#include <term.h>

#include <time.h>

//Get users online
#include<sys/utsname.h>
#include<utmp.h>


#define stringSize (char *)malloc(255*sizeof(char))

#define symRow '-'
#define symFill "#"
#define symNotFill "-"

#define maxDay 2
#define forHour 2


#define KNRM "\x1B[0m" 
#define KRED "\x1B[31m" 
#define KGRN "\x1B[32m" 
#define KYEL "\x1B[33m" 
#define KBLU "\x1B[34m" 
#define KMAG "\x1B[35m" 
#define KCYN "\x1B[36m"
#define KWHT  "\x1B[37m"


/*#define usernameColor "\033[31;1m"
#define white "\033[39;1m"
#define rowColor "\033[32;1m"
#define msgColor "\033[33;255m"*/
#define usernameColor "\x1B[37m"
#define white "\x1B[39m"
#define statColor usernameColor
//#define rowColor white 
#define rowColor "\x1B[32m"
#define msgColor "\x1B[36m"
#define branchColor rowColor
#define fillColor statColor
#define notFillColor "\x1B[36m"
#define NEXT 3

#define programName "rpg"

char *username;
char mainDir[] = "/var/lib/rpg";
char usersFolderName[] = "users";
char usersDir[255] = "\0";
char userDir[255]="\0";
char userExpPath[255]="\0";
char userTimePath[255]="\0";
char userExpFile[] = "exp";
char userTimeFile[] = "time";
char userLastDayFile[] = "lastDay";
char todayRandFile[] = "todayRand";

typedef struct{
	char* nickname;
	int place;
	int exp;
	int startExp;
	int nextUp;
	int lvl;
}user;

//struct user initUser(char *username);
user curUser;
user* Users;
int regUsers = 0;

int amionline()
{
  int online = 0;
  struct utmp *n;
  setutent();
  n=getutent();
  char *us = getlogin();
  while(n) {
    if(n->ut_type==USER_PROCESS) {
      if(strCompare(n->ut_user,us)==1)
	{
		online = 1;
		break;
	}
    }
    n=getutent();
  }
  return online;
}

const char * createTempDir()
{
  char template[] = "/tmp/tmpdir.XXXXXX";
  char *tmp_dirname = mkdtemp(template);
  return tmp_dirname;
}

int getDay(){
  time_t theTime = time(NULL);
  struct tm *aTime = localtime(&theTime);
  int day=aTime->tm_mday;
  return day;
//  printf("hour: %d\n",day);
}

int getMonth(){
  time_t theTime = time(NULL);
  struct tm *aTime = localtime(&theTime);
  int mnth=aTime->tm_mon + 1;
  return mnth;
//  printf("hour: %d\n",day);
}

int intlen(int num){
  int nDigits = 1;
  if(num<0){num=num*(-1); nDigits = 2;}
  float f = num;
  while(f>=10){
	f/=10;
	nDigits+=1;
  }
  return nDigits;
}

int* expToLvl(int exp){
  int startExp = 0;
  int forNext = NEXT;
  int lvl = 0;
  int d = forNext;
  int tmpExp = exp;
  while (tmpExp>=d){
	lvl+=1;
	tmpExp-=d;
	d+=1;
	startExp = forNext;
	forNext+=d;
  }
  int* ret=(int *) malloc(3 * sizeof(int) );
  ret[0]=lvl;
  ret[1]=forNext;
  ret[2]=startExp;
  return ret;
}

int createDir(char path[255]){
  struct stat st = {0};
  if (stat(path, &st) == -1){
    mkdir(path, 0700);
  }
}

int existsDir(char path[255]){
  struct stat st = {0};
  if (stat(path, &st) == -1){
    return 0; //Folder not exists
  }
  return 1;
}


int fileExists(char path[255]){
  FILE *f;
//  printf(" %d ",f=fopen(path,"r"));
  
  f = fopen(path,"r");
  if (f != NULL)
  {
//	printf("File exists ");
	fclose(f);
	return 1;
  } else return 0;
/*  if( access( path, F_OK ) != -1 ){
    return 1;
  } else { return 0;}*/
}

int userExists(char *usernameCheck){
  int ret = 1;
  struct passwd *exists = getpwnam(usernameCheck);
  if (exists == NULL) ret = 0;
  return ret;
}

int getWidth(){
  struct winsize w;
  ioctl(0,TIOCGWINSZ, &w);
  return w.ws_col;
}

void fillRow(char sym){
  int widthScreen = getWidth();
  printf(rowColor);
  int i;
  for(i=0;i<widthScreen;i++){
    printf("%c",sym);
  }
  printf(white);
  return;
}

void spacesToCenter(size_t strLen){
  size_t Spaces = (size_t)(getWidth()-strLen)/2;
  size_t i;
  for(i=0;i<Spaces;i++){
    printf(" ");
  }
  return;
}

void writeWelcome(){
  char *msgTo = stringSize;
  char *tmpMsg = stringSize;
  size_t lenMsg = 0;
  strcpy(msgTo,msgColor);
  tmpMsg = "Добро пожаловать на сервер, ";
  lenMsg=strlen(tmpMsg);
  strcat(msgTo,tmpMsg);
  strcat(msgTo,usernameColor);
  curUser.nickname = getlogin();
  tmpMsg = curUser.nickname;
  lenMsg = lenMsg+strlen(tmpMsg);
  strcat(msgTo,tmpMsg);
  strcat(msgTo,msgColor);
  tmpMsg = "!";
  lenMsg = lenMsg+strlen(tmpMsg);
  strcat(msgTo,tmpMsg);
  strcat(msgTo,"\n");
  spacesToCenter(29+strlen(curUser.nickname));
  printf("%s",msgTo);
  //printf("%sПривет, \x1B[33m%s%s!\x1B[37m\n",msgColor,username,msgColor);
}

void writeProgress(){
  printf("\n");
  //printf("dlina %d ",intlen(123));
  if(strcmp(curUser.nickname,getlogin())==0)
  {
    spacesToCenter(41);
    printf("%sНа данный момент, твоя статистика такова:\n",msgColor);
  } else
  {
    spacesToCenter(strlen(curUser.nickname)+1);
    printf("%s%s%s:\n\n",usernameColor,curUser.nickname,msgColor);
  }
  spacesToCenter(10+intlen(curUser.lvl)+intlen(1));
  printf("%s- %s%d уровень%s\n",msgColor,statColor,curUser.lvl,msgColor);
//  printf("exp %d next %d lvl %d\n",curUser.exp,curUser.nextUp,curUser.lvl);
  spacesToCenter(10+intlen(curUser.lvl)+intlen(1));
  printf("- %sопыт %d%s\n",statColor,curUser.exp,msgColor);
  spacesToCenter(10+intlen(curUser.lvl)+intlen(1));
  printf("- %s%d место%s (%s%s top%s)\n\n\n\n\n",statColor,curUser.place,msgColor,statColor,programName,msgColor);
  
  int startExp,endExp;
  startExp = curUser.exp-curUser.startExp;
  endExp = curUser.nextUp-curUser.startExp;
  spacesToCenter(14+intlen(startExp)+intlen(endExp));
  printf("Шкала опыта: %s%d%s/%s%d\n\n",statColor,startExp,msgColor,notFillColor,endExp);
  spacesToCenter(41);
  printf("%s[%s",branchColor,fillColor);
  int full = 41-2;
	 int expNow = curUser.exp-curUser.startExp;
	 int expNeed = curUser.nextUp-curUser.startExp;

//  int expNow = 0,expNeed = 3;
  if(curUser.exp<0)
  {
	expNow = 0;
	expNeed = 3;
  }
  float ExpPercent = (float)expNow/expNeed*100;
  int fill = (int)ExpPercent*full/100;
  int notFill = full-fill;
  int i;
  for (i=0;i<fill;i++) printf(symFill);
  printf(notFillColor);
  for (i=0;i<notFill;i++) printf(symNotFill);


//  printf(" fill %d ",fill);
//  printf("    exp %d        start %d       next %d ",curUser.exp,curUser.startExp,curUser.nextUp);
//  float f = fill;
//  printf("%.2f",f);
  printf("%s]%s\n",branchColor,msgColor);  
}

void writeMsg(int wrtWelcome){
//  setupterm(NULL, STDOUT_FILENO, NULL);
//  putp(enter_bold_mode);

  printf("\n");
//  fillRow(symRow);
  printf("\n\n");
  if (wrtWelcome==1)
	writeWelcome();
  writeProgress();
  printf("\n");
//  fillRow(symRow);
  printf("%s\n\n",white);
  
//  putp(exit_attribute_mode);
  return;
}

void initUser(user* tmpUser,char *username){
  tmpUser->lvl=0;
  tmpUser->startExp=0;
  tmpUser->exp=0;
  tmpUser->nextUp=NEXT;
  tmpUser->nickname = username;
  tmpUser->place = 0;
//  if(strcmp(username,getlogin())=0){
  char userD[255],userExpPth[255],userLastDayPth[255];
//  char userLastDayFile[] = "lastDay";

  strcpy(userD,usersDir);
  strcat(userD,"/");
  strcat(userD,username);
  createDir(userD);

  strcpy(userExpPth,userD);
  strcat(userExpPth,"/");
  strcat(userExpPth,userExpFile);

  strcpy(userLastDayPth,userD);
  strcat(userLastDayPth,"/");
  strcat(userLastDayPth,userLastDayFile);
  int rf = 0;
  if (fileExists(userExpPth)==1){
	FILE *f=fopen(userExpPth,"r");
	fscanf(f,"%d",&rf);
	fclose(f);
	tmpUser->exp = rf;
	int* tmp=(int *)malloc(3*sizeof(int));
	tmp = expToLvl(rf);
	tmpUser->lvl = tmp[0];
	tmpUser->nextUp = tmp[1];
	tmpUser->startExp = tmp[2];
  } else {
	FILE *f=fopen(userExpPth,"w");
	fprintf(f,"0");
	fclose(f);
  }
  if (strcmp(getlogin(),username)==0)
  {
	  if (fileExists(userLastDayPth)==0)
	  {
		FILE *f=fopen(userLastDayPth,"w");
		fprintf(f,"%d",getDay());
		fclose(f);
	  } else {
		FILE *f=fopen(userLastDayPth,"r");
		int lastDay = 0,today = getDay();
		fscanf(f,"%d",&lastDay);
//		printf("Last %d\n",lastDay);
		fclose(f);
		if(lastDay!=today)
		{
			FILE *f=fopen(userLastDayPth,"w");
			fprintf(f,"%d",today);
			fclose(f);

			char todayRandPth[255];
			strcpy(todayRandPth,mainDir);
			strcat(todayRandPth,"/");
			strcat(todayRandPth,todayRandFile);
			f=fopen(todayRandPth,"r");
			int lastD,addExp = 1;
			fscanf(f,"%d %d",&lastD,&addExp);
			fclose(f);

			rf+=addExp;

			tmpUser->exp = rf;
			int* tmp=(int *)malloc(3*sizeof(int));
			tmp = expToLvl(rf);
			tmpUser->lvl = tmp[0];
			tmpUser->nextUp = tmp[1];
			tmpUser->startExp = tmp[2];

			f=fopen(userExpPth,"w");
			fprintf(f,"%d",rf);
			fclose(f);

		}
	  }
  }
}

void countUsers(){
  DIR *dir,*dirInner;
  struct dirent *ent, *entInner;
  regUsers = 0;
  if ((dir = opendir (usersDir)) != NULL) {
	while ((ent = readdir (dir)) != NULL) {
		if(ent->d_name==NULL) printf("NULL");
//	   usDir="\0";
	   char usDir[255];
	   strcpy(usDir,usersDir);
	   strcat(usDir,"/");
	   strcat(usDir,ent->d_name);
	   //if (ent->d_name[0]!='.')//{ printf(" this %s dir",usDir);}
	   if ((strcmp(ent->d_name,".") != 0) && (strcmp(ent->d_name,"..") != 0))
	   if ((dirInner = opendir(usDir)) != NULL) { 
		regUsers+=1;
		closedir(dirInner);
	   }
	}
	closedir(dir);
  }
  return;
}


void createTop(){
  countUsers();
  Users = (user*)malloc(sizeof(user) * regUsers);
  //Users[99].nickname="fhjvhkhhkgfg";
//  *Users = malloc(regUsers * sizeof *Users);
//  printf(" reg %d users",regUsers);
  DIR *dir,*dirInner;
  struct dirent *ent,*entInner;
  int userC = 0;
  if ((dir = opendir (usersDir)) != NULL) {
	while ((ent = readdir (dir)) != NULL) {
		if(ent->d_name==NULL) printf("NULL");
//	   usDir="\0";
	   char usDir[255];
	   strcpy(usDir,usersDir);
	   strcat(usDir,"/");
	   strcat(usDir,ent->d_name);
	   //if (ent->d_name[0]!='.')//{ printf(" this %s dir",usDir);}
	   if ((strcmp(ent->d_name,".") != 0) && (strcmp(ent->d_name,"..") != 0))
	   if ((dirInner = opendir(usDir)) != NULL) { 
//		printf ("%s\n", usDir);
//		user tmpUser;
//		Users[userC]=tmpUser;
		initUser(&Users[userC],ent->d_name);
		userC+=1;
		closedir(dirInner);
	   }
	}
	closedir(dir);
  }
  user tmpUser;
  int el1,el2;
  for(el1=0;el1<regUsers-1;el1++){
	for(el2=0;el2<regUsers-1-el1;el2++)
	{
		if (Users[el2].exp<Users[el2+1].exp)
		{
			tmpUser = Users[el2];
			Users[el2] = Users[el2+1];
			Users[el2+1] = tmpUser;
		}
	}
  }
  for(el1=0;el1<regUsers;el1++){
	Users[el1].place=el1+1;
//	printf(" %s  %d\n",Users[el1].nickname,Users[el1].exp);
	if (strcmp(Users[el1].nickname,curUser.nickname)==0)
		curUser.place=el1+1;
  }
  return;
}

int randExp()
{
  int r = rand()%maxDay+1;
  if (getDay()==9)
	if(getMonth()==10)
		r = 910;
  return r;
}

void createStructure(int makeTop){
    createDir(mainDir);
    strcpy(usersDir,mainDir);
    strcat(usersDir,"/");
    strcat(usersDir,usersFolderName);
    createDir(usersDir);
    char* curUsername = getlogin();
    strcpy(userDir,usersDir);
    strcat(userDir,"/");
    strcat(userDir,curUsername);
    createDir(userDir);

    strcpy(userExpPath,userDir);
    strcat(userExpPath,"/");
    strcat(userExpPath,userExpFile);

    strcpy(userTimePath,userDir);
    strcat(userTimePath,"/");
    strcat(userTimePath,userTimeFile);


    srand(time(NULL));
  char todayRandPth[255];
  strcpy(todayRandPth,mainDir);
  strcat(todayRandPth,"/");
  strcat(todayRandPth,todayRandFile);

  if(fileExists(todayRandPth) == 0)
  {
    FILE *f=fopen(todayRandPth,"w");
    fprintf(f,"%d %d",getDay(),randExp());
    fclose(f);
  } else {
	FILE *f=fopen(todayRandPth,"r");
	int lastD,lastE;
	fscanf(f,"%d %d",&lastD,&lastE);
	fclose(f);
	if(lastD!=getDay())
	{
	    FILE *f=fopen(todayRandPth,"w");
	    fprintf(f,"%d %d",getDay(),randExp());
	    fclose(f);
	}
  }

  if (makeTop==1) {
    initUser(&curUser,curUsername);
    createTop();
  }
}

void writeHelp(int admin){
  printf("\n %s%s top %s- показать себя в топе среди других пользователей",statColor,programName,msgColor);
  printf("\n %s%s top N %s- открыть топ на странице N",statColor,programName,msgColor);
  printf("\n %s%s stats %s- показать статистику",statColor,programName,msgColor);
  //printf("\n %s%s stats ник_пользователя %s- показать статистику пользователя",statColor,programName,msgColor);
  if(admin==1)
  {
	printf("\n\n %sФункции админа:",KRED);
	printf("\n %s%s + ник_пользователя N: %s добавить пользователю N опыта ",statColor,programName,msgColor);
	printf("\n %s%s - ник_пользователя N: %s убавить у пользователя N опыта ",statColor,programName,msgColor);
	printf("\n %s%s = ник_пользователя N: %s приравнять пользователю N опыта ",statColor,programName,msgColor);
	printf("\n %s%s \\* ник_пользователя N: %s умножить опыт пользователя на N единиц",statColor,programName,msgColor);
	printf("\n %s%s \\/ ник_пользователя N: %s поделить опыт пользователя на N единиц",statColor,programName,msgColor);
  }
  printf("%s\n\n",white);
  return;
}

int changeExp(char sign,char *userToChange, char *constUpdate)
{
  char userFolderToUpdate[255];
  strcpy(userFolderToUpdate,usersDir);
  strcat(userFolderToUpdate,"/");
  strcat(userFolderToUpdate,userToChange);
  char fileUserUpdate[255];
  strcpy(fileUserUpdate,userFolderToUpdate);
  strcat(fileUserUpdate,"/");
  strcat(fileUserUpdate,userExpFile);
  
  int doNext = 1;
  char tmpCmd[255] = "\0";
  if(existsDir(userFolderToUpdate) == 0){
	createStructure(1);
		int indUser = 0;
	int founded = 0;
	for(indUser=0;indUser<regUsers;indUser++)
		{
		char tmpNick1[255],tmpNick2[255];
		strcpy(tmpNick1,Users[indUser].nickname);
		strcpy(tmpNick2,userToChange);
		int c;
		for(c=0;c<strlen(tmpNick1);c++)
			tmpNick1[c] = tolower(tmpNick1[c]);
		for(c=0;c<strlen(tmpNick2);c++)
			tmpNick2[c] = tolower(tmpNick2[c]);
		if(strcmp(tmpNick1,tmpNick2)==0)
		{
		  strcpy(userToChange,Users[indUser].nickname);
		  strcpy(userFolderToUpdate,usersDir);
		  strcat(userFolderToUpdate,"/");
		  strcat(userFolderToUpdate,Users[indUser].nickname);
		  strcpy(fileUserUpdate,userFolderToUpdate);
		  strcat(fileUserUpdate,"/");
		  strcat(fileUserUpdate,userExpFile);
		  founded = 2;
		  break;
		}
	}

	if(founded==0)
	{
	printf("\n %sПользователь %s%s %sещё не зарегистрирован в программе!\n",msgColor,usernameColor,userToChange,msgColor);
	printf(" %sДобавить пользователя %s%s %s? (y - чтобы добавить| n - чтобы отменить действие)\n\n %s",msgColor,usernameColor,userToChange,msgColor,white);
	char s = '\0';
	scanf("%c",&s);
	printf("\n %s",msgColor);
	if(s!='y')
	{
		printf("%sДейстиве отменено!\n\n%s",msgColor,white);
		doNext = 0;
	} else
	{
		strcpy(tmpCmd,"mkdir ");
		strcat(tmpCmd,userFolderToUpdate);
		if(system(tmpCmd)!=0) { printf("%sНет доступа!%s\n\n",msgColor,white); return 0;}
		else {
			strcpy(tmpCmd,"echo 0 > ");
			strcat(tmpCmd,fileUserUpdate);
			system(tmpCmd);
		}
	}
     }
  }
	int userExp = 0;
	float updateExp = 0;
	if (doNext==1)
	{
		FILE *f = fopen(fileUserUpdate,"r");
		fscanf(f,"%d",&userExp);
		fclose(f);
		updateExp = atof(constUpdate);
		printf("\n %sОпыт пользователя %s%s%s: %s%d\n",msgColor,usernameColor,userToChange,msgColor,statColor,userExp);
	switch(sign){
		case '+':
			userExp+=updateExp;
			break;
		case '-':
			userExp-=updateExp;
			break;
		case '=':
			userExp=updateExp;
			break;
		case '*':
			userExp=(int)userExp*updateExp;
			break;
		case '/':
			userExp=(int)userExp/updateExp;
			break;
		}
		strcpy(tmpCmd,"echo ");
		char strExp[255];
		sprintf(strExp,"%d",userExp);
		strcat(tmpCmd,strExp);
		strcat(tmpCmd," > ");
		strcat(tmpCmd,fileUserUpdate);
		if(system(tmpCmd)!=0) { printf("%sНет доступа!%s\n\n",msgColor,white); return 0;}
//		f = fopen(fileUserUpdate,"w");
//		fprintf(f,"%d",userExp);
//		fclose(f);
		printf(" %sНовый опыт пользователя: %s%d\n\n",msgColor,statColor,userExp);
	}

//  printf("\ndir user %s\nfile user %s\n\n",userFolderToUpdate,fileUserUpdate);
  //system(usersDir);
  return 1;
}

void writeTop(int page)
{
  int strt = (page-1)*10, end = strt+10-1;
  if (page==0)
  {
    strt=0; end=regUsers-1;
  }
  if (end>=regUsers)
  {
    end = regUsers-1;
  }
  if(strt<0) strt=0;
//  if(strt>regUsers){strt=end-10;}
  char tmpInfo[255];
  char strPlace[255];
  int place,maxSym=0,next=1,last=0;
/*  for(place=strt;place<=end;place++)
	if (strlen(Users[place].nickname)>maxSym)
	{
		maxSym=strlen(Users[place].nickname);
		if(place==end)
			last = 1;
	}*/
//  if (maxSym>18)
//	maxSym=18;
/*  if (last == 1)
	maxSym++;
  char spaces[255],spaces2[255];
  int maxLvlSym = intlen(Users[strt].lvl)-intlen(Users[end].lvl);*/
  int i;
  int larger = intlen(Users[strt].lvl)+intlen(Users[strt].exp);
  char spaces[255];
  printf("\n");
  for(place=strt;place<=end;place++)
  {
	strcpy(spaces,"");
	for(i=0;i<larger-intlen(Users[place].lvl)-intlen(Users[place].exp);i++)
		strcat(spaces," ");

/*	strcpy(spaces,"");
	strcpy(spaces2,"");
	if (place == end)
		if (intlen(place)==intlen(place+1))
		{
			for(i=0;i<maxSym-strlen(Users[place].nickname);i++)
				strcat(spaces,"");
			next = 0;
		}

	if (next==1)
	for(i=0;i<maxSym-strlen(Users[place].nickname);i++)
		strcat(spaces," ");
	printf("some problem with spaces");
	if(spaces == NULL)
		strcpy(spaces," ");
	for(i=0;i<maxLvlSym-intlen(Users[place].lvl);i++)
		strcat(spaces2," ");*/
	if(strcmp(Users[place].nickname,curUser.nickname)==0)
		printf(" %s(%d) (%d уровень| опыта %d) %s%s%s\n",KGRN,place+1,Users[place].lvl,Users[place].exp,spaces,Users[place].nickname,white);
//		printf(" %s%d) %s \n   (%d уровень| опыта %d)%s\n\n",KGRN,place+1,Users[place].nickname,Users[place].lvl,Users[place].exp,white);
	else if(strcmp(Users[place].nickname,"KirKhal")==0)
		printf(" %s(%d) (%d уровень| опыта %d) %s(Разработчик) %s%s\n",KRED,place+1,Users[place].lvl,Users[place].exp,spaces,Users[place].nickname,white);
//		printf(" %s%d) %s (Разработчик) (%d уровень| опыта %d)%s\n\n",KRED,place+1,Users[place].nickname,Users[place].lvl,Users[place].exp,white);
	else printf(" %s(%d)%s (%s%d уровень%s|%s опыта %d%s)%s %s%s%s\n",msgColor,place+1,msgColor,statColor,Users[place].lvl,msgColor,statColor,Users[place].exp,msgColor,spaces,usernameColor,Users[place].nickname,white);
//	else printf(" %s%d) %s%s %s\n   (%s%d уровень%s|%s опыта %d%s)%s\n\n",msgColor,place+1,usernameColor,Users[place].nickname,msgColor,statColor,Users[place].lvl,msgColor,statColor,Users[place].exp,msgColor,white);

/*	sprintf(strPlace,"%d",place+1);
	strcpy(tmpInfo," ");
	strcat(tmpInfo,msgColor);
	strcat(tmpInfo,strPlace);
	strcat(tmpInfo,") ");
	strcat(tmpInfo,usernameColor);
	strcat(tmpInfo,Users[place].nickname);
	strcat(tmpInfo,statColor);*/
//	strcat(tmpInfo," (");
//	strcat(tmpInfo,")");

//	printf(" %s \n",tmpInfo);
  }
  printf("\n");
}

int myAccess() 
{ 
  uid_t uid=getuid(), euid=geteuid();
  if (uid<0 || uid!=euid)
	return 0;
  else
	return 1;
}

const char * strrev(const char *s)
{
  int l = strlen(s);
  char tmp[255] = "\0";
  int i;
  for(i=l-1;i>=0;i--)
  {
	tmp[l-1-i] = s[i];
	tmp[l-i] = '\0';
  }
//  printf("%s",tmp);
  char *tmp2 = tmp;
  return tmp2;
}

int strCompare(const char *s1,const char *s2)
{
  int cmp = 0;
  int l1,l2;
  for(l1=0;s1[l1];l1++)
	{}
//  printf("cmp %d\n\n",l1);
  for(l2=0;s2[l2];l2++)
	{}
//  printf("cmp %d\n\n",l2);
//  printf("cmp %d and %d\ncmp %s and %s\n",l1,l2,s1,s2);
  if(l1==l2)
  {
	cmp = 1;
	for(l1=0;s1[l1];l1++)
	{
		if(s1[l1]!=s2[l1])
		{
			cmp = 0;
			break;
		}
	}
  }
  return cmp;
}

void fileNull(char pth[255],int nulls)
{
  if(fileExists(pth) == 0)
  {
	FILE *f = fopen(pth,"w");
	fprintf(f,"0");
	if (nulls>1)
	{
		int i;
		for(i=1;i<nulls;i++)
			fprintf(f," 0");
	}

	fclose(f);
  }
}

const char *getTTY(){
  char *tty_name = ttyname(STDIN_FILENO); 
  int i;
/*  for(i=0;i<strlen(tty_name);i++){
    if (tty_name[i]=='/')
	tty_name[i]='_';
  }*/
  return tty_name;
}

int inFile(const char *pth,const char *fnd)
{
  FILE *f=fopen(pth,"r");
  int founded = 0;
  int l1,l2=0;
  for(l1=0;fnd[l1];l1++){}
  char c;
//  fscanf(f,"%c",&c);
  while (fscanf(f, "%c", &c) == 1) 
//  while((c != EOF))
  {
//	fscanf(f,"%c",&c);
	if(fnd[l2]==c)
	{
		l2++;
	} else {
		l2=0;
	}

	if(l2==l1)
	{
		founded = 1;
		break;
	}
//	printf("%c",c);
  }
  fclose(f);
  return founded;
}

int inString(const char *subs, const char *s)
{
  int inS = 0;
  int l = 0;
  for(l=0;s[l];l++){}
  int l2 = 0,ls=0;
  for(ls=0;subs[ls];ls++){}
  int i;
  for(i=0;s[i];i++)
  {
	if (s[i]==subs[l2])
	{
		l2++;
		if(l2==ls)
		{
			inS = 1;
			break;
		}
	} else {
		l2 = 0;
	}
  }
  return inS;
}

void WhatToDo(char *args[])
{
  int access = myAccess();
//  printf("%s %s\n",args[0],args[1]);
  char tmpArg[255] = "\0";
  if (args[1] != NULL) {
	strcpy(tmpArg,args[1]);
	int i;
	for(i=0;i<strlen(tmpArg);i++)
		tmpArg[i] = tolower(tmpArg[i]);
  }
  if (strcmp(tmpArg,"welcome") == 0)
  {
    createStructure(1);
    float floatDelay = 0;
    int startWidth = getWidth();
//    sleep(1);
    floatDelay = 1;
    floatDelay*=1000000;
    while ((startWidth==getWidth()) && (floatDelay>0))
    {
      floatDelay = floatDelay-50000;
      usleep(50000);
      //usleep(50000);
    }
//    system("clear");
    writeMsg(1);
  } else if (strCompare(tmpArg,"background")==1)
  {
	fileNull(userTimePath,2);
	FILE *f = fopen(userTimePath,"r");
	int hours,min;
	fscanf(f,"%d %d",&hours,&min);
	char lastTTYfile[255];
	strcpy(lastTTYfile,userDir);
	strcat(lastTTYfile,"/last_tty");

	char lastTTY[255];
	strcpy(lastTTY,getTTY());
	f = fopen(lastTTYfile,"w");
	fprintf(f,"%s",lastTTY);
	fclose(f);
	while(1==1)
	{
		f = fopen(lastTTYfile,"r");
		char tmpTTY[255]="\0";
		fscanf(f,"%s",tmpTTY);
//		fscanf(f,"%s",&tmpTTY);
//		printf("\n%s\n%s\n",tmpTTY,lastTTY);
		if((strCompare(tmpTTY,lastTTY)==0) || (amionline()==0))
		{
			//printf("Founded new connection!\n");
//			exit(0);
			return;
		}
		sleep(60);
		min++;
		if (min>=60)
		{
			hours++;
			min = 0;
			f = fopen(userExpPath,"r");
			int exp;
			fscanf(f,"%d",&exp);
			fclose(f);
			exp+=forHour;
			f = fopen(userExpPath,"w");
			fprintf(f,"%d",exp);
			fclose(f);
		}
		f = fopen(userTimePath,"w");
		fprintf(f,"%d %d",hours,min);
		fclose(f);
	}
  }
  else if ((strcmp(tmpArg,"+") == 0) || (strcmp(tmpArg,"-") == 0) || (strcmp(tmpArg,"*") == 0) || (strcmp(tmpArg,"/") == 0) || (strcmp(tmpArg,"=") == 0))
  {
//    writeHelp(access);
    if(access==1)
    {
	int next = 1;
	if(args[2]==NULL)
	{
	   next = 0;
	   printf("%s\n Для выполнения операции, необходимо указать ник пользователя и число.\n\n%s",KRED,white);
	}
	else if(args[3]==NULL)
	{
	   next = 0;
	   printf("%s\n Для выполнения операции, необходимо указать число.\n\n%s",KRED,white);
	}
	if (next == 1)
		changeExp(tmpArg[0],args[2],args[3]);
//	else writeHelp(access);
    }
    else
    {
		printf("\n %sНет доступа!%s\n\n",msgColor,white);
    }
//    usersDir
    //system(usersDir);
    //system("echo message > /var/lib/rpg/users/qwerty");
  } else if (strcmp(tmpArg,strrev("}lahkrik_yb_d3d1h{galf"))==0){
	char rev1[255],uef[255];
	strcpy(rev1,userDir);
	strcat(rev1,"/rev1");
	if(fileExists(rev1)==0)
	{
		printf("\n   %s+EXP - %s%s stats%s\n\n",KRED,statColor,programName,white);
		FILE *f=fopen(userExpPath,"r");
		int expExtr;
		fscanf(f,"%d",&expExtr);
		fclose(f);
		expExtr+=1200;
		f=fopen(userExpPath,"w");
		fprintf(f,"%d",expExtr);
		fclose(f);
		f=fopen(rev1,"w");
		fclose(f);
	}
  }
  else if (strcmp(tmpArg,"stats")==0)
  {
    createStructure(1);
    char userStat[255];
    strcpy(userStat,curUser.nickname);
    int founded = 1;
    char *findUser = args[2];
    if(args[2] != NULL)
    {
	founded = 0;
	int indUser=0,indMaybe=0;
	char maybeUser[255]="\0";
	for(indUser=0;indUser<regUsers;indUser++)
	{
		if(strcmp(Users[indUser].nickname,args[2])==0)
		{
			  /*curUser.lvl=Users[indUser].lvl;
			  curUser.startExp=Users[indUser].startExp;
			  curUser.exp=Users[indUser].exp;
			  curUser.nextUp=Users[indUser].nextUp;
			  curUser.nickname = Users[indUser].nickname;
			  curUser.place = Users[indUser].place;*/

			curUser = Users[indUser];
			strcpy(userStat,Users[indUser].nickname);
			founded=1;
			break;
		}
		char tmpNick1[255],tmpNick2[255];
		strcpy(tmpNick1,Users[indUser].nickname);
		strcpy(tmpNick2,args[2]);
		int c;
		for(c=0;c<strlen(tmpNick1);c++)
			tmpNick1[c] = tolower(tmpNick1[c]);
		for(c=0;c<strlen(tmpNick2);c++)
			tmpNick2[c] = tolower(tmpNick2[c]);
		if(strcmp(tmpNick1,tmpNick2)==0)
		{
			strcpy(maybeUser,Users[indUser].nickname);
			indMaybe = indUser;
		}
	}
	    if(founded==0)
		{//printf(" user %s ",maybeUser);
			if(strcmp(maybeUser,"\0")!=0)
			{
				founded=2;
				curUser=Users[indMaybe];
			}
		}
    }
    if(founded!=0)
	    writeMsg(0);
    else
    {
	printf("\n  %sПользователь %s%s %sне найден%s\n\n",msgColor,usernameColor,findUser,msgColor,white);
    }
  } else if (strcmp(tmpArg,"top")==0)
  {
    createStructure(1);
//    tmpArg="\0";
//    strcpy(tmpArg,args[2]);
    int page = 1;
    if(curUser.place>10)
	page = (int)((curUser.place-1)/10)+1;
    if (args[2] != NULL)
	{
//	printf("%s",tmpArg);
	page = atoi(args[2]);
	if((page-1)*10>regUsers)
	{
	    page = 1;
	    if(regUsers>10)
		page = (int)((regUsers-1)/10)+1;
	}
//	printf("%d ",page);
	}
    writeTop(page);
  } else writeHelp(access);

  return;
}

int main(int argc, char *argv[])
{
  
  myAccess();
  createStructure(0);
  WhatToDo(argv);
/*  if (inFile("/home/KirKhal/pipe.txt","kirkhal")==1)
	printf("Founded\n");
  else 	printf("Not founded\n");
  printf(" %s ",getTTY());
  char tt[255];
  strcpy(tt,getTTY());
  printf("  %d ",fileExists(tt));*/
//  printf("Size of int = %d",sizeof(int));
  //printf(createTempDir());



//  printf("day %d \n",getDay());
  //system("exec /bin/bash");
  //system("fc -ln -1 > /tmp/test.fc");

/*  char *frstArg = stringSize, *scndArg = stringSize, *thrdArg = stringSize;
  frstArg = argv[1];
  scndArg = argv[2];
  thrdArg = argv[3];*/
/*  if (Delay != NULL)
	  {floatDelay = atof(Delay);}
  else*/

//  system("fc -nl -1");

  //readline();
  // getcwd
 //fflush(stdout);
//    historic = readline(userInput);
  return 0;
}
