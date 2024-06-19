#include <iostream>
#include <cstdlib> //biblioteca padrão do "c"
#include <time.h> //biblioteca da função time()
using namespace std;

int main()
{
    srand(time(0)); //inicializando o gerador de números pseudo-aleatórios
    int min, max, i;
    
    while (i != 2)
    {
        //Menu:
        cout << "1. Gerar número aleatório\n2. Sair" << endl;
        cout << "\nEscolha uma opção: ";
        cin >> i;
        
        if (i == 1) //Gerar número aleatório:
        {
            cout << "Defina o valor mínimo: ";
            cin >> min;
            cout << "Defina o valor máximo: ";
            cin >> max;
            
            if (max < min) //checa se o valor máximo é menor que o valor mínimo
            {
                while (max < min)
                {
                    cout << "O valor máximo não pode ser maior que o valor mínimo.\nDefina um outro valor máximo: ";
                    cin >> max;
                }
            }
            
            cout << "Número aleátorio gerado: " << (rand() % (max - min + 1)) + min << endl; //imprime um número aleatório
        }
        else
        {
            if (i == 2) //Sair:
            {
                cout << "Saindo..." << endl;
            }
            else //Opções inválidas:
            {
                cout << "Opção inválida." << endl;
            }
        }
    }
}