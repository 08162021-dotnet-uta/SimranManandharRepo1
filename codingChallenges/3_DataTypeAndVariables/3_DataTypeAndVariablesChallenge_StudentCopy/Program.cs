using System;

namespace _3_DataTypeAndVariablesChallenge
{
  public class Program
  {
    public static void Main(string[] args)
    {
      //
      //
      // Insert code here.
      //
      //
      Console.WriteLine(PrintValues(23));
    }

    /// <summary>
    /// This method has an 'object' type parameter. 
    /// 1. Create a switch statement that evaluates for the data type of the parameter
    /// 2. You will need to get the data type of the parameter in the 'case' part of the switch statement
    /// 3. For each data type, return a string of exactly format, "Data type => <type>" 
    /// 4. For example, an 'int' data type will return ,"Data type => int",
    /// 5. A 'ulong' data type will return "Data type => ulong",
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static string PrintValues(object obj)
    {
      // throw new NotImplementedException($"PrintValues() has not been implemented");
      switch (obj)
      {
        case bool a:
          return "Data type => bool";
        case byte b:
          return "Data type => byte";
        case sbyte c:
          return "Data type => sbyte";
        case char d:
          return "Data type => char";
        case decimal e:
          return "Data type => decimal";
        case double o:
          return "Data type => double";
        case float n:
          return "Data type => float";
        case int m:
          return "Data type => int";
        case uint l:
          return "Data type => uint";
        case long i:
          return "Data type => long";
        case ulong h:
          return "Data type => ulong";
        case short g:
          return "Data type => short";
        case ushort f:
          return "Data type => ushort";
        default:
          return "Wrong input";
      }
    }

    /// <summary>
    /// THis method has a string parameter.
    /// 1. Use the .TryParse() method of the Int32 class (Int32.TryParse()) to convert the string parameter to an integer. 
    /// 2. You'll need to investigate how .TryParse() and 'out' parameters work to implement the body of StringToInt().
    /// 3. If the string cannot be converted to a integer, return 'null'. 
    /// 4. Investigate how to use '?' to make non-nullable types nullable.
    /// </summary>
    /// <param name="numString"></param>
    /// <returns></returns>
    public static int? StringToInt(string numString)
    {
      throw new NotImplementedException($"StringToInt() has not been implemented");

    }
  }// end of class
}// End of Namespace
