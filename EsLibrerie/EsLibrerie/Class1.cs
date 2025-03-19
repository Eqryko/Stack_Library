namespace MyStack
{
    public class CStack<T>
    {
        private CNodo<T> head;

        public CStack()
        {
            head = null;
        }

        public void Push(T element)
        {
            CNodo<T> node = new CNodo<T>(element);
            node.next = head;
            head = node;
        }

        public T Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack vuoto");
            T val = head.value;
            head = head.next;
            return val;
        }

        public bool IsEmpty()
        {
            return head == null;
        }
    }

    public class CNodo<T>
    {
        public T value { get; set; }
        public CNodo<T> next { get; set; }

        public CNodo(T data)
        {
            value = data;
            next = null;
        }
    }
}
