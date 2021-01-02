// UN.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include<iostream>
#include<cstdio>
#include<cstdlib>
//Node decleration
using namespace std;
class node
{
private:
	int info;
	node *next;
	node *prev;
public:
	void SetData(int data)
	{
		info = data;
	}

	int GetData()
	{
		return info;
	}

	void SetNext(node *Next)
	{
		next = Next;
	}
	node* GetNext()
	{
		return next;
	}
	void SetPrev(node *pre)
	{
		prev = pre;
	}
	node* Getprev()
	{
		return prev;
	}
};


class double_list
{
private:
	node *start;
public:
	void create_list(int value);
	void add_begin(int value);
	void add_after(int value, int position);
	void delete_element(int value);
	void search_element(int value);
	void display_dlist();
	void count();
	void reverse();
	double_list()
	{
		start = NULL;
	}
};
//Main
int main()
{
	int choice, element, position;
	double_list dl;
	while (1)
	{
		cout << endl << "---------------" << endl;
		cout << endl << "operations on doubly linked list" << endl;
		cout << endl << "--------------" << endl;
		cout << "1.create node" << endl;
		cout << "2.add at begning" << endl;
		cout << "3.add after position" << endl;
		cout << "4.delete" << endl;
		cout << "5.display" << endl;
		cout << "6.count" << endl;
		cout << "7.reverse" << endl;
		cout << "8.quit" << endl;
		cout << "enter your choice:";
		cin >> choice;
		switch (choice)
		{
		case 1:
			cout << "enter the element";
			cin >> element;
			dl.create_list(element);
			cout << endl;
			break;
		case 2:
			cout << "enter the element";
			cin >> element;
			dl.add_begin(element);
			cout << endl;
			break;
		case 3:
			cout << "enter the element";
			cin >> element;
			cout << "enter the position";
			cin >> position;
			dl.add_after(element, position);
			cout << endl;
			break;
		case 4:
			if (start == NULL)
			{
				cout << "list empty" << endl;
				break;
			}
			cout << "enter the element for deletion";
			cin >> element;
			dl.delete_element(element);
			cout << endl;
			break;
		case 5:
			dl.display_dlist();
			cout << endl;
			break;
		case 6:
			dl.count();
			break;
		case 7:
			if (start == NULL)
			{
				cout << "list is empty" << endl;
				break;
			}
			dl.reverse();
			cout << endl;
			break;
		case 8:
			exit(1);
		default:
			cout << "wrong choice";
		}
	}
	return 0;
}
//create double list
void double_list::create_list(int value)
{
	struct node*s, *temp;
	temp = new node;
	temp->info = value;
	temp->next = NULL;
	if (start == NULL)
	{
		temp->prev = NULL;
		start = temp;
	}
	else
	{
		s = start;
		while (s->next != NULL)
			s = s->next;
		s->next = temp;
		temp->prev = s;
	}
}
//insertion at begining
void double_list::add_begin(int value)
{
	if (start == NULL)
	{
		cout << "first create list" << endl;
		return;
	}
	struct node*temp;
	temp = new(struct node);
	temp->prev = NULL;
	temp->info = value;
	temp->next = start;
	start->prev = temp;
	start = temp;
	cout << "element inserted" << endl;
}
// insertion at partiular position
void double_list::add_after(int value, int position)
{
	if (start == NULL)
	{
		cout << "first create the list" << endl;
		return;
	}
	struct node*tmp, *q;
	int i;
	q = start;
	for (i = 0; i<position - 1; i++)
	{
		q = q->next;
		if (q == NULL)
		{
			cout << "there are less then";
			cout << position << "element" << endl;
			//return 0;
		}
	}
	tmp = new(struct node);
		tmp->info = value;
	if (q->next == NULL)
	{
		q->next = tmp;
		tmp->next = NULL;
		tmp->prev = q;
	}
	else
	{
		tmp->next = q->next;
		tmp->next->prev = tmp;
		q->next = tmp;
		tmp->prev = q;
	}
	cout << "element inserted" << endl;
}
// deletion of element
void double_list::delete_element(int value)
{
	struct node*tmp, *q;
	//firt element deletion
	if (start->info == value)
	{
		tmp = start;
		start = start->next;
		start->prev = NULL;
		cout << "element deleted" << endl;
		free(tmp);
		return;
	}
	q = start;
	while (q->next->next != NULL)
	{
		//element deleted in between
		if (q->next->info == value)
		{
			tmp = q->next;
			q->next = tmp->next;
			tmp->next->prev = q;
			cout << "element deleted" << endl;
			free(tmp);
			return;
		}
		q = q->next;
	}
	// last element deleted
	if (q->next->info == value)
	{
		tmp = q->next;
		free(tmp);
		q->next = NULL;
		cout << "element deleted" << endl;
		//return 0;
	}
	cout << "element not found" << endl;
}
//display elements
void double_list::display_dlist()
{
	struct node*q;
	if (start == NULL)
	{
		cout << "list empty" << endl;
		return;
	}
	q = start;
	cout << "the dll is" << endl;
	while (q != NULL)
	{
		cout << q->info << "<->";
		q = q->next;
	}
	cout <<  "null" << endl;
}
// no of elements in ddl
void double_list::count()
{
	struct node*q = start;
	int cnt = 0;
	while (q != NULL)
	{
		q = q->next;
		cnt++;
	}
	cout << "no of elements are:" << cnt << endl;
}
// revrese list
void double_list::reverse()
{
	struct node*p1, *p2;
	p1 = start;
	p2 = p1->next;
	p1->prev = p2;
	while (p2 != NULL)
	{
		p2->prev = p2->next;
		p2->next = p1;
		p1 = p2;
		p2 = p2->prev;
	}
	start = p1;
	cout << "list reversed" << endl;
}