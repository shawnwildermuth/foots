namespace Foots.API.Data.Entities;

public class CartItem
{
  public int Id { get; set; }
  public required int ProductId { get; set; }
  public Product? ProductItem { get; set; }
  public required int CartId { get; set; }
  public Cart? Cart { get; set; }
  public int Quantity { get; set; }
  public decimal Price { get; set; }
  public short Discount { get; set; }
}
