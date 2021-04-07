namespace prova_paradigma.Entities
{
    public class Node
    {
        public Node Left { get; set; }
        public Node Right { get; set; }
        public string Value { get; set; }
        
        public Node(string value)
        {
            this.Value = value;
        }
    }
}