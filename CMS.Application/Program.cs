using System;
namespace CMS.Applicaiton;
using CMS.UI.Models;
using CMS.UI.Display;

class Program{
    static void Main(string[] args){
        Student st = new Student();

        st.firstName = "Utkarsh";
        st.lastName = "Chouhan";
        st.id = 1;

        Console.WriteLine("First name : " + st.firstName);
        Console.WriteLine("Last name : " + st.firstName);
        Console.WriteLine("Student id : " + st.firstName);


        //  all the public feilds i.e. the variable sof the class can be instatiated during the creation of the object
        Student st1 = new Student(){
            firstName = "Mayank",
            lastName = "Chouahn",
            id = 2
        };

        Console.WriteLine("First name : " + st1.firstName);
        Console.WriteLine("Last name : " + st1.firstName);
        Console.WriteLine("Student id : " + st1.firstName);

        Student st2 = new Student();
        Console.WriteLine("First name : " + st2.firstName);
        Console.WriteLine("last name : " + st2.lastName);
        Console.WriteLine("id name : " + st2.id);

        // ======================================
        // static variable

        Console.WriteLine(Student.maxBooksAllowed);

        // ==============================
        // Value type and Reference Type

        int a = 10;
        Console.WriteLine(a);
        int b = a;

        b = 20;
        Console.WriteLine(a);


        Student student1 = new Student();
        Student student2 = new Student();

        student1.firstName = "Utkarsh";

        student2 = student1;    ///After this assignment statement both student1 and student2 referes to the same statement

        Console.WriteLine(student2.firstName);

        student2.firstName = "Mayank";
        Console.WriteLine(student1.firstName);



        // ============= Staff Class ===============
        Staff stf = new Staff("Utkarsh", 1);


        Console.WriteLine("Name : " + stf.getName());
        Console.WriteLine("Id : " + stf.getId());

        //this syntax is similar to template literal in javascript 
        Console.WriteLine($"Id :  {stf.getId()}");

        //Constructor and Destructor
        Staff stf1 = new Staff("Mayank", 2);

        //Property
        stf1.Department = "Frontend";
        Console.WriteLine(stf1.Department);

        //Auto-Property
        stf1.Address = "Phagwara";
        Console.WriteLine(stf1.Address);




        //Passing Parameters
        decimal electiveFess = 5000;
        decimal roughFees = 5000;
        decimal finalFees = 5000;

        Console.WriteLine($"electiveFess : {electiveFess} and roughFees : {roughFees} and finalFees : {finalFees} .");

        stf1.CalculateFees(electiveFess, ref roughFees, out finalFees);

        Console.WriteLine($"electiveFess : {electiveFess} and roughFees : {roughFees} and finalFees : {finalFees} .");



        //Using the Static class
        Display.show("I am inside the show method of the Display static-class");
    }
}
