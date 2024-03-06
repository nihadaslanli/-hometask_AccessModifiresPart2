namespace _hometask_AccessModifiresPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            City city=new City();
            Console.WriteLine("seher daxil edin");
            city.Name = Console.ReadLine();
            Console.WriteLine("population daxil edin");
            city.Population=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"seher:{city.Name}+population:{city.Population}");
        }
    }
}
