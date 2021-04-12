#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>

int main()
{
    int i1;
    printf("i1 = %d\n", i1);

    i1 = 5;
    printf("i1 = %d\n", i1);

    i1 = -3;
    printf("i1 = %d\n",1);

    i1 = -3.5;
    printf("i1 = %d\n\n", i1);

    //int i1 = 2;

    double d1 = 3.5;

    printf("d1 = %f\n", d1);

    d1 = 0;
    printf("d1 = %f\n", d1);

    float f1  = 3.7;
    printf("f1 = %f\n\n",f1);

    char c = 'A';
    printf("%c\n",c);

    c = 65;
    printf("%c\n",c);

    int code = 'A';
    printf("%d\n\n", code);

    _Bool b = 0;
    printf("b = %d\n", b);

    b = 1;
    printf("b = %d\n", b);

    b = 2;
    printf("b = %d\n", b);

    b = -1;
    printf("b = %d\n", b);

    ///#include <stdbool.h> to use "true" and false
    b = false;
    printf("using keywords b = %d\n",b);

    b = true;
    printf("using keyword b = %d\n\n",b);

    char name[] = "Ali Badran";///group of characters
    printf("%s\n", name);

    ///how to know how much a variable can hold
    int x = sizeof(int);
    printf("numbers of bytes of an int: %d bytes\n",x);
    printf("numbers of bits: 4x8 = 32 bit \n");
    printf("we can store 2^32 in an integer");///4294967296
    //
    return 0;
}
