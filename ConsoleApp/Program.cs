using Classes;
using System;

namespace ConsoleApp;






public class Program{

    public static void Main(string [] args){
        Student student = new Student("Utkarsh", "Chouhan");
        
        Console.WriteLine(student. FirstName);

        //Implicit casting
        Person p = new Student("Mayank", " Singh");

        // Console.WriteLine(p.FirstName);
        // Console.WriteLine(p.LastName);
        Console.WriteLine(p.GetFullName());

    }
};