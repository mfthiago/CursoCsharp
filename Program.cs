namespace ExercícioInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.WriteLine("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Date: (dd/MM/yyyy");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Contract Value: ");
            double value = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of installments: ");
            int installment = int.Parse(Console.ReadLine());

        }
    }
}