//

#include <iostream>
#include<cstdlib>

//utf-8
//SlemnyovVictor2002 53 6c 65 6d 6e 79 6f 76 56 69 63 74 6f 72 32 30 30 32
//СлемневВиктор2002  d1 eb e5 ec ed e5 e2 c2 e8 ea f2 ee f0 32 30 30 32
//Слемнев2002Victor d1 eb e5 ec ed e5 e2 32 30 30 32 56 69 63 74 6f 72
//utf-16
//SlemnyovVictor2002  0053 006C 0065 006D 006E 0079 006F 0076 0056 0069 0063 0074 006F 0072 0032 0030 0030 0032
//СлемневВиктор2002  0421 043B 0435 043C 043D 0435 0432 0412 0438 043A 0442 043E 0440 0032 0030 0030 0032
//Слемнев2002Victor  0421 043B 0435 043C 043D 0435 0432 0032 0030 0030 0032 0056 0069 0063 0074 006F 0072
//1251
//SlemnyovVictor2002  53 6c 65 6d 6e 79 6f 76 56 69 63 74 6f 72 32 30 30 32
//СлемневВиктор2002  d1 eb e5 ec ed e5 e2 c2 e8 ea f2 ee f0 32 30 30 32
//Слемнев2002Victor  Слемнев2002Victor 

char* UpperW1251(char* destination, char* source);



int main(){
	char lf[] = "SlemnyovVictor2002";
	char rf[] = "СлемневВиктор2002";
	char lr[] = "Слемнев2002Victor";

	wchar_t Llp[] = L"SlemnyovVictor2002";
	wchar_t Lrp[] = L"СлемневВиктор2002";
	wchar_t Llr[] = L"Слемнев2002Victor";

	char source[] = "12345sdfghjйцгшщз";
	char destination[] = "12345678990123456789";

	UpperW1251(destination, source);
	std::cout << UpperW1251(destination, source) <<std:: endl;
	system("pause");
	
}
char* UpperW1251(char* destination, char* source)
{
	for (int i = 0; i < strlen(source); i++)
	{
		if ((source[i] >= 'a' && source[i] <= 'z') || (source[i] >= 'а' && source[i] <= 'я')) destination[i] = source[i] - 32;
		else destination[i] = source[i];
	}

	return destination;
}

