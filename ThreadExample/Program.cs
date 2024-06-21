using System;
using System.Threading;

Thread newThreadForPrintingName = new Thread(PrintName);
newThreadForPrintingName.Start();

for (int i = 0; i < 1000; i++)
{
    Console.Write("_Mona_");
    Console.Write("_Start_T_M_", Thread.CurrentThread.Name,"_End");
}

void PrintName()
{
    for (int i = 0; i < 1000; i++)
    {
        Console.Write("_Pradyumna_");
        Console.Write("_Start_T_P_", Thread.CurrentThread.Name,"_End");
    }
}
newThreadForPrintingName.Join();

Thread t = new Thread(Go);
t.Start();
t.Join();
Console.WriteLine("Thread t has ended!");

void Go()
{
    for (int i = 0; i < 1000; i++) Console.Write("y");
}