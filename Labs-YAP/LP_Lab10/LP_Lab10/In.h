#pragma once
#define IN_MAX_LEN_TEXT 1024 * 1024	// максимальный размер исходного кода = 1MB
#define IN_CODE_ENDL '\n'	// символ конца строки
// таблица проверки входной информации, индекс = код (Windows-1251) символа
// значения IN::F - завершенный символ, IN::Т - разрешенный символ, IN::I -игнорировать (не вводить), //	если 0 <= значение < 256 - то вводится данное значение
#define IN_CODE_TABLE {\
	IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::T, IN::F, IN::F, IN::I, IN::F, IN::F, \
	IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, \
	IN::T, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, \
	IN::T, IN::F, IN::T, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, \
	IN::F, IN::T, IN::T, IN::F, IN::F, IN::T, IN::F, IN::F, IN::T, IN::T, IN::F, IN::T, IN::T, IN::F, IN::F, IN::T, \
	IN::F, IN::F, IN::F, IN::T, IN::F, IN::F, IN::T, IN::F, IN::I, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, \
	IN::F, IN::T, IN::T, IN::F, IN::F, IN::T, IN::F, IN::F, IN::T, IN::T, IN::F, IN::T, IN::T, IN::F, IN::F, IN::T, \
	IN::F, IN::F, IN::F, IN::T, IN::F, IN::F, IN::T, IN::F, IN::I, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, \
																													\
	IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, \
	IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, \
	IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, \
	IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, \
	  '-', IN::T, IN::T, IN::F, IN::F, IN::T, IN::F, IN::F, IN::T, IN::T, IN::T, IN::T, IN::F, IN::F, IN::T, IN::F, \
	IN::F, IN::T, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::T, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, \
	  '-', IN::T, IN::T, IN::F, IN::F, IN::T, IN::F, IN::F, IN::T, IN::T, IN::T, IN::T, IN::F, IN::F, IN::T, IN::F, \
	IN::F, IN::T, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::T, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F, IN::F  \
}

namespace In 
{
	struct IN										// исходные данные
	{
		enum { T = 1024, F = 2048, I = 4096 };		// T - допустимый символ, F - недопустимый, I - игнорировать, иначе заменить
		int size = 0;								//	размер исходного кода
		int lines = 0;								//	количество строк
		int ignor = 0;								//	количество проигнорированных символов
		unsigned char* text;						//	исходный код (Windoius -	1251)
		int code[256] = IN_CODE_TABLE;				//	таблица проверки: T, F,	I новое	значение
	};
	IN getin(wchar_t infile[]);						// ввести и проверить входной поток
}