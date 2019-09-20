using System;
using System.Collections.Generic;

//Question https://www.briefmenow.org/microsoft/which-collection-type-should-you-use-7/

//You are developing an application that includes a class named Order.The application will store a
//collection of Order objects.
//The collection must meet the following requirements:
//Use strongly typed members.
//Process Order objects in first-in-first-out order.
//Store values for each Order object.
//Use zero-based indices.
//You need to use a collection type that meets the requirements.
//Which collection type should you use?

namespace BriefMeNow.ListImplementations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Queue<int> --> Enqueue(1), Enqueue(2), Enqueue(3), Enqueue(4)");
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(1);
            queue.Enqueue(1);
            queue.Enqueue(1);

            Console.WriteLine("Dequeue first element: " + queue.Dequeue());
        }
    }
}
