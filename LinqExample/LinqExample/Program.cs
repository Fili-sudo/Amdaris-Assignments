

IEnumerable<Singer> Singers = Exercitiu.GetSingers();
IEnumerable<Concert> Concerts = Exercitiu.GetConcerts();


var finalResult = from singer in Singers
           join concert in Concerts on singer.Id equals concert.SingerId
           where concert.Country == "Germany" && concert.Year >= 1950 && concert.Year <= 1980 && singer.FirstName == "Elvis" && singer.LastName == "Presley"
           select concert.Avenue;

foreach(var concerts in finalResult)
{
    Console.WriteLine(concerts);
}
