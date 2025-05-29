namespace MethodsExercise
{
    public class Program
    {
        public static void Story()
        {
            Console.WriteLine("Please enter your name:");
            string userName=Console.ReadLine();
            
            Console.WriteLine("Now please enter your favorite Color:");
            string userColor=Console.ReadLine();
            
            Console.WriteLine("Please enter your favorite number:");
            string userNumber=Console.ReadLine();
            
            Console.WriteLine("Please enter your animal:");
            string usersAnimal=Console.ReadLine();
            
            Console.WriteLine("Please enter your Favorite Band:");
            string usersBand=Console.ReadLine();

            Console.WriteLine($"Hello lets start story: Name of person: {userName},");
            Console.WriteLine($"favorite Color: {userColor},  favorite number: {userNumber},");
            Console.WriteLine($"animal: {usersAnimal}, Favorite Band: {usersBand}");
        }

        static int addNums(params int[] num1)
        {
            int sum=0;
            
            foreach (int num in num1)
            {
                sum += num;
            }

            return sum;
        }
        
        static int subNums(params int[] num1)
        {
            Console.WriteLine("Please enter Subtracting number");
            int sum = int.Parse(Console.ReadLine());
          
            foreach (int num in num1)
            {
                sum -= num;
            }

            return sum;
        }
        
        static int multiNums(params int[] num1)
        {
            Console.WriteLine("Please enter Multiplying number");
            int sum = int.Parse(Console.ReadLine());
            foreach (int num in num1)
            {
                sum *= num;
            }

            return sum;
        }
        
        static int divNums(params int[] num1)
        {
            Console.WriteLine("Please enter Dividing number");
            int sum = int.Parse(Console.ReadLine());
            
            foreach (int num in num1)
            {
                sum /= num;
            }

            return sum;
        }

        static void Main(string[] args)
        {
            
            Story();
         
            Console.WriteLine(addNums(1, 2, 3));
            Console.WriteLine(subNums(10, 6, 3));
            Console.WriteLine(multiNums(2, 2, 5));
            Console.WriteLine(divNums(4, 2, 3));
            
        }
    }
}
