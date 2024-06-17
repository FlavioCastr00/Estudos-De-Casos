#include "Calculadora.h"

double Calculadora::Soma(){
    cout << "Digite os valores que deseja somar:" << endl;
    cin >> x;
    cin >> y;
    return x+y;
}

double Calculadora::Subtração(){
    cout << "Digite os valores que deseja subtrair:" << endl;
    cin >> x;
    cin >> y;
    return x-y;
}

double Calculadora::Multiplicação(){
    cout << "Digite os valores que deseja multiplicar:" << endl;
    cin >> x;
    cin >> y;
    return x*y;
}
    
double Calculadora::Divisão(){
    cout << "Digite os valores que deseja dividir:" << endl;
    cin >> x;
    cin >> y;
    return x/y;
}
    
double Calculadora::raizQuadrada(){
    cout << "Raiz quadrada de?" << endl;
    cin >> x;
    return sqrt(x);
}
    
double Calculadora::logNatural(){
    cout << "Log natural de?" << endl;
    cin >> x;
    return log(x);
}
