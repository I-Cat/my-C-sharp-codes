// ClassesComplete.cpp : Defines the entry point for the console application.
//
#include "stdafx.h"
#include <iostream>
#include <string>
using namespace std;

class Student
{
public:
	Student();
	Student(string n, string r)
	{
		name = n;
		rNO = r;
	}
	~Student();
	

	void Display()
	{
		cout << name << endl;
		cout << rNO << endl;
	}

	void SetName(string _name)
	{
		name = _name;
	}
	void SetRoll(string roll)
	{
		rNO = roll;
	}

	string Getname();
	string Getroll();
private:
	string name;
	string rNO;
};

string Student::Getname()
{
	return name;
}
string Student::Getroll()
{
	return rNO;
}

Student::Student()
{
	
}

Student::~Student()
{
	cout << "Destructor Called..."<<endl;

}
int _tmain(int argc, _TCHAR* argv[])
{
	//Student std;
	string nameV, rollV;
	cout << "Enter Name:\n";
	cin >> nameV;
	cout << "Enter Name:\n";
	cin >> rollV;

	Student std(nameV,rollV);
	std.SetName(nameV);
	std.SetRoll(rollV);
	
	//
	std.Display();

	//////

	cout << "By Getter Setters\n";
	cout << std.Getname()<<endl;
	cout << std.Getroll()<<endl;

	return 0;
}

