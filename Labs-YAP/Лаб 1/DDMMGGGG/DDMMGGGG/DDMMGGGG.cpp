using namespace std;

#include <iostream>
int  day, year, month;
bool isVysokGod;

void InputDate() {

    int a;
    do {
        cout << "Введите ДДММГГ: ";
        cin >> a;
        day = a / 1000000;
        month = (a - day * 1000000) / 10000;
        year = (a - day * 1000000 - month * 10000) / 1;
    } while (day <= 0 || day > 31 || month > 12 || year < 0 || month == 2 && day>29);
}

bool IsVysokGod(int year)
{
    if (year % 4 == 0) //дописать условия
    {
        cout << endl << "Год високосный";
        return true;
    }
    else
    {
        cout << endl << "Не високосный" << endl;
        return false;
    }
}

void por() {
    
    int arr[12]{ 31,28,31,30,31,30,31,31,30,31,30,31 };
    int kolvo = 0;
    int l;
    if (isVysokGod) {
        arr[1]++;        
    }

    for (int i = 0; i < month - 1; i++)
        kolvo += arr[i];

    kolvo += day;

    cout << endl <<"Порядковый номер дня: "<< kolvo << endl;
    if (!isVysokGod)
    {
        l = 330 - kolvo;
        if (kolvo > 330)
        {
            l += 365;
        }
    }
    else
    {
        l = 331 - kolvo;
        if (kolvo>331)
        {
            l += 366;
        }
    }
    cout << "Дней до ближайшего Дня рождения: " << l << endl;
}


int main()
{
    setlocale(LC_CTYPE, "rus");   

    InputDate();
    isVysokGod = IsVysokGod(year);

    por();   
}

