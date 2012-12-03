#include <iostream>
#include <vector>
using namespace std;

//VECTOR USING
void vectorSample()
{
	vector<char> vchar;
	vchar.push_back('a');
	vchar.push_back('b');
	vchar.push_back('c');

	vector<char>::iterator i;
	i = vchar.begin();

	for (;i != vchar.end();i++)
	{
		cout<<*(i)<<" ";
	}
	
	//remove(vchar.begin(),vchar.end(),'a');
}

template<typename T>
const T* find(T* array, T n, T x)
{
	const T* p= array;
	int i;
	for (int i = 0; i < n; ++i)
	{
		if (x==*p)
		{
			return p;
		}
		p++;
	}
}

//delegater == function pointer
int add(int a, int b){return a+b;}
int minus(int a, int b){return a-b;}

void operate(int (*p)(int,int), int a, int b)
{
	cout<<p(a,b);
}

void operate()
{
	operate(add,1,2);
}
