using System;
using System.IO;
using System.Collections.Generic;
using ContantoQuantidadeDeacessosLog.Entities;

namespace ContantoQuantidadeDeacessosLog
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> lr = new HashSet<LogRecord>();

            string sourcePath = @"c:\temp\log.txt"; // Sem o Arroba teria que colocar // no caminho

            // FileStream fs = null;
            StreamReader sr = null;

            try
            {
                //fs = new FileStream(sourcePath, FileMode.Open); // Abri o arquivo
                // sr = new StreamReader(fs);

                sr = File.OpenText(sourcePath); // Tem a mesma função do FileStram 


                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine().Split(' ');
                    
                    string nome = line[0];
                    DateTime data = DateTime.Parse(line[1]);

                    // Como implementamos o iguals e HashCode na classe por USERNAME, não entra repedido
                    lr.Add(new LogRecord{ UserName = nome, Data = data });

                }
                Console.WriteLine("Total de usuario: "+ lr.Count);

            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro: ");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();

            }

        }
    }
}
