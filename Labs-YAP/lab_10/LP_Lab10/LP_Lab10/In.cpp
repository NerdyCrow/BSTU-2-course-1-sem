#include "In.h"
#include "Parm.h"
#include "Error.h"
#include <iostream>
#include <locale>
#include <cwchar>
#include <fstream>
using namespace std;
ifstream reading;
namespace In {
	IN In::getIn(wchar_t infile[]) {
		IN in;
		unsigned char s;
		in.text = "";

		in.size = 0;
		in.lines = 0;
		in.ignor = 0;
		int i = 0;
		int inCode[256] = IN_CODE_TABLE;
		reading.open(infile);
		if (reading.fail())throw ERROR_THROW(110);
		while (reading.read((char*)&s, 1)) {
			if ((unsigned int)s > 0 && (unsigned int)s < 256) {
				if (inCode[(unsigned int)s] == in.F) {
					throw ERROR_THROW_IN(111, in.lines, i);
				}
				else if (inCode[(unsigned int)s] == in.T) {
					in.text += s;
					if (s == IN_CODE_ENDL) {
						in.lines++;
						i = 0;
					}
				}
				else if (inCode[(unsigned int)s] == in.I) {
					in.ignor++;

				}
				else {
					in.text += inCode[(unsigned int)s];
				}
				
				
			}



			i++;
			in.size++;
		}
		reading.close();

		return in;

	}
};