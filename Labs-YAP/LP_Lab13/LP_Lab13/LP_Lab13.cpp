#include "stdafx.h"

void fun(wchar_t inputName[], wchar_t outputName[])
{
	int str_len = 256;
	char* str = new char[str_len];
	std::ifstream input(inputName);
	std::ofstream output(outputName);

	while (true)
	{
		input.getline(str, str_len);
		if (input.eof() != 0) break;

		for (int i = 0; i < str_len; i++)
		{
			if (str[i] == '|')
			{
				str[i] = '\0';
				break;
			}
		}

		FST::FST fst(
			str,
			6,
			FST::NODE(1, FST::RELATION('a', 1)),
			FST::NODE(2, FST::RELATION('b', 1), FST::RELATION('b', 2)),
			FST::NODE(4, FST::RELATION('c', 3), FST::RELATION('d', 3), FST::RELATION('e', 3), FST::RELATION('b', 4)),
			FST::NODE(2, FST::RELATION('f', 2), FST::RELATION('b', 4)),
			FST::NODE(2, FST::RELATION('b', 4), FST::RELATION('g', 5)),
			FST::NODE()
		);

		if (FST::execute(fst)) output << "Цепочка " << fst.string << " распознана\n";
		else output << "Цепочка " << fst.string << " не распознана\n";
	}

	input.close();
	output.close();
}

int wmain(int argc, wchar_t* argv[])
{
	setlocale(LC_ALL, "rus");

	Log::LOG log = Log::INITLOG;
	try
	{
		Parm::PARM parm = Parm::getparm(argc, argv);
		log = Log::getlog(parm.log);
		Log::WriteLine(log, L"Тест", L" Без ошибок", L"");
		Log::WriteLog(log);
		Log::WriteParm(log, parm);
		In::IN in = In::getin(parm.in);
		Log::WriteIn(log, in);
		Log::Close(log);
		fun(parm.in, parm.out);
	}
	catch (Error::ERROR e)
	{
		Log::WriteError(log, e);
	}

	return 0;
}
//LP_Lab13.exe -in:E:\Учёба\ЯП\LP_Lab13\LP_Lab13\input.txt -log:E:\Учёба\ЯП\LP_Lab13\LP_Lab13\log.txt -out:E:\Учёба\ЯП\LP_Lab13\LP_Lab13\output.txt