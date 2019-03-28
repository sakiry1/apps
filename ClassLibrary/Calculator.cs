using System;
using System.Collections.Generic;
using System.Text;

namespace prob1
{
    public class Calculator

    {
        //atributo
        private static Calculator calc;
        //Constructor
        static Calculator()
        {
            calc = new Calculator();
        }
        //Metodos
        public static string DoOperation(double num1, double num2, string op)
        {
            //// Default value is "not-a-number" which we use if an operation, such as division, could result in an error   
            //double result = double.NaN;
            switch (op) {

                case "+":
                    {
                        Suma(num1,num2);
                        break; }
                case "-":
                    {
                        Resta(num1,num2);
                        break;
                    }
                case "x":
                    {
                        Multiplicacion(num1, num2);
                        break;
                    }
                case "/":
                    {
                        Division(num1, num2);
                        break;
                    }

            }


            return op;
        }

        public static double Suma(double num1, double num2)
        {
            var resultado = num1 + num2;
            return resultado;
        }

        public static double Resta(double num1, double num2)
        {
            var resultado = num1 - num2;
            return resultado;
        }
        public static double Multiplicacion(double num1, double num2)
        {
            var resultado = num1 * num2;
            return resultado;
        }
        public static double Division(double num1, double num2)
        {
            var resultado = num1 / num2;
            return resultado;
        }
    }
}


