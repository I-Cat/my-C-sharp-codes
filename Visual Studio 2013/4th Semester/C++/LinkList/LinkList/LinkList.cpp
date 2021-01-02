// LinkList.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
using namespace std;

struct Node
{
	int info;
	Node *next;

}*start;

//class Delation

class Single_List
{
public:
	Node* Create_node(int);
	void insert_begin();
	void insert_pos();
	void insert_last();
	void delete_pos();
	void sort();
	void search();
	void Update();
	void Reverse();
	void Display();

	Single_List()
	{
		start = NULL;
	}

};


int _tmain(int argc, _TCHAR* argv[])
{
	int choice,nodes,element,position,i;
	Single_List sl;
	start = NULL;
	while (1)
	{
		cout << endl << "------------------------" << endl;
		cout << endl << "Operations on Singly Linkes List" << endl;
		cout << endl << "------------------------" << endl;
		cout << endl << "1.Insert Node At Begining " << endl;
		cout << endl << "2.Insert Node At Last " << endl;
		cout << endl << "3.Insert Node At position " << endl;
		cout << endl << "4.Sort Link List " << endl;
		cout << endl << "5.Delete A prticular Node " << endl;
		cout << endl << "6.update A prticular Node " << endl;
		cout << endl << "7.Search Element " << endl;
		cout << endl << "8 Display List " << endl;
		cout << endl << "9.Reverse Linked List " << endl;
		cout << endl << "10.Exit " << endl;
		cout << endl << "Enter Choice: " << endl;
		cin >> choice;

		switch (choice)
		{
		case 1:
			cout << "inserting Node at Begining"<<endl;
			sl.insert_begin();
			cout << endl;
			break;
		case 2:
			cout << "inserting Node at last" << endl;
			sl.insert_last();
			cout << endl;
			break;
		case 3:
			cout << endl << "Inserting Node At position " << endl;
			sl.insert_pos();
			cout << endl;
			break;
		case 4:
			cout << "Sort";
			sl.sort();
			cout << endl;
			break;
		case 5:
			cout << "Delet A particular node ";
			sl.delete_pos();
			cout << endl;
			break;
		case 6:
			cout << "Update Node VAlue:"<<endl;
			sl.Update();
			cout << endl;
			break;
		case 7:
			cout << "Searching element in List:" << endl;
			sl.search();
			cout << endl;
			break;

		case 8:
			cout << "Display element in List:" << endl;
			sl.Display();
			cout << endl;
			break;

		case 9:
			sl.Reverse();
			cout << endl;
		case 10:
			exit(1);
			break;
		default :
			cout << "Wrong Choice" << endl;

		}

	}

	return 0;
}

Node *Single_List::Create_node(int value);