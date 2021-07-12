using System;

namespace Rhythmic_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is the answer to number 2

           int a, b, c, d, e, f, n1, n2, n3, x, y;
                 // first element of the matrix
                 Console.WriteLine("input first element of the matrix:_");
                 a  = Convert.ToInt32(Console.ReadLine()); 
                 Console.WriteLine(a + " is the first element of the matrix");

                 // second element of the matrix
                 Console.WriteLine("input second element of the matrix:_"); 
                 b  = Convert.ToInt32(Console.ReadLine()); 

                   // third element of the matrix
                 Console.WriteLine("input third element of the matrix:_"); 
                 c  = Convert.ToInt32(Console.ReadLine()); 

                   // fourth element of the matrix
                 Console.WriteLine("input fourth element of the matrix:_"); 
                 d  = Convert.ToInt32(Console.ReadLine()); 


                   // fifth element of the matrix
                 Console.WriteLine("input fifth element of the matrix:_"); 
                 e  = Convert.ToInt32(Console.ReadLine()); 

                   // sixth element of the matrix
                 Console.WriteLine("input sixth element of the matrix:_"); 
                 f  = Convert.ToInt32(Console.ReadLine()); 

                 // now to find n1
                  n1 = Convert.ToInt32(a*d - b*c); 
                  Console.WriteLine(n1);
                   Console.WriteLine("our n1 is equals to" + n1);
                   if(n1 == 0){
                       Console.WriteLine("The Equation has no solution");   
                   }
                  

                   // now to find n2
                  n2 = Convert.ToInt32(e*d - f*c); 
                  Console.WriteLine(n2);
                   Console.WriteLine("our n3 is equals to " + n2);



                 // now to find n3
                  n3 = Convert.ToInt32(a*f - b*e); 
                  Console.WriteLine(n3);
                   Console.WriteLine("our n2 is equals to " + n3);

                   //now to find x 
                   x = Convert.ToInt32(n2 / n1); 
                  Console.WriteLine(x);
                   Console.WriteLine("our x is equals to " + x);

                   //now to find y 
                   y = Convert.ToInt32(n3 / n1); 
                  Console.WriteLine(y);
                   Console.WriteLine("our y is equals to " + y);


                   
                  


        }
    }
}
