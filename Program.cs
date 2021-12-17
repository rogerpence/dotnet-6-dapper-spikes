

Spikes test = new Spikes();

Console.WriteLine("AnonymousResult-----------------");
test.AnonymousResult();

Console.WriteLine("StronglyTypedResult-----------------");
test.StronglyTypedResult();

Console.WriteLine("StronglyTypedResultWithWhere-----------------");
IEnumerable<Artist> artists = test.StronglyTypedResultWithWhere();
foreach (var a in artists)
{
    Console.WriteLine($"Name: {a.Name} prefixWithThe: {a.PrefixWithThe}");
}

Console.WriteLine("StronglyTypedResultAsync-----------------");
await test.StronglyTypedResultAsync();

