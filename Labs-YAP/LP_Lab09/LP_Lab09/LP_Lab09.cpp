#include<iostream>
#include"Varparm.h"
#include"Call.h"
using namespace std;
using namespace Varparm;
using namespace Call;

int defaultparm(int a, int b, int c, int d, int e, int f = 6, int g = 7)
{
	return (a + b + c + d + e + f + g) / 7;
}

int main()
{
	setlocale(LC_ALL, "RUS");
	int a = 4, b = 8, c = 2;
	cout << "ivarparm 1 параметр: "<<ivarparm(1, 3) << endl;
	cout << "ivarparm 2 параметра: "<<ivarparm(2, 6, 5) << endl;
	cout << "ivarparm 3 параметра: " <<ivarparm(3, 2, 9,12) << endl;
	cout << "ivarparm 7 параметров: "<<ivarparm(7, 2, 5, 9,10, 3,7,2) << endl;

	cout << svarparm(1, 45) << endl;
	cout << svarparm(2, 43, 3) << endl;
	cout << svarparm(3, 45, 2, 8) << endl;
	cout << svarparm(7, 1, 3, 5, 2, 3, 5,3) << endl;

	cout << "fvarparm 1 параметров: "<<fvarparm(1.0, FLT_MAX) << endl;
	cout << "fvarparm 2 параметров: "<<fvarparm(2.0, 3.5, FLT_MAX) << endl;
	cout << "fvarparm 3 параметров: "<<fvarparm(3.0, 4.6, 6.7, FLT_MAX) << endl;
	cout <<"fvarparm 7 параметров: "<<fvarparm(7.0, 2.3, 3.6 , 4.6 , 7.3 ,8.4, 3.6, FLT_MAX) << endl;

	cout << dvarparm(3.04, 3.64, 5.89, DBL_MAX);

	cout << cdevl(a, b, c) << endl;
	cout << cstd(a, 2, 3) << endl;
	cout << cfst(1, 2, 3) << endl;

	cout << defaultparm(1, 2, 3, 4, 5);
}