#include <iostream>
#include "Forma_Geometrica.h"
using namespace std;

void Forma_Geometrica::setLargura(){
    cout << "Defina a largura: ";
    cin >> largura;
}

void Forma_Geometrica::setAltura(){
    cout << "Defina a altura: ";
    cin >> altura;
}

float Forma_Geometrica::getLargura(){
    return largura;
}

float Forma_Geometrica::getAltura(){
    return altura;
}