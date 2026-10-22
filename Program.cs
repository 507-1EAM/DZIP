using System.IO.Compression;
using System.Formats.Tar;

Console.WriteLine("DZIP V1.0 BY D1X3");
Console.WriteLine("1. Разархивировать архив");
Console.WriteLine("2. Архивировать папку (Ещё не реализовал)\n");
Console.Write("Выбор: ");
string? select = Console.ReadLine();
if (select == "1") // О господи. Долго делал
{
    Console.Write("\nНазвание файла архива: ");
    string? namearchive = Console.ReadLine();
    if (namearchive.EndsWith(".tar"))
    {
        Console.Write("Это Tar");
        TarFile.ExtractToDirectory(namearchive, ".", overwriteFiles: true);
        Console.Write("\nРазархивировано!");
    }
    if (namearchive.EndsWith(".zip"))
    {
        Console.Write("Это Zip");
        ZipFile.ExtractToDirectory(namearchive, ".");
        Console.Write("\nРазархивировано!");
    }
    
}

if (select == "2") // Реализовать нада. но мне лень.
{
    Console.WriteLine("Написано же что не работает)");
}