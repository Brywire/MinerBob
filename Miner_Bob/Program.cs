using System.Threading;
using System.ComponentModel; //Backgroundworker



Console.Clear();

Console.WriteLine("Sinterklaas... wie kent hem niet?!");

BackgroundWorker thread = new BackgroundWorker();
thread.DoWork += keypressThread;
thread.RunWorkerAsync();

