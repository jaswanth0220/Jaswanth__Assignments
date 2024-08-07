using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HandsOnApiUsingEntityFrameWork.Entities
{
    public class Order
    {
        [Key]
        public Guid OrderId { get; set; }


        [ForeignKey("Product")]
        public int ProductId { get; set; }
        //Navigation property
        public Product Product { get; set; }

        [Column(TypeName ="Date")]
        public DateTime OrderDate { get; set; }
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

    }
}
