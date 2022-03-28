
public class Exercitiu
{
    private IEnumerable<Singer> _singers;
    private IEnumerable<Concert> _concerts;

    public Exercitiu()
    {
        _singers = GetSingers();
        _concerts = GetConcerts();
    }

    public static IEnumerable<Singer> GetSingers()
    {
        return new List<Singer>()
            {
                new Singer { Id = 1, FirstName = "Freddie", LastName = "Mercury"},
                new Singer { Id = 2, FirstName = "Elvis", LastName = "Presley"},
                new Singer { Id = 3, FirstName = "Chuck", LastName = "Berry"},
                new Singer { Id = 4, FirstName = "Ray", LastName = "Charles"},
                new Singer { Id = 5, FirstName = "David", LastName = "Bowie"}
            };
    }

    public static IEnumerable<Concert> GetConcerts()
    {
        return new List<Concert>()
            {
                new Concert { SingerId = 2, Country = "Germany", Avenue = "Alianz", Year = 1979},
                new Concert { SingerId = 1, Country = "USA", Avenue = "NYW", Year = 1980},
                new Concert { SingerId = 1, Country = "Germany", Avenue = "Opera Nazional", Year = 1981},
                new Concert { SingerId = 2, Country = "Germany", Avenue = "Berlin Arena", Year = 1970},
                new Concert { SingerId = 2, Country = "Rusia", Avenue = "Lujniki", Year = 1968},
                new Concert { SingerId = 3, Country = "UK", Avenue = "London Opera", Year = 1960},
                new Concert { SingerId = 3, Country = "USA", Avenue = "Central Park", Year = 1961},
                new Concert { SingerId = 2, Country = "Rusia", Avenue = "Red Square", Year = 1962},
                new Concert { SingerId = 4, Country = "USA", Avenue = "Capitolium", Year = 1950},
                new Concert { SingerId = 4, Country = "Romania", Avenue = "Arena nationala", Year = 1951},
                new Concert { SingerId = 5, Country = "France", Avenue = "Verdun", Year = 1983}
            };
    }
}

public class Singer
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }
}

public class Concert
{
    public int SingerId { get; set; }

    public string Avenue { get; set; }

    public int Year { get; set; }

    public string Country { get; set; }
}

