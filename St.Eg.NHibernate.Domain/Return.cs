using System;
using System.Collections.Generic;

namespace St.Eg.NHibernate.Domain
{
	public partial class Return
	{
		public Return()
		{		
		}

	    public virtual string Reason { get; set; }
	    public virtual int ReturnId { get; set; }
	    public virtual DateTime Type { get; set; }
	    public virtual Order Order { get; set; }
	    /*
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(this, obj))
				return true;
				
			return Equals(obj as Return);
		}
		
		public virtual bool Equals(Return obj)
		{
			if (obj == null) return false;

			if (Equals(Reason, obj.Reason) == false) return false;
			if (Equals(ReturnId, obj.ReturnId) == false) return false;
			if (Equals(Type, obj.Type) == false) return false;
			return true;
		}
		
		public override int GetHashCode()
		{
			int result = 1;

			result = (result * 397) ^ (Reason != null ? Reason.GetHashCode() : 0);
			result = (result * 397) ^ ReturnId.GetHashCode();
			result = (result * 397) ^ Type.GetHashCode();
			return result;
		}
         * */
	}
}