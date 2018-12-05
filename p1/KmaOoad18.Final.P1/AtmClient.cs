using System.Collections.Generic;

namespace KmaOoad18.Final.P1
{
    public class AtmClient
    {
        // What banknotes ATM has at the moment, e.g. [50, 200, 500] etc
        public List<int> AvailableBanknotes()
        {
            return new List<int>();
        }

        // How much money ATM has
        public long AvailableAmount()
        {
            return -1;
        }

        // Input is list of pairs - banknote and its quantity, e.g. (100, 1000), (200, 500) etc,
        // that means we load ATM with 1000 of 100 banknotes and 500 of 200 banknotes
        public AtmClient Refill(params (int banknote, int qty)[] cash)
        {
            // Refill ATM with given cash amount

            return this;
        }

        // Take provided amount of money from the ATM
        // Check that ATM has enough banknotes to give that amount
        public AtmClient Withdraw(long amount)
        {
            // Update ATM 

            return this;
        }
    }
}
