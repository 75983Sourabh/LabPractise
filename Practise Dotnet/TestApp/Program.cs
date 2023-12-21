using HR;
Employee e1=new Employee();
WageEmployee wg1=new WageEmployee();
SalesEmployee sales1=new SalesEmployee();
List<Employee>employees=new List<Employee>();
employees.Add(e1);
employees.Add(wg1);
employees.Add(sales1);

foreach (Employee emp in employees)
{
 Console.WriteLine(emp);
 Console.WriteLine(emp.ComputePay());


}
int amount =67;
Console.WriteLine(amount);
float cost=amount;

int latestAmount=(int) cost;
WageEmployee wg3=sales1;
SalesEmployee latestSalesEmp=wg3 as SalesEmployee;



if(latestSalesEmp is SalesEmployee){
    
}
int instanceCount =SalesEmployee.count;