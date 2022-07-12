string str = "";

Console.WriteLine("Enter a Roman Numeral using I, V and/ or X.");
str = Console.ReadLine();

Console.WriteLine(Roman(str));

static int Roman(string R)
{
    int result = 0;

    Dictionary<char, int> Roman_Dict = new Dictionary<char, int>();

    Roman_Dict.Add('I', 1);
    Roman_Dict.Add('V', 5);
    Roman_Dict.Add('X', 10);
    

    for (int i = 0; i < R.Length; i++)
    {
        char currentRomanChar = R[i];
        Roman_Dict.TryGetValue(currentRomanChar, out int num);

        if (i + 1 < R.Length && Roman_Dict[R[i + 1]] > Roman_Dict[currentRomanChar])
        {
            result -= num;

        }
        else
        {
            result += num;
        }
    }
    return result;
}