// ТЕСТИРОВАНИЕ ERROR

#include <iostream>
#include <locale>
#include <cwchar>
#include <fstream>
#include "Error.h"	//обработка ошибок
#include "Log.h"	//работа с протоколом
#include "In.h"		//ввод исходного файла
#include "Parm.h"	//обработка парам
using namespace std;


int main() {
	setlocale(LC_CTYPE, "Russian");
	std::cout << "---- тест Error::geterror ---" << std::endl << std::endl;
	try { throw ERROR_THROW(100); }
	catch (Error::ERROR e)

	{
		std::cout << "ошибка " << e.id << ": " << e.message << std::endl << std::endl;
	};
	std::cout << "---- тест Error::getErrorin ---" << std::endl << std::endl;

	try { throw ERROR_THROW_IN(111, 7, 7); }
	catch (Error::ERROR e)

	{
		std::cout << "ошибка " << e.id<< ": " << e.message
			<< ", строка " << e.inext.line
			<<"‚позиция " << e.inext.column << std::endl << std::endl;
	
};
system("pause");

return 0;

}

// ТЕСИТРОВАНИЕ LOG

//#include <cwchar>
//
//#include "Error.h" // обработка ошибок
//
//#include "Parm.h" // обработка параметров
//#include "Log.h" // работа с протоколом
//#include "In.h" // ввод исходного файла
//#include <iostream>
//
//int wmain(int argc,const wchar_t *argv[])
//{
//	setlocale(LC_ALL, "rus");
//	std::cout << "---- тест Parm::getparm ---" << std::endl << std::endl;
//	try
//	{
//
//		Parm::PARM parm = Parm::getParm(argc, argv);
//		std::wcout << "-in:" << parm.in << ", -out:" << parm.out << ", -log:" << parm.log << std::endl << std::endl;
//
//	}
//	catch (Error::ERROR e)
//	{
//		std::cout << "ошибка " << e.id << ": " << e.message << std::endl << std::endl;
//	};
//
//	system("pause");
//	return 0;
//}

// ТЕСТИРОВАНИЕ IN

//#include <iostream>
//#include <locale>
//#include <cwchar>
//
//#include  "Error.h" // обработка ошибок
//
//#include  "Parm.h" // обработка параметров
//#include  "Log.h" // работа с протоколом
//#include  "In.h" // ввод исходного Файла
//
//int wmain(int argc, const wchar_t *argv[])
//{
//	setlocale(LC_ALL, "rus");
//	std::cout << "---- тест In::getin ---" << std::endl << std::endl;
//	try
//	{
//		Parm::PARM parm = Parm::getParm(argc, argv);
//		In::IN in = In::getIn(parm.in);
//		std::cout << in.text << std::endl;
//		std::cout << "всего символов: " << in.size << std::endl;
//		std::cout << "всего строк: " << in.lines << std::endl;
//		std::cout << "пропущено: " << in.ignor << std::endl;
//
//	}
//
//	catch (Error::ERROR e)
//	{
//		std::cout << "ошибка " << e.id << ": " << e.message << std::endl << std::endl;
//	};
//	system("pause");
//	return 0;
//}


// ТЕСТИРОВАНИЕ LOG

//#define _CRT_SECURE_NO_WARNINGS
//#include <iostream>
//#include <locale>
//#include <cwchar>
//

//#include "Error.h" // обработка ошибок
//#include  "Parm.h" // обработка параметров
//#include  "Log.h" // работа с протоколом{
//#include  "In.h" // ввод исходного Файла
//int wmain(int argc, const wchar_t* argv[])
//{
//	setlocale(LC_ALL, "rus");
//	Log::LOG log;
//	try
//	{
//		Parm::PARM parm = Parm::getParm(argc, argv);
//		log = Log::getlog(parm.log);
//		Log::WriteLine(log, "тест: ", "без ошибок ", "");
//		Log::WriteLog(log);
//		Log::WriteParm(log, parm);
//		In::IN in = In::getIn(parm.in);
//		Log::WriteInsideTextTo_OutFile(parm, in);
//		Log::WriteIn(log, in);
//		Log::Close(log);
//	}
//
//	catch (Error::ERROR e)
//	{
//		Log::WriteError(log, e);
//	}
//	system("pause");
//	return 0;
//
//};