class Program
{
    static void Main()
    {
        Random random = new Random();

        for (int i = 0; i < 5; i++)
        {
            int wagonType = random.Next(1, 4);
            IParent wagon = null;

            if (wagonType == 1)
            {
                double price = random.Next(50, 200);
                int seats = random.Next(50, 200);
                wagon = new Child1(price, seats);
            }
            else if (wagonType == 2)
            {
                double price = random.Next(100, 400);
                int seats = random.Next(20, 100);
                double extraServicesPrice = random.Next(10, 50);
                wagon = new Child2(price, seats, extraServicesPrice);
            }
            else
            {
                double price = random.Next(150, 600);
                int seats = random.Next(10, 40);
                double extraServicesPrice = random.Next(20, 100);
                wagon = new Child3(price, seats, extraServicesPrice);
            }

            wagon.Metod();
            Console.WriteLine(wagon.Info());
        }
    }
}
