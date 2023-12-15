using System;

namespace reyhaneh_rajaee2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            byte age;
            int height;
            Console.WriteLine("enter your age:");
            age = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("enter your height:");
            height = Convert.ToInt32(Console.ReadLine());
            bool teenager;
            teenager = (age < 30) ? true : false;
            if (teenager)//=> if (teenager==true)
            {
                if ( height < 150)
                    Console.WriteLine( "you are a teenager very short height");
                else if ( height > 150 && height < 160 ) 
                Console.WriteLine  ( "you are a teenager with short height");


                 else if ( height > 160 && height < 170) 
                Console.WriteLine( "you are a teenager with medium height" );
              else
                {
                    Console.WriteLine("you are a teenager with high height");
                }
            }

            else
            {
                if (height < 150)
                    Console.WriteLine("you are a teenager with very short height");
                else if (height > 150 && height < 160)
                    Console.WriteLine("you are a young with short height");
                else if (height > 160 && height < 170)
                    Console.WriteLine("you are a young with medium height");
                else
                    Console.WriteLine("you are a young with high height");

            }











        }    



      
    }
}
