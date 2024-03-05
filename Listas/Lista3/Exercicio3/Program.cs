using System;
class Program
{
    static void Main(string[] args)
    {
        const string NOME_USUARIO = "admin";
        const string SENHA = "123senha";
        const int TENTATIVAS = 3;
        int contador = 1;

        while (contador <= TENTATIVAS)
        {
            Console.Write("Nome de usuario: ");
            string nomeUsuario = Console.ReadLine();

            Console.Write("Senha: ");
            string senha = Console.ReadLine();

            if (nomeUsuario == NOME_USUARIO && senha == SENHA)
            {
                Console.WriteLine("\nLogin realizado com sucesso");
                break;
            }

            else
            {
                Console.WriteLine("Credenciais invalidas... \n");
            }

            contador++;
        }

        if (contador > TENTATIVAS)
        {
            Console.WriteLine("sua conta foi bloqueada");
        }
    }
}
