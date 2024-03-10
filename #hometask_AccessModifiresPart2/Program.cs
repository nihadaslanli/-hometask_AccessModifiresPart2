namespace _hometask_AccessModifiresPart2
{
    internal class Program
    {
        class Program
        {
            static double CalculateAveragePopulation(City[] cityArray)
            {
                int totPopulation = 0;
                foreach (City city in cityArray)
                {
                    totPopulation += city.Population;
                }
                return cityArray.Length > 0 ? (double)totPopulation / cityArray.Length : 0;
            }

            static void Main(string[] args)
            {
                City[] chinaCityArray = new City[3];

                for (int i = 0; i < chinaCityArray.Length; i++)
                {
                    string cityName;
                    int population;
                    bool validCityName = false;
                    bool validPopulation = false;

                    do
                    {
                        Console.WriteLine("--------------------------------------------");
                        Console.Write($"seher adi daxil edin: {i + 1}: ");
                        cityName = Console.ReadLine();


                        if (cityName.Length < 3 || cityName.Length > 20)
                        {
                            Console.WriteLine("Seher en az 3 en cox 20 simvol olmalidir.");
                            Console.WriteLine("----------------------------------------------");
                        }
                        else
                        {
                            validCityName = true;
                        }

                    } while (!validCityName);

                    do
                    {
                        Console.WriteLine("-------------------------------------------");
                        Console.Write($"Seher ehali sayni daxil edin{i + 1}: ");
                        string populationInput = Console.ReadLine();

                        if (!int.TryParse(populationInput, out population) || population <= 0)
                        {
                            Console.WriteLine("1 den kicik eded daxil etmek olmaz");
                            Console.WriteLine("------------------------------------");
                        }
                        else
                        {
                            validPopulation = true;
                        }
                    } while (!validPopulation);

                    chinaCityArray[i] = new ChinaCity(cityName, population);
                }

                double averagePopulation = CalculateAveragePopulation(chinaCityArray);
                Console.WriteLine("Ehali sayi: " + averagePopulation);
            }
        }
    }
}




