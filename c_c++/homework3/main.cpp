#include <iostream>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <conio.h>

#include "test.h"

using namespace std;

int main()
{
    cout << "Hello World!" << endl;
    system("color 1f");

    double d = 3.145592654;
    cout << d<<endl;
    cout << (int)((d*1000+5)/10)*1.0/100 << endl;
    testMoney1();
    char ch = getch();
    return 0;
}

