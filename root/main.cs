using System.IO;
using System;

class Program
{
    static void Main()
    {
        //lê linha por linha do arquivo e coloca as linhas em array
        string[] linhas = System.IO.File.ReadAllLines(@"in.txt");
        
        //atribui as linhas a variaveis para facilitar...
        int tamanhoLinha = Convert.ToInt32(linhas[0]);
        string texto = linhas[1].ToString();
        
        // variaveis auxiliares
        char separador = ' ';
        string[] palavras = texto.Split(separador);
        int tamanhoPalavra;
        int contador = 0;
        string strOut = "";
        
        foreach (string palavra in palavras){
            tamanhoPalavra = palavra.Length;
            contador = contador + tamanhoPalavra;
            strOut = strOut+palavra;
            
            //Se o numero de caracteres for igual ou maior ao tamanho maximo da linha...
            if(contador >= tamanhoLinha){
                //Insere uma quebra de Linha
                strOut = strOut+"\r\n";
                //Zera o contador
                contador = 0;
            }
            //Se o numero de caracteres for menor do que o tamanho maximo...
            else{
                //coloca um espaço na frente da palavra para melhor vizualização
                strOut = strOut+" ";
                //soma 1 ao contador(referente ao espaco)
                contador++;
            }
           
        }
        //Escreve o texto formatado no arquivo txt
        System.IO.File.WriteAllText(@"out.txt", strOut);
        Console.WriteLine("O Arquivo foi gerado com sucesso!");

    }
}
