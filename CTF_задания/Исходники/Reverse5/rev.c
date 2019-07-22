#include <stdio.h>

int main(){
    char s[255];
    printf("Enter license key:\n");
    scanf("%s",s);
    if(s[0]*14!=1428)
    { printf("Access denied!"); scanf("%s",s); return 1; }
    if(s[1]*37!=3996)
    { printf("Access denied!"); scanf("%s",s); return 2; }
    if(s[2]*7!=679)
    { printf("Access denied!"); scanf("%s",s); return 3; }
    if(s[3]*42!=4326)
    { printf("Access denied!"); scanf("%s",s); return 4; }
    if(s[4]*8!=984)
    { printf("Access denied!"); scanf("%s",s); return 5; }
    if(s[5]*35!=2275)
    { printf("Access denied!"); scanf("%s",s); return 6; }
    if(s[6]*24!=1560)
    { printf("Access denied!"); scanf("%s",s); return 7; }
    if(s[7]*45!=2925)
    { printf("Access denied!"); scanf("%s",s); return 8; }
    if(s[8]*13!=845)
    { printf("Access denied!"); scanf("%s",s); return 9; }
    if(s[9]*14!=630)
    { printf("Access denied!"); scanf("%s",s); return 10; }
    if(s[10]*18!=1206)
    { printf("Access denied!"); scanf("%s",s); return 11; }
    if(s[11]*27!=1809)
    { printf("Access denied!"); scanf("%s",s); return 12; }
    if(s[12]*40!=2680)
    { printf("Access denied!"); scanf("%s",s); return 13; }
    if(s[13]*28!=1876)
    { printf("Access denied!"); scanf("%s",s); return 14; }
    if(s[14]*44!=1980)
    { printf("Access denied!"); scanf("%s",s); return 15; }
    if(s[15]*7!=462)
    { printf("Access denied!"); scanf("%s",s); return 16; }
    if(s[16]*26!=1768)
    { printf("Access denied!"); scanf("%s",s); return 17; }
    if(s[17]*10!=660)
    { printf("Access denied!"); scanf("%s",s); return 18; }
    if(s[18]*38!=2546)
    { printf("Access denied!"); scanf("%s",s); return 19; }
    if(s[19]*8!=360)
    { printf("Access denied!"); scanf("%s",s); return 20; }
    if(s[20]*10!=680)
    { printf("Access denied!"); scanf("%s",s); return 21; }
    if(s[21]*16!=1104)
    { printf("Access denied!"); scanf("%s",s); return 22; }
    if(s[22]*25!=1725)
    { printf("Access denied!"); scanf("%s",s); return 23; }
    if(s[23]*35!=2450)
    { printf("Access denied!"); scanf("%s",s); return 24; }
    if(s[24]*6!=750)
    { printf("Access denied!"); scanf("%s",s); return 25; }
    printf("Access allowed\nCongratulations, You found the flag\n\n  %s\n\n",s);
    scanf("%s",s);
    return 0;
}
