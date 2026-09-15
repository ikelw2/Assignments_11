
public class Program
{
    static void Main(string[] args)
    {
        Solution mysol = new Solution();
        Console.WriteLine(" result is " + mysol.MaxProfit([7, 1, 5, 3, 6, 4]));
        Console.WriteLine(" result is " + mysol.MaxProfit([7, 6, 4, 3, 1]));
    }
}

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        if (prices.Length <= 1)
            return 0;




        // int maxDifference = 0;

        // int rightIndex = prices.Length - 1;
        // int rightValue = prices[rightIndex];

        // int leftIndex = 0;
        // int leftValue = prices[leftIndex];

        // // start from both ends of array working towards opposite sides, find if any combo results in highest difference
        // do {
        //     if (rightValue - leftValue > 0)
        //         maxDifference = rightValue - leftValue;

        // } while ()
        int highestDiff = 0;
        for (int i = 1; i < prices.Length; i++)
        {

            int temp = HigherByHowMuchOrZero(prices, prices.Length - 1 - i, prices.Length - i, highestDiff);
            if (temp > highestDiff)
                highestDiff = temp;
        }
        return highestDiff;
    }

    public int HigherByHowMuchOrZero(int[] array, int l, int r, int prevMax)
    {
        int max = prevMax;
        while (l >= 0)
        {
            //Console.WriteLine($" Testing r_{array[r]} - l_{array[l]} = {array[r] - array[l]} > max ");
            if (array[r] - array[l] > max)
                max = array[r] - array[l];
            l--;
        }
        return max;
    }






    // int highest = 0;
    // for (int i = 0; i < prices.Length; i++) 
    // //for (int i = prices.Length - 1; i > 0; i--) // 3, 5  -> length=2  i= 1, 0
    // {
    //     // CheckForLowestToLeft(prices, i, prices[i]);
    //     if (prices[i] < lowest)
    //         lowest = 
    // }
    //}
    // public int getLeftDifferences(int[] array, int index, int maxDifference, int origValue)
    // {
    //     if (index < 0)
    //         return 0;
    //     if (origValue - array[index] > maxDifference) 
    //     {
    //         return 
    //     }
    // }


    // public int GetGreatestDecreaseToLeft(int[] array, int index, int greatest, int greatestIndex)
    // {
    //     if (index < 0)
    //         return 0;

    //     if (array[greatestIndex] - array[index] > greatest)
    //         return array[greatestIndex] - array[index];

    //     if ((compare - array[index]) > biggestDifference)
    //         return index;
    // }
}