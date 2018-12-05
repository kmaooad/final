using System;
using Xunit;
using FluentAssertions;
using FsCheck;
using FsCheck.Xunit;
using System.Linq;
using Microsoft.FSharp.Collections;

namespace KmaOoad18.Final.P1
{
    public class Spec
    {
        [Property]
        public void CanRefill(int initQty)
        {
            if (Acceptable(initQty))
            {
                AtmClient atm = Refill(initQty);

                // Amount should be valid after refill
                atm.AvailableAmount().Should().Be(Total(initQty));

                // Banknotes should match what has been refilled
                atm.AvailableBanknotes().OrderBy(b => b).Should().Equal(Banknotes.OrderBy(b => b));
            }
        }

        [Property]
        public void CanWithdrawAll(int initQty)
        {
            if (Acceptable(initQty))
            {
                AtmClient atm = Refill(initQty);

                atm.Withdraw(atm.AvailableAmount()).AvailableAmount().Should().Be(0);
            }
        }

        [Property]
        public void CanWithdraw(int initQty, int withdrawQty)
        {
            if (Acceptable(initQty) && withdrawQty > 0 && withdrawQty < 20)
            {
                AtmClient atm = Refill(initQty);

                if (withdrawQty > initQty)
                {
                    var initial = atm.AvailableAmount();
                    atm.Withdraw(Total(withdrawQty)).AvailableAmount().Should().Be(initial);
                }
                else
                {
                    var initial = atm.AvailableAmount();
                    var withdrawn = Total(withdrawQty);
                    atm.Withdraw(withdrawn).AvailableAmount().Should().Be(initial - withdrawn);
                }
            }
        }

        [Fact]
        public void CanTrackBanknotes()
        {
            foreach (var b in Banknotes)
            {
                var remains = Banknotes.Where(bb => bb != b).ToList();
                Refill(1).Withdraw(b).AvailableBanknotes().OrderBy(e => e).Should().Equal(remains.OrderBy(e => e));
            }
        }

        

        #region Private helpers 

        private static int Total(int qty)
        {
            return Banknotes.Select(b => b * qty).Sum();
        }

        private static bool Acceptable(int initQty)
        {
            return initQty > 0 && initQty < 1000;
        }

        private static readonly int[] Banknotes = new[] { 10, 50, 100, 200, 500 };

        private static AtmClient Refill(int initQty)
        {
            var cash = Banknotes.Select(b => (b, initQty)).ToArray();

            var atm = new AtmClient().Refill(cash);

            return atm;
        }
        #endregion
    }
}
