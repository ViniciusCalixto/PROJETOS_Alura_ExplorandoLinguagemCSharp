using ByteBankIO;
using System.Text;

partial class Program
{
    static void LidandoComFileStreamDiretamente()
    {
        //D:\APRENDENDO_Csharp\APRENDENDOCSHARP\PROJETOS_Alura_ExplorandoLinguagemCSharp\CSharpTrabalhandoArquivos\ByteBankIO-master

        var enderecoArquivo = "contas.txt";

        using (var fluxoArquivo = new FileStream(enderecoArquivo, FileMode.Open))
        {

            var numeroDeBytesLidos = -1;

            var buffer = new byte[1024]; //1kb


            numeroDeBytesLidos = fluxoArquivo.Read(buffer, 0, 1024);
            while (numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoArquivo.Read(buffer, 0, 1024);
                //Console.Write(  $"bytes lidos:"+numeroDeBytesLidos);
                EscreverBuffer(buffer, numeroDeBytesLidos);
            }
            //fluxoArquivo.Read(buffer, 0, 1024);


            fluxoArquivo.Close();

        }


        Console.ReadLine();
    }
    static void EscreverBuffer(byte[] buffer, int bytesLidos)
    {
        var utf8 = new UTF8Encoding();
        var texto = utf8.GetString(buffer, 0, bytesLidos);
        Console.WriteLine(texto);

        //foreach (var meuByte in buffer)
        //{
        //    Console.Write(meuByte);
        //    Console.Write(" ");
        //}
    }
}