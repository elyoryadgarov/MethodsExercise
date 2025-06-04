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

        static int AddNums(params int[] num1)
        {
            int sum=0;
            
            foreach (int num in num1)
            {
                sum += num;
            }

            return sum;
        }
        
        static int SubNums(params int[] num1)
        {
            
            int sum = 0;
          
            foreach (int num in num1)
            {
                sum -= num;
            }

            return sum;
        }
        
        static int MultiNums(params int[] num1)
        {
            
            int sum = 0;
            foreach (int num in num1)
            {
                sum *= num;
            }

            return sum;
        }
        
        static int DivNums(params int[] num1)
        {
            
            int sum = 0;
            
            foreach (int num in num1)
            {
                sum /= num;
            }

            return sum;
        }

        static void Main(string[] args)
        {
            
            Story();
         
            Console.WriteLine(AddNums(1, 2, 3));
            Console.WriteLine(SubNums(10, 6, 3));
            Console.WriteLine(MultiNums(2, 2, 5));
            Console.WriteLine(DivNums(4, 2, 3));
            
        }
    }
}
