namespace Structure
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*StructPoint s1 = new StructPoint();
            StructPoint s2 = s1;*/

            ClassPoint s1 = new ClassPoint();
            ClassPoint s2 = s1;

            Console.WriteLine(s1.x);
            Console.WriteLine(s2.x);

            s1.x++;
            Console.WriteLine(s1.x);
            Console.WriteLine(s2.x);

        }

    }
}