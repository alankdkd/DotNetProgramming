using System;
using System.Collections.Generic;

namespace St.Eg.NHibernate.Domain
{
	public partial class Promotion
	{
		public Promotion()
		{
		}

	    public virtual bool AllProducts { get; set; }
	    public virtual string Description { get; set; }
	    public virtual DateTime EndDate { get; set; }
	    public virtual string Name { get; set; }
	    public virtual int PromotionId { get; set; }
	    public virtual DateTime StartDate { get; set; }
	    public virtual IEnumerable<Category> Categories { get; set; }
	    public virtual IEnumerable<Product> Products { get; set; }
	    /*
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(this, obj))
				return true;
				
			return Equals(obj as Promotion);
		}
		
		public virtual bool Equals(Promotion obj)
		{
			if (obj == null) return false;

			if (Equals(AllProducts, obj.AllProducts) == false) return false;
			if (Equals(Description, obj.Description) == false) return false;
			if (Equals(EndDate, obj.EndDate) == false) return false;
			if (Equals(Name, obj.Name) == false) return false;
			if (Equals(PromotionId, obj.PromotionId) == false) return false;
			if (Equals(StartDate, obj.StartDate) == false) return false;
			return true;
		}
		
		public override int GetHashCode()
		{
			int result = 1;

			result = (result * 397) ^ AllProducts.GetHashCode();
			result = (result * 397) ^ (Description != null ? Description.GetHashCode() : 0);
			result = (result * 397) ^ EndDate.GetHashCode();
			result = (result * 397) ^ (Name != null ? Name.GetHashCode() : 0);
			result = (result * 397) ^ PromotionId.GetHashCode();
			result = (result * 397) ^ StartDate.GetHashCode();
			return result;
		}
         * */
	}
}