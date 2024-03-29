using System;

namespace custom_application_exception;


// We can define our own custom Application Exception class which needs to inherit the ApplicationException class
public class DivisionByOdd : ApplicationException{

    // Remember the ApplicationException class have a Property class "Message" which is virtual in nature and we can override that property in our
    // own custom ApplicationException class
    public override string Message{
        get{
            return "Attempted to divide by odd number";
        }
    }
};

class Program{
    public static void Main(string[] args){
        try{
            Console.Write("Enter the value of x : ");
            int x = int.Parse(Console.ReadLine());
            
            Console.Write("Enter the value of y : ");
            int y = int.Parse(Console.ReadLine());

            if(y % 2 != 0){
                // throw new ApplicationException("Division by odd number is not allowed in this application");
                throw new DivisionByOdd();
            }

            int z = x / y;

        }

        catch(DivisionByOdd ex){
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("End of the Program");
    }
}