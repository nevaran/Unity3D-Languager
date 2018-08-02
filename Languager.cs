using System.Collections.Generic;
using System.Text;

public static class Languager{
    /*public static readonly Dictionary<char, string> TemplateMapping = new Dictionary<char, string>()
    {
        { ' ', " " }
        ,{ '!', "!" }

        ,{ 'A', "" }
        ,{ 'B', "" }
        ,{ 'C', "" }
        ,{ 'D', "" }
        ,{ 'E', "" }
        ,{ 'F', "" }
        ,{ 'G', "" }
        ,{ 'H', "" }
        ,{ 'I', "" }
        ,{ 'J', "" }
        ,{ 'K', "" }
        ,{ 'L', "" }
        ,{ 'M', "" }
        ,{ 'N', "" }
        ,{ 'O', "" }
        ,{ 'P', "" }
        ,{ 'Q', "" }
        ,{ 'R', "" }
        ,{ 'S', "" }
        ,{ 'T', "" }
        ,{ 'U', "" }
        ,{ 'V', "" }
        ,{ 'W', "" }
        ,{ 'X', "" }
        ,{ 'Y', "" }
        ,{ 'Z', "" }

        ,{ '0', "" }
        ,{ '1', "" }
        ,{ '2', "" }
        ,{ '3', "" }
        ,{ '4', "" }
        ,{ '5', "" }
        ,{ '6', "" }
        ,{ '7', "" }
        ,{ '8', "" }
        ,{ '9', "" }
    };*/

    public static readonly Dictionary<char, string> EnochianMapping = new Dictionary<char, string>()//Modified Enochian
    {
        { ' ', " " }
        ,{ '!', "!" }
        ,{ '?', "?" }
        ,{ '\'', "'" }

        ,{ 'A', "Un" }
        ,{ 'B', "Pa" }
        ,{ 'C', "Veh" } ,{ 'K', "V'e" }
        ,{ 'D', "Gal" }
        ,{ 'E', "Graph" }
        ,{ 'F', "Or" }
        ,{ 'G', "Ged" },{ 'J', "Ooal" }
        ,{ 'H', "Na" }
        ,{ 'I', "Gon" }
        ,{ 'L', "Ur" }
        ,{ 'M', "Tal" }
        ,{ 'N', "Drux" }
        ,{ 'O', "Med" }
        ,{ 'P', "Mais" }
        ,{ 'Q', "Ger" }
        ,{ 'R', "Don" }
        ,{ 'S', "Fam" }
        ,{ 'T', "Gisg" }
        ,{ 'U', "Van" },{ 'V', "Va'al" }
        ,{ 'X', "Pal" }
        ,{ 'Y', "Uo" }
        ,{ 'W', "Re" }
        ,{ 'Z', "Ceph" }

        ,{ '0', "Nan" }
        ,{ '1', "An" }
        ,{ '2', "En" }
        ,{ '3', "In" }
        ,{ '4', "On" }
        ,{ '5', "Un" }
        ,{ '6', "Aen" }
        ,{ '7', "Ein" }
        ,{ '8', "Ion" }
        ,{ '9', "Oun" }
    };

    public static readonly Dictionary<char, string> CommonMapping = new Dictionary<char, string>()//Modified R'lyehian
    {
        { ' ', " " }
        ,{ '!', "!" }
        ,{ '?', "?" }
        ,{ '\'', "'" }

        ,{ 'A', "Ka" }
        ,{ 'B', "Kha" }
        ,{ 'C', "Ga" }
        ,{ 'D', "N'ga" }
        ,{ 'E', "Ca" }
        ,{ 'F', "Cha" }
        ,{ 'G', "Ja" }
        ,{ 'H', "Nya" }
        ,{ 'I', "Ta" }
        ,{ 'J', "Sa" }
        ,{ 'K', "Da" }
        ,{ 'L', "Na" }
        ,{ 'M', "Pa" }
        ,{ 'N', "Ha" }
        ,{ 'O', "Ba" }
        ,{ 'P', "Ma" }
        ,{ 'Q', "Tsa" }
        ,{ 'R', "Tsha" }
        ,{ 'S', "Dza" }
        ,{ 'T', "Wa" }
        ,{ 'U', "Zha" }
        ,{ 'V', "Za" }
        ,{ 'W', "Ya" }
        ,{ 'X', "Ra" }
        ,{ 'Y', "La" }
        ,{ 'Z', "Sha" }

        ,{ '0', "Nihil" }
        ,{ '1', "Unus" }
        ,{ '2', "Duo" }
        ,{ '3', "Tres" }
        ,{ '4', "Quattuor" }
        ,{ '5', "Quinque" }
        ,{ '6', "Sek" }
        ,{ '7', "Septem" }
        ,{ '8', "Octo" }
        ,{ '9', "Novem" }
    };

    public static string ToEnochian(string cyrillic)
    {
        StringBuilder result = new StringBuilder();

        char lastChar = ' ';
        for(int i = 0; i < cyrillic.Length; i++)
        {
            char c = cyrillic[i];
            try
            {
                string exitString;
                if(c.ToString().ToUpper() == lastChar.ToString().ToUpper())//shorten/change if its same char
                {
                    if (char.IsUpper(c))
                    {
                        exitString = EnochianMapping[c][EnochianMapping[c].Length - 1].ToString().ToUpper();//get the last letter in lowercase, as an elongated word
                        result.Append(exitString);
                    }
                    else
                    {
                        c = char.ToUpper(c);
                        if (!char.IsDigit(c))
                        {
                            exitString = EnochianMapping[c].ToUpper()[EnochianMapping[c].Length - 1].ToString().ToLower();//get the last letter in lowercase, as an elongated word
                            result.Append(exitString);
                        }
                        else
                            result.Append(EnochianMapping[c]);
                    }
                }
                else
                {
                    if (char.IsUpper(c))
                    {
                        result.Append(EnochianMapping[c]);
                    }
                    else
                    {
                        c = char.ToUpper(c);
                        if (!char.IsDigit(c))
                            result.Append(EnochianMapping[c].ToLower());
                        else
                            result.Append(EnochianMapping[c]);
                    }
            }
            }
            catch//replacement if its not in the dictionary
            {
                //Debug.Log("Unable to find in dictionary");
                //result.Append("□");
                result.Append("_");
            }
            lastChar = c;
        }

        return "<color=#C9C3A1>[Enchonian]</color> " + result.ToString();
    }

    public static string ToCommon(string cyrillic)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < cyrillic.Length; i++)
        {
            char c = cyrillic[i];
            try
            {
                if (char.IsUpper(c))
                {
                    result.Append(CommonMapping[c]);
                }
                else
                {
                    c = char.ToUpper(c);
                    if (!char.IsDigit(c))
                        result.Append(CommonMapping[c].ToLower());
                    else
                        result.Append(CommonMapping[c]);
                }
            }
            catch
            {
                result.Append("_");
            }
        }

        return "<color=#C9C3A1>[Common]</color> " + result.ToString();
    }
}