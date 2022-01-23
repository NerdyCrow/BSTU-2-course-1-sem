#include "stdafx.h"
#include "Dictionary.h"
#include <iostream>
#include <locale>

Instance Create(const char name[DICTNAMEMAXSIZE], int size) {
	const char* x = name;
	if ((strlen(name)) > (DICTNAMEMAXSIZE)) throw  THROW01;
	if (size > DICTMAXSIZE) throw THROW02;
	Instance* i = new Instance;
	i->size = 0;
	i->maxsize = size;
	for (int x = 0; x < DICTNAMEMAXSIZE; x++) {
		i->name[x] = { name[x] };
	}
	i->dictionary = new Entry[size];
	return *i;
}

void AddEntry(Instance& inst, Entry ed) {
	if (inst.size> DICTMAXSIZE) throw THROW03;
	for (int i = 0; i < inst.size; i++) {
		if (inst.dictionary[i].id== ed.id) throw THROW04;
	}
	if (inst.size == inst.maxsize) {
		for (int i = 0; i < inst.maxsize; i++) {
			if (inst.dictionary[i].id == NULL) {
				inst.dictionary[i] = ed; break;
			}
			if (i == inst.maxsize - 1)
				cout << "В словаре нет свободных мест!" << endl;
		}
	}
	else {
		inst.dictionary[inst.size] = ed;
		inst.size++;
	}
}

void DelEntry(Instance& inst, int id) {
	int count = 0;
	Entry a = { NULL,"" };
	for (int i = 0; i < inst.maxsize; i++) {
		if (inst.dictionary[i].id == id) {
			inst.dictionary[i] = a;
		}
		else
			count++;
		if (inst.maxsize== count) throw THROW06;
	}
}

Entry GetEntry(Instance& inst, int id) {
	int count = 0;
	for (int i = 0; i < inst.maxsize; i++) {
		if (inst.dictionary[i].id == id) {
			return inst.dictionary[i];
		}
		else
			count++;
		if (inst.maxsize== count) throw THROW05;
	}
}

void UpdEntry(Instance& inst, int id, Entry new_ed) {
	int count = 0, mark;
	for (int i = 0; i < inst.maxsize; i++) {
		if (inst.dictionary[i].id == id) {
			inst.dictionary[i] = new_ed;
			mark = i;
			for (int i = 0; i < inst.maxsize; i++) {
				if (i != mark) {
					if (inst.dictionary[i].id== new_ed.id) throw THROW08;
				}
			}
		}
		else
			count++;
		if (inst.maxsize==count) throw THROW07;
	}
}

void Print(Instance d) {
	if (d.maxsize == NULL)
		std::cout << "Список пуст" << endl;
	else {
		std::cout << d.name << std::endl;
		for (int i = 0; i < d.maxsize; i++) {
			if (d.dictionary[i].id == NULL)
				cout << "";
			else
				std::cout << "Фамилия: " << d.dictionary[i].name << " id: " << d.dictionary[i].id << std::endl;
		}
	}
}

void Delete(Instance& d) {
	delete[] d.dictionary;
	d.maxsize = NULL;
	d.size = NULL;
}