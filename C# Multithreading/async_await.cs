using System;

namespace async_await;

class Program{
    public static void func1(){
        Console.WriteLine("fucn 1 starting ...");
        Thread.Sleep(4000);
        Console.WriteLine("fucn 1 ending");
    }


    public static void func2(){
        Console.WriteLine("fucn 2 starting ...");
        Thread.Sleep(2000);
        Console.WriteLine("fucn 2 ending");
    }


    public static void func3(){
        Console.WriteLine("fucn 3 starting ...");
        Thread.Sleep(5000);
        Console.WriteLine("fucn 3 ending");
    }


    public static void func4(){
        Console.WriteLine("fucn 4 starting ...");
        Thread.Sleep(1000);
        Console.WriteLine("fucn 4 ending");
    }




    public static void Main(String[] args){
        Thread t1 = new Thread(func1);
        Thread t2 = new Thread(func2);
        Thread t3 = new Thread(func3);
        Thread t4 = new Thread(func4);

        t1.Start();
        t2.Start();
        t3.Start();
        t4.Start();
         

    }
}


// Async and await are ht etwo keywords that helps us to acheive the asynchronous programming

// An "async" keyword is a method that performs asynchronous tasks such as "fetching data from the databaase,
// "reading a file" etc they can be marked as 'async;