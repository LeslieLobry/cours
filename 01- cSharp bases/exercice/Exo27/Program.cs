
//while(compteur <= 100)
//{
//    compteur++;
//    if (compteur % 5 == 0 && compteur % 3 == 0)
//    {
//        Console.WriteLine("FizzBuzz");
//        if (compteur % 3 == 0)
//        {
//            Console.WriteLine("Fizz");
//        }
//        else if (compteur % 5 == 0)
//        {
//            Console.WriteLine("Buzz");
//        }
//    }
//    else
//        Console.WriteLine(compteur);
//    }
   

for (int compteur =1; compteur < 100; compteur++)
{
    if ( compteur % 3 == 0 && compteur % 5 == 0)
    {
        Console.WriteLine("Fizzbuzz");
    }
    else if (compteur % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (compteur % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
        Console.WriteLine(compteur);
}