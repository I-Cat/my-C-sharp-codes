#include "stdafx.h";

#include<iostream>
#include<cstdlib>


class Node
{
public:
	int data;
	Node* next;

};

using namespace std;

class LinkedList
{
public:
	int length;
	Node* head;

	void Delete(int del);
	LinkedList();
	~LinkedList();
	void add(int data);
	void print();
};

LinkedList::LinkedList(){
	this->length = 0;
	this->head = NULL;
}

LinkedList::~LinkedList(){
	std::cout << "LIST DELETED";
}

void LinkedList::add(int data){
	Node* node = new Node();
	node->data = data;
	node->next = this->head;
	this->head = node;
	//this->length++;
}


void LinkedList::print(){
	Node* head = this->head;
	int i = 1;
	while (head != NULL){
		std::cout << i << ": " << head->data << std::endl;
		head = head->next;
		i++;
	}
}
void LinkedList::Delete(int del)
{
	Node *node = new Node();
	//do
	//{
		if (node->data == del)
			delete node;
			//break;
		/*}
		node++;
	} 
	while (node->next != NULL)*/

}
int main(int argc, char const *argv[])
{
	LinkedList* list = new LinkedList();
	/*for (int i = 0; i < 100; i++)
	{
		list->add(rand() % 10);
	}*/

	list->add(23);
	list->add(56);
	list->add(586);
	list->print();

	list->Delete(586);
	list->print();
	std::cout << "List Length: " << list->length << std::endl;
	delete list;
	return 0;
}