using System;

namespace Queens
{
    class Program
    {
        
      
        static void Main(string[] args)
        {

            NQueens q = new NQueens(4);
            q.AllOptions();
            Console.ReadKey();
        }
    }
}
