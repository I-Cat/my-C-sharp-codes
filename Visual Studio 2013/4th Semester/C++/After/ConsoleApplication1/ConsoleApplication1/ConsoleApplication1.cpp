// ConsoleApplication1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include<fstream>
#include<iostream>
#include<string>

using namespace std;

void ReadFile()
{
	string fileName = "Text.txt";
	ifstream input;

	input.open(fileName);
	string line;

	if (input){
		while (input){
			//input >> line;
			getline(input, line);
			cout << line << endl;

		}
		input.close();
	}
}
int _tmain(int argc, _TCHAR* argv[])
{

	ofstream outFile;
	outFile.open("Text.txt");
	if (outFile.is_open())
	{
		for (int index = 1; index < 10;index++)
		outFile << "Welcome Asif"<<endl;
		

		outFile.close();
	}
	else
	{
		cout << "File could not generated...";
	}

	ReadFile();
	return 0;
}

