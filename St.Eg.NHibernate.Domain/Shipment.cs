using System;
using System.Collections.Generic;

namespace St.Eg.NHibernate.Domain
{
	public partial class Shipment
	{
		public Shipment()
		{
		}

	    public virtual DateTime DateShipped { get; set; }
	    public virtual bool EntireOrder { get; set; }
	    public virtual int OrderId { get; set; }
	    public virtual int ShipmentId { get; set; }
	    public virtual IEnumerable<LineItem> LineItems { get; set; }
	    public virtual Shipper Shipper { get; set; }
	    /*
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(this, obj))
				return true;
				
			return Equals(obj as Shipment);
		}
		
		public virtual bool Equals(Shipment obj)
		{
			if (obj == null) return false;

			if (Equals(DateShipped, obj.DateShipped) == false) return false;
			if (Equals(EntireOrder, obj.EntireOrder) == false) return false;
			if (Equals(OrderId, obj.OrderId) == false) return false;
			if (Equals(ShipmentId, obj.ShipmentId) == false) return false;
			return true;
		}
		
		public override int GetHashCode()
		{
			int result = 1;

			result = (result * 397) ^ DateShipped.GetHashCode();
			result = (result * 397) ^ EntireOrder.GetHashCode();
			result = (result * 397) ^ OrderId.GetHashCode();
			result = (result * 397) ^ ShipmentId.GetHashCode();
			return result;
		}
         * */
	}
}