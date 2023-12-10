using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orderList = new List<Order>();

        orderList.Add(new Order());

        orderList[0].AddProduct("apples", 0.68, 32, 4);
        orderList[0].AddProduct("banana", 0.73, 41, 5);

        orderList[0].CreateCustomer("Bailey");
        orderList[0].CreateAddress("Walnut Blvd", "Corvallis", "Oregon", "USA");

        orderList.Add(new Order());

        orderList[1].AddProduct("hotdog", 2.43, 13, 2);
        orderList[1].AddProduct("burger", 4.51, 14, 1);

        orderList[1].CreateCustomer("Korben");
        orderList[1].CreateAddress("68th Avenue", "Olympia", "Washington", "Finland");

        int number = 1;
        
        foreach (Order order in orderList)
        {
            Console.WriteLine($"\nOrder #{number}");
            Console.WriteLine("\nPackaging Label:");
            order.DisplayPackagingLabel();
            Console.WriteLine("\nShipping Label:");
            order.DisplayShippingLabel();
            Console.WriteLine($"\nTotal: {order.GetTotal()}");
            Console.WriteLine();
            number++;
        }
    }
}