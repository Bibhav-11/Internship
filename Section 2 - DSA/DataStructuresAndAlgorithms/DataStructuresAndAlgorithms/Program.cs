//Searching Algorithms
using DataStructuresAndAlgorithms.DataStructures;
using DataStructuresAndAlgorithms.Helper;
using DataStructuresAndAlgorithms.Recursion;
using DataStructuresAndAlgorithms.SearchingAlgorithms;
using DataStructuresAndAlgorithms.SortingAlgorithms;
using System;

int[] inputArray = new int[] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };

var BinaryResult = BinarySearchAlgorithm.BinarySearch(inputArray, 45);
var LinearResult = LinearSearchAlgorithm.LinearSearch(inputArray, 45);

Console.WriteLine($"Binary Search Algorithm result: {BinaryResult}");
Console.WriteLine($"Linear Search Algorithm result: {LinearResult}");
Console.WriteLine();


//Sorting Algorithms
int[] unsortedArray = new int[] { 57, 49, 73, 99, 133, 20, 1 };

var bubbleResult = BubbleSortAlgorithm.BubbleSort(unsortedArray);
Console.WriteLine("Bubble Sort Algorithm Result");
PrintArray.Print(bubbleResult);

Console.WriteLine();
Console.WriteLine();

var selectionResult = SelectionSortAlgorithm.SelectionSort(unsortedArray);
Console.WriteLine("Selection Sort Algorithm Result");
PrintArray.Print(selectionResult);

Console.WriteLine();
Console.WriteLine();

var insertionResult = InsertionSortAlgorithm.InsertionSort(unsortedArray);
Console.WriteLine("Insertion Sort Algorithm Result");
PrintArray.Print(insertionResult);

Console.WriteLine();
Console.WriteLine();

var mergeResult = MergeSortAlgorithm.MergeSort(unsortedArray, 0, unsortedArray.Length - 1);
Console.WriteLine("Merge Sort Algorithm Result");
PrintArray.Print(mergeResult);

Console.WriteLine();
Console.WriteLine();

var quickResult = QuickSortAlgorithm.QuickSort(unsortedArray, 0, 1);
Console.WriteLine("Quick Sort Algorithm Result");
PrintArray.Print(quickResult);

Console.WriteLine();
Console.WriteLine();

//Data Structures

//Stack
Console.WriteLine("Stack:");
CustomStack stack = new CustomStack(5);

stack.Push(1);
stack.Push(2);
stack.Push(3);

Console.WriteLine("Top element: " + stack.Peek());

stack.Push(4);
stack.Push(5);

while (!stack.IsEmpty())
{
    Console.WriteLine("Popped: " + stack.Pop());
}

Console.WriteLine();

//Queue
Console.WriteLine("Queue:");
CustomQueue queue = new CustomQueue(5);

queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);

Console.WriteLine("Front element: " + queue.Peek());

queue.Enqueue(4);
queue.Enqueue(5);

while (!queue.IsEmpty())
{
    Console.WriteLine("Dequeued: " + queue.Dequeue());
}

Console.WriteLine();

Console.WriteLine("Linked List");
LinkedList linkedList = new LinkedList();

linkedList.Add(1);
linkedList.Add(2);
linkedList.Add(3);
linkedList.Add(4);

linkedList.Display();

linkedList.Remove(3);
linkedList.Display();


Console.WriteLine();

Console.WriteLine("Binary Tree");
BinaryTree tree = new BinaryTree();

tree.Insert(50);
tree.Insert(30);
tree.Insert(70);
tree.Insert(20);
tree.Insert(40);
tree.Insert(60);
tree.Insert(80);

tree.InOrderTraversal(tree.Root);

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Tower of Hanoi");
int numDisks = 3;
TowersOfHanoi.Solve(numDisks, 'A', 'B', 'C');