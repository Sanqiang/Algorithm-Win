#include <iostream>
using namespace std;

#define max(a,b) ((a)<(b)?(b):(a))
#define abs(a) ((a)>=0?(a):-(a))

int foo(int x, int y)
{
	int t = max(x, y);
	int u = t+t;
	int v = u-1;
	v=v*v+u;
	if(x == -t)
	{
		v+=u+t-y;
	}else if(y==-t)
	{
		v+=3*u+x-t;
	}else if(y==t)
	{
		v+=t-x;
	}else
	{
		v+=y-t;
	}
	return v;
}