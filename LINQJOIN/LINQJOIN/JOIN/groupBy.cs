using System;
using System.Collections.Generic;
using System.Linq;

var people = new List<Person>
{
    new Person { Name = "Alice", City = "New York" },
    new Person { Name = "Bob", City = "Los Angeles" },
    new Person { Name = "Charlie", City = "New York" },
    new Person { Name = "David", City = "Chicago" },
    new Person { Name = "Eve", City = "Los Angeles" }
};

//Linq Aggregate 
var cityCounts = people.GroupBy(p => p.City)
                       .Select(group => new
                       {
                           City = group.Key,
                           Count = group.Count()
                       });

foreach (var cityCount in cityCounts)
{
    Console.WriteLine($"{cityCount.City}: {cityCount.Count} people");
}