import numpy as np #importa a biblioteca numpy

vt = np.empty(5) #cria um vetor vazio

for i in range(5):
    vt[i] = int(input("Digite um valor: ")) #carrega o vetor através de inputs do usuário

print(f"\nA média é: {vt.mean()}",           #retorna a média
      f"\nO maior número é: {vt.max()}",     #retorna o maior valor
      f"\nO menor número é: {vt.min()}",     #retorna o menor valor
      f"\nComprimento do vetor: {len(vt)}",  #retorna o comprimento do vetor
      f"\nSoma dos elementos: {vt.sum()}",)  #retorna a soma de todos os elementos