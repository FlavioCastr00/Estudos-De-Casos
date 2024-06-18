#include "Retangulo.h"

void Retangulo::novaForma(){
    setLargura();
    setAltura();
}

float Retangulo::getArea(){
    return getLargura() * getAltura();
}