using System;
using System.Collections.Generic;

namespace St.Eg.NHibernate.Domain
{
	public partial class Shipper
	{
		public Shipper()
		{
		}

	    public virtual string Name { get; set; }
	    public virtual int ShipperId { get; set; }
	    public virtual IEnumerable<Shipment> Shipments { get; set; }
	    /*
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(this, obj))
				return true;
				
			return Equals(obj as Shipper);
		}
		
		public virtual bool Equals(Shipper obj)
		{
			if (obj == null) return false;

			if (Equals(Name, obj.Name) == false) return false;
			if (Equals(ShipperId, obj.ShipperId) == false) return false;
			return true;
		}
		
		public override int GetHashCode()
		{
			int result = 1;

			result = (result * 397) ^ (Name != null ? Name.GetHashCode() : 0);
			result = (result * 397) ^ ShipperId.GetHashCode();
			return result;
		}
         * */
	}
}