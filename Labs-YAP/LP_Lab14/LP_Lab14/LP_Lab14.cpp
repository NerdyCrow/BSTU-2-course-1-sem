#include "stdafx.h"

#define TIMES 1

int wmain(int argc, wchar_t* argv[])
{
	setlocale(LC_ALL, "rus");

	Log::LOG log = Log::INITLOG;
	try
	{
		std::chrono::high_resolution_clock::time_point t1 = std::chrono::high_resolution_clock::now();

		for (size_t i = 0; i < TIMES; i++)
		{
			Parm::PARM parm = Parm::getparm(argc, argv);
			log = Log::getlog(parm.log);
			LT::LexTable lexTable = LT::Create(300);
			IT::IdTable	idTable = IT::Create(100);
			In::IN in = In::getin(parm.in, parm.IT, parm.LT, lexTable, idTable);
			PN::PolishNotation(15, lexTable, idTable);
			PN::PolishNotation(60, lexTable, idTable);
			PN::PolishNotation(116, lexTable, idTable);
			LT::LexTablePrint(lexTable, parm.LT);
			IT::PrintIdTable(idTable, parm.IT);
			LT::Delete(lexTable);
			IT::Delete(idTable);
			Log::AssembleLog(log, parm, in);
		}
		
		std::chrono::high_resolution_clock::time_point t2 = std::chrono::high_resolution_clock::now();
		std::chrono::duration<double> time_span = std::chrono::duration_cast<std::chrono::duration<double>>(t2 - t1);
		std::cout << time_span.count() / TIMES << " seconds.";
	}
	catch (Error::ERROR e)
	{
		Log::WriteError(log, e);
	}

	return 0;
}

//LP_Lab14.exe -in:E:\ЯП\LP_Lab14\input.txt -log:E:\ЯП\LP_Lab14\log.txt -out:E:\ЯП\LP_Lab14\output.txt -IT:E:\ЯП\LP_Lab14\idTable.txt -LT:E:\ЯП\LP_Lab14\lexTable.txt