#include <iostream>;
using namespace std;

void rotateStrLeft(char *str,int length, int num, int head, int tail, bool right)
{
	if (str == NULL || head ==tail || num<=0)
	{
		return;
	}
	if (right)
	{
		int p1 = head , p2=head + num, k = length-num-(length%num);

		for (int i = 0; i < k; i++)
		{
			char temp = str[p1];
			str[p1]=str[p2];
			str[p2]=temp;
			p1++;p2++;
		}
		rotateStrLeft(str,length - k,length%num,p1,tail,false);
	}else
	{
		int p1 = tail, p2 = tail - num, k = length - num -(length%num);

		for (int i = 0; i < k; i++)
		{
			char temp = str[p1];
			str[p1]=str[p2];
			str[p2]=temp;
			p1--;p2--;
		}
		rotateStrLeft(str,length - k,length%num,p1,tail,true);

	}
}
/*
int main()
{

	char str[] = "abcdefg";
	rotateStrLeft(str,strlen(str),3,0,strlen(str)-1,true);
	cout<<str;
	getchar();
	return 0;
}
*/