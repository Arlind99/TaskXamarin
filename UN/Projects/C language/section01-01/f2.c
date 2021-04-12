#include <stdio.h>

int main(){
    printf("\tConvertimi i miljeve ne KM.\n");
    float a;
    float b;
    printf("numri i miljeve a: ");
    scanf("%f", &a);
    b = a * 1.60934;
    printf("\nvlera e konvertimit nga miljet ne km b: %f", b);
    printf("\n");

    system("pause");
    return 0;
}
