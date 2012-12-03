//Using recursive stack as tree
int Count(int x)
{
	if (x<=3)
	{
		return 1;
	}

	return Count(x-2)+Count(x-4)+1;
}