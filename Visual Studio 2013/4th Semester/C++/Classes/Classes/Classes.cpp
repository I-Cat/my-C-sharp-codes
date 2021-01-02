// Classes.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include<iostream>
#include<string>
using namespace std;


class Animal
{
private:
	int Amount;
	string type;

public:
	int id;
	void Print()
	{
		cout << id<<endl;
		//cout <<"GetAmount\t"<<GetAmount();
		
	}
	int SETAmount(int a)
	{
		Amount = a;
		return Amount;
	}

	void GetAmount(){
		
		cout << "Amount \t" <<Amount;

	}
	string SetType(string b){
		type = b;
		return type;
	}
};


int _tmain(int argc, _TCHAR* argv[])
{
	
	Animal Lion;
	Lion.id = 12;
	Lion.Print();
	cout<<"Amount: "<<Lion.SETAmount(1200)<<endl;
	cout << "Type: " << Lion.SetType("XYZ") << endl;

	return 0;

	
}

