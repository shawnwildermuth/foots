namespace Foots.API.Data.Entities;

public class Cart
{
  public int Id { get; set; }
  public DateTime DateOpened { get; set; }

  public virtual ICollection<CartItem> Items { get; set; } = new List<CartItem>();
}
