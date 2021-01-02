// PracticeSingleList.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>

using namespace std;

class node
{
private:
	int data;
	node *Next;
public:
	void SetData(int value)
	{
		data = value;
	}
	int GetData()
	{
		return data;
	}
	node* GetNext(){
		return Next;
	}
	void SetNext(node *ptr)
	{
		Next = ptr;
	}
};

//list class
class List
{
private:
	node *currentLocation;
public:
	List()
	{
		currentLocation = NULL;
	}
	//Insert Method
	void Insert(int data)
	{
		node *newNode = new node();
		newNode->SetData(data);
		newNode->SetNext(NULL);

		node *temp = currentLocation;
		//node exist alresdy
		if (temp != NULL)
		{
			while (temp->GetNext() != NULL)
			{
				temp = temp->GetNext();
			}
			temp->SetNext(newNode);
			
		}
		//first node
		else{

			currentLocation = newNode;
		}

	}

	void Print()
	{
		node *temp = currentLocation;
		if (temp == NULL){

			cout << "\nList is empty.\n" << endl;
		}
		else
		{
			do{
				{
					cout << temp->GetData()<<endl;
					temp = temp->GetNext();
				}
			} while (temp != NULL);
		}
	}

	//Sort method
	void Sort()
	{
		node *ptr = new node(); int value;
		node *tempNode = currentLocation;

		if (tempNode == NULL)
		{
			cout << "\nList IS empty.\n";
			system("Color 2B");
		}
		else 
		{
			while (tempNode != NULL)
			{
				for (ptr = tempNode->GetNext(); ptr != NULL; ptr = ptr->GetNext())
				{
					if (ptr->GetData() > tempNode->GetData())
					{
						value = tempNode->GetData();
						tempNode->SetData(ptr->GetData());
						ptr->SetData(value);
					}
				}
				tempNode = tempNode->GetNext();
			}
		}
	}

	//delete method

	void Delete(int value)
	{
		node *tempNode = currentLocation;
		if (tempNode == NULL)
		{
			cout << "\nList IS empty\n\n";
		}
		//only one Node
		else if (tempNode->GetNext() == NULL)
		{
			delete tempNode;
		}

		else{
			node *previous = new node();
			do{
				{
					if (tempNode->GetData() == value)
						break;
					previous = tempNode;
					tempNode = tempNode->GetNext();
				}

			} while (tempNode != NULL);
			previous->SetNext(tempNode->GetNext());
			delete tempNode;
			tempNode = NULL;
		}
		cout << "Value Deleted...\n\n";
	}

	//Insrt At specific Location
	void Insert_POS(int value)
	{
		node *newNode = new node();
		node *temp = currentLocation;
		node *s = new node();
		int counter = 0;
		int position;
		newNode->SetData(value);
		newNode->SetNext(NULL);

		if (temp == NULL){
			cout << "\nList is empty Element will be inserted at first position\n\n";
		}

			while (temp != NULL)
			{
				temp = temp->GetNext();
				counter++;

			}
			cout << "Enter POsition";
			cin >> position;
			if (position == 1)
			{
				if (currentLocation == NULL)
				{
					currentLocation = newNode;
				//	currentLocation->SetNext(NULL);

				}
				else
				{
					s = currentLocation; 
					currentLocation = newNode;
					currentLocation->SetNext(s);
				}
			}
			else if (position > 1 && position < counter)
			{
				temp = currentLocation; 
				for (int i = 1; i < position; i++)
				{
					s = temp;
					temp = temp->GetNext();
				}
				s->SetNext(newNode);
				newNode->SetNext(temp);
			}
			else
				cout << "Postion Out of Range...\n\n";
	}

	//Update
	void update(){

		node *temp = currentLocation;
		node *ptr = new node;
		int oldvalue, newValue;
		if (temp == NULL)
			cout << "List is emty\n\n";
		else{
			cout << "Enter value to update :";
			cin >> oldvalue;
			cout << "Enter new value ";
			cin >> newValue;

			for (ptr = temp; ptr != NULL; ptr = ptr->GetNext()){

				if (oldvalue == ptr->GetData())
				{
					ptr->SetData(newValue);
					cout << "\nValue Updated...\n";
				}

			}
		}
	}

	//maximum
	void maximum()
	{
		node *temp = currentLocation;
		node *ptr = new node;
		int value = temp->GetData();
		for (ptr = temp; ptr != NULL; ptr = ptr->GetNext())
		{
			if (value < ptr->GetData())
			{
				value = ptr->GetData();
			}
		}
		cout << "Maximum is >>> " << value;
	}
};


int _tmain(int argc, _TCHAR* argv[])
{

	List li;
	int choice, value;
	do
	{
		cout << " 1 for INSERT Node" << endl;
		cout << " 2 for DISPLAY Nodes" << endl;
		cout << " 3 for DELETE Nodes" << endl;
		cout << " 4 for SORT Nodes" << endl;
		cout << " 5 for Find MINIMUM Value" << endl;
		cout << " 6 for Find MAXIMUM Value" << endl;
		cout << " 7 for SEARCH Value" << endl;
		cout << " 8 for INSERT At given Position" << endl;
		cout << " 9 for UPdate Node" << endl << "\n";
		cout << "Enter Your Choice :";
		cin>> choice;
		switch (choice)
		{
		case 1:
			cout << "Enter Value to be Inserted : ";
			cin >> value;
			li.Insert(value);
			break;
		case 2:
			li.Print();
			break;
		case 3:
			cout << "Enter Value to be Deleted : ";
			cin >> value;
			li.Delete(value);
			break;
		case 4:
			li.Sort();
			break;
		/*case 5:
			li.minimum();
			break;*/
		case 6:
			li.maximum();
			break;
		/*case 7:
			li.search();
			break;*/
		case 8:
			cout << "Enter Value to be Inserted : ";
			cin >> value;
			li.Insert_POS(value);
			break;
		case 9:
			li.update();
			break;
		default:
			cout << "Invalid Choice..." << endl;
			break;
		}

	} while (1);
	return 0;
}

