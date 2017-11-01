using System;
using NetOffice.ExcelApi;

public class Carros{
    public Carros(){        

    }

    private string Marca { get; set; }
    private string Modelo { get; set; }
    private string Ano { get; set; }
    private string Valor { get; set; }  

    private Opcionais Op { get; set; }  

    public void CadastarCarro(){        
        try{
            
            System.Console.WriteLine("Informe a marca do carro: ");
            this.Marca = Console.ReadLine();
            System.Console.WriteLine("Informe o Modelo do carro: ");
            this.Modelo = Console.ReadLine();
            System.Console.WriteLine("Informe o Ano do carro: ");
            this.Ano = Console.ReadLine();
            System.Console.WriteLine("Informe o Valor do carro: "); 
            System.Console.WriteLine("Haverá Ar Condicionado?  ");
            System.Console.WriteLine("ArCondicionado ?");
            this.Op.ArCondicionado = Convert.ToBoolean(Console.ReadLine());
            System.Console.WriteLine("Vidro Eletrico? ");
            this.Op.VidroEletrico = Convert.ToBoolean(Console.ReadLine());
            System.Console.WriteLine("Direção Hidráulica? ");
            this.Op.DirecaoHidraulica = Convert.ToBoolean(Console.ReadLine());
            System.Console.WriteLine("Banco de Couro?");
            this.Op.BancoDeCouro = Convert.ToBoolean(Console.ReadLine()); 
                                       

            Application ex = new Application();
            ex.Workbooks.Add();
            ex.Cells[1,1].Value = this.Marca;
            ex.Cells[1,2].Value = this.Modelo;
            ex.Cells[1,3].Value = this.Ano;
            ex.Cells[1,4].Value = this.Valor;
            ex.Cells[1,5].Value = this.Op.ArCondicionado;
            ex.Cells[1,6].Value = this.Op.DirecaoHidraulica;
            ex.Cells[1,7].Value = this.Op.VidroEletrico;
            ex.Cells[1,8].Value = this.Op.BancoDeCouro;
            ex.ActiveWorkbook.SaveAs(@"C:\Users\08929532845\Desktop\sistema_concessionaria\dadosCarros.xlsx");
            ex.Quit();

        }
        catch (System.Exception e){
            Cliente cli = new Cliente();
            Erro err = new Erro();
            err.GravarErro("Cadastrar Carro",e.Message);       
          
        }
        
    }

    

}
