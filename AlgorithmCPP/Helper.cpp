#include <iostream>
using namespace std;

#define FIND(obj,ele) (unsigned int)obj.ele
#define FIND2(obj,ele) (unsigned int)&(((obj*)0)->ele)
//&(((obj*)0)->ele)

const char nm = 'a';


class x
{
private:
	int val;
	mutable int c;
public:
	x(){}
	x(int val){
		this->val=val;
	}
	x(x &other){
		this->val=other.val;
	}

	void increment() const
	{
		c++;
	}
	virtual void xxx(){}
};
int external_val = 10;

#pragma pack(1)
struct stru
{
	int a;
	int b;
	int c;
	char d[6];
	char e;
}stru1;
#pragma pack()

void changeStr(char *str)
{
	*str = 'a';
	//*(str+1) ='\0';
	//str[0]='R';
}

void changeStr(char **str)
{
	//**str = 'F';
	*str = "S";
}

void changeVal(int *val)
{
	*val = 100; 
}
/*
int main()
{
	char str[] = "Good";
	//changeStr(str); //just copy of pointer, so change pointer value
	cout<<str<<endl;
	char *p = str;
	//*p = 'j';
	changeStr(&p);
	cout<<str<<endl;

	int val = 20;
	int *pp = &val;
	//changeVal(&val);
	changeVal(&*pp);
	cout<<val<<endl;

	char *word ="Amp";
	cout<<word<<endl;
	changeStr(&word);
	cout<<word<<endl;

	/* alignment and pack without alignment on memory
	cout<<sizeof(stru1);
	cout<<sizeof(char);*/

	/* const method cannot change member other than mutable member
	x* inst = new x(); 
	inst->increment();*/


	/* define use case
	stru1.a=10;
	int x = FIND(stru1,a);
	int y = FIND2(stru,a);
	int z = FIND2(stru,c);*/

	/* Mid
	int mid = (200&300) + ((200^300)>>1);*/
	/* not good in windows
	unsigned int i = 97;
	unsigned char c = (unsigned int)i;
	char* b = (char*)(&i);
	printf("%08x,%08x",i,*b);

	float f= 1.23f;
	cout<<(float&)f<<"\r\n";
	//cout<<(int&)f+"\r\n";*/

	/* priority assignment
	int external_val=external_val;
	cout<<external_val;*/

	/* new way to do construction and sizeof for abstract class
	cout<<sizeof(x);
	x inst = 10;
	x inst2 = inst;*//*
	getchar();
	return 0;
}
*/