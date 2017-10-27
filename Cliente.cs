using System;
using System.IO;
using NetOffice.ExcelApi;

public class Cliente{

    public Cliente(){

    }

    public string CpfCli { get; set; }
    public string NomeCli { get; set; }
    public string EmailCli { get; set; }
    public Endereco End { get; set; }


    public void CadastrarCliente(){ 
        try
            {
                string documento = "";
                bool documentoValido = false;
                Documento doc = new Documento();
                do
                {                    
                    System.Console.WriteLine("Digite o CPF do Cliente");
                    documento = Console.ReadLine();
                    documentoValido = doc.ValidarCPF(documento);                    
                    if(!documentoValido)
                    System.Console.WriteLine("CPF Inválido!");     
                } while (!documentoValido);
                
                Console.WriteLine("Digite o nome do cliente");
                NomeCli = Console.ReadLine();

                Console.WriteLine("Digite o email do cliente");
                EmailCli = Console.ReadLine();

                System.Console.WriteLine("Digite a rua do cliente");
                End.Rua = Console.ReadLine();

                System.Console.WriteLine("Digite o bairro do cliente ");
                End.Bairro = Console.ReadLine();

                Application Ex = new Application();
                //Ex.Work   
                
                
               
        }           
        catch (Exception e)
        {
           //GravarErro("CadastrarCliente", e.Message);
        }       
    }        
         
}
