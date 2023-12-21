namespace HR;
public class WageEmployee:Employee{

    public int WorkingHours{get;set;}
    
    public WageEmployee(int id,string fullName,int hours){
        this.WorkingHours=hours;
    }
    
    
    public WageEmployee():this(1,"Sourah Lowanshi",700){

    }
    
    public override float ComputePay(){
        return base.ComputePay()+WorkingHours*600;
    }
    
    public override string ToString(){

        return base.ToString()+"Working hours :"+WorkingHours;
    }








}
