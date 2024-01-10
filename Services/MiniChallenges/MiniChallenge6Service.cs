namespace MiniChallenges5_7.Services.MiniChallenges;

public class MiniChallenge6Service : IMiniChallenge6Service
{
    public string OddOrEven(string input)
    {
        bool isNum = int.TryParse(input, out int number);

        if (isNum)
        {
            if (number % 2 == 0)
            {
                return $"The number {number} is even.";
            }
            else
            {
                return $"The number {number} is odd.";
            }

        }
        else
        {
            return $"{input} was not a number. Please input a valid number/input.";
        }
    }
}
