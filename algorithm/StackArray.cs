namespace StackArray
{
    class CreateStackArray
    {
        int current_size = -1;
        const int MAX_SIZE = 100;
        int[] stack = new int[MAX_SIZE];
        // kiểm tra stack rỗng
        public bool isEmpty()
        {
            return (current_size == -1);
        }
        // kiểm tra stack full
        public bool isFull()
        {
            return (current_size == MAX_SIZE);
        }
        // thêm dữ liệu vào trong stack 
        public void Push(int data)
        {
            if (isFull())
            {
                current_size++;
                stack[current_size] = data;
            }
            else
            {
                Console.WriteLine("Stack full");
            }
        }
        // peek() lấy phần tử top nhưng ko xóa
        public int top()
        {
            if (!isEmpty())
            {
                int data = stack[current_size];
                return data;
            }
            Console.WriteLine("Stack empty");
            return 0;
        }
        // lấy phần tử top và xóa khỏi stack
        public int pop()
        {
            if (!isEmpty())
            {
                int data = stack[current_size];
                current_size--;
                return data;
            }
            Console.WriteLine("Stack empty");
            return 0;
        }
    }
}
