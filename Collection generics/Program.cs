//Christian Rapp SUT23
using System.ComponentModel;

namespace Collection_generics

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee em1 = new Employee(1,"Hans","Male",27000);
            Employee em2 = new Employee(2,"Keneth","Male",23000);
            Employee em3 = new Employee(3,"Lisa","Female",33000);
            Employee em4 = new Employee(4,"Aquillian","Female",45000);
            Employee em5 = new Employee(5,"Tina","Female",22000);




            //Stack<Employee> stack = new Stack<Employee>();

            //stack.Push(em1);
            
            //stack.Push(em2);
            
            //stack.Push(em3);
           
            //stack.Push(em4);
            
            //stack.Push(em5);
            

            //foreach (Employee em in stack)
            //{
            //    Console.WriteLine(em.ToString());
            //    Console.WriteLine(" ");
            //    Console.WriteLine($"Number of items left in stack: {stack.Count}");


            //}
            //Console.WriteLine("-------------------------------------");

            //List<Employee> TempList = new List<Employee>(stack);

            //foreach (Employee em in TempList)
            //{
            //    Console.WriteLine("Retrive Using Pop Method");
            //    Console.WriteLine(em.ToString());
            //    stack.Pop();
            //    Console.WriteLine($"Number of items left in stack: {stack.Count}");
               
            //}
            //Console.WriteLine("-------------------------------------");
            //// pushar tillbaka objekt till list.
            //foreach (Employee em in TempList)
            //{
            //    stack.Push(em);
                
            //}

            //if(stack.Count > 0)
            //{
            //    Console.WriteLine("Retrive Using Peek Method");
                
            //    Employee TopElement = stack.Peek();
            //    Console.WriteLine(TopElement.ToString());
            //    Console.WriteLine($"Number of items left in stack: {stack.Count}");
                
            //    Employee TopElement1 = stack.Peek();
                
            //    Console.WriteLine(TopElement1.ToString());
            //    Console.WriteLine($"Number of items left in stack: {stack.Count}");
            //}
            //Console.WriteLine("-------------------------------------");
            
            //bool contains3 = stack.Contains(em3);

            //if(contains3 )
            //{
            //    Console.WriteLine("em3 is in the stack");
            //}
            
            // del 2 

            List<Employee> list = new List<Employee>();

            list.Add(em1);
            list.Add(em2);
            list.Add(em3);
            list.Add(em4);
            list.Add(em5);

            



            Console.ReadKey();
        }
    }
}