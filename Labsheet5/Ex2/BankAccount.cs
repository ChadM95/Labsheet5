using System;
namespace Ex2
{
	public class BankAccount
	{
		//properties
		public string AccNo { get; set; }
        public int Balance { get; set; }
        public int OverdraftLimit { get; set; }



		//constructor 1
        public BankAccount(string accNo, int overdraftLimit)
		{
			AccNo = accNo;
			OverdraftLimit = overdraftLimit;
		}



	}
}

