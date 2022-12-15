string path = "D:/_docs/GB/C#/Task00";  // путь к папке
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);  // время создания папки
FileInfo[] fi = di.GetFiles();  // файлы в директории

for (int i = 0; i < fi.Length; i++) // вывод имен файлов
{
    Console.WriteLine(fi[i].Name);
}

CatalogInfo(path);

void CatalogInfo(string path, string indent = "")   // вывод содержимого папки
{
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + "  ");
    }
    FileInfo[] files = catalog.GetFiles();
    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}
