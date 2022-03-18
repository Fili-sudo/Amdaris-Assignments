// See https://aka.ms/new-console-template for more information

using System.Globalization;

string composite = "I need a {0} desk measuring {1} in width and {2} in height";
Console.WriteLine(string.Format(composite, "red", "1.2m", "80cm"));

var brand = "Samsung";
string interpolation = $"My {brand} phone shows the {DateTime.Now} at the moment";
Console.WriteLine(interpolation);

var sentence = "This is a regular sentence that will be splitted in separate words";
string[] words = sentence.Split(' ');
foreach (var word in words)
{
    Console.WriteLine(word);
}

DateTimeOffset date1 = new DateTimeOffset(DateTime.Now);
DateTimeOffset date2 = new DateTimeOffset( new DateTime(2000, 3, 21), new TimeSpan(10, 13, 0));
Console.WriteLine(date1);
Console.WriteLine(date2);

CultureInfo invariant = CultureInfo.InvariantCulture;
CultureInfo ro = CultureInfo.GetCultureInfo("ro-RO");
CultureInfo china = CultureInfo.GetCultureInfo("zh-CHT");

Console.WriteLine(34.56.ToString(invariant));
Console.WriteLine(34.56.ToString(ro));
Console.WriteLine(34.56.ToString(china));

Console.WriteLine(10.ToString("C", china));