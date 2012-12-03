#include <iostream>
using namespace std;

int getFinRecursive(int m, int n)
{
	if (1==m)
	{
		return n;
	}
	if (1==n)
	{
		return m;
	}
	return getFinRecursive(m-1,n)+getFinRecursive(m,n-1);
}

int getFinIterate(int m, int n)
{
	int ** matrix = (int **)malloc(sizeof(int)*m);
	for (int i = 0; i < m; i++)
	{
		int * row = (int *)malloc(sizeof(int)*n);
		* (matrix+i) = & * row;
	}



	for (int i = 0; i < m; i++)
	{
		//**(matrix+i*sizeof(int)) = i;
		matrix[i][0] = i+1;
	}
	for (int i = 0; i < n; i++)
	{
		//**(matrix+i) = i;
		matrix[0][i]=i+1;
	}
	for (int i = 1; i < m; i++)
	{
		for (int j = 1; j < n; j++)
		{
			//**(matrix+sizeof(int)*i+j) = **(matrix+sizeof(int)*i+(j-1)) + **(matrix+sizeof(int)*(i-1)+j);
			matrix[i][j] = matrix[i-1][j]+matrix[i][j-1];
		}
	}

	return matrix[m-1][n-1];//**(matrix+sizeof(int)*(m-1)+n-1);
	//return **(matrix+(m-1)+n-1);
}