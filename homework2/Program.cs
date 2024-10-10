internal class Program
{


    static void InsertionSortRecursive(int []arr, int n)
    {
        if (n<=1) return;

        InsertionSortRecursive(arr, n - 1);

        int key = arr[n-1];
        int j = n - 2;
        while (j>=0 && arr[j] > key)
        {
            arr[j+1] = arr[j];
            j --;
            
        }

        arr[j + 1] = key;
    }
class Queue
{
    int[] queue = new int[100];
    int front = -1;
    int rear = -1;
    int n = 100;

    // check if the queue is empty or full
    void IsEmpty()
    {
        if (rear == -1 && front == -1)
        {
            Console.WriteLine("Queue is empty");
        }
        else Console.WriteLine("Queue is full");
    }

    //peek at the front element
    void Peek()
    {
        if (front == -1 && rear == -1)
        {
            Console.WriteLine("There is no element to display");
        }
        else Console.WriteLine("The element at the front is: " + queue[front]);
    }

    // add an element to the queue
    void Enqueue()
    {
        int element;
        if (rear == n - 1)
        {
            Console.WriteLine("Overflow Error");
        }
        else
        {
            if (front == -1)
            {
                front = 0;
            }
            Console.WriteLine("Enter element to enqueue:");
            element = Convert.ToInt32(Console.ReadLine());
            rear++;
            queue[rear] = element;
            Console.WriteLine("Enqueued element: " + element);
        }
    }

    //remove an element from the queue
    void Dequeue()
    {
        if (front == -1 && rear == -1)
        {
            Console.WriteLine("Underflow Error");
        }
        else if (front == rear)
        {
            Console.WriteLine("The deleted element from queue is: " + queue[front]);
            front = rear = -1;
        }
        else
        {
            Console.WriteLine("The deleted element from queue is: " + queue[front]);
            front++;
        }
    }

    //display all elements in the queue
    void Display()
    {
        if (front == -1)
        {
            Console.WriteLine("Queue is Empty");
        }
        else
        {
            Console.WriteLine("Queue elements are:");
            for (int i = front; i <= rear; i++)
            {
                Console.Write(queue[i] + " ");
            }
            Console.WriteLine();
        }
    }

    public static void Main()
    {

            /* int[] arr = { 1, 35, 2, 42, 43, 0, 5, 34 };
 InsertionSortRecursive(arr,arr.Length);

 for (int i = 0; i < arr.Length; i++) { 

     Console.WriteLine(arr[i]);
 }

 */

            Queue<int> queue = new Queue<int> ();

        while (true)
        {
            Console.WriteLine("\n--- Queue Operations Menu ---");
            Console.WriteLine("1. Insert element into queue ");
            Console.WriteLine("2. Delete element from queue ");
            Console.WriteLine("3. Display all elements of queue");
            Console.WriteLine("4. Peek at the front element");
            Console.WriteLine("5. Check if queue is empty");
            Console.WriteLine("6. Quit");

            Console.WriteLine("Enter your choice:");
            int answer = Convert.ToInt32(Console.ReadLine());

            switch (answer)
            {
                    case 1:
                        Console.WriteLine("Enter element to enqueue:");
                        int element = Convert.ToInt32(Console.ReadLine());
                        queue.Enqueue(element);
                        Console.WriteLine($"Enqueued element: {element}");
                        break;
                    case 2:
                        if (queue.Count == 0)
                        {
                            Console.WriteLine("Queue is empty, cannot dequeue.");
                        }
                        else
                        {
                            int dequeuedElement = queue.Dequeue();
                            Console.WriteLine($"Dequeued element: {dequeuedElement}");
                        }
                        break;
                    case 3:
                        if (queue.Count == 0)
                        {
                            Console.WriteLine("Queue is empty.");
                        }
                        else
                        {
                            Console.WriteLine("Queue elements are: " + string.Join(" ", queue));
                        }
                        break;
                    case 4:
                        if (queue.Count == 0)
                        {
                            Console.WriteLine("Queue is empty, nothing to peek.");
                        }
                        else
                        {
                            Console.WriteLine("Element at the front: " + queue.Peek());
                        }
                        break;
                    case 5:
                        if (queue.Count == 0)
                        {
                            Console.WriteLine("Queue is empty.");
                        }
                        else
                        {
                            Console.WriteLine("Queue is not empty.");
                        }
                        break;
                    case 6:
                        Console.WriteLine("Quiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                
            }
        }
    }
}

}

