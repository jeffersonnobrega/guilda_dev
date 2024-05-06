using System;
using System.IO;

namespace Compactador_Solution
{
    class Compactador
    {
        static void Main(string[] args)
        {
            Monitorar();

        }

        static void Monitorar()
        {
            string Diretorio = @"C:\Temp";
            string Origem = @"C:\Temp\Arquivos_Livres";
            string Destino = @"C:\Temp\Compactados";

            if (!Directory.Exists(Destino))
            {
                Directory.CreateDirectory(Destino);
                Console.WriteLine("Não existe");
            } else
            {
                Console.WriteLine("Existe");
            }
        }
    }
}

