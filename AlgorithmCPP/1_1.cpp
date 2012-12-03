#include <cstring>
#include <iostream>
using namespace std;

void swap(char *str, char *s, char *e);

void rotateStr(char *str, int num, bool left)
{
	char *FirstStart, *FirstEnd,*SecondStart,*SecondEnd;
	int length = strlen(str);
	num %= length;
	if (left)
	{
		FirstStart=str;
		FirstEnd=str+num-1;
		SecondStart=str+num;
		SecondEnd=str+length-1;
	}
	else
	{
		FirstStart=str;
		FirstEnd = str+length-num-1;
		SecondStart = str+length-num;
		SecondEnd=str+length-1;
	}
	swap(str,FirstStart,FirstEnd);
	swap(str,SecondStart,SecondEnd);
	swap(str,str,str+length-1);
	
}

void swap(char *str, char *s, char *e)
{
	if (str != NULL)
	{
		while (s < e)
		{
			char tmp = *s;
			*s=*e;
			*e= tmp;
			*s++;
			*e--;
		}
	}
}
/*
int main()
{
	char str[] = "abcdefg";
	cout<<str<<"\r\n";
	rotateStr(str,3,false);
	cout<<str<<"";

	getchar();
	return 0;
}
*/