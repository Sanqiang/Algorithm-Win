#include <iostream>
using namespace std;

void printArray(char * longer, char * shorter, int longer_len, int shorter_len, int * solutions, int longer_index, int shorter_index, int solutions_index)
{
	if (solutions_index == shorter_len)
	{
		for (int i = 0; i < shorter_len; i++)
		{
			cout<<*(solutions+i)<<" ";
		}
		cout<<endl;
		return;
	}

	for (int i = longer_index; i < longer_len; i++)
	{
		for (int j = shorter_index; j < shorter_len; j++)
		{
			if (*(longer+i) == *(shorter+j))
			{
				*(solutions+solutions_index)=(i+1);
				longer_index = i;
				shorter_index = j;
				printArray(longer,shorter,longer_len,shorter_len,solutions,longer_index+1,shorter_index+1,solutions_index+1);
			}

		}
	}
}

void connectSequence(char * longer, char * shorter)
{
	if (longer == NULL || shorter == NULL)
	{
		cout<<"String ERROR"<<endl;
		return;
	}

	int longer_len=strlen(longer);
	int shorter_len=strlen(shorter);
	int * solutions = new int[shorter_len];

	if (solutions == NULL)
	{
		cout<<"Allocation ERROR"<<endl;
		return;
	}

	printArray(longer,shorter,longer_len,shorter_len,solutions,0,0,0);
}

