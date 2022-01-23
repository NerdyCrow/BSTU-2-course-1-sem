#pragma once
#include<iostream>
using namespace std;

#define DICTNAMEMAXSIZE 20
#define DICTMAXSIZE 100
#define ENTRYNAMEMAXSIZE 30
#define THWOW01 "Create: �������� ������ ����� �������"
#define THWOW02	"Create: �������� ������������ ������ �������"
#define THWOW03	"AddEntry: ������������ �������"
#define THWOW04	"AddEntry: ������������ ��������������"
#define THWOW05 "GetEntry: �� ������ �������"
#define THWOW06 "DelEntry: �� ������ �������"
#define THWOW07 "UpdEntry: �� ������ �������"
#define THWOW08 "UpdEntry: ������������ ��������������"

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