using System;
using NetOffice.ExcelApi;

namespace sistema_concessionaria
{
    class Program
    {
        static void Main(string[] args)
        {
                
            try
            {
                int opcao =0;
                do
                {
                    System.Console.WriteLine("Digite a opção");
                    System.Console.WriteLine("1 - Cadastrar Cliente");
                    System.Console.WriteLine("2 - Cadastrar Carro");
                    System.Console.WriteLine("3 - Venda Carro");
                    System.Console.WriteLine("4 - Lista Carro Vendido");
                    System.Console.WriteLine("5 - Sair");
                    opcao = Int16.Parse(Console.ReadLine());
                    
                    switch (opcao)
                    {
                        case 1 :
                        Cliente cliente = new Cliente();                        

                            
                            cliente.CadastrarCliente();
                            break;
                        

                        case 2 :
                           // CadastrarCarro();

                            break;
                            
                        case 3 :
                            //VenderCarro();
                            break;

                        case 4 :
                           // ListarCarro();
                            break;

                        case 5 :
                            System.Console.WriteLine("Deseja realmente sair? ");
                            string sair = Console.ReadLine();
                            if(sair.ToLower().Contains("s"))
                                Environment.Exit(0);
                            else if(sair.ToLower().Contains("n")){
                                opcao = 0;
                                System.Console.WriteLine("Opção Inválida!");
                            }
                            else{
                                opcao = 0;
                            }
                            break;

                        default:
                            break;
                    }
                    

                } while (opcao != 5);
                
            }
            catch (System.Exception e)
            {
                Log Log = new Log("Main",e.Message);               
                
            }          
        } 
            
    }
}

