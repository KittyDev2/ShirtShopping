using System.ComponentModel.DataAnnotations.Schema;
using ShirtShopping.CartAPI.Model.Base;

namespace ShirtShopping.CartAPI.Model;

[Table("cart_detail")]
public class CartDetail : BaseEntity
{
    
    public long CartHeaderId { get; set; }
    
    [ForeignKey("CartHeaderId")]
    public CartHeader CartHeader { get; set; }
    
    
    public long ProductId { get; set; }
    
    [ForeignKey("ProductId")]
    public Product Product { get; set; }
    
    [Column("Count")]
    public int Count { set; get; }
}