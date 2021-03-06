using System;
using System.Collections.Generic;

namespace St.Eg.NHibernate.Domain
{
	public partial class Category
	{
		public Category()
		{
		}

	    public virtual int CategoryId { get; set; }
	    public virtual string Name { get; set; }
	    public virtual IEnumerable<Product> Products { get; set; }
	    public virtual Promotion Promotion { get; set; }

	    /*
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(this, obj))
				return true;
				
			return Equals(obj as Category);
		}
		
		public virtual bool Equals(Category obj)
		{
			if (obj == null) return false;

			if (Equals(CategoryId, obj.CategoryId) == false) return false;
			if (Equals(Name, obj.Name) == false) return false;
			return true;
		}
		
		public override int GetHashCode()
		{
			int result = 1;

			result = (result * 397) ^ CategoryId.GetHashCode();
			result = (result * 397) ^ (Name != null ? Name.GetHashCode() : 0);
			return result;
		}
         * */
	}
}