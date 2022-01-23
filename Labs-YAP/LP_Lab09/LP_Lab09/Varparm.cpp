#include"Varparm.h"

namespace Varparm {
	int ivarparm(int n, ...)
	{
		int *rs = &n+1;
		int* p = &n + 2;
		for (int i = 1; i < n; i++, p++)
		{
			*rs *=  *p;
		}
		return *rs;
	}

	int svarparm(short n, ...)
	{
		short* rs = &n + 2;
		short* p = &n + 4;
		for (int i = 1; i < n; i++, p +=2)
		{
			*rs *=  *p;
		}
		return *rs;
	}

	double fvarparm(float n, ...)
	{
		double *p = (double*)(&n+1);
		double rs = n;
		for (int i = 0; i < n; i++, p++)
		{
			if(*p != FLT_MAX)
				rs += *p;
		}
		return rs;
	}

	double dvarparm(double n, ...)
	{
		double* p = &n + 1;
		double rs = n;
		for (int i = 0; i < n; i++, p++)
		{
			if (*p != DBL_MAX)
				rs += *p;
		}
		return rs;
	}
}