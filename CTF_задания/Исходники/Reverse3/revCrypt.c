#include <stdio.h>

char* encrypt(char* t,int key){
    //printf("%s",t);
    int hided = ((key+29)*14-(key*12))%256;
    static char s[255] = "\0";
    int i,l;
    for(l=0;t[l];l++){}
    for(i=0;i<l;i++)
        s[i] = (t[i]+hided)%256;
    s[l] = '\0';
    return s;
}

int main(){
//    char s[255] = encrypt();
    char flag[] = {192, 198, 187, 193, 213, 172, 191, 208, 191, 204, 205, 191, 185, 189, 194, 187, 200, 193, 191, 190, 185, 206, 194, 191, 185, 197, 191, 211, 185, 195, 200, 185, 188, 211, 206, 191, 205, 215};
    int key = 990910;
    int trueKey = 77704;
    printf("Key: %d",key);
    printf("\n\nText: %s",flag);
    //for(int i=77600;i<=77777;i++)
    if(key == trueKey)
        printf("\n\nKey changed succesfully");
    printf("\n\nDecrypt: %s",encrypt(flag,key));//,77704));
    if(key != trueKey)
        printf("\n\nOoh... It's not flag. Try key = 77704\n\n");
    //printf("%i\n%s\n",i,encrypt(flag,147));
    scanf("%s",flag);
    return 0;
}
