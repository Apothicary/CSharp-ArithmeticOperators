namespace ArithmeticOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int friends = 10;

            // Below are examples in increments

             friends = friends + 2; 
             friends += 2;          // Shortcut to the above
             friends++;             // This way is found in loops and only increments in 1


            // Below are examples of decrements

             friends = friends -1; 
             friends -= 1;          // shortcut of the above  
             friends--;             // This way is found in loops and only decrements in 1


            // Below are examples of multiplication 

             friends = friends * 2; 
             friends *= 2;          // Shortcut of the above

            // Below are examples of division

             friends = friends / 2; // This will show as whole number as we are using int not double
             friends /= 2;


            // Below are examples of modulus/remainder 

            int remainder = friends % 3; 

            Console.WriteLine(friends);
            Console.ReadKey();
        }
    }
}
