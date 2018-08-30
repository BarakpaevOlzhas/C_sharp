using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndArray
{
    class Money
    {
        private double _nominalValue;
        private int _count;

        public Money()
        {

        }

        public Money(double nominal_value, int count)
        {
            SetNominalValue(nominal_value);
            SetCount(count);
        }

        public double GetNominalValue()
        {
            return this._nominalValue;
        }

        public void SetNominalValue(double nominalValue)
        {
            this._nominalValue = nominalValue;
        }

        public int GetCount()
        {
            return this._count;
        }

        public void SetCount(int count)
        {
            this._count = count;
        }

        public bool WillYouHaveEnoughMoney(double sum)
        {
            return (_nominalValue * _count) >= sum;
        }

        public int HowMuch(int sum)
        {         
            double amountOfMoney = _nominalValue * _count;

            return sum / (int)amountOfMoney;
        }

        public double AmountOfMoney()
        {
            return _nominalValue * _count;
        }

    }
}
