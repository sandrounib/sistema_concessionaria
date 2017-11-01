using System;
using System.IO;
using NetOffice.ExcelApi;

public class Cliente
{

    public Cliente()
    {
        End = new Endereco();

    }

    private string CpfCli { get; set; }
    private string NomeCli { get; set; }
    private string EmailCli { get; set; }
    private Endereco End { get; set; }

    public void CadastrarCliente()
    {
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
                if (!documentoValido)
                    System.Console.WriteLine("CPF Inválido!");
            } while (!documentoValido);
            this.CpfCli = documento;
            Console.WriteLine("Informe o nome do cliente");
            this.NomeCli = Console.ReadLine();

            Console.WriteLine("Informe o email do cliente");
            this.EmailCli = Console.ReadLine();

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

            Application ex = new Application();
            ex.Workbooks.Add();
            ex.Cells[1, 1].Value = this.CpfCli;
            ex.Cells[1, 2].Value = this.NomeCli;
            ex.Cells[1, 3].Value = this.EmailCli;
            ex.Cells[1, 4].Value = this.End.Logradouro;
            ex.Cells[1, 5].Value = this.End.Numero;
            ex.Cells[1, 6].Value = this.End.Bairro;
            ex.Cells[1, 7].Value = this.End.Cep;

            ex.ActiveWorkbook.SaveAs(@"C:\Users\08929532845\Desktop\sistema_concessionaria\dadoscli.xlsx");
            ex.Quit();
        }
        catch (Exception e)
        {
            Erro err = new Erro();
            err.GravarErro("CadastrarCliente", e.Message);
        }
    }
}









