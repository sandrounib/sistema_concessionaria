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
                    System.Console.WriteLine("Informe o CPF do Cliente");
                    documento = Console.ReadLine();
                    documentoValido = doc.ValidarCPF(documento);                    
                    if(!documentoValido)
                    System.Console.WriteLine("CPF Inválido!");     
                } while (!documentoValido);
                
                Console.WriteLine("Informe o nome do cliente");
                NomeCli = Console.ReadLine();

                Console.WriteLine("Informe o email do cliente");
                EmailCli = Console.ReadLine();

                System.Console.WriteLine("Informe a rua do cliente");
                End.Logradouro = Console.ReadLine();

                System.Console.WriteLine("Informe o Número: ");
                End.Numero = Console.ReadLine();

                System.Console.WriteLine("Informe o complemento: ");
                End.Complemento = Console.ReadLine();

                System.Console.WriteLine("Informe o bairro: ");
                End.Bairro = Console.ReadLine();

                System.Console.WriteLine("Informe Cep");
                End.Cep = Console.ReadLine();

                System.Console.WriteLine("Informe o bairro do cliente ");
                End.Bairro = Console.ReadLine().ToString();

                Application ex = new Application();
                ex.Workbooks.Add();
                ex.ActiveCell[1,1].Value = this.NomeCli;
                ex.ActiveCell[1,2] .Value = this.EmailCli;
                ex.ActiveCell[1,3].Value = this.CpfCli;
               // ex.ActiveCell[2,1].Value = this.End.Rua;
                ex.ActiveCell[2,2].Value = this.End.Bairro;              
                ex.ActiveWorkbook.SaveAs(@"C:\Users\Sandro Reis\Desktop\sistema_concessionaria\dadoscli.xlsx");
                ex.Quit();
        }           
        catch (Exception e)
        {
           GravarErro("CadastrarCliente", e.Message);
        }  

        
          
    }        

    static void GravarErro(string funcao, string erro){
                try
                {
                    //Informa ao usuário que ocorreu um erro
                    Console.WriteLine("Ocorreu um erro - Contacte o Administrador");
                    //Abre um arquivo textp
                    StreamWriter sr = new StreamWriter("logerro.txt", true);
                    //Grava as informações no arquivo erro
                    sr.WriteLine(DateTime.Now + " - " + funcao + " - " + erro );
                    //fecha o arquivo, caso não feche o arquivo não será salvo
                    sr.Close();
                }
                catch (System.Exception)
                {
                    
                    Console.WriteLine("Ocorreu um erro - Contacte o Administrador");
                }    
    }
         
}
