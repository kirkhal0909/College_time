#include <stdio.h>

int main(){
    char flag[] = "flag{easy_get_flag_from_binary_file}";
    printf("You want get flag?\n");
    scanf("%s",&flag);
    int i = 0;
    for(i=0;flag[i];i++)
        if(flag[i]<'a')
            flag[i] = flag[i]+32;
    if(i=3)
        if(flag[0]=='y' && flag[1]=='e' && flag[2]=='s')
            printf("Find it in file");
}
