#include "stdafx.h"

namespace In
{
	IN getin(wchar_t infile[])
	{
		std::ifstream inputF(infile);
		if (!inputF.is_open()) throw ERROR_THROW(110);

		IN result;
		int curLine = 0, curCol = 0;
		std::string fullText, curStr;

		while (true)
		{
			std::getline(inputF, curStr);
			if (!inputF) break;
			result.lines++;
			curStr.append("\n");
			fullText.append(curStr);
		}

		if (fullText.size() > IN_MAX_LEN_TEXT) throw ERROR_THROW(1)
		else result.text = new unsigned char[fullText.size()];
		unsigned char* resPtr = result.text;
		unsigned char symbol;

		for (size_t i = 0; i < fullText.size(); ++i)
		{
			symbol = fullText[i];

			switch (result.code[symbol])
			{
			case IN::T:
				*resPtr++ = symbol;
				break;
			case IN::F:
				throw ERROR_THROW_IN(111, curLine, curCol)
					break;
			case IN::I:
				result.ignor++;
				break;
			default:
				*resPtr++ = result.code[symbol];
				break;
			}

			if (symbol == '\n')
			{
				curLine++;
				curCol = 0;
			}
			else curCol++;
		}
		*resPtr = '\0';
		result.size = strlen((char*)result.text);

		return result;
	}
}