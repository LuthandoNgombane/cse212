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

        //LN - Plan:
        // 1. Creating a new array of size 'length' to hold the multiples.
        // 2. Using a for loop to iterate from 1 to length (inclusive).
        // 3. In each iteration, multiplying the input 'number' by the current loop index.
        // 4. Storing the result in the array at the current index - 1 (because arrays are zero-indexed).
        // 5. After the loop finishes, returning the array.
        
        double[] multiples = new double[length];  

        for (int i = 1; i <= length; i++)         
        {
            multiples[i - 1] = number * i;        
        }

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
        // be implemented by another person.

        // LN -Plan:
        // 1. The goal is to shift elements to the right by 'amount'.
        // 2. This means the last 'amount' elements should move to the front.
        // 3. Using List.GetRange to get the last 'amount' elements.
        // 4. Removing the last 'amount' elements from the original list.
        // 5. Inserting the saved elements at the front of the list.
        // 6. This changes the original list in place.

        List<int> lastElements = data.GetRange(data.Count - amount, amount);

        data.RemoveRange(data.Count - amount, amount);

        data.InsertRange(0, lastElements);

        
    }
}
