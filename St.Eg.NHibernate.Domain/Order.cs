using System;
using System.Collections.Generic;
using System.Text;

namespace St.Eg.NHibernate.Domain
{
	public partial class Order
	{
		public Order()
		{
		}

        public virtual int OrderId { get; set; }
        public virtual string Comment { get; set; }
	    public virtual DateTime? ShippedDate { get; set; }
	    public virtual bool OnlineOrder { get; set; }
	    public virtual DateTime OrderDate { get; set; }
	    public virtual int PromotionId { get; set; }
	    public virtual string PurchaseOrderNumber { get; set; }
	    public virtual string SalesOrderNumber { get; set; }
	    public virtual double SubTotal { get; set; }
	    public virtual Customer Customer { get; set; }
        public virtual ShippingAddress ShippedTo { get; set; }

	    public override string ToString()
	    {
	        var sb = new StringBuilder();
	        sb.AppendFormat("{0} {1}", OrderId, OrderDate);
            if (this.Customer != null) sb.AppendFormat(" {0}", Customer.Id);
	        if (this.ShippedTo != null) sb.AppendFormat(" {0} {1}", ShippedTo.City, ShippedTo.State);
	        return sb.ToString();
	    }

	    //public virtual IEnumerable<LineItem> LineItems { get; set; }
	    //public virtual IEnumerable<Payment> Payments { get; set; }
	    //public virtual IEnumerable<Return> Returns { get; set; }

	    /*
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(this, obj))
				return true;
				
			return Equals(obj as Order);
		}
		
		public virtual bool Equals(Order obj)
		{
			if (obj == null) return false;

			if (Equals(Comment, obj.Comment) == false) return false;
			if (Equals(DueDate, obj.DueDate) == false) return false;
			if (Equals(ModifiedDate, obj.ModifiedDate) == false) return false;
			if (Equals(OnlineOrder, obj.OnlineOrder) == false) return false;
			if (Equals(OrderDate, obj.OrderDate) == false) return false;
			if (Equals(OrderId, obj.OrderId) == false) return false;
			if (Equals(PromotionId, obj.PromotionId) == false) return false;
			if (Equals(PurchaseOrderNumber, obj.PurchaseOrderNumber) == false) return false;
			if (Equals(SalesOrderNumber, obj.SalesOrderNumber) == false) return false;
			if (Equals(SubTotal, obj.SubTotal) == false) return false;
			return true;
		}
		
		public override int GetHashCode()
		{
			int result = 1;

			result = (result * 397) ^ (Comment != null ? Comment.GetHashCode() : 0);
			result = (result * 397) ^ (DueDate != null ? DueDate.GetHashCode() : 0);
			result = (result * 397) ^ ModifiedDate.GetHashCode();
			result = (result * 397) ^ OnlineOrder.GetHashCode();
			result = (result * 397) ^ OrderDate.GetHashCode();
			result = (result * 397) ^ OrderId.GetHashCode();
			result = (result * 397) ^ PromotionId.GetHashCode();
			result = (result * 397) ^ (PurchaseOrderNumber != null ? PurchaseOrderNumber.GetHashCode() : 0);
			result = (result * 397) ^ (SalesOrderNumber != null ? SalesOrderNumber.GetHashCode() : 0);
			result = (result * 397) ^ SubTotal.GetHashCode();
			return result;
		}
         * */
	}
}