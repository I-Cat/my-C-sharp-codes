// Lab7Ex_4.cpp : Defines the entry point for the console application.
//


#include "stdafx.h"
#include <iostream>
using namespace std;
const int MAX = 100;
class postfix
{
private:

	int stack[MAX];
	int top, nn;
	char *s;
public:
	postfix();
	void setexpr(char *str);
	void push(int item);
	int pop();
	void calculate();
	void show();
};
postfix::postfix()
{
	top = -1;
}
void postfix::setexpr(char *str)
{
	s = str;
}
void postfix::push(int item)
{
	if (top == MAX - 1)
		cout << endl << "Stack is full";
	else
	{
		top++;
		stack[top] = item;
	}
}
int postfix::pop()
{
	if (top == -1)
	{
		cout << endl << "Stack is empty";
		return NULL;
	}
	int data = stack[top];
	top--;
	return data;
}
void postfix::calculate()
{
	int n1, n2, n3;
	while (*s)
	{
		if (*s == ' ' || *s == '\t')
		{
			s++;
			continue;
		}
		if (isdigit(*s))
		{
			nn = *s - '0';
			push(nn);
		}
		else
		{
			n1 = pop();
			n2 = pop();
			switch (*s)
			{
			case '+':
				n3 = n2 + n1;
				break;
			case '-':
				n3 = n2 - n1;
				break;
			case '/':
				n3 = n2 / n1;
				break;
			case '*':
				n3 = n2 * n1;
				break;
			case '%':
				n3 = n2 % n1;
				break;
			case '$':
				n3 = pow(n2, n1);
				break;
			default:
				cout << "Unknown operator";
				exit(1);
			}

			push(n3);
		}
		s++;
	}
}
void postfix::show()
{
	nn = pop();
	cout << "Result is: " << nn;
}


   //Ex 3 Decimal to binary

void CalulateBinary()
{
	Stack st;
	int number, remainder;
	char response;
	cout << "Enter a number\n";
	cin >> number;
	while (number != 0){
		remainder = number % 2;
		st.Push(remainder);
		number =number/ 2;     
	}
	while (!(st.IsEmpty()))
		cout << st.Pop();
	cout << endl;
}



void main()
{
	char expr[MAX];
	cout << "\nEnter postfix expression to be evaluated : ";
	cin.getline(expr, MAX);
	postfix q;
	q.setexpr(expr);
	q.calculate();
	q.show();
} 
