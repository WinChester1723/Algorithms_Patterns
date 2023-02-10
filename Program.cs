using Algorithms_Patterns.Patterns.Generative_Patterns.AbstractFactory;
using Algorithms_Patterns.Patterns.Generative_Patterns.Builder;
using Algorithms_Patterns.Patterns.Generative_Patterns.Conceptual;

namespace Algorithms_Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region AbstractFactoryTest

            //Client client = new Client();
            //client.Main();

            #endregion

            #region Builder

            //var director = new Director();
            //var builder = new ConcreteBuilder();
            //director.Builder = builder;

            //Console.WriteLine("Standart bsaic product:");
            //director.BuildMinimalViableProduct();
            //Console.WriteLine(builder.GetProduct().ListParts());

            //Console.WriteLine("Standard full featured product:");
            //director.BuildFullFeaturedProduct();
            //Console.WriteLine(builder.GetProduct().ListParts());

            //Console.WriteLine("Custom product:");
            //builder.BuilderPartA();
            //builder.BuilderPartC();
            //Console.WriteLine(builder.GetProduct().ListParts());

            #endregion

            #region Factory

            //new Client().Main();

            #endregion

            #region Conceptual

            //Person p1 = new Person();
            //p1.Age = 42;
            //p1.BirthDate = Convert.ToDateTime("1977-01-01");
            //p1.Name = "Jack Daniels";
            //p1.IdInfo = new IdInfo(666);

            //Person p2 = p1.ShallowCopy();
            //Person p3 = p1.DeepCopy();

            //Console.WriteLine("Original values of p1, p2, p3:");
            //Console.WriteLine("   p1 instance values: ");
            //Display.DisplayValues(p1);
            //Console.WriteLine("   p2 instance values:");
            //Display.DisplayValues(p2);
            //Console.WriteLine("   p3 instance values:");
            //Display.DisplayValues(p3);

            //p1.Age = 32;
            //p1.BirthDate = Convert.ToDateTime("1900-01-01");
            //p1.Name = "Frank";
            //p1.IdInfo.IdNumber = 7878;
            //Console.WriteLine("\nValues of p1, p2 and p3 after changes to p1:");
            //Console.WriteLine("   p1 instance values: ");
            //Display.DisplayValues(p1);
            //Console.WriteLine("   p2 instance values (reference values have changed):");
            //Display.DisplayValues(p2);
            //Console.WriteLine("   p3 instance values (everything was kept the same):");
            //Display.DisplayValues(p3);


            #endregion

            Console.ReadLine();
        }

    }
}