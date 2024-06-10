contatos = dict()
i = 0

while i != 5:
    print("--MENU--\n1. ADD contato\n2. Alterar contato\n3. Remover contato\n4. Consultar contatos\n5. Sair")
    
    i = int(input("Escolha uma opção: "))
    
    if i == 1: #adicionar contato
        nome = input("\nDigite o nome do contato: ")
        numero = int(input("Digite o número do contato: "))
        if numero in contatos.values():
            while numero in contatos.values():
                print("\nNúmero de telefone já existente!")
                numero = int(input("Digite outro número de contato: "))
            contatos[nome] = numero
            print("Contato adicionado!\n")
        else:
            contatos[nome] = numero
            print("Contato adicionado!\n")
    
    if i == 2: #alterar contato
        nome = input("\nDigite o nome do contato que deseja alterar: ")
        if contatos.get(nome):
            contatos[nome] = int(input("Digite o novo número: "))
            print("Contato alterado!\n")
        else:
            print("\nContato não encontrado!\n")
    
    if i == 3: #remover contato
        nome = input("\nDigite o nome do contato que deseja remover: ")
        if contatos.get(nome):
            del contatos[nome]
            print("Contato removido!\n")
        else:
            print("\nContato não encontrado!\n")
    
    if i == 4: #ver contatos
        if not contatos.items():
            print("\nSem contatos no momento!\n")
        else:
            for k,v in contatos.items():
                print(f"\n{k} - {v}")

print("Saindo...")