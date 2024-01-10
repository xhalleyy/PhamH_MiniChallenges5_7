namespace MiniChallenges5_7.Services.MiniChallenges;

public class NumericReverseItService : INumericReverseItService
{
    public string ReverseInput(string input)
    {
        string reversedStr = "";
        bool isNumSeq = int.TryParse(input, out int number);
        if (isNumSeq){
            
            for( int i = number.ToString().Length - 1; i >= 0; i--)
            {
                reversedStr += number.ToString()[i];
            }

            return $"The reverse sequence of {input} is: {reversedStr}";

        }else{
            return $"Your sequence, {input},doesn't have all numerical values. Try again!";
        }
    }
}
