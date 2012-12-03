#include <iostream>
using namespace std;
//
//void changeValue(int *a)
//{
//	*a = 2;
//}
//
//void changeString(char* str)
//{
//
//
//	str ="x";
//
//	int x =1;
//
//	//*str = 'x';
//}
//
//void changeString(char** str)
//{
//
//
//	*str ="x";
//
//}
//
//
//char * s="Good";
////char s[] ="Good";
//struct S
//{
//	int i;
//	int * p;
//};


void swap(int* p , int* q)
{
	//int* temp;
	//*temp = *p;
	//*p=*q;
	//*q=*temp;
	int temp;
	temp = *p;
	*p = *q;
	*q =temp;
}

//void swap(int* p , int* q)
//{
//	int* temp;
//	temp = p;
//	p=q;
//	q=temp;
//}

//void swap(int& p , int& q)
//{
//	int temp;
//	temp = p;
//	p=q;
//	q=temp;
//}
//
//int a =1 , b =2;

int max(int x, int y)
{
	return x>y?x:y;
}
/*
int main(){

	char* pp[] = {"A","P","D"};
	char** p =pp;


	//int arr[]= {1,2,3,4,5};
	//int * ptr =(int *)(&arr+1);

	//int max(int,int);
	//int (*p)(int, int) = &max;
	//
	//int a =1, b=2;
	//p(1,2);

	//swap(&a,&b);

	//swap(a,b);
/*
	changeString(&s);*/

	//int arr[3];
	//arr[0]=1;
	//arr[1]=2;
	//arr[2]=3;
	//int * p , * q;
	//p=arr;
	//q=&arr[2];


	//S s;
	//int * p =&s.i;
	//p[0]=4;
	//p[1]=3;
	//s.p=p;
	//s.p[0]=1;
	//s.p[1]=2;


	/*int a = 1;
	int *p = &a;
	cout<<*p<<endl;
	changeValue(p);
	changeValue(&a);
	cout<<*p<<endl;
	int *pt;
	pt = 0;
	cout<<*pt;*/
//	getchar();
//	return 0;
//}
//*/