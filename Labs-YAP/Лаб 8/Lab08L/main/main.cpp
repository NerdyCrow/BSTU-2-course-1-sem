#include "../Lab08L/Dictionary.h"
#pragma comment(lib, "D:\\Лабы ЯП\\Лаб 8\\Lab08L\\Debug\\Lab08L.lib")

int main()
{
	setlocale(LC_ALL, "rus");
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);

	try
	{
#if (defined(TEST_CREATE_01) + defined(TEST_CREATE_02) + defined(TEST_ADDENTRY_03) + defined(TEST_ADDENTRY_04) + defined(TEST_GETENTRY_05) + defined(TEST_DELENTRY_06) + defined(TEST_UPDENTRY_07) + defined(TEST_UPDENTRY_08) + defined(TEST_DICTIONARY) > 1)
#error MORE THAN ONE TEST IS BEING USED
#endif

#ifdef TEST_CREATE_01
		Dictionary::Instance d1 = Dictionary::Create((char*)"1234567890_1234567890", 7);
#endif // TEST_CREATE_01

#ifdef TEST_CREATE_02
		Dictionary::Instance d1 = Dictionary::Create((char*)"1234567890", 101);
#endif // TEST_CREATE_02

#ifdef TEST_ADDENTRY_03
		Dictionary::Instance d1 = Dictionary::Create((char*)"123", 1);
		Dictionary::Entry e1 = { 1, "Наркевич" }, e2 = { 2, "Доморад" };
		Dictionary::AddEntry(d1, e1);
		Dictionary::AddEntry(d1, e2);
#endif // TEST_ADDENTRY_03

#ifdef TEST_ADDENTRY_04
		Dictionary::Instance d1 = Dictionary::Create((char*)"123", 2);
		Dictionary::Entry e1 = { 1, "Наркевич" }, e2 = { 1, "Доморад" };
		Dictionary::AddEntry(d1, e1);
		Dictionary::AddEntry(d1, e2);
#endif // TEST_ADDENTRY_04

#ifdef TEST_GETENTRY_05
		Dictionary::Instance d1 = Dictionary::Create((char*)"123", 1);
		Dictionary::Entry e1 = { 1, "Наркевич" };
		Dictionary::GetEntry(d1, 2);
#endif // TEST_GETENTRY_05

#ifdef TEST_DELENTRY_06
		Dictionary::Instance d1 = Dictionary::Create((char*)"123", 1);
		Dictionary::Entry e1 = { 1, "Наркевич" };
		Dictionary::AddEntry(d1, e1);
		Dictionary::DelEntry(d1, 2);
#endif // TEST_DELENTRY_06

#ifdef TEST_UPDENTRY_07
		Dictionary::Instance d1 = Dictionary::Create((char*)"123", 1);
		Dictionary::Entry e1 = { 1, "Наркевич" };
		Dictionary::AddEntry(d1, e1);
		Dictionary::UpdEntry(d1, 2, e1);
#endif // TEST_UPDENTRY_07

#ifdef TEST_UPDENTRY_08
		Dictionary::Instance d1 = Dictionary::Create((char*)"123", 2);
		Dictionary::Entry e1 = { 1, "Наркевич" }, e2 = { 2, "Доморад" }, e3 = { 1, "Романова" };
		Dictionary::AddEntry(d1, e1);
		Dictionary::AddEntry(d1, e1);
		Dictionary::UpdEntry(d1, 2, e3);
#endif // TEST_UPDENTRY_08

#ifdef TEST_DICTIONARY
		Dictionary::Instance d1 = Dictionary::Create((char*)"Преподаватели", 7);
		Dictionary::Entry e1 = { 1, "Наркевич" }, e2 = { 2, "Доморад" }, e3 = { 3, "Романова" }, e4 = { 4,"Кантарович" }, e5 = { 5, "Ловенецкая" }, e6 = { 6,"Жиляк" }, e7 = { 7,"Белодед" }, e8 = { 8,"Пацей" };
		Dictionary::Instance d2 = Dictionary::Create((char*)"Студенты", 7);
		Dictionary::Entry s1 = { 1, "Белашков" }, s2 = { 2, "Сапегина" }, s3 = { 3, "Слемнёв" }, s4 = { 4, "Пилипович" }, s5 = { 5, "Булавский" }, s6 = { 6, "Анкип" }, s7 = { 7, "Бай" };
		Dictionary::AddEntry(d1, e1);
		Dictionary::AddEntry(d1, e2);
		Dictionary::AddEntry(d1, e3);
		Dictionary::AddEntry(d1, e4);
		Dictionary::AddEntry(d1, e5);
		Dictionary::AddEntry(d1, e6);
		Dictionary::AddEntry(d1, e7);
		Dictionary::AddEntry(d2, s1);
		Dictionary::AddEntry(d2, s2);
		Dictionary::AddEntry(d2, s3);
		Dictionary::AddEntry(d2, s4);
		Dictionary::AddEntry(d2, s5);
		Dictionary::AddEntry(d2, s6);
		Dictionary::AddEntry(d2, s7);
		Dictionary::Entry e1_1 = Dictionary::GetEntry(d1, 3);
		Dictionary::DelEntry(d2, 5);
		Dictionary::UpdEntry(d1, 4, e8);
		Dictionary::Print(d1);
		Dictionary::Print(d2);
		Dictionary::Delete(d1);
		Dictionary::Delete(d2);
#endif // TEST_DICTIONARY
	}
	catch (char* e)
	{
		cout << e;
	}
}