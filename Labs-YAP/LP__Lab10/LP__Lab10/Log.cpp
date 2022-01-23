#include <iostream>
#include <ctime>
#include "Parm.h"
#include "Log.h"

namespace Log
{
	LOG getlog(wchar_t* logfile)
	{
		LOG temp;
		temp.stream->open(logfile);

		if (!temp.stream)
			throw ERROR_THROW(112);

		return temp;
	}

	void WriteLine(LOG log, const char* c, ...)
	{
		const char** ptr = &c;

		while (*ptr != "")
		{
			*log.stream << *ptr;
			ptr++;
		}
	}

	void WriteLine(LOG log, const wchar_t* wc, ...)
	{
		const wchar_t** ptr = &wc;

		char temp[100];

		while (*ptr != L"")
		{
			wcstombs(temp, *ptr++, sizeof(temp));
			*log.stream << temp;
		}
	}

	void WriteLog(LOG log)
	{
		time_t rawtime;
		struct tm timeinfo;			//ñòðóêòóðà õðàíÿùàÿ òåêóùåå âðåìÿ
		char buffer[100];

		time(&rawtime);					//òåêóùàÿ äàòà â ñåêóíäàõ
		localtime_s(&timeinfo, &rawtime);	//òåêóùåå ëîêàëüíîå âðåìÿ, ïðåäñòàâëåííîå â ñòðóêòóðå

		*log.stream << "-----Ïðîòîêîë----- " << endl;
		strftime(buffer, 100, "Äàòà: %d.%m.%Y %A %H:%M:%S", &timeinfo);
		*log.stream << buffer << endl;
	}

	void WriteParm(LOG log, Parm::PARM parm)
	{
		char inInfo[PARM_MAX_SIZE];
		char outInfo[PARM_MAX_SIZE];
		char logInfo[PARM_MAX_SIZE];

		wcstombs(inInfo, parm.in, sizeof(inInfo));
		wcstombs(outInfo, parm.out, sizeof(outInfo));
		wcstombs(logInfo, parm.log, sizeof(logInfo));

		*log.stream << "-----Ïàðàìåòðû----- " << endl;
		*log.stream << "-in:\t" << inInfo << endl;
		*log.stream << "-log:\t" << logInfo << endl;
		*log.stream << "-out:\t" << outInfo << endl;
	}

	void WriteIn(LOG log, In::IN in)
	{
		*log.stream << "-----Èñõîäíûå äàííûå----- " << endl;
		*log.stream << "Êîëè÷åñòâî ñèìâîëîâ: " << in.size << endl;
		*log.stream << "Ïðîèãíîðèðîâàíî    : " << in.ignor << endl;
		*log.stream << "Êîëè÷åñòâî ñòðîê   : " << in.lines + 1 << endl;
	}

	void WriteInsideTextTo_OutFile(Parm::PARM parm, In::IN in)
	{
		ofstream outFile;
		outFile.open(parm.out);

		if (!outFile)
			ERROR_THROW(1);

		outFile << in.text;
		outFile.close();
	}

	void WriteError(LOG log, Error::ERROR error)
	{
		if (error.id == 100 || error.id == 113)
		{
			cout << "ÎØÈÁÊÀ " << error.id << ": " << error.message << "\n";
		}
		else
		{
			cout << "ÎØÈÁÊÀ " << error.id << ": " << error.message << "\n" << "Ñòðîêà " << error.inext.line << ", ïîçèöèÿ: " << error.inext.column << endl;
		}
		log.stream->close();
	}

	void Close(LOG log)
	{
		(*log.stream).close();
	}
}