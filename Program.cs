using Algorithms_Patterns.Patterns.Generative_Patterns.AbstractFactory;
using Algorithms_Patterns.Patterns.Generative_Patterns.Builder;
using Algorithms_Patterns.Patterns.Generative_Patterns.Conceptual;
using Algorithms_Patterns.Patterns.Generative_Patterns.Singleton;
using Algorithms_Patterns.Patterns.Structural_Patterns.Adapter;
using Algorithms_Patterns.Patterns.Structural_Patterns.Bridge;
using Algorithms_Patterns.Patterns.Structural_Patterns.Composite;
using Algorithms_Patterns.Patterns.Structural_Patterns.Decorator;
using Algorithms_Patterns.Patterns.Structural_Patterns.Facade;

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

            #region Singleton

            //Singleton s1 = new Singleton();
            //Singleton s2 = new Singleton();

            //if (s1 == s2)
            //{
            //    Console.WriteLine("Singleton works, both variables contain the same instance.");
            //}
            //else
            //{
            //    Console.WriteLine("Singleton failed, variables contain different instances.");
            //}

            #endregion

            #region Adapter

            //Adaptee adaptee = new Adaptee();
            //ITarget target = new Adapter(adaptee);

            //Console.WriteLine("Adaptee interface is incompatible with the client.");
            //Console.WriteLine("But with adapter client can call it's method.");

            //Console.WriteLine(target.GetRequest());

            #endregion

            #region Bridge

            //Clients clients = new Clients();

            //Abstraction abstraction;
            //abstraction = new Abstraction(new ConcreteImplementationA());
            //clients.CLienCode(abstraction);

            //Console.WriteLine();

            //abstraction = new ExtendedAbstration(new ConcreteImplementationB());
            //clients.CLienCode(abstraction);

            #endregion

            #region Composite

            //ClientComposite client = new ClientComposite();

            //Leaf leaf = new Leaf();
            //Console.WriteLine("Client: I get a simple component:");
            //client.ClientCode(leaf);

            //Composite tree = new Composite();
            //Composite branch1 = new Composite();
            //branch1.Add(new Leaf());
            //branch1.Add(new Leaf());
            //Composite branch2 = new Composite();
            //branch2.Add(new Leaf());
            //tree.Add(branch1);
            //tree.Add(branch2);
            //Console.WriteLine("Client: Now I've got a composite tree:");
            //client.ClientCode(tree);

            //Console.Write("Client: I don't need to check the components classes even when managing the tree:\n");
            //client.ClientCode2(tree, leaf);

            #endregion

            #region Decorator

            //ClientDecorator client = new ClientDecorator();

            //var simple = new ConcreteComponentDecorator(); 
            //Console.WriteLine("Client: I get a simple component:");
            //client.ClientCode(simple);
            //Console.WriteLine();

            //ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(simple);
            //ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(decorator1);
            //Console.WriteLine("Client: Now I've got a decorated component:");
            //client.ClientCode(decorator2);

            #endregion

            #region Facade

            //Subsystem1 subsystem1 = new Subsystem1();
            //Subsystem2 subsystem2 = new Subsystem2();
            //Facade facade = new Facade(subsystem1, subsystem2);
            //ClientFacade.ClientCode(facade);

            #endregion

            Console.ReadLine();
        }

    }
}