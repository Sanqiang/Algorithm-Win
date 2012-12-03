#include <iostream>
using namespace std;

class String
{
public:
	String(const char *str = NULL);
	~String();

	String(const String &other);
	String & operator = (const String &other);
private:
	char *m_data;
};

String::String(const char *str)
{
	if (str == NULL)
	{
		m_data=new char[1];
		*m_data = '\0';
	}else
	{
		int len = strlen(str);
		m_data = new char[len];
		strcpy(m_data,str);
	}
}

String::~String()
{
	delete [] m_data;
}

String::String(const String &other)
{
	int len = strlen(other.m_data);
	m_data = new char[len+1];
	strcpy(m_data,other.m_data);
}

String & String::operator=(const String &other)
{
	if (this == &other)
	{
		return *this;
	}else
	{
		delete [] m_data;
		int len = strlen(other.m_data);
		m_data = new char[len+1];
		strcpy(m_data,other.m_data);
		return *this;
	}
}