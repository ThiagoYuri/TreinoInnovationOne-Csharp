using System;

namespace DIO.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
        
           string opcaoUser = ObterOpcaoUsuario();

           while(opcaoUser.ToUpper() != "X"){
            switch(opcaoUser.ToUpper()){
                case "1":
                 ListarSeries();
                break;
                case "2":
                InserirSerie();
                break;
                case "3":
                AtualizarSerie();
                break;
                case "4":
                ExcluirSerie();
                break;
                case "5":
                VisualizarSerie();
                break;
                case "C":
                Console.Clear();
                break;
                default:
                throw new ArgumentOutOfRangeException();
            }
            opcaoUser = ObterOpcaoUsuario();
           }

         
        }
        //metodo para obter opção do usuario
        private static string ObterOpcaoUsuario(){
            string opcao = "";
            Console.WriteLine("------------------------------");
            Console.WriteLine("DIO SERIES a seu disport");
            Console.WriteLine("Informe a opção que deseja");
            Console.WriteLine("------------------------------");
            Console.WriteLine("1- Listar series");
            Console.WriteLine("2- Inserir nova serie");
            Console.WriteLine("3- Atualizar serie");
            Console.WriteLine("4- Excluir serie");
            Console.WriteLine("5- Visualizar serie");
            Console.WriteLine("C- limpar tela");
            Console.WriteLine("X- Sair");
            opcao = Console.ReadLine().ToUpper();
            Console.WriteLine("");
             return opcao;
        }
        //metodo para ultilizar a lista
        //criar foreach para pecorrer a lista e lista para o usuario
        private static void ListarSeries(){
            Console.WriteLine("Listar series");
            var lista = repositorio.Lista();
            if(lista.Count == 0){
                Console.WriteLine("Nenhuma serie cadastrada.");
                return;
            }
            foreach(var x in lista){
                var excluido = x.retornaExcluido();
          
                Console.WriteLine("@ID {0}: - {1} - {2}", x.retornaId(),x.retornaTitulo(),(excluido? "*Excluindo*": ""));  
                                    
            }
        }
        //inserir Serie na lista
        private static void InserirSerie(){
            Console.WriteLine("Inserir serie");
            Console.WriteLine("");
            foreach(int i in Enum.GetValues(typeof(Genero))){
                Console.WriteLine("{0} - {1}",i,Enum.GetName(typeof(Genero),i));
            }

            Console.WriteLine("Digite o genero entre as opções acima:");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o titulo de serie: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano de inicio da serie: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição da serie: ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id:repositorio.ProximoId(),genero:(Genero)entradaGenero,titulo:entradaTitulo,ano:entradaAno,descricao:entradaDescricao);

            repositorio.Insert(novaSerie);


        }
        //Atualizar Serie pelo ID
        private static void AtualizarSerie(){
        Console.WriteLine("Digite o id da serie:");
        int indiceSerie = int.Parse(Console.ReadLine());
             foreach(int i in Enum.GetValues(typeof(Genero))){
                Console.WriteLine("{0} - {1}",i,Enum.GetName(typeof(Genero),i));
            }

            Console.WriteLine("Digite o genero entre as opções acima:");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o titulo de serie: ");
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano de inicio da serie: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a descrição da serie: ");
            string entradaDescricao = Console.ReadLine();

            Serie atualizarSerie = new Serie(id:repositorio.ProximoId(),genero:(Genero)entradaGenero,titulo:entradaTitulo,ano:entradaAno,descricao:entradaDescricao);

            repositorio.Atualizar(indiceSerie,atualizarSerie);
        }

        private static void ExcluirSerie(){
            Console.WriteLine("Digite o id para pode excluir a serie:");
            int indiceSerie = int.Parse(Console.ReadLine());
            repositorio.Excluir(indiceSerie);
        }
  
        private static void VisualizarSerie(){
            System.Console.WriteLine("Digite o id serie:");
            int indiceId = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorId(indiceId);

            Console.WriteLine(serie);
        }
  
    }
 
}
