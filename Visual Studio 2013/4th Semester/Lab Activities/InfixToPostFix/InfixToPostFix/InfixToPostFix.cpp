// InfixToPostFix.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include<iostream>
#include<cstring>
#include<stack>
using namespace std;

//Function to get the presedence of operaters
int getWeight(char ch) {
	switch (ch) {
	case '/':
	case '*':
		return 2;
	case '+':
	case '-':
		return 1;
	default:
		return 0;
	}
}

void infixTopostfix(char infix[], char postfix[], int size) {
	stack<char> s;
	int weight;
	int i = 0;
	int k = 0;
	char ch;
	while (i < size) {
		ch = infix[i];
		if (ch == '(') {
			s.push(ch);
			i++;
			continue;
		}
		if (ch == ')') {
			
			while (!s.empty() && s.top() != '(') {
				postfix[k++] = s.top();
				s.pop();

			}
			if (!s.empty()) {
				s.pop();
			}
			i++;
			continue;
		}
		weight = getWeight(ch);
		if (weight == 0) {
			
			postfix[k++] = ch;

		}
		else {
			if (s.empty()) {
				
				s.push(ch);
			}
			else {
				
				while (!s.empty() && s.top() != '(' &&	weight <= getWeight(s.top())) 
				{
					postfix[k++] = s.top();
					s.pop();

				}
				s.push(ch);
			}
		}
		i++;
	}
	
	while (!s.empty()) 
	{
		postfix[k++] = s.top();
		s.pop();
	}
}

int _tmain(int argc, _TCHAR* argv[])
{
	char infix[100];
	cout << "\nENter Infix Operation:";
	cin >> infix;
   const int size = strlen(infix);
	char postfix[100];
	infixTopostfix(infix, postfix, size);
	cout << "\nInfix Expression :: " << infix;
	cout << "\nPostfix Expression :: " << postfix;
	cout << endl;
	
	return 0;
}

