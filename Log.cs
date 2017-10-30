using System;
// classe log para gravar erro da aplicação
using System.IO;
public class Log{
public string Metodo { get; set; }
public string Mensagem { get; set; }

public Log(){

}

public Log(string metodo,string mensagem){
    this.Metodo = metodo;
    this.Mensagem = mensagem;
}

private void SalvarLog(){
    StreamWriter sw = new StreamWriter("Logerro.txt");
    sw.WriteLine("Metodo: " + this.Metodo + "- erro" + this.Mensagem);
    sw.Close();
}

}