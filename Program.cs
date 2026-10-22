using EromuApp;
int hibasorok=0;
List<eromu> list = new List<eromu>{};

while(hibasorok<0)
{
    hibasorok += 1;
    Console.ReadLine();
    File.ReadAllLines(eromuvek.txt.Split('|'));
    list.Add(list[0]);
 
}
foreach (list[0].Azonosito)
{
    if (list[0].Azonosito=="Z")
    {
        hibasorok += 1;
    }
    if (list[0].count>=5)
    {
        hibasorok += 1;
    }
    if (list[0].Azonosito=="S")
    {
        new megint =new eromu(10, 21, 30);
    }
    else
    {
        new most =new szelgenerator(10,21,30);
    }
}
Console.WriteLine(hibasorok);
Console.WriteLine(list);
Console.WriteLine(Sum(e =>e.NapiTermeles(12));
