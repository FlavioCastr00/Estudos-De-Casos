#include <iostream>
#include <string>
#include <cstdlib>
#include <time.h>
using namespace std;

int main()
{
    srand(time(0));
    
    char grid[3][3] = 
    {
        {' ', ' ', ' '},
        {' ', ' ', ' '},
        {' ', ' ', ' '}
    };
    char const players[2] = {'X', 'O'};
    char vezJogador = players[rand() % 2]; //sorteia qual jogador irá começar primeiro
    char vencedor = ' ';
    int linha = -1, coluna = -1;
    
    for (int i = 0; i <= 9; i++)
    {
        //imprime o grid
        cout << "   |   |   " << endl;
        cout << " " << grid[0][0] << " | " << grid[0][1] << " | " << grid[0][2] << endl;
        cout << "___|___|___" << endl;
        cout << "   |   |   " << endl;
        cout << " " << grid[1][0] << " | " << grid[1][1] << " | " << grid[1][2] << endl;
        cout << "___|___|___" << endl;
        cout << "   |   |   " << endl;
        cout << " " << grid[2][0] << " | " << grid[2][1] << " | " << grid[2][2] << endl;
        cout << "   |   |   " << endl;
        
        //checa se já há um vencedor
        if (vencedor != ' ')
        {
            cout << vencedor << " é o Vencedor!!!" << endl;
            break;
        }
        //empate
        if (i == 9)
        {
            cout << "Empate!" << endl;
            break;
        }
        
        //jogadas
        cout << "Vez do jogador: " << vezJogador << endl;
        while (true)
        {
            cout << "Digite um número de 1 à 3 para a linha e coluna:" << endl;
            cin >> linha >> coluna;
            if (linha < 1 || linha > 3 || coluna < 1 || coluna > 3) //checa se a escolha do jogador é válida.
            {
                cout << "Escolha inálida!" << endl;
            }
            else
            {
                if (grid[linha - 1][coluna - 1] != ' ') //checa se a posição do grid já está ocupada.
                {
                    cout << "Esse lugar já está ocupado!" << endl;
                }
                else
                {
                    grid[linha - 1][coluna - 1] = vezJogador; //adiciona o jogador na posição escolhida.
                    break;
                }
            }
            cin.clear(); //limpa mensagens de erro para que as próximas operações de I/O possam funcionar.
            cin.ignore(1000, '\n'); //pula para a próxima linha.
        }
        
        //vitoria na horizontal
        for (int linha = 0; linha < 3; linha++)
        {
            if (grid[linha][0] != ' ' && grid[linha][0] == grid[linha][1] && grid[linha][1] == grid[linha][2])
            {
                vencedor = vezJogador;
            }
        }
        //vitoria na vertical
        for (int coluna = 0; coluna < 3; coluna ++)
        {
            if (grid[0][coluna] != ' ' && grid[0][coluna] == grid[1][coluna] && grid[1][coluna] == grid[2][coluna])
            {
                vencedor = vezJogador;
            }
        }
        //vitoria na diagonal
        if (grid[0][0] != ' ' && grid[1][1] != ' ' && grid[2][2] != ' ' || grid[0][2] != ' ' && grid[1][1] != ' ' && grid[2][0] != ' ')
        {
            if (grid[0][0] == grid[1][1] && grid[1][1] == grid[2][2] || grid[0][2] == grid[1][1] && grid[1][1] == grid[2][0])
            {
                vencedor = vezJogador;
            }
        }
        
        //muda a vez do jogador
        if (vezJogador == players[0])
        {
            vezJogador = players[1];
        }
        else
        {
            vezJogador = players[0];
        }
    }
}