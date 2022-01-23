#include <iostream>
using namespace std;

void function(void);

int main()
{
	setlocale(LC_ALL,"rus");
	
	bool a = true;
	bool b = false;
	char ch = 'w';
	wchar_t cht = 'г';

	short s1 = 22; // 00 16
	// 22/2=11(ост. 0)
	// 11/2=5(ост. 1)
	// 5/2=2(ост. 1)
	// 2/2=1(ост. 0)
	// 0000 0000 0001 0110(2 с.с.)
	//    0    0    1    6(16 c.c.)

	short s2 = -22; // FF EA
	// 0000 0000 0001 0110(2 с.с.)
	// 1111 1111 1110 1001(2 c.c. обратный код)
	// 1111 1111 1110 1010(2 c.c. дополнительный код)
	//    F    F    E    A(16 c.c.)

	short sMin = 0x8000; // 80 00
	

	short sMax = 0x7FFF; // 7F FF
	

	unsigned short usMin = 0x0000; // 00 00
	

	unsigned short usMax = 0xFFFF; // FF FF


	int i1 = 23; // ff ff
	

	int i2 = -23; // ff ff ff e9
	

	int iMin = 0x80000000; // 80 00 00 00
	// 1000 0000 0000 0000 0000 0000 0000 0000(2 с.с.)
	// 0111 1111 1111 1111 1111 1111 1111 1111(2 c.c. обратный код)
	// 1000 0000 0000 0000 0000 0000 0000 0000(2 c.c. дополнительный код)
	//    8    0    0    0    0    0    0    0(16 c.c.)

	int iMax = 0x7FFFFFFF; // 7F FF FF FF
	// 0111 1111 1111 1111 1111 1111 1111 1111(2 c.c.)
	//    7    F    F    F    F    F    F    F(16 с.с.)

	unsigned int uiMin = 0x0; // 00 00 00 00
	// 0000 0000 0000 0000 0000 0000 0000 0000(2 с.с.)
	//    0    0    0    0    0    0    0    0(16 с.с.)

	unsigned int uiMax = 0xFFFFFFFF; // FF FF FF FF
	// 1111 1111 1111 1111 1111 1111 1111 1111(2 c.c.)
	//    F    F    F    F    F    F    F    F(16 с.с.)

	long l1 = 24; // 00 00 00 18
	long l2 = -24; // FF FF FF e8
	long lMin = 0x80000000; // 80 00 00 00
	long lMax = 0x7FFFFFFF; // 7F FF FF FF
	unsigned long ulMin = 0x0; // 00 00 00 00
	unsigned long ulMax = 0xFFFFFFFF; // FF FF FF FF

	float f1 = 14.000; // 00 00 60 41
	float f2 = -14.000; // 00 00 60 c1
	float f3 = f1 / 0; // +∞ (1.#INF)
	float f4 = f2 / 0; // -∞ (-1.#INF)
	float f5 = sqrt(f2); //неопределённость (-1.#IND)

	double d1 = 4.00; //

	char* pch = &ch;//0x010ffb17
	wchar_t* pcht = &cht;//0x010ffb08
	short* ps1 = &s1;//0x010ffafc
	int* pi1 = &i1;//0x010ffab4
	float* pf1 = &f1;//0x010ffa24
	double* pd1 = &d1;//0x010ff9e4

	pch += 3; //0x010ffb1a
	pcht += 3;// 0x008ffdca
	ps1 += 3;//0x0053fe26
	pi1 += 3;//0x0053fde4
	pf1 += 3;//0x0053fd54
	pd1 += 3;//0x0053fd20

	void(*fun)(void);
	fun = function;

	char& lch = ch;
	wchar_t& lcht = cht;
	short& ls1 = s1;
	int& li1 = i1;
	float& lf1 = f1;
	double& ld1 = d1;


	system("pause");
}

void function(void)
{
	cout << "Hello, world!" << endl;
}