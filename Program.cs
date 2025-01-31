﻿using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string baseFolderFtpImage = @"P:\FtpImagens544";

        // Definindo pastas ST
        string[] maua = { "ST00000090", "ST00000091", "ST00000092", "ST00000093", "ST00000094", "ST00000095", "ST00000096", "ST00000097", "ST00000098", "ST00000099", "ST00000100", "ST00000101", "ST00000102", "ST00000103", "ST00000104", "ST00000105", "ST00000106", "ST00000107", "ST00000108", "ST00000109", "ST00000110", "ST00000111", "ST00000113", "ST00000123", "ST00000124", "ST00000125", "ST00000127", "ST00000139", "ST00000140", "ST00000155" };
        string[] araraquara = { "ST00000200", "ST00000250", "ST00000276", "ST00000334", "ST00000335", "ST00000336", "ST00000337", "ST00000338", "ST00000366", "ST00000367", "ST00000388", "ST00000406" };
        string[] araras = { "ST00000129", "ST00000163", "ST00000164", "ST00000172", "ST00000173", "ST00000174", "ST00000175", "ST00000178", "ST00000179", "ST00000180", "ST00000181", "ST00000182" };
        string[] santoAndre = { "ST00000040", "ST00000046" };
        string[] saoCaetano = { "ST00000036", "ST00000037", "ST00000041", "ST00000047", "ST00000048", "ST00000049", "ST00000050", "ST00000052", "ST00000066", "ST00000067", "ST00000075", "ST00000076", "ST00000135", "ST00000136", "ST00000184", "ST00000185" };
        string[] indaiatuba = { "ST00000331", "ST00000332", "ST00000333", "ST00000387" };
        string[] jarinu = { "ST00000166", "ST00000104" };
        string[] paulinia = { "" };
        string[] dourados = { "ST00000069", "ST00000085", "ST00000086", "ST00000087", "ST00000088", "ST00000089", "ST00000116", "ST00000126", "ST00000141", "ST00000147", "ST00000364" };
        string[] aparecidaDeGoiania = { "ST00000068", "ST00000156", "ST00000189", "ST00000190", "ST00000191", "ST00000204", "ST00000206", "ST00000223", "ST00000224", "ST00000227", "ST00000228", "ST00000229", "ST00000351", "ST00000352", "ST00000353", "ST00000354" };
        string[] capivari = { "ST00000060", "ST00000061", "ST00000062", "ST00000063", "ST00000064", "ST00000065" };
        string[] cotia = { "ST00000053", "ST00000054", "ST00000055", "ST00000056", "ST00000057", "ST00000058", "ST00000059", "ST00000079", "ST00000080", "ST00000081", "ST00000082", "ST00000083", "ST00000084", "ST00000112", "ST00000114", "ST00000115", "ST00000130", "ST00000131", "ST00000132", "ST00000133", "ST00000134", "ST00000161", "ST00000162", "ST00000243", "ST00000244", "ST00000245" };
        string[] itapevi = { "ST00000137", "ST00000138", "ST00000273", "ST00000274", "ST00000275", "ST00000339", "ST00000340" };
        string[] itaquaquecetuba = { "ST00000202", "ST00000226", "ST00000254", "ST00000255", "ST00000257", "ST00000258", "ST00000259", "ST00000260", "ST00000263", "ST00000264", "ST00000265", "ST00000266", "ST00000267", "ST00000268", "ST00000269", "ST00000270", "ST00000346", "ST00000380", "ST00000381", "ST00000382", "ST00000383" };
        string[] jundiai = { "ST00000386", "ST00000390", "ST00000016", "ST00000017", "ST00000018", "ST00000019", "ST00000020", "ST00000024", "ST00000025", "ST00000027" };
        string[] jundiaiArcor = { "ST00000077", "ST00000120", "ST00000122", "ST00000146", "ST00000150", "ST00000160", "ST00000177", "ST00000256", "ST00000261", "ST00000384", "ST00000385", "ST00000391", "ST00000392", "ST00000393", "ST00000394", "ST00000395", "ST00000396", "ST00000397", "ST00000398", "ST00000399" };
        string[] manaus = { "ST00000144", "ST00000145", "ST00000242", "ST0000247", "ST00000248", "ST00000249", };
        // Chamar a função para cada lista de pastas
        CheckLastModifiedFolder(baseFolderFtpImage, araraquara, "Araraquara");
        CheckLastModifiedFolder(baseFolderFtpImage, araras, "Araras");
        CheckLastModifiedFolder(baseFolderFtpImage, maua, "Mauá");
        CheckLastModifiedFolder(baseFolderFtpImage, santoAndre, "Santo André");
        CheckLastModifiedFolder(baseFolderFtpImage, saoCaetano, "São Caetano");
        CheckLastModifiedFolder(baseFolderFtpImage, indaiatuba, "Indaiatuba");
        CheckLastModifiedFolder(baseFolderFtpImage, jarinu, "Jarinu");
        CheckLastModifiedFolder(baseFolderFtpImage, dourados, "Dourados");
        CheckLastModifiedFolder(baseFolderFtpImage, aparecidaDeGoiania, "Ap. de Goiânia");
        CheckLastModifiedFolder(baseFolderFtpImage, capivari, "Capivari");
        CheckLastModifiedFolder(baseFolderFtpImage, itapevi, "Itapevi");
        CheckLastModifiedFolder(baseFolderFtpImage, itaquaquecetuba, "Itaquaquecetuba");
        CheckLastModifiedFolder(baseFolderFtpImage, jundiai, "Jundiaí");
        CheckLastModifiedFolder(baseFolderFtpImage, jundiaiArcor, "Jundiai Arcor");
        CheckLastModifiedFolder(baseFolderFtpImage, manaus, "Manaus");
    }

    static void CheckLastModifiedFolder(string baseFolderFtpImage, string[] folders, string regionName)
    {
        foreach (string folder in folders)
        {
            //Define pasta entrada
            string folderPath = Path.Combine(baseFolderFtpImage, folder, "Entrada");

            if (Directory.Exists(folderPath))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);
                DateTime lastModified = directoryInfo.LastWriteTime;
                DateTime now = DateTime.Now;

                double hoursDifference = (now - lastModified).TotalHours;
                
                // Define cor baseada na diferença de horas

                if (hoursDifference <=6)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (hoursDifference <=12)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (hoursDifference <=24)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
               Console.Write($"Região: ");
                Console.Write(regionName.PadRight(15));
                Console.ForegroundColor = ConsoleColor.White; // Resetar a cor para a padrão
                Console.Write("| Pasta: {0,-15} | Data da última modificação da pasta 'Entrada': ", folder);
                
                // Define cor da data baseada na diferença de horas
                if (hoursDifference <=6)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (hoursDifference <=12)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (hoursDifference <=24)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine(lastModified);
            }
        }
    }
}   

