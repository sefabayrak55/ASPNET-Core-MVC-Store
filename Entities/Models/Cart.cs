namespace Entities.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; }
        public Cart()
        {
            Lines = new List<CartLine>();
        }

        public virtual void AddItem(Product product, int quantity)
        {
            CartLine? line = Lines.Where(l => l.Product.ProductId.Equals(product.ProductId)).FirstOrDefault();

            if (line == null)
            {
                Lines.Add(new CartLine() { Product = product, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public virtual void RemoveLine(Product product)
        {
            CartLine? line = Lines.Where(l => l.Product.ProductId.Equals(product.ProductId)).FirstOrDefault();
            if (line != null)
            {
                if (line.Quantity > 1)
                {
                    line.Quantity -= 1;
                }
                else
                {
                    Lines.RemoveAll(l => l.Product.ProductId.Equals(product.ProductId));
                }
               
            }
        }

        public decimal ComputeTotalValue() => Lines.Sum(l => l.Product.ProductPrice * l.Quantity);

        public virtual void Clear() => Lines.Clear();
    }
}