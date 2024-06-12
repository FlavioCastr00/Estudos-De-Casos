import numpy as np

matriz = np.empty((3, 3)) #cria uma matriz vazia

#carregando a matriz por inputs
for i in range(3): #linha
    for n in range(3): #coluna
        matriz[i][n] = int(input("Digite um número: "))

print(f"\nMatriz:\n{matriz}")                        #imprime a matriz por inteiro
print(f"\nSoma: {sum(sum(matriz))}")                 #soma dos elementos
print(f"\nMenor valor: {matriz.min()}")              #imprime o menor valor
print(f"\nA média dos elementos é: {matriz.mean()}") #imprime a média de todos os elementos da matriz