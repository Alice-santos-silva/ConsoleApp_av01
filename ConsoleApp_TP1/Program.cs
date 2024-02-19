namespace ConsoleApp_TP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            Pessoa p1 = new Pessoa("Alice", 21, "123456789");
            Console.WriteLine(p1.Nome);
            Console.WriteLine(p1.Idade);
            Console.WriteLine(p1.Cpf);

            while (true)
            {
                Console.WriteLine("1 - nova pessoa");
                Console.WriteLine("2 - listar pessoas");
                Console.WriteLine("3 - sair");
                Console.WriteLine("(aperte qualquer tecla para sair.)");
                string escolha = Console.ReadLine();
                int escolhaInt = int.Parse(escolha);
                

                if (escolhaInt == 1)
                {
                    Console.WriteLine("NOVA PESSOA");
                    Console.WriteLine("Nome: ");
                    string novoNome = Console.ReadLine();
                    Console.WriteLine("Idade: ");
                    string novaIdade = Console.ReadLine();
                    int idadeInt = int.Parse(novaIdade);
                    Console.WriteLine("CPF: ");
                    string novoCpf = Console.ReadLine();
                    pessoas.Add(new Pessoa(novoNome, idadeInt, novoCpf));
                }
                else if(escolhaInt == 2)
                {
                    foreach(Pessoa pessoa in  pessoas)
                    {
                        Console.WriteLine(pessoa.Nome + "-" + pessoa.Idade + "-" + pessoa.Cpf);
                    }
                }
                else if(escolhaInt == 3)
                {
                    Console.WriteLine("Programa encerrado.");
                    break;
                }
            }
        }
    }
}
