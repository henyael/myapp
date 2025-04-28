using System;
using System.Collections.Generic;

namespace Hen{

class Customer
{
    public string Name { get; set; }
    public int TicketNumber { get; set; }

 public Customer(string name, int ticketNumber){
        Name=name;
        TicketNumber=ticketNumber;
 }   
}

class Program
{
static public Queue<Customer> Customerqueue=new Queue<Customer>();

static public void Search(string a){
bool found=false;
foreach(Customer item in Customerqueue){
if(item.Name==a){
Console.WriteLine($"Yey, there is a match in the name, the ticket num is{item.TicketNumber}");
found=true;
break;
}

}
if(found==false){
    Console.WriteLine("Sorry, we didnt find any match");
}
}
static public void Main(string[]args){
Customer customer1=new Customer("Hen",1);
Customer customer2=new Customer("Gal",2);
Customer customer3=new Customer("Avi",3);
Customer customer4=new Customer("Dan",4);
Customer customer5=new Customer("Ron",5);
Customerqueue.Enqueue(customer1);
Customerqueue.Enqueue(customer2);
Customerqueue.Enqueue(customer3);
Customerqueue.Enqueue(customer4);
Customerqueue.Enqueue(customer5);

Console.WriteLine("Hey user,pls enter a name");
string name=Console.ReadLine();
Search(name);

}
}
}