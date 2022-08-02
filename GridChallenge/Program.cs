using System.Linq;

List<string> grid = new List<string>();
grid.Add("eabcd");
grid.Add("fghij");
grid.Add("olkmn");
grid.Add("trpqs");
grid.Add("xywuv");

string[] arrString = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
var strResult = "";

foreach (var word in grid)
{
    var wordSort = word.OrderBy(o => o).ToList();
    var index = Array.IndexOf(arrString, wordSort[0].ToString());
    var len = word.Length;

    bool[] result = new bool[len];


    var strX = arrString.Skip(index).Take(len).ToList();

    int i = 0;
    foreach (var sort in strX)
    {
        string a = wordSort[i].ToString();
        if (sort.Equals(wordSort[i].ToString()))
        {
            strResult = "YES";
        }

        i++;
    }    
}

var sorted = grid[0].OrderBy(o => o).ToList();
var isA = sorted.FirstOrDefault();
if (isA.ToString() != "a")
{
    strResult = "NO";
}


Console.WriteLine($"{strResult}");
Console.WriteLine("Hello, World!");
