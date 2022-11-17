// See https://aka.ms/new-console-template for more information

namespace Vowel_Count;

static class VowelCount
{
    public static int VowelCounter(string data)
    {
        char[] dataSplit = data.ToLower().ToCharArray();
        int countResult = 0;
        foreach (var info in dataSplit)
        {
            if (info == 'a' || info == 'e' || info == 'i' || info == 'o' || info == 'u')
            {
                countResult++;
            }
        }

        return countResult;
    }
}