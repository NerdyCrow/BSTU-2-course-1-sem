#include "Dictionary.h"

namespace Dictionary
{
	Instance Create(char name[DICTNAMEMAXSIZE], int size)
	{
		if (strlen(name) > DICTNAMEMAXSIZE) throw (char*)THROW01;
		if (size > DICTMAXSIZE)				throw (char*)THROW02;

		Instance obj;
		obj.name[strlen(name)] = '\0';
		for (int i = 0; obj.name[i] != '\0'; i++)
		{
			obj.name[i] = name[i];
		}
		obj.maxsize = size;
		obj.size = 0;
		obj.dictionary = new Entry[size];
		return obj;
	}

	void AddEntry(Instance& inst, Entry ed)
	{
		if (inst.size == inst.maxsize) throw (char*)THROW03;
		for (int i = 0; i < inst.size; i++)
		{
			if (inst.dictionary->id == ed.id) throw (char*)THROW04;
		}
		inst.dictionary[inst.size] = ed;
		inst.size++;
	}

	void DelEntry(Instance& inst, int id)
	{
		for (int i = 0; i < inst.size; i++)
		{
			if (inst.dictionary[i].id == id)
			{
				for (i; i < inst.size - 1; i++)
				{
					inst.dictionary[i] = inst.dictionary[i + 1];
				}
				break;
			}
			if (i == inst.size - 1) throw (char*)THROW06;
		}
		inst.size--;
	}

	void UpdEntry(Instance& inst, int id, Entry new_ed)
	{
		bool g = true;
		for (size_t i = 0; i < inst.size; i++)
		{
			if (inst.dictionary[i].id == id)
			{
				inst.dictionary[i] = new_ed;
				break;
			}
			if (new_ed.id == inst.dictionary[i].id) throw (char*)THROW08;
			if (i == inst.size - 1)				    throw (char*)THROW07;
		}
	}

	Entry GetEntry(Instance inst, int id)
	{
		for (size_t i = 0; i < inst.size; i++)
		{
			if (inst.dictionary[i].id == id) return inst.dictionary[i];
			if (i == inst.size - 1) throw (char*)THROW05;
		}
	}

	void Print(Instance d)
	{
		int n = strlen(d.name);
		cout << "------- ";
		for (size_t i = 0; i < n; i++)
		{
			cout << d.name[i];
		}
		cout << " -------" << endl;
		for (size_t i = 0; i < d.size; i++)
		{
			cout << d.dictionary[i].id << " " << d.dictionary[i].name << endl;
		}
	}

	void Delete(Instance& d)
	{
		delete[] d.dictionary, d;
	}
}