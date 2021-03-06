using System;
using System.Collections.Generic;

namespace St.Eg.NHibernate.Domain
{
	public partial class Payment
	{
		public Payment()
		{		
		}

	    public virtual double Amount { get; set; }
	    public virtual DateTime Date { get; set; }
	    public virtual int PaymentId { get; set; }
	    public virtual Order Order { get; set; }
	    /*
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(this, obj))
				return true;
				
			return Equals(obj as Payment);
		}
		
		public virtual bool Equals(Payment obj)
		{
			if (obj == null) return false;

			if (Equals(Amount, obj.Amount) == false) return false;
			if (Equals(Date, obj.Date) == false) return false;
			if (Equals(PaymentId, obj.PaymentId) == false) return false;
			return true;
		}
		
		public override int GetHashCode()
		{
			int result = 1;

			result = (result * 397) ^ Amount.GetHashCode();
			result = (result * 397) ^ Date.GetHashCode();
			result = (result * 397) ^ PaymentId.GetHashCode();
			return result;
		}
         * */
	}
}