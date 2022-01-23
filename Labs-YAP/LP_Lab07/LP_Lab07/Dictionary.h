#pragma once
#include<iostream>
#include"Test.h"
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

	Instance Create(char name[DICTNAMEMAXSIZE], int maxsize)
	{
		if (maxsize > DICTMAXSIZE)
			throw THWOW01;
		else if (strlen(name) > DICTNAMEMAXSIZE)
			throw THWOW02;
		else {
			Instance* e = new Instance;
			e->maxsize = maxsize;
			e->size = 0;
			strcpy_s(e->name, name);
			e->dictionary = new Entry[maxsize];
			return *e;
		}
	}
	
	void AddEntry(Instance& inst, Entry ed)
	{
		if (inst.size < inst.maxsize) {
			for (int i = 0; i < inst.size; i++) {
				if (ed.id == inst.dictionary[i].id)
					throw THWOW04;
			}
			inst.dictionary[inst.size].id = ed.id;
			strcpy_s(inst.dictionary[inst.size].name, ed.name);
			inst.size++;
		}
		else throw THWOW03;
	}
	
	void Print(Instance d) {
		int i;
		for (i = 0; i < d.size; i++)
		{
			cout << d.dictionary[i].id << " " << d.dictionary[i].name << endl;
		}
	}
	
	Entry GetEntry(Instance inst, int id) {
		bool chk = 0;
		for (int i = 0; i < inst.size; i++)
		{
			if (id == inst.dictionary[i].id) {
				cout << "Найденный элемент: " << inst.dictionary[i].id << " " << inst.dictionary[i].name << endl;
				chk = 1;
				break;
			}
		}
		if(chk == 0) throw THWOW05;
		return *inst.dictionary;
	}

	void DelEnrty(Instance& inst, int id) {
		bool chk = 0;
		for (int i = 0; i < inst.size; i++) {
			if (inst.dictionary[i].id == id)
			{
				for (int de1 = (id - 1); de1 < inst.size; de1++)
					inst.dictionary[de1] = inst.dictionary[de1 + 1];
				inst.size = inst.size - 1;
				chk = 1;
			}
		}
		if(chk == 0) throw THWOW06;

	}

	void UpdEntry(Instance& inst, int id, Entry new_ed) {
		int i;
		bool chk = 0;
		for (i = 0; i < inst.size; i++)
		{
			if (inst.dictionary[i].id == id) {
				inst.dictionary[i] = new_ed;
				chk = 1;
			}
		}
		if(chk == 0) throw THWOW07;
	}

	void Delete(Instance &d) {
		delete d.dictionary;
	}
}