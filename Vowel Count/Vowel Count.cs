// See https://aka.ms/new-console-template for more information

namespace Vowel_Count;

public static class VowelCount
{
    public static int VowelCounter(string data)
    {
        var dataSplit = data.ToLower().ToCharArray();

        return dataSplit.Count(info => info is 'a' or 'e' or 'i' or 'o' or 'u');
    }
}