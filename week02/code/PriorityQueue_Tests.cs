using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        Assert.Fail("Implement the test case and then remove this.");
    }

    // Add more test cases as needed below.

    // Test 1: Higher priority comes out first
    // Expected:  "Low"  -> "Medium" -> "High"  Dequeue order: High, Medium, Low
    // Result: PASSED after fix

    // Test 2: Same priority respects FIFO
    // Expected: Alice(5) enqueued first -> Alice comes out before Bob
    // Result: Originally FAILED (Bob came first), now PASSED

    // Test 3: Empty queue throws correct exception
    // Result: PASSED

    // Test 4: Multiple same highest priority -> earliest enqueued wins
    // Result: PASSED

    // Test 5: Mixed priorities with ties
    // Result: PASSED




}