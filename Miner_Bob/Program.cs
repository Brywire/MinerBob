using System.Threading;
using System.ComponentModel;
using System.Runtime.CompilerServices; //Backgroundworker



Console.Clear();

Console.WriteLine("Sinterklaas... wie kent hem niet?!");

BackgroundWorker thread = new BackgroundWorker();
thread.DoWork += keypressThread;
thread.RunWorkerAsync();

while (true)
{
	/*
	if (!miner.Update())
	{ break; }
	*/
	Console.WriteLine("Hello World!");
	Thread.Sleep(2000);	
}

static void keypressThread(object sender, DoWorkEventArgs e)
{
	while(true)
	{
		if (Console.KeyAvailable)
		{
			if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
			{
				Environment.Exit(0);
			}
		}
		Thread.Sleep(100);
	}
}