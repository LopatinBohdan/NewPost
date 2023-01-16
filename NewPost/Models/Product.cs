namespace NewPost.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int senderClientId { get; set; }
        public int reciplientClientId { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int depth { get; set; }
        public int weight { get; set; }
        public int CellId { get; set; }
        public int ProductStatusId { get; set; }
        public virtual ProductStatus? ProductStatus { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime SendBackTime { get; set; }
        public int DestinationDepartmentId{ get; set; }
        public int DeliveredDepartmentId{ get; set; }
        public decimal Price{ get; set; }
    }
}
