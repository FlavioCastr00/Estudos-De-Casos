#carreda dois vetores através de inputs do usuário. No final, cria um terceiro vetor intercalando os valores dos outros dois vetores
import numpy as np

vt1 = np.empty(10) #cria um vetor vazio
vt2 = np.empty(10)
vt3 = np.empty(20)
j = 0 #variável auxiliar

print("Para o vetor 1.")
for i in range(10): #estrutura de repetição para carregar valores no vetor 1
    vt1[i] = int(input(f"Digite um número para a posição {i+1}: "))

print("\nPara o vetor 2.")
for i in range(10): #estrutura de repetição para carregar valores no vetor 2
    vt2[i] = int(input(f"Digite um número para a posição {i+1}: "))

for i in range(20): #estrutura de repetição que carregará o vetor 3
  if i % 2 == 0:
    vt3[i] = vt1[j] #agrega o valor do vetor 1
  else:
    vt3[i] = vt2[j] #agrega o valor do vetor 2
    j = j + 1

print(f"\nVetor 1: {vt1}\nVetor 2: {vt2}\nVetor 3 intercalado: {vt3}")