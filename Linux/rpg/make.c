#include <stdio.h>
#include <stdlib.h>
#include <sys/stat.h>
#include <string.h>

#include <unistd.h>

char programName[] = "rpg";
char cFileName[] = "rpg.c";
char folderUsersInfo[] = "/var/lib";
char folderBin[] = "/usr/bin";

char* addSlash(char *s){
  static char tmpS[255]="\0";
  int i;
  int Slashes = 0;
  int curSlash = 0;
  for(i=0;i<strlen(s);i++)
     if (s[i]=='/')
	Slashes++;
  for(i=0;i<strlen(s);i++)
  {
    if ((s[i]=='/') || (s[i]=='[') || (s[i]==']') || (s[i]=='='))
    {
	if ((s[i]=='/') && (curSlash > 1) && (curSlash != Slashes-1))
        	strcat(tmpS,"\\");
	else if (s[i] !='/') strcat(tmpS,"\\");
	if (s[i]=='/') curSlash++;
    }
    tmpS[strlen(tmpS)] = s[i];
//    strcat(tmpS,s[i]);
    tmpS[strlen(tmpS)] = '\0';
  }
  //s = tmpS;
  return tmpS;
  //printf("%s ",tmpS);
}

int createDir(char path[255]){
  struct stat st = {0};
  if (stat(path, &st) == -1){
    mkdir(path, 0700);
  }
}

int main(int argc, char *argv[]){  
  char curPath[255];
//  system("sleep 3");
  getcwd(curPath, sizeof(curPath));
//  printf("Current working dir: %s\n", cwd);
//  system("sed -i s///g %s",cFileName);
  createDir(folderBin);
  createDir(folderUsersInfo);
  char folderData[255];
  strcpy(folderData,folderUsersInfo);
  strcat(folderData,"/");
  strcat(folderData,programName);
  createDir(folderData);
  char cmd[255] = "sed -i 's/^char mainDir[].*$/char mainDir[] = \"";
  strcat(cmd,folderData);
  strcat(cmd,"\";/g' ");
  strcat(cmd,cFileName);
//  addSlash(cmd);
  strcpy(cmd,addSlash(cmd));
  printf("\nChange path in main C file to store users data to %s\n%s\n",folderData,cmd);
  system(cmd);
  createDir("/etc/profile.d");
  char autoSh[255] = "/etc/profile.d/";
  char programPath[255];
  strcpy(programPath,folderBin);
  strcat(programPath,"/");
  strcat(programPath,programName);
  strcpy(cmd,"gcc ");
  strcat(cmd,cFileName);
  strcat(cmd," -o ");
  strcat(cmd,programPath);
  printf("\nMake program\n%s\n",cmd);
  system(cmd);
  strcpy(cmd,"chmod a+xs ");
  strcat(cmd,programPath);
//  printf("\nGive access\n%s\n\n",cmd);
  system(cmd);
/*  createDir(programPath);
  strcat(programPath,"/");
  strcat(programPath,programName);*/
  strcat(autoSh,programName);
  strcat(autoSh,".sh");
  FILE* f;
  f = fopen(autoSh,"w");
//  fprintf(f,"alias топ='rpg top'\n");
//  fprintf(f,"alias top='rpg top'\n");
//  fprintf(f,"alias stats='rpg stats'\n");
  fprintf(f,"%s %s &\n",programPath,"background");
  fprintf(f,"%s %s\n",programPath,"Welcome");
  fprintf(f,"exec /bin/bash");
  fclose(f);
  return 0;
}
