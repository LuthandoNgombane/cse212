using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // LN - Scenario: Enqueue items with different priorities and dequeue them to verify highest priority is removed first.
    // Expected Result: Items are dequeued in order of highest priority; if priorities are equal, FIFO method is used.
    // Defect(s) Found: Dequeue does not remove the item from the queue; loop in Dequeue goes out of bounds for last element.
    public void TestPriorityQueue_DifferentPriorities()
    {
        
        //LN - The expected order is High, HighFirst, Medium, Low
        //LN - The test verifies that the items are dequeued in the correct order based on their priority
        // and that the queue is empty after all items are dequeued.
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("High", 3);
        priorityQueue.Enqueue("Medium", 2);
        priorityQueue.Enqueue("HighFirst", 3);

        Assert.AreEqual("High", priorityQueue.Dequeue()); 
        Assert.AreEqual("HighFirst", priorityQueue.Dequeue()); 
        Assert.AreEqual("Medium", priorityQueue.Dequeue()); 
        Assert.AreEqual("Low", priorityQueue.Dequeue()); 
    }

    [TestMethod]
    //LN - Scenario: Try to dequeue from an empty queue.
    // Expected Result: Throws InvalidOperationException with message "The queue is empty."
    // Defect(s) Found: None
    public void TestPriorityQueue_Empty()
    {

        //LN - The test verifies that an exception is thrown when trying to dequeue from an empty queue
        // and that the exception message is as expected.
        var priorityQueue = new PriorityQueue();
        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception : Failed.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }

    [TestMethod]
    //LN - Scenario: Enqueue items with the same priority and dequeue to verify FIFO method.
    // Expected Result: Items are dequeued in FIFO method when priorities are equal.
    // Defect(s) Found: Dequeue does not remove the item from the queue; loop in Dequeue goes out of bounds for last element.
    public void TestPriorityQueue_SamePriorities()
    {
        //LN - The expected order is First, Second, Third
        //LN - The test verifies that the items are dequeued in the correct order based on their priority
        // and that the queue is empty after all items are dequeued.
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First", 2);
        priorityQueue.Enqueue("Second", 2);
        priorityQueue.Enqueue("Third", 2);

        Assert.AreEqual("First", priorityQueue.Dequeue());
        Assert.AreEqual("Second", priorityQueue.Dequeue());
        Assert.AreEqual("Third", priorityQueue.Dequeue());
    }
}
