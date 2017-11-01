using System;
using System.IO;

public class Erro
{

    public Erro()
    {
    }
    public void GravarErro(string funcao, string erro)
    {
        try
        {
            //Informa ao usuário que ocorreu um erro
            Console.WriteLine("Ocorreu um erro - Contacte o Administrador");
            //Abre um arquivo textp
            StreamWriter sr = new StreamWriter("logerro.txt", true);
            //Grava as informações no arquivo erro
            sr.WriteLine(DateTime.Now + " - " + funcao + " - " + erro);
            //fecha o arquivo, caso não feche o arquivo não será salvo
            sr.Close();
        }
        catch (System.Exception)
        {

            Console.WriteLine("Ocorreu um erro - Contacte o Administrador");
        }
    }





}

