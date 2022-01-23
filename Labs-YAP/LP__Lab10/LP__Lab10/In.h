#pragma once
#include<iostream>
#include<string>
using namespace std;
#define IN_MAX_LEN_TEXT 1024*1024		//ìàêñèìàëüíûé ðàçìåð èñõîäíîãî êîäà 1ÌÂ
#define IN_CODE_ENDL '\n'				//ñèìâîë êîíöà ñòðîêè

//òàáëèöà ïðîâåðêè âõîäíîé èíôîðìàöèè, èíäåêñ = êîä (Windows-1251) ñèìâîëà
//çíà÷åíèÿ IN::F - çàïðåùåííûé ñèìâîëÁ IN::T - ðàçðåøåííûé ñèìâîë, IN::I - èãíîðèðîâàòü (íå ââîäèòü),
//			åñëè 0 <= çíà÷åíèå < 256  - òî ââîäèòüñÿ äàííîå çíà÷åíèå

#define IN_CODE_TABLE {\
		IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::T, IN::F, IN::F, IN::F, IN::F, IN::F, \
		IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, \
		IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, \
		IN::T, IN::T, IN::T, IN::T, IN::T, IN::T, IN::T, IN::T, IN::T, IN::T, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, \
		IN::F, IN::T, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::T, IN::F, IN::T, \
		IN::F, IN::F, IN::T, IN::F, IN::F, IN::F, IN::F, IN::F, IN::I,   '!', IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, \
		IN::F, IN::T, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::T, IN::F, IN::T, \
		IN::F, IN::F, IN::T, IN::F, IN::F, IN::F, IN::F, IN::F, IN::I, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, \
																														\
		IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, \
		IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, \
		IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, \
		IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, \
		IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, \
		IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, \
		IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, \
		IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F	\
	}

namespace In {
	struct IN {		//èñõîäíûå äàííûå
		enum { T = 1024, F = 2048, I = 4096 };	//T - äîïóñòèìûé ñèìâîë, F - íåäîïóñòèìûé, I - èãíîðèðîâàòü, èíà÷å çàìåíèòü
		int size;								//ðàçìåð èñõîäíîãî êîäà
		int lines;								//êîë-âî ñòðîê
		int ignor;								//êîë-âî ïðîèãíîðèðîâàííûõ ñèìâîëîâ	
		string text;                            //èñõîäíûé êîä (Windows-1251)
		int code[256];							//òàáëèöà ïðîâåðêè: T, F, I íîâîå çíà÷íèå
	};
	IN getIn(wchar_t infile[]);					//ââåñòè è ïðîâåðèòü âõîäíîé ïîòîê
}