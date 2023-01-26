
public class Program
{
    public static void Main()
    {
        List<int> listHead = new List<int>();
        listHead.Add(1);
        listHead.Add(2);
        listHead.Add(4);
        listHead.Add(5);
        listHead.Add(8);
        listHead.Add(9);
        listHead.Add(11);
        listHead.Add(12);

        foreach(int list in listHead)
        {
            Console.WriteLine(list);
        }

        Console.WriteLine("====================");
        Console.WriteLine("after even delete");

        listHead.RemoveAll(i => i % 2 == 0);
        /*for (int i = 0; i < listHead.Count; i++)
        {
            if (listHead[i] % 2 == 0)
            {
                listHead.Remove(listHead[i]);
            }
        }*/
        foreach(int list in listHead)
        {
            Console.WriteLine(list);
        }

    }
}