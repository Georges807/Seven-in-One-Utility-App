using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Name:Arshath Wuvais
//Date:2023-07-21
//Description:Cal Class
namespace Object_Oriented_Project_S2
{
    internal class Calculator
    {
        //private fields
        decimal operand1;
        decimal operand2;
        decimal currentValue;
        string op;



        //public constructers
        public Calculator() { }

        public Calculator(decimal operand1, decimal operand2, string op, decimal currentValue)
        {
            this.operand1 = operand1;
            this.operand2 = operand2;
            this.currentValue = currentValue;
            this.op = op;


        }





        //public properties
        //public decimal Operand1
        //{
        //    get { return operand1; }
        //    set { operand1 = value; }
        //}
        //public decimal Operand2
        //{
        //    get { return operand2; }
        //    set { operand2 = value; }
        //}

        //public string OP
        //{
        //    get { return op; }
        //    set { op = value; }
        //}
        public decimal CurrentValue
        {
            get { return currentValue; }
            set { currentValue = value; }
        }






        //public methods
        public void Add(decimal displayValue)
        {
            if (op == null)
            {
                operand1 = displayValue;
                currentValue = displayValue;
                op = "+";
            }
            else
            {
                operand2 = displayValue;

                op = "+";
            }




        }



        public void Subtract(decimal displayValue)
        {
            if (op == null)
            {
                operand1 = displayValue;
                currentValue = displayValue;
                op = "-";
            }
            else
            {
                operand2 = displayValue;

                op = "-";
            }
        }



        public void Multiply(decimal displayValue)
        {
            if (op == null)
            {
                operand1 = displayValue;
                currentValue = displayValue;
                op = "*";
            }
            else
            {
                operand2 = displayValue;

                op = "*";
            }
        }



        public void Divide(decimal displayValue)
        {
            if (op == null)
            {
                operand1 = displayValue;
                currentValue = displayValue;
                op = "/";
            }
            else
            {
                operand2 = displayValue;

                op = "/";
            }
        }



        public decimal Equals()
        {
            if (op == "+")
            {
                return operand1 + operand2;
            }
            else if (op == "-")
            {
                return operand1 - operand2;
            }
            else if (op == "*")
            {
                return operand1 * operand2;
            }
            else if (op == "/")
            {
                if (operand1 != 0 && operand2 != 0)
                {
                    return operand1 / operand2;
                }
                else
                {
                    return 0;
                }

            }
            else
            {
                return 0;
            }



        }



        public void Clear()
        {
            operand1 = 0;
            operand2 = 0;
            currentValue = 0;
            op = null;
        }
    }
}