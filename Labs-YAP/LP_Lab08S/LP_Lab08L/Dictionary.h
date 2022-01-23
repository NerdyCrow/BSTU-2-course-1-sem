#pragma once
#include<iostream>
using namespace std;

#define DICTNAMEMAXSIZE 20
#define DICTMAXSIZE 100
#define ENTRYNAMEMAXSIZE 30
#define THWOW01 "Create: Превышен размер имени словаря"
#define THWOW02	"Create: Превышен максимальный размер словаря"
#define THWOW03	"AddEntry: Переполнение словаря"
#define THWOW04	"AddEntry: Дублирование идентификатора"
#define THWOW05 "GetEntry: Не найден элемент"
#define THWOW06 "DelEntry: Не найден элемент"
#define THWOW07 "UpdEntry: Не найден элемент"
#define THWOW08 "UpdEntry: Дублирование идентификатора"

namespace Dictionary
{
	struct Entry {
		int id;
		char name[ENTRYNAMEMAXSIZE];
	};
	struct Instance {
		char name[DICTNAMEMAXSIZE];
		int maxsize;
		int size;
		Entry* dictionary;

	};
	Instance Create(char name[DICTNAMEMAXSIZE], int maxsize);
	void AddEntry(Instance& inst, Entry ed);
	void Print(Instance d);
	void DelEnrty(Instance& inst, int id);
	void UpdEntry(Instance& inst, int id, Entry new_ed);
	void Delete(Instance& d);
	Entry GetEntry(Instance inst, int id);
}