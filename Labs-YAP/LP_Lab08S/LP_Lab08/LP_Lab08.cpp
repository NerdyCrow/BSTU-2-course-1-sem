#include<iostream>
#include"D:\User\Desktop\ЯП\LP_Lab08S\LP_Lab08L\Dictionary.h"
#pragma comment(lib, "D:\\User\\Desktop\\ЯП\\LP_Lab08S\\Debug\\LP_Lab08L.lib" )
using namespace std;
using namespace Dictionary;

int main()
{
	setlocale(LC_ALL, "RUS");
	try {
		char teachers[DICTNAMEMAXSIZE] = { "Преподаватели" };
		char students[DICTNAMEMAXSIZE] = { "Студенты" };
		Instance d1 = Create(teachers, 7);
		Entry e1 = { 1,"Гладкий" }, e2 = { 2,"Веялкин" }, e3 = { 3,"Смелов" },
			e4 = { 4,"Гринюк" }, e5 = { 5,"Пацей" }, e6 = { 6,"Белодед" }, e7 = { 7,"Жиляк" };
		AddEntry(d1, e1);
		AddEntry(d1, e2);
		AddEntry(d1, e3);
		AddEntry(d1, e4);
		AddEntry(d1, e5);
		AddEntry(d1, e6);
		AddEntry(d1, e7);
		Entry ex2 = GetEntry(d1, 4);
		DelEnrty(d1, 2);
		Entry newentry1 = { 3,"Гурин" };
		UpdEntry(d1, 3, newentry1);
		Print(d1);
		Instance d2 = Create(students, 8);
		Entry s1 = { 1,"Иванов" }, s2 = { 2,"Петров" }, s3 = { 3,"Сидоров" }, s4 = { 4,"Евгеньев" }, s5 = { 5,"Михалькевич" }, s6 = { 6,"Разумовский" }, s7 = { 7,"Васильев" }, s8 = { 8,"Николаев" };
		AddEntry(d2, s1);
		AddEntry(d2, s2);
		AddEntry(d2, s3);
		AddEntry(d2, s4);
		AddEntry(d2, s5);
		AddEntry(d2, s6);
		AddEntry(d2, s7);
		AddEntry(d2, s8);

		Entry newentry2 = { 3,"Николаев" };
		UpdEntry(d2, 3, newentry2);
		Print(d2);
		Delete(d1);
		Delete(d2);
	}
	catch (const char* e)
	{
		cout << e << endl;
	};
}