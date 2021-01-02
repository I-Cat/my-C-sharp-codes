#include "stdafx.h"
#include<iostream>
using namespace std;
#define pi 3.1415926 ;

class node
{
private:
	int Data;
	node* Next;
public:
	node();
	int getData();
	node* getNext();

	void setData(int);
	void setNext(node*);
};
node::node()
{

}
int node::getData()
{
	return Data;
}

node* node::getNext()
{
	return Next;
}
void node::setData(int Data)
{
	this->Data = Data;
}
void node::setNext(node* Next)
{
	this->Next = Next;
}
class List
{
private:
	node *currentLocation;
public:
	List()
	{
		currentLocation = NULL;
	}
	void Print();
	void Insert(int);
	void Delete(int);
	void Sort();
	void minimum();
	void maximum();
	void search();
	void Insert_POS(int);
	void update();
};



void List::Insert(int data)
{
	// Create a new Node
	node* newNode = new node();
	newNode->setData(data);
	newNode->setNext(NULL);
	// Create temp Node.
	node* tempNode = currentLocation;

	if (tempNode != NULL)
	{
		//after first node inserted new node
		while (tempNode->getNext() != NULL)
		{
			tempNode = tempNode->getNext();
		}
		tempNode->setNext(newNode);
	}
	else
	{
		//insert first in the list
		currentLocation = newNode;

	}

}


void List::Insert_POS(int data)
{
	// Create a new Node
	node* newNode = new node();
	// Create temp Node.
	node* tempNode = currentLocation;
	node *s = new node();
	int counter = 0;
	int position;
	newNode->setData(data);
	newNode->setNext(NULL);

	if (tempNode == NULL)
	{
		cout << "List is Empty Insert at FIRST Position..." << endl;
	}
	while (tempNode != NULL)
	{
		tempNode = tempNode->getNext();
		counter++;
	}
	cout << "Enter Position : ";
	cin >> position;
	if (position == 1)
	{
		if (currentLocation == NULL)
		{
			currentLocation = newNode;
			currentLocation->setNext(NULL);
		}
		else
		{
			s = currentLocation;
			currentLocation = newNode;
			currentLocation->setNext(s);
		}
	}
	else if (position > 1 && position < counter)
	{
		tempNode = currentLocation;
		for (int i = 1; i < position; i++)
		{
			s = tempNode;
			tempNode = tempNode->getNext();
		}
		s->setNext(newNode);
		newNode->setNext(tempNode);

	}
	else
	{
		cout << "Position Out of Range..." << endl;
	}


}

void List::Print()
{
	//cretae temp node
	node *tempNode = currentLocation;
	int i = 1;
	if (tempNode == NULL)
	{
		cout << "List is Empty..." << endl;
		return;
	}
	if (tempNode->getNext() == NULL)
	{
		cout << i << "\t--->\t" << tempNode->getData() << endl;
		cout << "NULL" << endl;
	}
	else
	{
		do
		{
			cout << i << "\t--->\t" << tempNode->getData() << endl << endl;
			tempNode = tempNode->getNext();
			i++;
		} while (tempNode != NULL);
		cout << "NULL" << endl;
	}
}

void List::Delete(int data)
{
	//create temp node
	node *tempNode = currentLocation;
	//case 1
	if (tempNode == NULL)
	{
		return;
	}
	//case 2
	if (tempNode->getNext() == NULL)
	{
		delete tempNode;
		currentLocation = NULL;
	}
	//case 3
	else
	{
		node *privious = new node;
		do
		{
			if (tempNode->getData() == data)
			{
				break;
			}
			privious = tempNode;
			tempNode = tempNode->getNext();

		} while (tempNode != NULL);
		privious->setNext(tempNode->getNext());
		delete tempNode;
		tempNode = NULL;
	}
	cout << "Value Deleted..." << endl;
}

void List::Sort()
{
	node *temp, *ptr = new node();
	int value;
	temp = currentLocation;
	if (temp == NULL)
	{
		cout << "List is Empty...";
	}
	while (temp != NULL)
	{
		for (ptr = temp->getNext(); ptr != NULL; ptr = ptr->getNext())
		{
			if (temp->getData() > ptr->getData())
			{
				value = temp->getData();
				temp->setData(ptr->getData());
				ptr->setData(value);
			}
		}
		temp = temp->getNext();

	}
	cout << "List Sorted..." << endl;
}

void List::minimum()
{
	node *temp, *ptr = new node();
	int value;
	temp = currentLocation;
	if (temp == NULL)
	{
		cout << "List is Empty...";
	}
	value = temp->getData();
	for (ptr = temp->getNext(); ptr != NULL; ptr = ptr->getNext())
	{
		if (value > ptr->getData())
		{
			value = ptr->getData();
		}
	}
	cout << "Minimum Value is : " << value << endl;
}

void List::maximum()
{
	node *temp, *ptr = new node();
	int value;
	temp = currentLocation;
	if (temp == NULL)
	{
		cout << "List is Empty...";
	}
	value = temp->getData();
	for (ptr = temp->getNext(); ptr != NULL; ptr = ptr->getNext())
	{
		if (value < ptr->getData())
		{
			value = ptr->getData();
		}
	}
	cout << "Maximum Value is : " << value << endl;
}


void List::search()
{
	node *temp, *ptr = new node();
	int value;
	temp = currentLocation;
	if (temp == NULL)
	{
		cout << "List is Empty...";
	}
	cout << "Enter Value for Search : ";
	cin >> value;
	for (ptr = temp->getNext(); ptr != NULL; ptr = ptr->getNext())
	{
		if (value == ptr->getData())
		{
			cout << "Value Found Wich is :" << value << endl;
			return;
		}
	}
	cout << "Value NOT Found..." << endl;
}


void List::update()
{

	node *temp, *ptr = new node();
	int value;
	int num;
	bool flage = false;
	temp = currentLocation;
	if (temp == NULL)
	{
		cout << "List is Empty...";
	}
	cout << "Enter Value to be Update : ";
	cin >> value;
	cout << "New Value : ";
	cin >> num;
	//for (ptr = temp->getNext(); ptr != NULL; ptr = ptr->getNext())
	while (temp!=NULL)
	{
		if (value == temp->getData())
		{
			flage = true;
			temp->setData(num);
			cout << "Value is Updated..." << endl;
		}
		temp = temp->getNext();
	}
	if (!flage)
	{
		cout << "Value is not in the list..." << endl;
	}
}



int _tmain(int argc, _TCHAR* argv[])
{
	cout << pi;

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
		cin >> choice;
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
		case 5:
			li.minimum();
			break;
		case 6:
			li.maximum();
			break;
		case 7:
			li.search();
			break;
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


