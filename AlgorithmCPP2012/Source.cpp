#include <cstring>

void rotateStr(char *str, int num, bool left)
{
	char *FirstStart, *FirstEnd,*SecondStart,*SecondEnd;
	int length = strlen(str);
	if (left)
	{
		FirstStart=str + (length-num);
		FirstEnd = str+length-1;
		SecondStart=str;
		SecondEnd=str+length-1;
	}
	else
	{
		FirstStart= str+num;
		FirstEnd=str+length-1;
		SecondStart=str;
		SecondEnd=FirstStart-1;
	}
}