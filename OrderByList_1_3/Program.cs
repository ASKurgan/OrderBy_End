// Коллекция, лист. Вывод на консоль упорядоченного массива

using System.Text.RegularExpressions;

System.Console.WriteLine("Введите числа:");
System.Console.WriteLine();
var myList = new List<double>();
bool tF = true;

int sch = 0;
string? strValue,str, strValueContinue, strValueContinueOne;
double value;
while (tF)
{
    
    //++sch;
    System.Console.WriteLine($"Введите {sch + 1}-е число: ");

    strValue = System.Console.ReadLine();
    str = (strValue == null) ? string.Empty : strValue;
        
    if (Helper.IsDigit(str))
    {
        value = double.Parse(str);
        myList.Add(value);
        System.Console.WriteLine();
        foreach (var item in myList)
        {
            System.Console.Write($"{Helper.DeleteNegativeZero(item.ToString())}   ");
        }
        System.Console.WriteLine();

        ++sch;


        if (sch > 1)
        {


            System.Console.WriteLine("Хотите продолжить заполнение списка или отсортировать? Любой символ - продолжить , s - отсортировать список");
            strValueContinueOne = Console.ReadLine();
            strValueContinue = (strValueContinueOne == null) ? string.Empty : strValueContinueOne;
            if (strValueContinue.ToLower() == "s")
            {
                tF = false;
            }
        }
    }
}

System.Console.WriteLine("Неотсортированный список:");
System.Console.WriteLine();

var countArray = myList.Count;
double[] myArray = new double [countArray]; 
for (var i = 0; i< myList.Count; i++)
{
    myArray[i] = myList[i]; 
    System.Console.Write(myList[i].ToString() + "   ");
}
System.Console.WriteLine();


System.Console.WriteLine();
for (int i = 0; i < countArray; i++)
{
    for ( int j = 0; j < countArray - i - 1; j++ )
    {
       var interValue =  myArray[j];
       if(interValue > myArray[j+1] )
       {
        myArray[j] = myArray[j+1];
        myArray[j+1] = interValue;
       }   
    }
}

System.Console.WriteLine("Отсортированный список:");
System.Console.WriteLine();
for (int i = 0; i < countArray; i++)
{
    System.Console.Write(Helper.DeleteNegativeZero(myArray[i].ToString())  + "   " );
}
System.Console.ReadLine();
