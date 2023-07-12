using System.Text.RegularExpressions;

public class Helper
{
    public static bool IsDigit(string str)
    {
        if (String.IsNullOrEmpty(str))
        {
            Console.WriteLine("Вы ввели пустую строку");
            return false;
        }
        string[] strArray = new string[str.Length];
        bool tFValue = true, isFirstComma = true;
        for (int i = 0; i < str.Length; i++)
        {
            strArray[i] = str.Substring(i, 1);
            if(i == 0 && strArray[i] == "-")
            {
               continue;
            }
            if(isFirstComma && i > 0 && strArray[i-1] != "-" && strArray[i] == ",")
            {
                isFirstComma = false;
                continue;

            }
            switch (strArray[i])
            {
                case "0":
                    break;
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;
                case "7":
                    break;
                case "8":
                    break;
                case "9":
                    break;

                default:
                    System.Console.WriteLine("Вы ввели неверное значение, попробуйте заново");
                    tFValue = false;
                    break;
            }


            if (!tFValue)
            {
                break;
            }
        }
        return tFValue;
    }

    public static string DeleteNegativeZero(string str)
    {
        Regex regex = new Regex("^-0$");
        MatchCollection matches = regex.Matches(str);
        if (matches.Count > 0)
        {
            return "0";
        }
        else
        {
            return str;
        }
    }
}