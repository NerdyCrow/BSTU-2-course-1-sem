﻿#include"Error.h"
namespace Error {
	//ñåðèè îøèáîê: 0 - 99 - ñèñòåìíûå îøèáêè
	//				100 - 109 - îøèáêè ïàðàìåòðîâ
	//				110 - 119 - îøèáêè îòêðûòèÿ è ÷òåíèÿ ôàéëîâ
	ERROR errors[ERROR_MAX_ENTRY] =
	{	//òàáëèöà îøèáîê
	ERROR_ENTRY(0,"Íåäîïóñòèìûé êîä îøèáêè"),	//êîä îøèáêè âíå äèàïàçîíà 0 - ERROR_MAX_ENTRY
	ERROR_ENTRY(1,"Ñèñòåìíûé ñáîé"),
	ERROR_ENTRY_NODEF(2),ERROR_ENTRY_NODEF(3),ERROR_ENTRY_NODEF(4),ERROR_ENTRY_NODEF(5),
	ERROR_ENTRY_NODEF(6),ERROR_ENTRY_NODEF(7),ERROR_ENTRY_NODEF(8),ERROR_ENTRY_NODEF(9),
	ERROR_ENTRY_NODEF10(10),ERROR_ENTRY_NODEF10(20),ERROR_ENTRY_NODEF10(30), ERROR_ENTRY_NODEF10(40),ERROR_ENTRY_NODEF10(50),
	ERROR_ENTRY_NODEF10(60),ERROR_ENTRY_NODEF10(70),ERROR_ENTRY_NODEF10(80),ERROR_ENTRY_NODEF10(90),
	ERROR_ENTRY(100,"Ïàðàìåòð -in äîëæåí áûòü çàäàí"),
	ERROR_ENTRY_NODEF(101), ERROR_ENTRY_NODEF(102),ERROR_ENTRY_NODEF(103),
	ERROR_ENTRY(104,"Ïðåâûøåíà äëèíà âõîäíîãî ïàðàìåòðà"),
	ERROR_ENTRY_NODEF(105), ERROR_ENTRY_NODEF(106), ERROR_ENTRY_NODEF(107),
	ERROR_ENTRY_NODEF(108), ERROR_ENTRY_NODEF(109),
	ERROR_ENTRY(110,"Îøèáêà ïðè îòêðûòèè ôàéëà ñ èñõîäíûì êîäîì (-in)"),
	ERROR_ENTRY(111,"Íåäîïóñòèìûé ñèìâîë â èñõîäíîì ôàéëå (-in)"),
	ERROR_ENTRY(112,"Îøèáêà ïðè ñîçäàíèè ôàéëà ïðîòîêîëà (-log)"),
	ERROR_ENTRY_NODEF(113),ERROR_ENTRY_NODEF(114),ERROR_ENTRY_NODEF(115),
	ERROR_ENTRY_NODEF(116),ERROR_ENTRY_NODEF(117),ERROR_ENTRY_NODEF(118),ERROR_ENTRY_NODEF(119),
	ERROR_ENTRY_NODEF10(120), ERROR_ENTRY_NODEF10(130),ERROR_ENTRY_NODEF10(140),ERROR_ENTRY_NODEF10(150),
	ERROR_ENTRY_NODEF10(160),ERROR_ENTRY_NODEF10(170),ERROR_ENTRY_NODEF10(180),ERROR_ENTRY_NODEF10(190),
	ERROR_ENTRY_NODEF100(200),ERROR_ENTRY_NODEF100(300),ERROR_ENTRY_NODEF100(400),ERROR_ENTRY_NODEF100(500),
	ERROR_ENTRY_NODEF100(600),ERROR_ENTRY_NODEF100(700),ERROR_ENTRY_NODEF100(800),ERROR_ENTRY_NODEF100(900)
	};
	ERROR getError(int id) {
		if (id >= 0 && id < ERROR_MAX_ENTRY)
			return errors[id];
		return errors[0];
	}
	ERROR getErrorIn(int id, int line = -1, int column = -1) {
		if (id >= 0 && id < ERROR_MAX_ENTRY) {
			errors[id].inext.line = line;
			errors[id].inext.column = column;

			return errors[id];
		}
		return errors[0];
	}
};