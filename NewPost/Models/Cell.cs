namespace NewPost.Models
{
    public class Cell
    {
        public int Id { get; set; }
        public int Width { get; set; }
        public int Heigth { get; set; }
        public int Depth { get; set; }
        public int MaxWeight { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department? Department { get; set; }
        public bool IsFull { get; set; }
    }
}
