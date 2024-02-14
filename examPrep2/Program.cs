

List<string> loot = Console.ReadLine().Split("|").ToList();

string Line = "";
while ((Line = Console.ReadLine()) != "Yohoho!")
{
    string[] tokens = Line.Split();
    string command = tokens[0];
    if (command == "Loot")
    {
        for (int i = 1; i < tokens.Length; i++)
        {
            if (!loot.Contains(tokens[i]))
            {
                loot.Insert(0, tokens[i]);
            }
        }
    }
    else if (command == "Drop")
    {
        int index = int.Parse(tokens[1]);
        if (index >= 0 && index < loot.Count)
        {
            string removedItem = loot[index];
            loot.RemoveAt(index);
            loot.Add(removedItem);
        }
    }
    else
    {
        int itemsCount = int.Parse(tokens[1]);
        List<string> removeedItems = new List<string>();
        for (int i = 0; i < itemsCount; i++)
        {
            if (loot.Count != 0)
            {
                
                string removedItem = loot[loot.Count - 1];
                loot.RemoveAt(loot.Count - 1);
                removeedItems.Add(removedItem);
            }
        }
        if (removeedItems.Count != 0)
        {
            removeedItems.Reverse();
            Console.WriteLine(string.Join(", ", removeedItems));
        }
    }
}
if (loot.Count == 0)
{
    Console.WriteLine("Failed treasure hunt.");
    return;
}
double sum = 0;
foreach (string item in loot)
{ 
   sum += item.Length;
}
double averageGain = sum / loot.Count;
Console.WriteLine($"Average treasure gain: {averageGain:f2} pirate credits.");


private static void CounterStrike()..