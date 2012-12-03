#include "Entity.cpp"
using namespace std;

void insertNode(LinkedNode **head, double val)
{
	LinkedNode *NewNode = new LinkedNode(val);
	NewNode->Next=*head;
	*head = NewNode;
}

void deleteNode(LinkedNode **head, double val)
{
	LinkedNode *loop = *head;
	if(loop->Data == val)
	{
		*head = loop->Next;
		delete loop;
		return;
	}

	while(loop->Next != NULL)
	{
		LinkedNode* next = loop->Next;
		if(next->Data == val)
		{
			loop->Next = next->Next;
		}
		loop = next;
	}
}

void deleteAll(LinkedNode **head)
{
	LinkedNode *loop = *head;
	while(loop= NULL)
	{
		LinkedNode *next = loop->Next;
		delete loop;
		loop = next;
	}
}

void reverseLinkedList(LinkedNode **head)
{
	LinkedNode *last = NULL, *current = *head, *next = current->Next;
	while(next != NULL){
		current->Next=last;
		last = current;
		current=next;
		next = next->Next;
	}
	current->Next=last;
	*head =  current;
}
/*
int main()
{
	LinkedNode *ln1 = new LinkedNode(3);
	LinkedNode *ln2 = new LinkedNode(2);
	LinkedNode *ln3 = new LinkedNode(1);
	ln1->Next= ln2; ln2->Next=ln3;
	insertNode(&ln1,20);
	//deleteNode(&ln1,1);
	reverseLinkedList(&ln1);

	LinkedNode *loop = ln1;
	while(loop != NULL)
	{
		cout<<loop->Data<<"\r\n";
		loop = loop->Next; 
	}

	getchar();
	return 0;
}
*/

