// See https://aka.ms/new-console-template for more information

using LinqAndExtensions;
using System.Collections.Generic;
using System.Linq;

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
            new Point {X = 30, Y = 37},
            new Point3D {X = 30, Y = 15, Z = 14},
            new Point3D {X = 20, Y = 10, Z = 14}
        };
        List<int> integerList = new List<int> { 3, 5, 6, 6 };

        Person unique_person = new Person { Age = 25, FirstName = "Daniel", LastName = "Filimon", Married = true, Ocupation = "Engineer" };
        Console.WriteLine(unique_person.IsAbleToVote());
        Console.WriteLine(unique_person.FullIdentity());

        int number = 5;
        Console.WriteLine(number.SecondPowerRaise());

        string word = "Sponge Bob Meme";
        Console.WriteLine(word.OneLowCaseOneUpperCase());
        Console.WriteLine();

        //Filtering
        Console.WriteLine("Filtering");
        var maried_able_to_vote_people = person_list.Where(person => (person.Married && person.Age >= 18));
        PrintCollection(maried_able_to_vote_people);
        Console.WriteLine();

        var first2People = person_list.Take(1);
        PrintCollection(first2People);
        Console.WriteLine();

        var skipFirst2 = person_list.Skip(2);
        PrintCollection(skipFirst2);
        Console.WriteLine();

        var takeWhileOver18 = person_list.TakeWhile(person => person.Age >= 18);
        PrintCollection(takeWhileOver18);
        Console.WriteLine();

        var skipWhileOver18 = person_list.SkipWhile(person => person.Age >= 18);
        PrintCollection(skipWhileOver18);
        Console.WriteLine();

        var distinctIntgers = integerList.Distinct();
        PrintCollection(distinctIntgers);
        Console.WriteLine();



        //Ordering
        Console.WriteLine("Ordering");
        var orderByAbciseThenByOrdonate = pointList.OrderBy(point => point.X).ThenBy(point => point.Y);
        PrintCollection(orderByAbciseThenByOrdonate);
        Console.WriteLine();

        var orderByDescendingAbsciseCoordinate = pointList.OrderByDescending(point => point.X);
        PrintCollection(orderByDescendingAbsciseCoordinate);
        Console.WriteLine();

        var orderByDistanceToTheCenterOfOrigin = pointList.OrderBy(point => point.X * point.X + point.Y * point.Y);
        PrintCollection(orderByAbciseThenByOrdonate);
        Console.WriteLine();

        PrintCollection(pointList);
        pointList.Reverse();
        PrintCollection(pointList);
        Console.WriteLine();



        //Quantifiers
        Console.WriteLine("Quantifiers");
        var isAnyMarried = person_list.Any(person => person.Married);
        Console.WriteLine(isAnyMarried);
        var areAllAbleToVote = person_list.All(person => person.Age >= 18);
        Console.WriteLine(areAllAbleToVote);
        var isThereAny3 = integerList.Contains(3);
        Console.WriteLine(isThereAny3);
        var areTheseEqual = integerList.SequenceEqual(new List<int> { 3, 5, 6, 6 });
        Console.WriteLine(areTheseEqual);
        Console.WriteLine();



        //Projection
        Console.WriteLine("Projection");
        List<NestedCollection> nestedCollections = new List<NestedCollection>()
        {
            new NestedCollection { SomeAttribute = 1, StringCollection = new List<string>{ "Hello", "there" } },
            new NestedCollection { SomeAttribute = 2, StringCollection = new List<string>{ "General", "Kenobi"} },
        };
        var Occupations = person_list.Select(person => person.Ocupation);
        PrintCollection(Occupations);
        Console.WriteLine();
        var allStringsWithinNestedCollection = nestedCollections.SelectMany(x => x.StringCollection);
        PrintCollection(allStringsWithinNestedCollection);
        Console.WriteLine();



        //Grouping
        Console.WriteLine("Gropuing");
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
        Console.WriteLine("Generation");
        var emptyCollectionOfPoints = Enumerable.Empty<Point>();

        Point repeatedPoint = new Point { X = 15, Y = 20 };

        var repeatedPointsCollection = Enumerable.Repeat<Point>(repeatedPoint, 10);
        PrintCollection(repeatedPointsCollection);
        Console.WriteLine();
        var range = Enumerable.Range(100, 10);
        PrintCollection(range);
        Console.WriteLine();



        //Element Operations
        Console.WriteLine("Element Operations");
        var firstElementOfOrderByAbciseThenByOrdonate = orderByAbciseThenByOrdonate.First();
        var lastElementOfOrderByAbciseThenByOrdonate = orderByAbciseThenByOrdonate.Last();
        var singleElementOfOrderByAbciseThenByOrdonate = new List<int> { 1 }.Single();
        var ElementAtWithinOrderByAbciseThenByOrdonate = orderByAbciseThenByOrdonate.ElementAt(3);

        Console.WriteLine(firstElementOfOrderByAbciseThenByOrdonate);
        Console.WriteLine(lastElementOfOrderByAbciseThenByOrdonate);
        Console.WriteLine(singleElementOfOrderByAbciseThenByOrdonate);
        Console.WriteLine(ElementAtWithinOrderByAbciseThenByOrdonate);
        Console.WriteLine();



        //Data Conversion
        Console.WriteLine("Data Conversion");
        Dictionary<int, Person> personDicitonary = person_list.ToDictionary(person => person.Age);
        foreach(var dictionaryEntry in personDicitonary)
        {
            Console.WriteLine($"({dictionaryEntry.Key}, {dictionaryEntry.Value.FirstName})");
        }
        Console.WriteLine();
        var personOver18List = person_list.Where(person => person.Age > 18).ToList();
        var personOver18Array = person_list.Where(person => person.Age > 18).ToArray();
        var only3DPoints = pointList.OfType<Point3D>();
        PrintCollection(only3DPoints);
        Console.WriteLine();
        var only3DPointCastedto2DPoints = only3DPoints.Cast<Point>();
        var only3DPointCastedtoIEnumerable = only3DPoints.AsEnumerable<Point>();



        //Aggregation
        Console.WriteLine("Aggregation");
        var howManyPoints = pointList.Count();
        var minPointByAbscise = pointList.Min(point => point.X);
        var maxPointByAbscise = pointList.Max(point => point.X);
        var sumAbscise = pointList.Sum(point => point.X);
        var avgAbscise = pointList.Average(point => point.X);

        var allPeopleFirstNames = person_list.Aggregate("", (s1, person) => person.FirstName + ", " + s1);
        allPeopleFirstNames = allPeopleFirstNames.Substring(0, allPeopleFirstNames.Length - 2);
        Console.WriteLine(allPeopleFirstNames);
        Console.WriteLine();

        Console.WriteLine(howManyPoints);
        Console.WriteLine(minPointByAbscise);
        Console.WriteLine(maxPointByAbscise);
        Console.WriteLine(sumAbscise);
        Console.WriteLine(avgAbscise);
        Console.WriteLine();

        //SetOperations
        Console.WriteLine("SetOperations");
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

        List<int> numberList1 = new List<int> { 1, 2, 3, 4, 5 };
        List<int> numberList2 = new List<int> { 3, 4, 5, 6, 7 };
        var concatList1List2 = numberList1.Concat(numberList2);
        var unionList1List2 = numberList1.Union(numberList2);
        var list1MinusList2 = numberList1.Except(numberList2);

        PrintCollection(concatList1List2);
        Console.WriteLine();

        PrintCollection(unionList1List2);
        Console.WriteLine();

        PrintCollection(list1MinusList2);
        Console.WriteLine();



        //joins
        Console.WriteLine("joins");
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

        var employeesByCompany = from company in companyList
                                 join employee in employeeList on company.Name equals employee.CompanyName into employeesGroupedByCompany
                                 select new { company.Name, employeesGroupedByCompany };

        PrintCollection(join1);
        Console.WriteLine();

        foreach(var employeeGroupedByCompany in employeesByCompany)
        {
            Console.WriteLine(employeeGroupedByCompany.Name); 
            foreach(var employee in employeeGroupedByCompany.employeesGroupedByCompany)
            {
                Console.WriteLine(employee);
            }
            
        }
        Console.WriteLine();
        List<int> someIntegerList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var zipSequence = person_list.Zip(someIntegerList, (first, second) => $"{first.FirstName} {first.LastName}" + " - " + second);
        PrintCollection(zipSequence);




    }
    private static void PrintCollection<T>(IEnumerable<T> source)
    {
        foreach (var item in source)
        {
            Console.WriteLine(item);
        }
    }

}

