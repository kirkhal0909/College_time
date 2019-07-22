#include <stdio.h> 

#include<sys/utsname.h>
#include<utmp.h>
int main() {
  int online = 0;
  struct utmp *n;
  setutent();
  n=getutent();
//  char *us = getlogin();
  while(n) {
    if(n->ut_type==USER_PROCESS) {
      printf("\n%s\n",n->ut_user);
    }
    n=getutent();
  }
  return online;
}
