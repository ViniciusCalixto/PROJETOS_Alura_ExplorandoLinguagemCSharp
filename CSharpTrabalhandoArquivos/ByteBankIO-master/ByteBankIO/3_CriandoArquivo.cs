using ByteBankIO;
using System.Net.NetworkInformation;
using System.Text;

partial class Program
{
    static void CriarArquivo()
    {
        var caminhoNovoArqiuvo = "contasExportadas.csv";
        
        using ( var fluxoArquivo = new FileStream(caminhoNovoArqiuvo, FileMode.Create) )
        {
            var contaComoString = "456, 7895, 4785.40, Gustavo Santos";

            var enconde = Encoding.UTF8;
            
            var bytes = enconde.GetBytes(contaComoString);
            fluxoArquivo.Write(bytes, 0, bytes.Length);
            
        }

        Console.ReadLine();
    }
    static void CriarArquivoComWriter()
    {
        var caminhoNovoArqiuvo = "contasExportadas.csv";

        using (var fluxoArquivo = new FileStream(caminhoNovoArqiuvo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoArquivo)) 
        {
            escritor.Write("456, 7895, 4785.40, Pedro");
        }
    }

}