namespace LinkedList
{
    class LinkedList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public LinkedList(T value)
        {
            Node<T> node = new Node<T>(value);
            head = node;
            tail = node;
        }

        public void Add(T value)
        {
            Node<T> node = new Node<T>(value);
            if (head == null)
            {
                head = node;
                tail = head;
            }
            else
            {
                tail.Next = node;
                tail = node;
            }
        }
        
        public bool Remove(T value)
        {
            Node<T> node = head;
            if (node == null)
            {
                throw new System.FieldAccessException("Create list first");
            }
            while (node != tail)
            {
                if (node.Next.Value.Equals(value))
                {
                    node.Next = node.Next.Next;
                    return true;
                }
            }
            node = node.Next;
            return false;
        }

        public void Output(LinkedList<T> list)
        {
            Node<T> node = list.head;
            while (node != null)
            {
                System.Console.WriteLine(node.Value + " ");
                node = node.Next;
            }
        }
    }
}