#include <iostream>
#include "Calculadora.h"
using namespace std;

int main(void){
    int i = 0;
    double resultado;
    
    Calculadora calc;
    
    while (i != 7){
        cout << "--MENU--\n1. Soma          | 2. Subtração"
                        "\n3. Multiplicação | 4. Divisão"
                        "\n5. Raiz Quadrada | 6. Logaritmo Natural"
                        "\n7. Sair" << endl;
        
        cout << "\nEscolha uma opção: ";
        cin >> i;
        
        if (i == 1){
            resultado = calc.Soma();
            cout << "A soma é: " << resultado << endl;
        }
        else{
            if (i == 2){
                resultado = calc.Subtração();
                cout << "A subtração é: " << resultado << endl;
            }
            else{
                if (i == 3){
                    resultado = calc.Multiplicação();
                    cout << "A multiplicação é: " << resultado << endl;
                }
                else{
                    if (i == 4){
                        resultado = calc.Divisão();
                        cout << "A divisão é: " << resultado << endl;
                    }
                    else{
                        if (i == 5){
                            resultado = calc.raizQuadrada();
                            cout << "A raiz quadrada é: " << resultado << endl;
                        }
                        else{
                            if (i == 6){
                                resultado = calc.logNatural();
                                cout << "O log natural é: " << resultado << endl;
                            }
                            else{
                                if (i == 7){
                                    cout << "Saindo..." << endl;
                                }
                                else{cout << "Opção inválida." << endl;}
                            }
                        }
                    }
                }
            }
        }
    }
}