using ConsoleStorage.Data;
using ConsoleStorage.Menus;
using ConsoleStorage.Menus.ConcreteMenus;
using ConsoleStorage.Models.Product;

List<string> options = new List<string>
{
    "Produtos",
    "Fornecedores",
    "Lojas",
    "Clientes"
};

IGUI gui = new Main(options, 15);

int index = 0;

do
{
    index = gui.Render();
    switch (index)
    {
        case 0:
            SelectOption("Produtos");
            break;
        case 1:
            SelectOption("Fornecedores");
            break;
        case 2:
            SelectOption("Lojas");
            break;
        case 3:
            SelectOption("Clientes");
            break;
    }
} while (index != 4);

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine("Done");


void SelectOption(string title)
{
    Console.Clear();
    Console.WriteLine(title);
    Console.ReadKey();
}