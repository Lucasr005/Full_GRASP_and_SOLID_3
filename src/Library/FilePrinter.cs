using System;
using System.IO;
using Full_GRASP_And_SOLID.Library;

namespace Library;

public class FilePrinter: IPrinterTerminal
{
    public void PrintTicket(Recipe recipe)
    {
        File.WriteAllText("Ticket.txt", recipe.GetTextToPrint());
    }
}
