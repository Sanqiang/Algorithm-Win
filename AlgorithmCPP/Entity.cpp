#include <iostream>

typedef struct LinkedNode
{
public:
	LinkedNode* Next;
	double Data;
	LinkedNode(double data)
	{
		this->Data=data;
		this->Next=NULL;
	}
};