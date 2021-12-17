

Spikes test = new Spikes();

test.AnonymousResult();
Console.WriteLine("-----------------");

test.StronglyTypedResult();
Console.WriteLine("-----------------");

IEnumerable<Artist> artists = test.StronglyTypedResultWithWhere();
foreach (var a in artists)
{
    Console.WriteLine($"Name: {a.Name} prefixWithThe: {a.PrefixWithThe}");
}

