using namespace std;

#include <iostream>

int main()
{
    setlocale(LC_CTYPE, "rus");
    int a, d, g, m;
    cin >> a;
    d = a / 1000000;
    m = (a - d * 1000000) / 10000;
    g = (a - d * 1000000 - m * 10000) / 1;
    cout << g;
    if (g%4!=0)
    {
        cout <<endl<< "Год високосный";

    }
    else
    {
        cout << endl << "Не високосный";
    }
}

