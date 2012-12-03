#include <iostream>;
using namespace std;

void rotateStrLeft(char *str, int num)
{
	if (str == NULL )
	{
		return;
	}
	int length = strlen(str);
	if (num % length <= 0)
	{
		return;
	}

	int p1 = 0, p2 =num;
	int k = length - num - (length%num);
	char temp;
	while (k--)
	{
		temp = str[p1];
		str[p1]=str[p2];
		str[p2]=temp;
		p1++;
		p2++;
	}

	k= length-p2;
	int i =p2;
	while (k--)
	{
		while (i + 1 != p1)
		{
			temp = str[i];
			str[i]=str[i-1];
			str[i-1]=temp;
			i--;
		}
		i= ++p2;
	}

}
/*
int main()
{

	char str[] = "abcdefg";
	rotateStrLeft(str,3);
	cout<<str;
	getchar();
	return 0;
}
*/