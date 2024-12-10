namespace assignment6._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
		    Stack<int> numbers = new Stack<int>();

            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);
            numbers.Push(4);
            numbers.Push(5);

            foreach( int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Popping elements off the stack:");

            while (numbers.Count > 0)
            {
                Console.WriteLine("Popping '{0}'", numbers.Pop());
            }

            //Create a copy using ToArray method
            int[] arrayNumbers = numbers.ToArray();

            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);
            numbers.Push(4);
            numbers.Push(5);

            arrayNumbers = numbers.ToArray();

            Console.WriteLine("Pushing elements to the array:");

            foreach ( int arrayNumber in arrayNumbers)
            {
                Console.WriteLine(arrayNumber);
            }
		}
    }
}
