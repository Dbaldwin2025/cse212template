using System.Globalization;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
       // double[] multiple = {7, 14, 21, 28, 35};

       // I will make a list which could adjust if needed then convert it to an array
       // I will need a loop to itterate through possible numbers and add them if they match to the list
       // I will need to limit my results by the legth specified in the 2nd 
       // I will then return the array 

        List<double> multipleList = [];
        
        for (double i = 0.5; i < 100; i += 0.5) {
            if (i % number == 0 && multipleList.Count < length) {
                if (number < 0) {
                   
                    multipleList.Add(i* -1);
                } 
                else 
                {
                multipleList.Add(i);
                }
                Console.Write(" " + i + " ");
            }
        }
   
        double[] multiples = multipleList.ToArray();
       
        return multiples;
    }
    
    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person

        // need to create a 2nd temporary array to store rotated numbers
        // need to run 2 for loops: 1st loop is to transfer values into a temporary array
        // as we are getting the data we shift the index correctly according to value or amount stated
        // we then need to repopulate the data back into the data array with the 2nd for loop


        int[] tempArray = new int[data.Count];
        int shiftIndex = data.Count -amount;
        for (int i = 0 ;i < data.Count; i++) {
            tempArray[i] = data[(i + shiftIndex)% data.Count];
            //Console.Write(" " + tempArray[i] + " ");
        }
        for (int i =0; i < data.Count; i++) {
            data[i] = tempArray[i];
            Console.Write(" " + data[i] + " ");
        }


    }
}
