using HR;
using Graphics;


Boolean status=false;

char ch='u';
int count=56;
count ++;
int []arr=[91,44,306,303];

string fullName="Hello Good Morning";
Console.WriteLine(fullName);
Console.WriteLine("Sourabh Lowanshi");
if(count>=100){
    Console.WriteLine("You are a Rider");

}else{
    Console.WriteLine("You are a Ultimate Bike Rider");

}
for(int i=0;i<arr.Length;i++){
    Console.WriteLine(arr[i]);

}
Person prn=new Person (22,"Sourabh","Lowanshi");
string objFname=prn.getFirstName();
prn.LastName="Lodha";
string anotherLastName=prn.LastName;
string strPerson=prn.ToString();

Console.WriteLine(strPerson);

Color myColor=new Color(255,0,0);