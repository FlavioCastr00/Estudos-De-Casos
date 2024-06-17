#define CALCULADORA_H
#include <iostream>
#include <cmath>
using namespace std;

class Calculadora
{
    public:
        
        double x, y;
        
        double Soma(){
            cout << "Digite os valores que deseja somar:" << endl;
            cin >> x;
            cin >> y;
            return x+y;
        }
        
        double Subtração(){
            cout << "Digite os valores que deseja subtrair:" << endl;
            cin >> x;
            cin >> y;
            return x-y;
        }
        
        double Multiplicação(){
            cout << "Digite os valores que deseja multiplicar:" << endl;
            cin >> x;
            cin >> y;
            return x*y;
        }
        
        double Divisão(){
            cout << "Digite os valores que deseja dividir:" << endl;
            cin >> x;
            cin >> y;
            return x/y;
        }
        
        double raizQuadrada(){
            cout << "Raiz quadrada de?" << endl;
            cin >> x;
            return sqrt(x);
        }
        
        double logNatural(){
            cout << "Log natural de?" << endl;
            cin >> x;
            return log(x);
        }
};