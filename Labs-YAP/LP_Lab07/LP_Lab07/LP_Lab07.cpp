#include<iostream>
#include"Dictionary.h"
#include"Test.h"
using namespace Dictionary;
#if defined(TEST_CREATE_01) && defined(TEST_CREATE_02)  && defined(TEST_ADDENTRY_03) && defined(TEST_ADDENTRY_04) && defined(TEST_GETENTRY_05) && defined(TEST_DELENTRY_06) && defined(TEST_UPDENTRY_07)&& defined(TEST_UPDENTRY_08) && defined(TEST_DICTIONARY)
#error "Определено более одного макроса теста"
#endif

int main()
{
	setlocale(LC_ALL, "Rus");
	try {

		char teachers[DICTNAMEMAXSIZE] = { "Преподаватели" };
		Instance d1 = Create(teachers, 7);
		Entry e1 = { 1,"Гладкий" }, e2 = { 2,"Веялкин" }, e3 = { 3,"Смелов" },
			e4 = { 4,"Урбанович" }, e5 = { 5,"Пацей" }, e6 = { 6,"Белодед" }, e7 = { 7,"Жиляк" };
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
		char students[DICTNAMEMAXSIZE] = { "Студенты" };
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

		char LONGNAME[] = "1234567890123456789012345678901";
		char NORMALNAME[] = "name";
		TEST_UPDENTRY_08;
		/*	TEST_CREATE_01;
		TEST_CREATE_02;
		TEST_ADDENTRY_03;
		TEST_ADDENTRY_04;
		TEST_GETENTRY_05;
		TEST_DELENTRY_06;
		TEST_UPDENTRY_07;
		TEST_UPDENTRY_08;*/
		
#ifdef TEST_DICTIONARY;//Применение директивы #ifdef
		Instance test1 = Create(teachers, 7);
		Entry t1 = { 1,"Гладкий" }, t2 = { 2,"Веялкин" }, t3 = { 3,"Смелов" }, \
			t4 = { 4,"Урбанович" }, t5 = { 5,"Пацей" }, t6 = { 6,"Белодед" }, t7 = { 7,"Жиляк" }; \
			AddEntry(test1, t1); AddEntry(test1, t2); AddEntry(test1, t3); AddEntry(test1, t4); AddEntry(test1, t5); AddEntry(test1, t6); AddEntry(test1, t7); \
			Instance test2 = Create(students, 7); \
			Entry ts1 = { 1,"Иванов" }, ts2 = { 2,"Петров" }, ts3 = { 3,"Сидоров" }, ts4 = { 4,"Евгеньев" }, ts5 = { 5,"Михалькевич" }, ts6 = { 6,"Разумовский" }, ts7 = { 7,"Васильев" }; \
			AddEntry(test2, ts1); AddEntry(test2, ts2); AddEntry(test2, ts3); AddEntry(test2, ts4); AddEntry(test2, ts5); AddEntry(test2, ts6); AddEntry(test2, ts7); \
			Print(test1); Print(test2);
		exit(1);
#endif//Применение директивы #endif
	}
	catch (const char* e)
	{
		cout << e << endl;
	};

}