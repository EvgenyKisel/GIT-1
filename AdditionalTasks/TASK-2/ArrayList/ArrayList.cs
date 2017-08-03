using System.Text;

namespace ArrayList
{
    class ArrayList
    {
        private int[] array;
        private int length;
        private int count;

        public int Length
        {
            get
            {
                return length;
            }
        }

        public ArrayList(int[] array)
        {
            this.array = array;
            length = array.Length;
            count = array.Length;
        }

        public int this[int index]
        {
            get => array[index];
            set => array[index] = value;
        }

        public void Add(int element, int index)
        {
            CheckIndex(index);
            Size size = new Size();
            int[] tempArray = new int[size.IncreaseSize(array)];
            for (int i = 0; i < index; i++)
            {
                tempArray[i] = array[i];
            }
            tempArray[index] = element;
            for (int i = index; i < length; i++)
            {
                tempArray[i + 1] = array[i];
            }
            array = tempArray;
            length = length + 1;
            count++;
        }

        public void Delete(int index)
        {
            CheckIndex(index);
            for (int i = index; i < length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            length = length - 1;
            count--;
        }

        private void CheckIndex(int index)
        {
            if (index > count || index < 0)
            {
                throw new System.IndexOutOfRangeException("Wrong index");
            }
        }

        public override string ToString()
        {
            StringBuilder returnVal = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                returnVal.Append(array[i]);
                returnVal.Append(' ');
            }
            return returnVal.ToString();
        }
    }
}