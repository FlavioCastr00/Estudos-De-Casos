# Programa para demonstrar o funcionamento do tipo de estrutura de pilha. 
# Insere carros em uma lista. Cada carro possui as propriedades "Marca", "Modelo" e "Ano" que serão armazenadas como chaves em um dicionário.
# Ao remover um carro, este será sempre o último inserido, seguindo o conceito de LIFO (Last In First Out).

pilha = list()
carro = dict()
i = 0

while i != 4:
    
    print("--MENU--\n1. Adcionar carro\n2. Remover carro\n3. Ver pilha de carros\n4. Sair")
    
    i = int(input("\nDigite sua opção: "))
    
    if i < 1 or i > 5:
        print("opção inválida.")
    
    #adcionar carro
    if i == 1:
        #determinando valores das chaves marca, modelo e ano:
        carro["Marca"] = input("Digite a marca: ") 
        carro["Modelo"] = input("Digite o modelo: ") 
        carro["Ano"] = int(input("Digite o ano do carro: "))
        pilha.append(carro.copy()) #faz uma cópia do dicionário e insere na lista
        print(f"Adcionando carro à pilha: {carro}\n")
    
    #remover carro
    if i == 2:
        if not pilha: #checa se a lista está vazia
            print("Sem carros no momento.\n")
        else:
            print(f"Removendo carro: {pilha.pop()}\n") #utiliza o método pop() para remover e imprimir o elemento removido
    
    #ver lista de carros
    if i == 3:
        if not pilha: #checa se a lista está vazia
            print("Sem carros no momento.\n")
        else:
            print(f"{pilha[::-1]}\n") #imprime a lista na ordem inversa

print("Encerrando...")