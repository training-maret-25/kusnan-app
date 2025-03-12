/* Kode Awal
public class OrderService
{
    public double CalculateTotalPrice(double price, string discountType)
    {
        if (discountType == "Percentage")
        {
            return price * 0.9; // Diskon 10%
        }
        else if (discountType == "Fixed")
        {
            return price - 50; // Diskon tetap Rp 50
        }
        else
        {
            return price;
        }
    }
}
*/

// interface discount
public interface DiscountStrategy
{
    double ApplyDiscount(double price);
}

// discount 10%
public class PercentageDiscount : DiscountStrategy
{
    public double ApplyDiscount(double price)
    {
        return price * 0.9; // Diskon 10%
    }
}

// discount tetap Rp 50
public class FixedDiscount : DiscountStrategy
{
    public double ApplyDiscount(double price)
    {
        return price - 50; // Diskon tetap Rp 50
    }
}

// tampa discount 
public class NoDiscount : DiscountStrategy
{
    public double ApplyDiscount(double price)
    {
        return price; // Gak dikasih diskon
    }
}

public class OrderService
{
    private readonly DiscountStrategy _discountStrategy;

    public OrderService(DiscountStrategy discountStrategy)
    {
        _discountStrategy = discountStrategy;
    }

    public double CalculateTotalPrice (double price)
    {
        return _discountStrategy.ApplyDiscount(price);
    }
}

class oop1
{
    static void Main()
    {
        double price = 2000;

        DiscountStrategy discount = new FixedDiscount();

        OrderService orderservice = new OrderService(discount);
        double totalprice = orderservice.CalculateTotalPrice(price);

        Console.WriteLine($"Total Harga {totalprice}");
    }
}