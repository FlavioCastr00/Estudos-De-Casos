#define CALCULADORA_H
#include <iostream>
#include <cmath>
using namespace std;

class Calculadora
{
    public:
        
        double x, y;
        
        double Soma();
        
        double Subtração();
        
        double Multiplicação();
        
        double Divisão();
        
        double raizQuadrada();
        
        double logNatural();
};