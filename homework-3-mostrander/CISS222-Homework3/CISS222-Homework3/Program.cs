using System;

namespace CISS222_Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            USConstitution constitution = new USConstitution();
            USFacts facts = new USFacts();

            const string ConstitutionTitle = "Constitution of the United States of America";

            Console.WriteLine(ConstitutionTitle);
            Console.WriteLine();
            Console.WriteLine(constitution.preamble);
            Console.WriteLine(constitution.article1);
            Console.WriteLine(constitution.article2);
            Console.WriteLine(constitution.article3);
            Console.WriteLine(constitution.article4);
            Console.WriteLine(constitution.article5);
            //Console.WriteLine(constitution.article6);

            Console.ReadLine();

            // This is a control structure
            /*
            for (int i = 0; i < constitution.amendments.Length; i++)
            {
                Console.WriteLine(constitution.amendments[i]);
            }
            */

            Console.WriteLine("Date founded: " + facts.DateFounded);
            Console.WriteLine("Population: " + facts.Population);
            Console.WriteLine("Number of states: " + facts.NumberOfStates);
            Console.WriteLine("Current president: " + facts.CurrentPresident);
            Console.WriteLine("Current vice president: " + facts.CurrentVicePresident);

            try
            {
                int averageNumberOfCounties = facts.NumberOfCounties / facts.NumberOfStates;
                Console.WriteLine("Average number of counties: " + averageNumberOfCounties);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divide by zero!");
            }

            //This is the average GDP per person. Must obtain GDP from user before calculating.

            Console.WriteLine("Please input the Gross Domestic Product (GDP): ");
            float grossDomesticProduct = float.Parse(Console.ReadLine());
            //Made GDP variable float because it is likely to have a decimal value & it is monetary value too.

            float capitaGDP = grossDomesticProduct / facts.Population;
            Console.WriteLine($"GDP per capita: {capitaGDP:C}");
        }
    }
}
