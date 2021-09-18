using System;

namespace DIO.CLIENTES
{
    class Program
    {
        static ClienteRepositorio repositorio = new ClienteRepositorio();
        static void Main(string[] args)
        {
             string opcaoUsuario = ObterMenuUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                       ListarClientes();
                       break;
                    case "2":
                       InserirCliente();
                       break;
                    case "3":
                       AtualizarCliente();
                       break;
                    case "4":
                       ExcluirCliente();
                       break;
                    case "5":
                       VisualizarCliente();
                       break;

                    case "6":
                       Console.Clear();
                       break;                     
                    default:
                        throw new ArgumentOutOfRangeException();                  
                } 
                opcaoUsuario = ObterMenuUsuario();
            }
            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }

        
        private static void AtualizarCliente()
        {
            Console.WriteLine("Digite o Id do cliente: ");
            int idCliente = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do cliente: ");
            string entradaNome = Console.ReadLine();

            Console.Write("Digite o endereço: ");
            string entradaEndereco = Console.ReadLine();

            Console.Write("Digite o número da casa: ");
            int entradaNumero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Bairro: ");
            string entradaBairro = Console.ReadLine();

            Console.Write("Digite a cidade: ");
            string entradaCidade = Console.ReadLine();

            Console.Write("Digite o estado: ");
            string entradaEstado = Console.ReadLine();

            Console.Write("Digite o cep: ");
            string entradaCep = Console.ReadLine();

            Console.Write("Digite o país: ");
            string entradaPais = Console.ReadLine();

            Console.Write("Digite a nacionalidade: ");
            string entradaNacionalidade = Console.ReadLine();

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} + {1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o telefone: ");
            string entradaTelefone = Console.ReadLine();

            Console.Write("Digite data aniversário: ");
            DateTime entradaAniversario = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Digite o e-mail: ");
            string entradaEmail = Console.ReadLine();
            
            Clientes updateCliente = new Clientes(id: idCliente,
                                                genero: (Genero)entradaGenero,
                                                nome: entradaNome,
                                                endereco: entradaEndereco,
                                                numero: entradaNumero,
                                                bairro: entradaBairro,
                                                cidade: entradaCidade,
                                                estado: entradaEstado,
                                                cep: entradaCep,
                                                pais: entradaPais,
                                                nacionalidade: entradaNacionalidade,
                                                telefone: entradaTelefone,
                                                aniversario: entradaAniversario,
                                                email: entradaEmail);

            repositorio.Atualizar(idCliente, updateCliente);

            Console.WriteLine();
            Console.WriteLine("***********************************************");
            Console.WriteLine("Cliente atualizado com sucesso!");
            Console.WriteLine("***********************************************"); 

        }

        private static void ExcluirCliente()
        {
            Console.Write("Digite o id do Cliente: ");
            int idCliente = int.Parse(Console.ReadLine());

            repositorio.Excluir(idCliente);

            Console.WriteLine();
            Console.WriteLine("***********************************************");
            Console.WriteLine("Cliente excluído com sucesso!");
            Console.WriteLine("***********************************************"); 
        }

        private static void VisualizarCliente()
        {
            Console.Write("Digite o id do cliente: ");
            int idCliente = int.Parse(Console.ReadLine());

            var cliente = repositorio.RetornaPorId(idCliente);

            Console.WriteLine(cliente);

            Console.WriteLine();
            Console.WriteLine("***********************************************");

        }

        private static void ListarClientes()
        {
            Console.WriteLine("Listar Clientes");

            var lista = repositorio.Listar();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum cliente cadastrado.");
                return;
            }
            foreach (var cliente in lista)
            {
                string status = cliente.retornaExcluido() ? "Inativo" : "Ativo";

                Console.WriteLine("#ID {0}: - {1} {2}", cliente.retornaId(), cliente.retornaNome(), cliente.retornaAniversario(), status);
            }
        }
        private static void InserirCliente()
        {
            Console.WriteLine("Inserir novo cliente");

            Console.Write("Digite o nome do cliente: ");
            string entradaNome = Console.ReadLine();

            Console.Write("Digite o endereço: ");
            string entradaEndereco = Console.ReadLine();

            Console.Write("Digite o número da casa: ");
            int entradaNumero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Bairro: ");
            string entradaBairro = Console.ReadLine();

            Console.Write("Digite a cidade: ");
            string entradaCidade = Console.ReadLine();

            Console.Write("Digite o estado: ");
            string entradaEstado = Console.ReadLine();

            Console.Write("Digite o cep: ");
            string entradaCep = Console.ReadLine();

            Console.Write("Digite o país: ");
            string entradaPais = Console.ReadLine();

            Console.Write("Digite a nacionalidade: ");
            string entradaNacionalidade = Console.ReadLine();

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} + {1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o telefone: ");
            string entradaTelefone = Console.ReadLine();

            Console.Write("Digite data aniversário: ");
            DateTime entradaAniversario = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Digite o e-mail: ");
            string entradaEmail = Console.ReadLine();
            
            Clientes NovoCliente = new Clientes(id: repositorio.ProximoId(),
                                                genero: (Genero)entradaGenero,
                                                nome: entradaNome,
                                                endereco: entradaEndereco,
                                                numero: entradaNumero,
                                                bairro: entradaBairro,
                                                cidade: entradaCidade,
                                                estado: entradaEstado,
                                                cep: entradaCep,
                                                pais: entradaPais,
                                                nacionalidade: entradaNacionalidade,
                                                telefone: entradaTelefone,
                                                aniversario: entradaAniversario,
                                                email: entradaEmail);
                                       

            repositorio.Inserir(NovoCliente);  

            Console.WriteLine();
            Console.WriteLine("***********************************************");
            Console.WriteLine("Cliente Cadastrado com sucesso!");
            Console.WriteLine("***********************************************");                          
        }

        private static string ObterMenuUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("***********************************************");
            Console.WriteLine("Espaço de Beleza Dika Dacome!!!");
            Console.WriteLine("***********************************************");
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada: ");
            
            Console.WriteLine();

            Console.WriteLine("1- Listar cliente ");
            Console.WriteLine("2- Inserir novo cliente ");
            Console.WriteLine("3-Atualizar cadastro ");
            Console.WriteLine("4- Excluir cliente ");
            Console.WriteLine("5- Visualizar cliente ");
            Console.WriteLine("6- Limpar tela ");
            Console.WriteLine("X- Sair ");
            Console.WriteLine();
            Console.WriteLine("***********************************************");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
        
        
        
        
        
        
        
        
        
        
       
        
        
    }
}
