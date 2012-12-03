#include <iostream>
using namespace std;

bool match(int a[], int b[], int len)
{
	int count = len;
	int i =0;
	while (i<=len-1)
	{
		int j =0;
		while (j<=len-1)
		{
			if (a[i] == b[j])
			{
				cout<<"a["<<i<<"]"<<" match "<<"b["<<j<<"]";
				len--;
				break;
			}
			j++;
		}
		i++;
	}
	return count == 0;
}