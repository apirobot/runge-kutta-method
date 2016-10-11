using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RK
{
    class RK4
    {
        private double rangeFrom;
        private double rangeTo;
        private int stepNumber;
        private double initialCondition;
        private double resistance;
        private double capacity;
        private double voltage;

        public RK4(double rangeFrom, double rangeTo, int stepNumber, double initialCondition,
            double resistance, double capacity, double voltage)
        {
            this.rangeFrom = rangeFrom;
            this.rangeTo = rangeTo;
            this.stepNumber = stepNumber;
            this.initialCondition = initialCondition;
            this.resistance = resistance;
            this.capacity = capacity;
            this.voltage = voltage;
        }

        public void Solve()
        {
            int elements = stepNumber + 1;

            Data.q = new double[elements];
            Data.t = new double[elements];

            Data.q[0] = initialCondition;
            Data.t[0] = rangeFrom;

            double h = (rangeTo - rangeFrom) / stepNumber;
            double K1, K2, K3, K4;

            for (int i = 0; i < elements - 1; i++)
            {
                K1 = f(Data.t[i], Data.q[i]);
                K2 = f(Data.t[i] + h / 2, Data.q[i] + h * K1 / 2);
                K3 = f(Data.t[i] + h / 2, Data.q[i] + h * K2 / 2);
                K4 = f(Data.t[i] + h, Data.q[i] + h * K3);

                Data.q[i + 1] = Data.q[i] + h * (K1 + 2 * K2 + 2 * K3 + K4) / 6;
                Data.t[i + 1] = Data.t[i] + h;
            }

        }

        private double f(double t, double q)
        {
            return voltage / resistance - q / (resistance * capacity);
        }
    }
}
