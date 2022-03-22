// See https://aka.ms/new-console-template for more information

using LinqAndExtensions;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Person> person_list = new List<Person>
        {
            new Person {Age = 25, FirstName = "Daniel", LastName = "Filimon", Married = true, Ocupation = "Engineer"},
            new Person {Age = 20, FirstName = "Oana", LastName = "Aioanei", Married = false, Ocupation = "Student"},
            new Person {Age = 43, FirstName = "Ovidiu", LastName = "Bogosel", Married = true, Ocupation = "Programmer"},
            new Person {Age = 14, FirstName = "One", LastName = "Little", Married = false, Ocupation = "Pupil"},
            new Person {Age = 13, FirstName = "One", LastName = "Second", Married = false, Ocupation = "Pupil"},
            new Person {Age = 15, FirstName = "One", LastName = "Third", Married = false, Ocupation = "Pupil"},
            new Person {Age = 21, FirstName = "Ioana", LastName = "Aioanei", Married = false, Ocupation = "Student"},
            new Person {Age = 23, FirstName = "Alexia", LastName = "Aioanei", Married = true, Ocupation = "Student"},

        };
        List<Point> pointList = new List<Point>
        {
            new Point {X = 30, Y = 50},
            new Point {X = 17, Y = 30},
            new Point {X = 10, Y = -1 },
            new Point {X = 20, Y = -13},
            new Point {X = 30, Y = 30},
            new Point {X = 30, Y = 37}
        };

        Person unique_person = new Person { Age = 25, FirstName = "Daniel", LastName = "Filimon", Married = true, Ocupation = "Engineer" };
        Console.WriteLine(unique_person.IsAbleToVote());
        Console.WriteLine(unique_person.FullIdentity());

        int number = 5;
        Console.WriteLine(number.SecondPowerRaise());

        string word = "Sponge Bob Meme";
        Console.WriteLine(word.OneLowCaseOneUpperCase());

        //Filtering
        var maried_able_to_vote_people = person_list.Where(person => (person.Married && person.Age >= 18));
        PrintCollection(maried_able_to_vote_people);
        Console.WriteLine();

        //Ordering
        var orderByAbciseThenByOrdonate = pointList.OrderBy(point => point.X).ThenBy(point => point.Y);
        PrintCollection(orderByAbciseThenByOrdonate);
        Console.WriteLine();

        var orderByDistanceToTheCenterOfOrigin = pointList.OrderBy(point => point.X * point.X + point.Y * point.Y);
        PrintCollection(orderByAbciseThenByOrdonate);
        Console.WriteLine();

        //Quantifiers
        var isAnyMarried = person_list.Any(person => person.Married);
        Console.WriteLine(isAnyMarried);
        var areAllAbleToVote = person_list.All(person => person.Age >= 18);
        Console.WriteLine(areAllAbleToVote);
        Console.WriteLine();

        //Projection
        var Occupations = person_list.Select(person => person.Ocupation);
        PrintCollection(Occupations);
        Console.WriteLine();

        //Gropuing
        var groupedByOccupation = person_list.GroupBy(person => person.Ocupation);

        foreach(var occupation in groupedByOccupation)
        {
            Console.WriteLine(occupation.Key);
            foreach(var person in occupation)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine();
        }

        //Generation
        var emptyCollectionOfPoints = Enumerable.Empty<Point>();

        Point repeatedPoint = new Point { X = 15, Y = 20 };

        var repeatedPointsCollection = Enumerable.Repeat<Point>(repeatedPoint, 10);
        PrintCollection(repeatedPointsCollection);
        Console.WriteLine();

        //Element Operations

        var firstElementOfOrderByAbciseThenByOrdonate = orderByAbciseThenByOrdonate.First();
        Console.WriteLine(firstElementOfOrderByAbciseThenByOrdonate);
        Console.WriteLine();

        //Data Conversion
        Dictionary<int, Person> personDicitonary = person_list.ToDictionary(person => person.Age);
        foreach(var dictionaryEntry in personDicitonary)
        {
            Console.WriteLine($"({dictionaryEntry.Key}, {dictionaryEntry.Value.FirstName})");
        }
        Console.WriteLine();

        //Aggregation
        var avgAbscise = pointList.Average(point => point.X);
        Console.WriteLine(avgAbscise);
        Console.WriteLine();

        //SetOperations
        HashSet<Point> pointSet1 = new HashSet<Point>();
        HashSet<Point> pointSet2 = new HashSet<Point>();

        Point commonPoint = new Point { X = 15, Y = 20 };

        pointSet1.Add(new Point { X = 30, Y = 15 });
        pointSet1.Add(commonPoint);
        pointSet1.Add(new Point { X = 10, Y = 10});

        pointSet2.Add(commonPoint);
        pointSet2.Add(new Point { X = 5, Y = 5 });

        IEnumerable<Point> reunion = pointSet1.Intersect(pointSet2);
        PrintCollection(reunion);
        Console.WriteLine();

        //joins
        List<Employee> employeeList = new List<Employee>()
        {
            new Employee { Name = "employee1", CompanyName = "Amdaris"},
            new Employee { Name = "employee2", CompanyName = "Amdaris"},
            new Employee { Name = "intelEmployee", CompanyName = "Intel"},
            new Employee { Name = "bitDefenderEmployee", CompanyName = "BitDefender"},
            new Employee { Name = "employee3", CompanyName = "Amdaris"}
        };
        List<Company> companyList = new List<Company>()
        {
            new Company { Name = "Amdaris", Revenue = 100},
            new Company { Name = "Continental", Revenue = 79.2},
            new Company { Name = "Hella", Revenue = 139}
        };

        var join1 = from employee in employeeList
                    join company in companyList on employee.CompanyName equals company.Name
                    select new { employeeName = employee.Name, companyName = company.Name };
        PrintCollection(join1);



    }
    private static void PrintCollection<T>(IEnumerable<T> source)
    {
        foreach (var item in source)
        {
            Console.WriteLine(item);
        }
    }

}

