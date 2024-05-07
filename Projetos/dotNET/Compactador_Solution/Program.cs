using System.IO.Compression;

namespace Compactador_Solution
{
    class Compactador
    {
        static readonly object lockObject = new object();

        static void Main(string[] args)
        {
            Thread thread = new Thread(Monitorar);
            thread.Start();
        }

        static void Monitorar()
        {
            string DiretorioDestino = @"C:\Temp\Compactados";
            string Origem = @"C:\Temp\Arquivos_Livres";

            // Mantém o último horário de compactação para evitar criar múltiplos arquivos ZIP no mesmo minuto
            DateTime ultimoHorarioCompactacao = DateTime.MinValue;

            while (true)
            {
                DateTime dataHoraAtual = DateTime.Now;

                // Verifica se passou pelo menos um minuto desde a última compactação
                if (dataHoraAtual.Subtract(ultimoHorarioCompactacao).TotalMinutes >= 1)
                {
                    // Obtém a data e hora da última modificação dos arquivos na pasta de origem
                    DateTime ultimaModificacao = ObterUltimaModificacao(Origem);

                    // Verifica se houve alguma modificação nos arquivos desde a última compactação
                    if (ultimaModificacao > ultimoHorarioCompactacao)
                    {
                        lock (lockObject)
                        {
                            string nomeArquivoZip = $"arquivos_{dataHoraAtual:yyyyMMddHHmmss}.zip";
                            string destino = Path.Combine(DiretorioDestino, nomeArquivoZip);

                            try
                            {
                                // Cria o arquivo ZIP
                                ZipFile.CreateFromDirectory(Origem, destino);

                                // Remove os arquivos de origem
                                foreach (string arquivo in Directory.GetFiles(Origem))
                                {
                                    File.Delete(arquivo);
                                }

                                Console.WriteLine("Arquivos compactados e movidos com sucesso.");
                                ultimoHorarioCompactacao = dataHoraAtual;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Ocorreu um erro ao compactar e mover os arquivos: {ex.Message}");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nenhuma modificação nos arquivos desde a última compactação.");
                    }
                }

                // Aguarda 20 segundos antes da próxima verificação
                Thread.Sleep(TimeSpan.FromSeconds(20));
            }
        }

        static DateTime ObterUltimaModificacao(string diretorio)
        {
            DateTime ultimaModificacao = DateTime.MinValue;

            foreach (string arquivo in Directory.GetFiles(diretorio))
            {
                DateTime dataModificacao = File.GetLastWriteTime(arquivo);
                if (dataModificacao > ultimaModificacao)
                {
                    ultimaModificacao = dataModificacao;
                }
            }

            return ultimaModificacao;
        }
    }
}
