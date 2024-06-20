using System;
using System.Threading;

Thread newThreadForPrintingName = new Thread(PrintName);
newThreadForPrintingName.Start();

for (int i = 0; i < 1000; i++) Console.Write("Mona");

void PrintName()
{
    for (int i = 0; i < 1000; i++) Console.Write("Pradyumna");
}
