#include <iostream>
#include "Triangulo.h"
using namespace std;

int main()
{
    //testando a classe "Retangulo"
    //instânciando a classe
    Retangulo r1;
    //métodos
    r1.novaForma();
    cout << "Área do retangulo: " << r1.getArea() << endl;
    
    //testando a classe "Triangulo"
    //instanciando a classe
    Triangulo t1;
    //métodos
    t1.novaForma();
    cout << "Área do triangulo: " << t1.getArea() << endl;
}