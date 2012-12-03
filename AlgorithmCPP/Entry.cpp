#include <iostream>;
#include <typeinfo>
using namespace std;
#include "treasure.h";

class base
{
public:
	long b;
	virtual void funcA()
	{
		cout<<"base"<<endl;
	}
};

class derive:public base
{
public:
	long t;

	void operator++(int)
	{
		t+10;
	}

	virtual void funcB()
	{
		cout<<"derive"<<endl;
	}
};

class derive2:private base
{
public:
	
protected:
private:
};

class derive3:protected base	
{
	
};

void funcC(base * p)
{
	derive * dp = dynamic_cast<derive*>(p);
	if (dp != NULL)
	{
		dp->funcB();
	}else
	{
		p->funcA();
	}
}

void funcD(base * p)
{
	derive * dp = NULL;
	if (typeid(*p) == typeid(derive))
	{
		dp = static_cast<derive*>(p);
		dp->funcB();
	}else
	{
		p->funcA();
	}
}

int main()
{
	base *cp = new derive();
	cout<<typeid(cp).name()<<endl;
	cout<<typeid(*cp).name()<<endl;
	
	int x =1;
	cout<<typeid(x).name()<<endl;
	funcD(cp);
	funcC(cp);
	base * dp = new base;
	cout<<typeid(dp).name()<<endl;
	cout<<typeid(*dp).name()<<endl;
	funcD(dp);
	funcC(dp);

	derive * dpx = NULL;
	dpx = static_cast<derive*>(dp);

	//connectSequence("abdbcc","abc");
	//cout<<getFinRecursive(3,4);
	//cout<<getFinIterate(3,4);
	//printJPEG();

	getchar();
	return 0;
}