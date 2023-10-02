using System;
using Full_GRASP_And_SOLID.Library;

namespace Library;

public class ConsolePrinter : IPrinterTerminal
{
    public void PrintTicket(Recipe recipe)
    {
        Console.WriteLine(recipe.GetTextToPrint());
    }
}