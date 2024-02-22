namespace CMS.UI.Models;

public class Staff{
    string name;
    int id;
    private string department;

    public Staff(string name, int id){
        Console.WriteLine("Constructor called");
        
        this.name = name;
        this.id = id;
    }

    ~Staff(){
        Console.WriteLine($"Destructor gets called ");
    }


    public string getName(){
        return this.name;
    }
    public int getId(){
        return this.id;
    }


    //Property
    public string Department{
        get{
            return this.department;
        }

        set{
            department = value;
        }
    }


    //Auto Property
    public string Address{
        get;
        set;
    }
    
    //Auto-Property
    public int Salary { get; set; }

    //Passing Parameters
    public void CalculateFees(decimal electiveFess, ref decimal roughFees, out decimal finalFees){
        electiveFess = 10000;
        roughFees = 10000;
        finalFees = 10000;
    }

    //Method overloading

    public void updateInfo(string name){
        this.name = name;
    }


    public int updateInfo(int id){
        return this.id = id;
    }


    //Default parameters

    public void updateInfo(string name, int id = 0){
        this.name = name;
        this.id = id;
    }
};