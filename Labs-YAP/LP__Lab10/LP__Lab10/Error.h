#pragma once
#define ERROR_THROW(id) Error::getError(id);	//throw ERROR_THROW(id)
#define ERROR_THROW_IN(id, line, column) Error::getErrorIn(id, line, column);	//throw ERROR_TROW(id,line, column)
#define ERROR_ENTRY(id,m) {id, m,{-1,-1}}		//ýëåìåíò òàáëèöû îøèáîê
#define ERROR_MAXSIZE_MESSAGE 200				//äëèíà ìàêñ ñîîáùåíèÿ îá îøèáêå
#define ERROR_ENTRY_NODEF(id) ERROR_ENTRY(id,"Íåîïðåä îøèáêà")					//-1 íåîïðåä ýëåìåíò òàáë îøèáîê
// ERROR_ENTRY_NODEF10(id) - 10 íåîïðåäåëåíûõ	ýëåìåíòû òàáë îøèáîê
#define ERROR_ENTRY_NODEF10(id) ERROR_ENTRY_NODEF(id+0), ERROR_ENTRY_NODEF(id+1), ERROR_ENTRY_NODEF(id+2), \
								ERROR_ENTRY_NODEF(id+3), ERROR_ENTRY_NODEF(id+4), ERROR_ENTRY_NODEF(id+5), \
								ERROR_ENTRY_NODEF(id+6), ERROR_ENTRY_NODEF(id+7), ERROR_ENTRY_NODEF(id+8), \
								ERROR_ENTRY_NODEF(id+9)

	 // ERROR_ENTRY_NODEF100(id) - 100 íåîïðåäåëåíûõ ýëåìåíòû òàáë îøèáîê
#define ERROR_ENTRY_NODEF100(id) ERROR_ENTRY_NODEF10(id+0), ERROR_ENTRY_NODEF10(id+10), ERROR_ENTRY_NODEF10(id+20), \
								ERROR_ENTRY_NODEF10(id+30), ERROR_ENTRY_NODEF10(id+40), ERROR_ENTRY_NODEF10(id+50), \
								ERROR_ENTRY_NODEF10(id+60), ERROR_ENTRY_NODEF10(id+70), ERROR_ENTRY_NODEF10(id+80), \
								ERROR_ENTRY_NODEF10(id+90)
#define ERROR_MAX_ENTRY 1000					//êîëè÷åñòâî ýëåìåíòîâ â òàáë îøèáîê

namespace Error {
	struct ERROR {								//òèï èñêëþ÷åíèÿ äëÿ throw ERROR_THROW | ERROR_THROW_IN è catch(ERROR)
		int id;									//êîä îøèáêè
		char message[ERROR_MAXSIZE_MESSAGE];	//ñîîáùåíèå îá îøèáêå
		struct IN {								//ðàñøèðåíèå äëÿ îøèáîê ïðè îáðàáîòêå âõîäíûõ äàííûõ
			short line;							//íîìåð ñòðîêè
			short column;						//íîìåð ïîçèöèè â ñòðîêå
		}inext;
	};
	ERROR getError(int id);								//ñôîðìèðîâàòü	ERROR äëÿ ERROR_THROW
	ERROR getErrorIn(int id, int line, int column);		//ñôîðìèðîâàòü	ERROR äëÿ ERROR_THROW_IN
}