using System.Linq;
using System.Reflection.PortableExecutable;

namespace planter.Domain.Entities;

public class Customer : BaseAuditableEntity, IAggregateRoot
{
    public Guid customer_id { get; private set; }
    public string Name { get; private set; }
    public string Email { get; private set; }

    public string phone { get; private set; }

   // readonly Cart cart;


    private ICollection<Order> Orders;



    public Customer(Guid customer_id, string name, string email, string phone)
    {
        this.customer_id = Guid.NewGuid();
        Name = name;
        Email = email;
        this.phone = phone;
       // this.cart = new Cart(customer_id);
        Orders = new List<Order>();

        this.AddDomainEvent(new CustomerRegisterEvent(customer_id));
    }


    public Guid MakeOrder(ICollection<OrderItem> order_Items)
    {

        Order _Order = new Order(customer_id, order_Items);
        Orders.Add(_Order);
        this.AddDomainEvent(new OrderMadeEvent(_Order.Order_ID, customer_id, _Order.TotalPrice));

        return _Order.Order_ID;
    }


    public void ChangeOrder(Guid order_ID, ICollection<OrderItem> order_Items)
    {
        Order Cur_Order = Orders.Single(O => O.Order_ID == order_ID);
        Cur_Order.Change(order_Items);
        this.AddDomainEvent(new OrderChangedEvent(order_ID));
    }

    public void RemoveOrder(Guid OrderID)
    {

        Order Cur_Order = Orders.Single(O => O.Order_ID == OrderID);
        this.AddDomainEvent(new OrderRemovedEvent(OrderID));

       Orders.Remove(Cur_Order);

    }

}
