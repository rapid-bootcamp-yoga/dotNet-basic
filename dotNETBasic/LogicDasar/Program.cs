
 static int simpleArraySum(List<int> ar)
{
    var value = ar;
    var n = value.Count;
    int sum = 0;
        foreach (var item in value)
    {
        sum += item;
    }
    return sum;
}

var daftar = new List<int> { 1, 2,3,4 };


Console.WriteLine(simpleArraySum(daftar));
