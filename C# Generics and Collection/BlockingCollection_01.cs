using System;
using System.Threading;
using System.Collections.Concurrent;

namespace BlockingCollection_01;

class Program{

    static BlockingCollection<string> queue = new BlockingCollection<string>(boundedCapacity:10);


    static void Producer(){
        string inp = Console.ReadLine();

        queue.Add(inp);
    }

    static void Consumer(){
        string val = queue.Take();

        Console.WriteLine($"Consumed: {val}");
    }

    
    public static void main(string[] args){
        Thread pt = new Thread(Producer);
        Thread ct = new Thread(Consumer);

        pt.Start();
        ct.Start();

        pt.Join();
        ct.Join();

    }
}