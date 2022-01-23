#include <iostream>
#include <string>
using namespace std;

typedef unsigned char day;
typedef unsigned char month;
typedef unsigned short year;

struct Date {
	day dd;
	month mm;
	year yyyy;
};

bool operator ==(const Date& first, const Date& second)
{
	return first.dd == second.dd && first.mm == second.mm && first.yyyy == second.yyyy;
};

bool operator >(const Date& first, const Date& second)
{
	return first.yyyy > second.yyyy || (first.yyyy == second.yyyy && first.mm > second.mm) || (first.yyyy == second.yyyy && first.mm == second.mm && first.dd > second.dd);
};

bool operator <(const Date& first, const Date& second)
{
	return first.yyyy < second.yyyy || (first.yyyy == second.yyyy && first.mm < second.mm) || (first.yyyy == second.yyyy && first.mm == second.mm && first.dd < second.dd);
};

struct Control {
	string name;
	string form;
	unsigned int mark;
	
};

bool operator >(const Control& first, const Control& second)
{
	return first.mark > second.mark;
};

bool operator <(const Control first, const Control& second)
{
	return first.mark  < second.mark ;
};

bool operator ==(const Control& first, const Control& second)
{
	return first.mark  == second.mark;
};

int main()
{
	setlocale(LC_ALL, "rus");

	Date date1{ 7,1,1980 };
	Date date2{ 7,2,1993 };
	Date date3{ 7,1,1980 };

	if (date1 < date2) cout << "истина" << endl;
	else cout << "ложь" << endl;
	if (date1 > date2) cout << "истина" << endl;
	else cout << "ложь" << endl;
	if (date1 == date2) cout << "истина" << endl;
	else cout << "ложь" << endl;
	if (date1 == date3) cout << "истина" << endl;
	else cout << "ложь" << endl;

	Control Control1{ "Математика","Экзамен",9 };
	Control Control2{ "Яп","Экзамен",8 };
	Control Control3{ "История","Зачет",7 };

	cout << "Максимальный балл по " << Control1.name << " больше чем по " << Control2.name << " - ";
	if (Control1 > Control2) cout << "правда" << endl;
	else cout << "ложь" << endl;
	system("pause");
}