PeriodicTimer timer = new PeriodicTimer(TimeSpan.FromSeconds(0.001));

while (await timer.WaitForNextTickAsync())
{
    Console.WriteLine("Hello World!");
}
