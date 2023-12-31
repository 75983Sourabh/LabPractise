namespace HR;
public class Employee{
    private int id ;
    public int Id{
        get{return this.id;}
        set{this.id=value;
        }
    }
    public string FullName{
        get;set;
    }
    public Employee():this(56,"Rakesh Lowanshi"){

    }
    public Employee(int id,string fullName){
        this.id=id;
        this.FullName=fullName;
    }
    public virtual float ComputePay(){
        return 56000;
    }
    public override string ToString(){
        return id+" "+FullName;
    }
}