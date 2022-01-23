#include "stdafx.h"
#include "Dictionary.h"
#include <iostream>
#include <string>
#include <locale>


int main() {
	setlocale(LC_ALL, "rus");
	int i = 0;

#if defined(TEST_CREATE_01) + defined(TEST_CREATE_02) + defined(TEST_ADDENTRY_03) +  defined(TEST_ADDENTRY_04)+ defined(TEST_GETENTRY_05)+ defined(TEST_DELENTRY_06)+ defined(TEST_UPDENTRY_07)+defined(TEST_UPDENTRY_08)>1
#error Подключено более одного макроса теста
#endif

	try {

#ifdef TEST_CREATE_01
		Instance d1 = Create("Преподаватели", 5);
#endif

#ifdef TEST_CREATE_02
		Instance d1 = Create("Преподаватели", 6);
#endif

#ifdef TEST_ADDENTRY_03
		Instance d1 = Create("Преподаватели", 5);
		Entry e1 = { 1,"Наркевич" }, e2 = { 2,"Белодед" },
			e3 = { 3,"Гринюк" }, e4 = { 4,"Ловенецкая" }, e5 = { 5,"Мисевич" }, e6 = { 6,"Жиляк" } ;
		AddEntry(d1, e1);
		AddEntry(d1, e2);
		AddEntry(d1, e3);
		AddEntry(d1, e4);
		AddEntry(d1, e5);
		AddEntry(d1, e6);
		
#endif

#ifdef TEST_ADDENTRY_04
		Instance d1 = Create("Преподаватели", 5);
		Entry e1 = { 1,"Наркевич" };
		AddEntry(d1, e1);
		AddEntry(d1, e1);
#endif

#ifdef TEST_GETENTRY_05
		Instance d1 = Create("Преподаватели", 5);
		Entry e2 = GetEntry(d1, 4);
#endif

#ifdef TEST_DELENTRY_06
		Instance d1 = Create("Преподаватели", 3);
		Entry e1 = { 1,"Наркевич" }, e2 = { 2,"Белодед" },
			e3 = { 3,"Гринюк" };
		AddEntry(d1, e1);
		AddEntry(d1, e3);
		DelEntry(d1, 2);
#endif

#ifdef TEST_UPDENTRY_07
		Instance d1 = Create("Преподаватели", 3);
		Entry e1 = { 1,"Наркевич" }, e2 = { 2,"Белодед" },
			e3 = { 3,"Гринюк" };
		AddEntry(d1, e1);
		AddEntry(d1, e2);
		Entry newentry = { 2,"Смелов" };
		UpdEntry(d1, 3, newentry);
#endif

#ifdef TEST_UPDENTRY_08
		Instance d1 = Create("Преподаватели", 3);
		Entry e1 = { 1,"Наркевич" }, e2 = { 2,"Белодед" },
			e3 = { 3,"Гринюк" };
		AddEntry(d1, e1);
		AddEntry(d1, e2);
		AddEntry(d1, e3);
		Entry newentry = { 2,"Смелов" };
		UpdEntry(d1, 3, newentry);
#endif
#ifdef TEST_DICTIONARY
		Instance d1 = Create("--------- Преподаватели ---------", 5);
		Entry e1 = { 1,"Наркевич" }, e2 = { 2,"Белодед" },
			e3 = { 3,"Гринюк" }, e4 = { 4,"Ловенецкая" }, e5 = { 5,"Мисевич" }, e6 = { 6,"Жиляк" }, e7 = { 7,"Савчанчик" };
		AddEntry(d1, e1);
		AddEntry(d1, e2);
		AddEntry(d1, e3);
		AddEntry(d1, e4);
		AddEntry(d1, e5);
		Entry ex2 = GetEntry(d1, 4);
		DelEntry(d1, 2);
		AddEntry(d1, e6);
		Entry newentry = { 3,"Смелов" };
		UpdEntry(d1, 3, newentry);
		Print(d1);
		Instance d2 = Create("--------- Студенты ---------", 3);
		Entry s1 = { 1,"Некрасова" }, s2 = { 2,"Бай" }, s3 = { 3,"Сапегина" };
		AddEntry(d2, s1);
		AddEntry(d2, s2);
		AddEntry(d2, s3);
		Entry newentry1 = { 3,"Пилипович" };
		UpdEntry(d2, 3, newentry1);
		Print(d2);
		Delete(d1);
		Delete(d2);
#endif
	}
	catch (const char* i) {
		cout << i << endl;
	}
	system("pause");
	return 0;
}

