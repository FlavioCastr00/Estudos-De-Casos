import random
import string

class FilaBancaria:
    def __init__(self):  # Inicializa a fila bancária e as senhas
        self.clientes = []  # Lista para armazenar os clientes na fila
        self.senhas = {}  # Dicionário para mapear clientes às suas senhas

    def gerar_senha(self):  # Método para gerar uma senha aleatória
        caracteres = string.ascii_uppercase + string.digits  # Letras maiúsculas e dígitos
        return ''.join(random.choice(caracteres) for _ in range(6))  # Gera uma senha de 6 caracteres

    def entrar_na_fila(self, cliente):  # Método para adicionar um cliente à fila
        senha = self.gerar_senha()  # Gera uma senha para o cliente
        self.clientes.append(cliente)  # Adiciona o cliente à lista de clientes
        self.senhas[cliente] = senha  # Associa a senha ao cliente no dicionário de senhas
        return senha  # Retorna a senha gerada para o cliente

    def atender_proximo(self):  # Método para atender o próximo cliente na fila
        if len(self.clientes) == 0:  # Verifica se não há clientes na fila
            return None  # Retorna None se não houver clientes
        cliente_atendido = self.clientes.pop(0)  # Remove o próximo cliente da fila
        del self.senhas[cliente_atendido]  # Remove a senha do cliente atendido do dicionário de senhas
        return cliente_atendido  # Retorna o cliente atendido

    def numero_de_clientes(self):  # Método para obter o número de clientes na fila
        return len(self.clientes)  # Retorna o comprimento da lista de clientes

    def proximo_cliente(self):  # Método para obter o próximo cliente na fila e sua senha
        if len(self.clientes) == 0:  # Verifica se não há clientes na fila
            return None  # Retorna None se não houver clientes
        return self.clientes[0], self.senhas[self.clientes[0]]  # Retorna o próximo cliente e sua senha

fila_bancaria = FilaBancaria()  # Cria uma instância da classe FilaBancaria

while True:
    print("-- MENU --")
    print("1. Atendimento ao Cliente")
    print("2. Abertura de Conta")
    print("3. Depósitos")
    print("4. Saque de Dinheiro")
    print("5. Pagamento de Contas")
    print("6. Empréstimos e Financiamentos")
    print("7. Sair")

    opcao = input("Escolha uma opção: ")  # Solicita ao usuário que escolha uma opção

    if opcao in ["1", "2", "3", "4", "5", "6"]:  # Verifica se a opção é válida
        cliente = None
        if opcao == "1":
            cliente = "Atendimento ao Cliente"
        elif opcao == "2":
            cliente = "Abertura de Conta"
        elif opcao == "3":
            cliente = "Depósitos"
        elif opcao == "4":
            cliente = "Saque de Dinheiro"
        elif opcao == "5":
            cliente = "Pagamento de Contas"
        elif opcao == "6":
            cliente = "Empréstimos e Financiamentos"

        senha = fila_bancaria.entrar_na_fila(cliente)  # Adiciona o cliente à fila e obtém sua senha
        print("Senha gerada:", senha)  # Exibe a senha gerada para o cliente

    elif opcao == "7":  # Verifica se o usuário escolheu sair
        print("Encerrando o programa...")
        break  # Encerra o loop

    else:  # Se a opção não for válida, exibe uma mensagem de erro
        print("Opção inválida. Por favor, escolha uma opção válida.")

    cliente_atendido = fila_bancaria.atender_proximo()  # Atende o próximo cliente na fila
    if cliente_atendido is not None:  # Verifica se há um cliente atendido
        print("\nCliente atendido:", cliente_atendido)  # Exibe o cliente que foi atendido
    else:
        print("\nNão há clientes na fila\n")  # Exibe uma mensagem se não houver clientes na fila

