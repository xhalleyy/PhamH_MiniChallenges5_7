namespace MiniChallenges5_7.Services.MiniChallenges;

public class AlphaNumericReverseItService : IAlphaNumericReverseItService
{
    public string ReverseInput(string input)
    {
        string reversedStr = "";
        for(int i = input.Length - 1; i >= 0; i--)
        {
            reversedStr += input[i];
        }

        return $"The reverse sequence of {input} is : {reversedStr}";
    }
}
