#include "stdafx.h"

int main()
{
	setlocale(LC_ALL, "rus");
	char* fst[9] = {(char*)"abcdebh", (char*)"abbcdebbh", (char*)"abcfggbh", (char*)"abbbh", (char*)"abbbbh", (char*)"abcfgbh", (char*)"abbbbbh", (char*)"abbbb", (char*)"aqbcfbg"};

	for (int i = 0; i < 9; i++)
	{
		FST::FST fst1(
			fst[i],
			10,
			FST::NODE(1, FST::RELATION('a', 1)),
			FST::NODE(1, FST::RELATION('b', 2)),
			FST::NODE(3, FST::RELATION('b', 8), FST::RELATION('b', 2), FST::RELATION('c', 3)),
			FST::NODE(3, FST::RELATION('d', 6), FST::RELATION('f', 4), FST::RELATION('e', 7)),
			FST::NODE(3, FST::RELATION('g', 5), FST::RELATION('b', 8) ,FST::RELATION('e', 7)),
			FST::NODE(4, FST::RELATION('b', 8),FST::RELATION('c', 3), FST::RELATION('g', 5), FST::RELATION('h', 9)),
			FST::NODE(3, FST::RELATION('b', 8), FST::RELATION('c', 3), FST::RELATION('e', 7)),
			FST::NODE(2, FST::RELATION('b', 8), FST::RELATION('c', 3)),
			FST::NODE(2, FST::RELATION('b', 8), FST::RELATION('h', 9)),
			FST::NODE()
		);
		if (FST::execute(fst1)) std::cout << "Цепочка " << fst1.string << " распознана" << std::endl;
		else std::cout << "Цепочка " << fst1.string << " не распознана" << std::endl;
	}
}
