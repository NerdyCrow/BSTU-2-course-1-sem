#include<iostream>
#include"Dictionary.h"
#include"Test.h"
using namespace Dictionary;
#if defined(TEST_CREATE_01) + defined(TEST_CREATE_02) + defined(TEST_ADDENTRY_03) + defined(TEST_ADDENTRY_04) + defined(TEST_GETENTRY_05) + defined(TEST_DELENTRY_06) + defined(TEST_UPDENTRY_07)+ defined(TEST_UPDENTRY_08) + defined(TEST_DICTIONARY) > 1
#error "Определено более одного макроса теста"
#endif

int main()
{
	setlocale(LC_ALL, "Rus");
	try {
		char teachers[DICTNAMEMAXSIZE] = { "Преподаватели" };
		char students[DICTNAMEMAXSIZE] = { "Студенты" };
		char LONGNAME[] = "1234567890123456789012345678901";
		char okNAME[] = "name";
#ifdef TEST_DICTIONARY;//Применение директивы #ifdef
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
#endif//Применение директивы #endif
#ifdef TEST_CREATE_01
		Instance t_1 = Create(LONGNAME, 1);
#elif defined TEST_CREATE_02
		Instance t_2 = Create(okNAME, 101);
#elif defined TEST_ADDENTRY_03
		Instance t_3 = Create(okNAME, 1);
		Entry e1 = { 1,"Гладкий" }, e2 = { 2,"Веялкин" };
		AddEntry(t_3, e1);
		AddEntry(t_3, e2);
#elif defined TEST_ADDENTRY_04
		Instance t_4 = Create(okNAME, 2);
		Entry t1 = { 1,"Гладкий" }, t2 = { 1,"Веялкин" };
		AddEntry(t_4, t1);
		AddEntry(t_4, t2);
#elif defined TEST_GETENTRY_05
		Instance t_5 = Create(okNAME, 2);
		Entry t1 = { 1,"Гладкий" };
		Entry testget = GetEntry(t_5, 2);
#elif defined TEST_DELENTRY_06
		Instance t_6 = Create(okNAME, 2);
		Entry t1 = { 1,"Гладкий" };
		AddEntry(t_6, t1);
		DelEnrty(t_6, 2);
#elif defined  TEST_UPDENTRY_07
		Instance t_7 = Create(okNAME, 2);
		Entry t1 = { 1,"Гладкий" }; 
		Entry testupd1 = { 6,"Гурин" };
		AddEntry(t_7, t1); 
		UpdEntry(t_7, 3, testupd1);
#elif defined TEST_UPDENTRY_08
		Instance t_8 = Create(okNAME, 2);
		Entry t1 = { 1,"Гладкий" };
		Entry t2 = { 2,"Смелов" };
		AddEntry(t_8, t1); 
		AddEntry(t_8, t2);
		Entry testupd2 = { 1,"Гурин" }; 
		UpdEntry(t_8, 3, testupd2);
#endif 

	}
	catch (const char* e)
	{
		cout << e << endl;
	};

}