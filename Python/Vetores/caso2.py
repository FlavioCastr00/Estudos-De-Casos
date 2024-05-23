import numpy as np

vt1 = np.empty(10)
vt2 = np.empty(10)
vt3 = np.empty(20)
j = 0

print("Para o vetor 1.")
for i in range(10):
    vt1[i] = int(input(f"Digite um número para a posição {i+1}: "))

print("\nPara o vetor 2.")
for i in range(10):
    vt2[i] = int(input(f"Digite um número para a posição {i+1}: "))

for i in range(20):
  if i % 2 == 0:
    vt3[i] = vt1[j]
  else:
    vt3[i] = vt2[j]
    j = j + 1

print(f"\nVetor 1: {vt1}\nVetor 2: {vt2}\nVetor 3 intercalado: {vt3}")