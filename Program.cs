using System.Globalization;

try
{
    //from string to int
    string textWithInt = "65";
    int convertToIntFromString = Convert.ToInt32(textWithInt);
    int parseToToIntFromString = int.Parse(textWithInt);
    Console.WriteLine($"convert to int: {convertToIntFromString}");
    Console.WriteLine($"parse to int: {parseToToIntFromString}");

    //from string to double
    string textWithDouble = "65,9";
    NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
    {
        NumberDecimalSeparator = ",",
    };
    double convertToDoubleFromString = Convert.ToDouble(textWithDouble, numberFormatInfo);
    double parseToDoubleFromString = double.Parse(textWithDouble, numberFormatInfo);
    Console.WriteLine($"convert to double: {convertToDoubleFromString}");
    Console.WriteLine($"parse to double: {parseToDoubleFromString}");

    //from string to byte
    string textWithByte = "255";
    byte convertToByteFromString = Convert.ToByte(textWithByte);
    byte parseToByteFromString = byte.Parse(textWithByte);
    Console.WriteLine($"convert to byte: {convertToByteFromString}");
    Console.WriteLine($"parse to byte: {parseToByteFromString}");

    //from string to char
    string textWithChar = "a";
    char convertToCharFromString = Convert.ToChar(textWithChar);
    char parseToCharFromString = char.Parse("a");
    Console.WriteLine($"convert to char: {convertToCharFromString}");
    Console.WriteLine($"parse to char: {parseToCharFromString}");

    //from string to decimal
    string textWithDecimal = "56.57";
    decimal convertToDecimalFromString = Convert.ToDecimal(textWithDecimal);
    decimal parseToDecimalFromString = decimal.Parse(textWithDecimal);
    Console.WriteLine($"convert to decimal: {convertToDecimalFromString}");
    Console.WriteLine($"parse to decimal: {parseToDecimalFromString}");

    //from int to double
    int doubleToInt = 53;
    double convertToDoubleFromInt = Convert.ToInt32(doubleToInt);
    Console.WriteLine($"convert to double: {convertToDoubleFromInt}");

    double result = doubleToInt;

    //from int to char
    int intToChar = 36;
    char convertToCharFromInt = Convert.ToChar(intToChar);
    Console.WriteLine($"convert to decimal: {convertToCharFromInt}");

    //from string to bool
    string textWithBool = "True";
    bool convertToBoolFromString = Convert.ToBoolean(textWithBool);
    Console.WriteLine($"convert to boolean: {convertToBoolFromString}");

}
catch (Exception exception)
{
    Console.WriteLine(exception);
}

//Try Parse
string textForTryParse = "45.4";
int intResult;
bool isParsed = int.TryParse(textForTryParse, out intResult);
if ( isParsed == true )
{
    Console.WriteLine($"The operation was successful:{intResult}");
}

else 
{
    Console.WriteLine($"The operation was not successful");
}


