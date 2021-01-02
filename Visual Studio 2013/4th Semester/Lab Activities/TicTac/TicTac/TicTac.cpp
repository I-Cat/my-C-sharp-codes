// TicTac.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"

#include<iostream>
#include<ctype.h>
using namespace std;
char game[10] = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
int r = 1, z = 1, d, u;

void draw(){

	if (game[1] != '1' && game[2] != '2' && game[3] != '3' && game[4] != '4' && game[5] != '5' && game[6] != '6' && game[7] != '7' && game[8] != '8' && game[9] != '9')
	{
		cout << "\adraw....";
		exit(1);
	}

}
int chk(){
	//char A;
	system("   color 2b");
	int g = 3;
	if (game[1] == 'X' & game[2] == 'X'& game[3] == 'X')
	{
		g = 3;
		return g;
	}
	else if (game[1] == 'X' & game[4] == 'X' & game[7] == 'X'){

		return g;
	}
	else if (game[1] == 'X' & game[5] == 'X' & game[9] == 'X'){

		return g;
	}
	else if (game[3] == 'X' & game[6] == 'X' &game[9] == 'X'){

		return g;
	}
	else if (game[3] == 'X' & game[5] == 'X' & game[7] == 'X'){

		return g;
	}
	else if (game[2] == 'X' & game[5] == 'X' & game[8] == 'X'){

		return g;
	}
	else if (game[7] == 'X' & game[8] == 'X' & game[9] == 'X'){

		return g;
	}
	else if (game[4] == 'X' & game[5] == 'X' & game[6] == 'X'){

		return g;
	}


}

int chk2(){

	system("color 3F");
	int f = 4;

	if (game[1] == 'Y'&&game[2] == 'Y'&&game[3] == 'Y'){
		f = 4;
		return f;
	}
	else if (game[1] == 'Y' & game[4] == 'Y' & game[7] == 'Y'){

		return f;
	}
	else if (game[1] == 'Y' & game[5] == 'Y' & game[9] == 'Y'){

		return f;
	}
	else if (game[3] == 'Y' & game[6] == 'Y' & game[9] == 'Y'){
		return f;
	}
	else if (game[3] == 'Y' & game[5] == 'Y' & game[7] == 'Y'){
		return f;
	}
	else if (game[2] == 'Y' & game[5] == 'Y' & game[8] == 'Y'){
		return f;
	}
	else if (game[7] == 'Y' & game[8] == 'Y' & game[9] == 'Y'){
		return f;
	}
	else if (game[4] == 'Y'& game[5] == 'Y' & game[6] == 'Y'){
		return f;
	}


}
void board()
{

	system("cls"); {
		system("color 1a");
		cout << "\t" "\n\n\tTic Tac Toe\n\n"; }
	cout << "\t" "Player 1 (X)  -  Player 2 (Y)" << endl << endl;
	cout << endl;
	cout << "\t" "     |     |     " << endl;
	cout << "\t" "  " << game[1] << "  |  " << game[2] << "  |  " << game[3] << endl;
	cout << "\t" "_____|_____|_____" << endl;
	cout << "\t""     |     |     " << endl;
	cout << "\t" "  " << game[4] << "  |  " << game[5] << "  |  " << game[6] << endl;
	cout << "\t" "_____|_____|_____" << endl;
	cout << "\t" "     |     |     " << endl;
	cout << "\t" "  " << game[7] << "  |  " << game[8] << "  |  " << game[9] << endl;
	cout << "\t" "     |     |     " << endl << endl;
}
void player1(){
	char a;
	cout << "Player 1 press any number from (1-9) " << endl << endl;
	cin >> a;
	for (int i = 0; i<10; i++){

		if (a == game[i]){

			game[i] = 'X';
			u++;
		}
		board();
		z = chk();
		if (z == 3){
			cout << endl;
			cout << "\a player 1 won..." << endl << endl;
			//	system("pause");
			break;
		}

	}

}
void player2(){
	if (z<3){
		char b;
		cout << "Player 2  press any number from (1-9)" << endl << endl;
		cin >> b;
		for (int i = 0; i<10; i++){

			if (b == game[i]){

				game[i] = 'Y';
				d++;
			}
			board();
			r = chk2();
			if (r == 4)	{
				cout << endl << endl;
				cout << "\a player 2 won..." << endl << endl;
				break;
			}

		}
	}

}

void intro(){
	system("cls");
	system("color 0a");
	cout << " \n\n\t\t\tproject:\n\n\n\t\t<<  TIC TAC TOE  (Game) >>";
	cout << endl << endl << endl << endl;
	cout << "\t\t\t  By:" << endl << endl << endl;
	cout << "\tM Asif:\t\t\t\t\tMohsin Ali:" << endl << endl << endl;
	//cout<<"************************************************";
	cout << "\t (16-NTU-1111)\t\t\t\t(16-NTU-1107)";
	cout << endl << endl << endl;

	cout << endl << endl << endl << endl << endl;


}

int main()

{
	system("Color 5e");
	intro();
	system("pause");
	system("CLS");


	do{

		board();
		player1();
		if (d >= 5 || u >= 5){

			draw();
		}
		player2();
	}


	while (z<3 && r<4);

}


