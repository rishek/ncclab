namespace example
{
    public class programstack<T>
    {
        private T[] s1 = new T[5];
        private int counter = -1;
        public void push(T item)
        {
            if (counter < 4)
            {
                counter++;
                s1[counter] = item;
            }
            else
            {
                Console.WriteLine("Overfllow");
            }
        }
        public void pop()
        {
            if(counter>=0)
            {
                s1[counter] = default(T);
                counter--;
            }
            else
            {
                Console.WriteLine("undeflow");
            }
        }
        public void print()
        {
            Console.WriteLine("Elements are:");
            for (int i = 0; i <=counter; i++)
            {
                Console.WriteLine(s1[i]);
            }
        }
    }
    public class CustomQueue<T>
    {
        public T[] t1 = new T[5];

        public int rear = -1;
        public int front = -1;

        public void enqueue(T item)
        {
            if (front == -1 && rear == -1)
            {

                rear++;
                t1[rear] = item;
                Console.WriteLine($"Item added is:{item}");


            }
            else if (front != rear)
            {

                if (rear < 5)
                {
                    rear++;
                    t1[rear] = item;
                    Console.WriteLine($"Item added is:{item}");
                }
            }
            else
            {
                Console.WriteLine("queue overflow");
            }
        }
        public void dequeue()
        {
            if (front != rear)
            {
                front++;
                Console.WriteLine($"Deqeued item is : {t1[front]}");
                t1[front] = default(T);
                // front++;
            }
            else
            {
                Console.WriteLine("Queue Underflow");
            }
        }
        public void display()
        {


            for (int a = 0; a <= rear; a++)
            {
                Console.WriteLine("Queue Items are:");

                Console.WriteLine(t1[a]);


            }
        }
    }
    public class program1
    {
        public static void Main()
        {
            CustomQueue<int> obj = new CustomQueue<int>();
            obj.enqueue(5);
            obj.enqueue(6);
            obj.display();
            obj.dequeue();
            obj.display();
            CustomQueue<string> obj1 = new CustomQueue<string>();
            obj1.enqueue("rishek");
            obj1.enqueue("pandey");
            obj1.display();
            obj1.dequeue();
            obj1.display();
            programstack<int> new1 = new programstack<int>();
            programstack<string> new2 = new programstack<string>();
            new1.push(5);
            new1.push(8);
            new1.push(5);
            new1.push(8);
            new1.push(5);
            
         
            new1.print();
            new2.push("rishek");
            new2.push("anjal");
            new2.print();
            new2.pop();
            new2.print();


        }
    }


}