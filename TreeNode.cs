using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DZ_Lesson_22_TreesAndHeap
{
    public class Node<T, F>
    {
        public T Value { get; set; }
        public F Data { get; set; }
        public Node<T, F> Left { get; set; }

        public Node<T, F> Right { get; set; }

    }
}
