

//Написать программу которая дает возможность запустить приложение (любое которое захотите) с настройками для запуска, которые будут предложены пользователю на выбор. (как я показывал запуск браузера со стартовой страницей) 

using System.Diagnostics;

Run();
void Run()
{
    Console.WriteLine("Выберите приложение для запуска:");
    Console.WriteLine("1. Google Chrome");
    Console.WriteLine("2. Opera");
    Console.WriteLine("Введите номер приложения:");

    string input = Console.ReadLine();
    string AppPath = "";
    string startPage = "";

    switch (input)
    {
        case "1":
            AppPath = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";
            startPage = NameStartPage();
            break;
        case "2":
            AppPath = @"C:\Users\31yur\AppData\Local\Programs\Opera\Opera";
            startPage = NameStartPage();
            break;
        default:
            Console.WriteLine("Неверный выбор.");
            Run();
            return;
    }

    LaunchApplication(AppPath, startPage);
}

 void LaunchApplication(string appPath, string startPage)
{
        Process.Start(appPath, startPage);
        Console.WriteLine("Приложение запущено.");
}
string NameStartPage()
{
    string startPage = "";
    Console.WriteLine("Запутить Ютюб? (Y/N)");
    string inpt = Console.ReadLine().ToUpper();
    while (inpt.ToUpper() != "Y" && inpt.ToUpper() != "N")
    {
        Console.WriteLine("Не верный ввод.Добавить добавить поле ProductId? (Y/N)");
        inpt = Console.ReadLine().ToUpper();
    }
    if (inpt == "Y") { startPage = "https://www.youtube.com"; }
    else
    {
        Console.WriteLine("Введите стартовую страницу для Google Chrome:");
        startPage = Console.ReadLine();
    }
    return startPage;
}
