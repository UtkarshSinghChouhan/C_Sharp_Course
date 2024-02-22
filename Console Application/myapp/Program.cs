using System;

namespace Numbers{
    class Program{
        static void Main(string[] args){
            // int i = 10;
            // Console.WriteLine(i);

            // int j = int.Parse(Console.ReadLine());
            // Console.WriteLine(j);

            // string[] days = new string[]{
            //     "Sunday",
            //     "Monday",
            //     "Tuesday",
            //     "Wednesday"
            // };

            // Console.WriteLine(days[3]);

            // int a = 1, b = 2;
            // Console.WriteLine($"a = {a} and b = {b}");


            // char ch;

            // Console.WriteLine("Enter your favourite subject : ");
            // ch = (char)Console.Read();

            // if(ch == 'e'){
            //     Console.WriteLine("Favourite subject is english");
            // }else{
            //     Console.WriteLine("english not favourite subject");
            // }


            // switch(ch){
            //     case 'e':
            //     {
            //         Console.WriteLine("Favourite subject is english");
            //         break;
            //     }

            //     default:{
            //         Console.WriteLine("Favourite subject is not english");
            //         break;

            //     }
            // }



            int inp; 
            Console.WriteLine("Enter a Number : ");
            inp = int.Parse(Console.ReadLine());

            int i = 0;
            while(i < inp){
                Console.Write(i + " ");
                i++;
            }
            Console.Write('\n');

            for(int j = 0; j < inp; j++){
                Console.Write(j + " ");
            }



        }
    }
}