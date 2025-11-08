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

       /* 1. Create a new double array called result with exactly 'length' elements.
         * 2. I need the 1st multiple (index 0) to be the number itself.
         * 3. The 2nd multiple = number * 2, 3rd = number * 3, etc.
         * 4. Use a for-loop that runs from 0 to length-1.
         * 5. In each iteration i, put (number * (i+1)) into result[i].
         *    - Using multiplication avoids adding floating-point errors over many additions.
         * 6. After the loop, return the completed array.
         */

        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result;
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

        /*
         * STEP-BY-STEP PLAN (using List slicing with GetRange):
         * 1. If the list is empty, do nothing and return.
         * 2. Since amount can equal data.Count, use modulo to handle full rotations:
         *    amount = amount % data.Count  → rotating by full length does nothing.
         * 3. If amount becomes 0 after modulo, just return (no change needed).
         * 4. Split the list into two parts:
         *    - lastPart  → the last 'amount' elements (these move to the front)
         *    - firstPart → everything before the last 'amount' elements
         * 5. Use GetRange to create shallow copies of each part.
         * 6. Clear the original list.
         * 7. Add the lastPart first (AddRange), then the firstPart (AddRange).
         * 8. The list is now rotated right by 'amount' positions.
         * 
         * Why this works: Rotating right by k is equivalent to taking the last k elements
         * and moving them to the beginning.
         */

        if (data.Count == 0) 
        {
            return;
        }

        // Handle full rotations (e.g., rotate by 9 on a 9-element list)
        amount = amount % data.Count;

        if (amount == 0) 
        {
            return;
        }

        // Get the two slices
        List<int> lastPart  = data.GetRange(data.Count - amount, amount);
        List<int> firstPart = data.GetRange(0, data.Count - amount);

        // Rebuild the list in the correct order
        data.Clear();
        data.AddRange(lastPart);
        data.AddRange(firstPart);
    }
}
