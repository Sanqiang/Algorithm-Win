#include <iostream>
using namespace std;

int getGCD(int l, int s)
{
	if (l<s)
	{
		int t = l;
		l=s;
		s=t;
	}
	int n;
	while (1)
	{
		n = l % s;
		if (n == 0)
		{
			break;
		}
		l = s;
		s = n;
	}
	return s;
}

void rotateLeftStr(string &str, int num)
{
	int LengthOfStr = str.length();
	int NumOfGroup = getGCD(LengthOfStr,num);
	int EleInSub = LengthOfStr/NumOfGroup;
	for (int j = 0; j < NumOfGroup; j++)
	{
		char tmp = str[j];
		int i ;
		for (i = 0; i < EleInSub-1; i++)
		{
			str[(j+i*num) % LengthOfStr] = str[(j+(i+1)*num) % LengthOfStr];
		}
		str[(j+i*num) % LengthOfStr]=tmp;
	}

}

void rotateLeftStr2(string &str, int num)
{

}
/*
int main()
{
	string str = "abcdefghi";
	rotateLeftStr(str,4);
	cout<<str.data();
	//cout<<getGCD(100,70);
	getchar();
	return 0;
}
*/