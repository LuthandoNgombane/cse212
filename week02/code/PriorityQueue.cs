public class PriorityQueue
{
    private List<PriorityItem> _queue = new();

    /// <summary>
    /// Add a new value to the queue with an associated priority.  The
    /// node is always added to the back of the queue regardless of 
    /// the priority.
    /// </summary>
    /// <param name="value">The value</param>
    /// <param name="priority">The priority</param>
    public void Enqueue(string value, int priority)
    {
        var newNode = new PriorityItem(value, priority);
        _queue.Add(newNode);
    }

    public string Dequeue()
    {
        if (_queue.Count == 0) // Verify the queue is not empty
        {
            throw new InvalidOperationException("The queue is empty.");
        }

        // Find the index of the item with the highest priority to remove
        // var highPriorityIndex = 0;
        // for (int index = 1; index < _queue.Count - 1; index++)
        // {
        //     if (_queue[index].Priority >= _queue[highPriorityIndex].Priority)
        //         highPriorityIndex = index;
        // }

        // // Remove and return the item with the highest priority
        // var value = _queue[highPriorityIndex].Value;
        // return value;


        //Bugs:
        // Loop went to Count - 1  and skipped the last element
        // Used >= later same priority items could win
        // Never removed the item memory leak and wrong behavior

        // Find highest priority (higher number = higher priority)
        int bestIndex = 0;
        for (int i = 1; i < _queue.Count; i++)
        {
            if (_queue[i].Priority > _queue[bestIndex].Priority ||
                (_queue[i].Priority == _queue[bestIndex].Priority && i < bestIndex))
            {
                bestIndex = i;
            }
        }

        string value = _queue[bestIndex].Value;
        _queue.RemoveAt(bestIndex);
        return value;

    }

    // DO NOT MODIFY THE CODE IN THIS METHOD
    // The graders rely on this method to check if you fixed all the bugs, so changes to it will cause you to lose points.
    public override string ToString()
    {
        return $"[{string.Join(", ", _queue)}]";
    }
}

internal class PriorityItem
{
    internal string Value { get; set; }
    internal int Priority { get; set; }

    internal PriorityItem(string value, int priority)
    {
        Value = value;
        Priority = priority;
    }

    // DO NOT MODIFY THE CODE IN THIS METHOD
    // The graders rely on this method to check if you fixed all the bugs, so changes to it will cause you to lose points.
    public override string ToString()
    {
        return $"{Value} (Pri:{Priority})";
    }
}