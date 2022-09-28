class Program
{

    static string JoinWithAnd(List<string> items, bool useSerialComma = true)
    {
        int count = items.Count;

        if (count == 0)
        {
            return "";
        }
        else if (count == 1)
        {
            return items[0];
        }
        else if (count == 2)
        {
            return $"{items[0]} and {items[1]}";
        }
        else
        {
            List<string> secondItems = new List<string>(items);

            if (useSerialComma)
            {
                int lastItemIndex = secondItems.Count - 1;

                string lastItem = secondItems[lastItemIndex];

                string lastItemFinal = $"and {lastItem}";

                secondItems[lastItemIndex] = lastItemFinal;
            }
            else
            {
                int lastItemIndex = secondItems.Count - 1;

                int secondToLastItemIndex = secondItems.Count - 2;

                secondItems[secondToLastItemIndex] = $"{secondItems[secondToLastItemIndex]} and {secondItems[lastItemIndex]}";

                secondItems.RemoveAt(lastItemIndex);
            }

            return String.Join(", ", secondItems);
        }
    }

    static void Main(string[] args)
    {
        //A list of strings called 'party' is generated.
        var party = new List<string> { };

        //The string 'Mary' is added to the list.
        party.Add("Mary");

        //The string 'Assasain' is added to the list.
        party.Add("Assasain");

        //The string 'Karl' is added to the list.
        party.Add("Karl");

        Console.WriteLine($"{JoinWithAnd(party)}");
    }
}