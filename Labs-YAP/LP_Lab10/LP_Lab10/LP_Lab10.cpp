#include "stdafx.h"

int wmain(int argc, wchar_t* argv[])
{
	setlocale(LC_ALL, "rus");

	std::cout << "---тест Error::geterror —" <<std::endl<<std::endl;
	/*try 
	{ 
		throw ERROR_THROW(100);
	}
	catch (Error::ERROR e)
	{
		std::cout << "Ошибка " << e.id << ": " << e.message << std::endl << std::endl;
	}
	std::cout << "---тест Error::geterrorin -" << std::endl << std::endl;
	try 
	{ 
		throw ERROR_THROW_IN(111, 7, 7); 
	}
	catch (Error::ERROR e)
	{
		std::cout << "Ошибка " << e.id << ": " << e.message
			<< ", строка " << e.inext.line
			<< "; позиция " << e.inext.col << std::endl << std::endl;
	};*/

	//-------------------------------------------------------------------------------------------------------------------------------

	std::cout << "------ тест Parm::getparm  ---" << std::endl << std::endl;
	try
	{
		Parm::PARM parm = Parm::getparm(argc, argv);
		std::cout << "-in: " << parm.in << ", -out: " << parm.out << ", -log: " << parm.log << std::endl << std::endl;
	}
	catch (Error::ERROR e)
	{
		std::cout << "Ошибка " << e.id << ": " << e.message << std::endl << std::endl;
	}

	//-------------------------------------------------------------------------------------------------------------------------------

	//LP_Lab10.exe -in:D:\ЯП\LP_Lab10\LP_Lab10\input.txt -log:E:\Учёба\ЯП\LP_Lab10\LP_Lab10\log.txt
	//std::cout << "------ тест IN::getin ---" << std::endl << std::endl;
	//try
	//{
	//	Parm::PARM parm = Parm::getparm(argc, argv);
	//	In::IN in = In::getin(parm.in);
	//	std::cout << in.text;
	//	std::cout << "Всего символов: " << in.size << std::endl;
	//	std::cout << "Всего строк: " << in.lines << std::endl;
	//	std::cout << "Пропущено: " << in.ignor << std::endl;
	//}
	//catch (Error::ERROR e)
	//{
	//	std::cout << "Ошибка " << e.id << ": " << e.message << ", строка " << e.inext.line << "; позиция " << e.inext.col << std::endl << std::endl;
	//}

	////-------------------------------------------------------------------------------------------------------------------------------

	//Log::LOG log = Log::INITLOG;
	//try
	//{
	//	Parm::PARM parm = Parm::getparm(argc, argv);
	//	log = Log::getlog(parm.log);
	//	Log::WriteLine(log, L"Тест", L" Без ошибок", L"");
	//	Log::WriteLog(log);
	//	Log::WriteParm(log, parm);
	//	In::IN in = In::getin(parm.in);
	//	Log::WriteIn(log, in);
	//	Log::Close(log);
	//}
	//catch (Error::ERROR e)
	//{
	//	Log::WriteError(log, e);
	//}

	system("pause"); 
	return 0;
}