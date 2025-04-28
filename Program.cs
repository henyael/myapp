using System;
using System.Collections.Generic;


namespace Hen{
public class Person
{
    public string Name { get; set; }
    public string City { get; set; }
    public int Age { get; set; }

public Person(string name, string city, int age)
        {
            Name = name;
            City = city;
            Age = age;
        }
}

public class CheckingSocialCircle{
    public List<Person>People;

public void Init(Person[] people){
    this.people=people.ToList();
}
bool AreInSameSocialCircle(Person personA, Person personB)
{
if( personA==personB){
    return true;
}

Queue<Person> queue=new Queue<Person>();
HashSet<Person> visited=new HashSet<Person>();
queue.Enqueue(personA);
visited.Add(personA);
while(queue.Count>0)
var current=queue.Dequeue();
{
foreach(var item in people)
{
    if(!visited.Contain(item)&&(item.City==current.City||item.Age==current.Age))
    {
        if(personB==item)
        {
         return true;
         }
        queue.Enqueue(item);
        visited.Add(item);
    }
}
}
    return false;

}
}

class Program{

static public void Main (string[] args)
{
Person Person1=new Person("Dan","Tel Aviv",25);
Person Person2=new Person("Yossi","Tel Aviv",30);
Person Person3=new Person("Beni","Haifa",25);
Person Person4=new Person("Omer","Jerusalem",40);

People.Add(Person1);
People.Add(Person2);
People.Add(Person3);
People.Add(Person4);

CheckingSocialCircle.AreInSameSocialCircle(people);
}

}
}