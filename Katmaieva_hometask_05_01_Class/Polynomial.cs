using System;
using System.Collections.Generic;
using System.Text;

namespace Katmaieva_hometask_05_Class
{
    /*Задание 2.
     * Разработать класс «многочлен» для работы с многочленами от одной переменной и 
     * перегрузить для класса операции, допустимые для работы с многочленами (сложение, вычитание, умножение). 
     * В классе определить свойства (например, степень многочлена), 
     * индексатор на чтение и запись (доступ к коэффициенту по индексу степени), 
     * метод, возвращающий строковое представление значения многочлена в удобном для восприятия виде, 
     * например, «5х^3 + 2x^2 + 45» - для этой цели перегружается метод ToString().  
     * Класс скомпилировать в динамическую библиотеку.  
     * В консольном приложении продемонстрировать работу созданного класса*/

    class Polynomial
    {
        private int[] arrayOfCoefficients;                   

        public Polynomial(int[] array)                    //constructor
        {
            this.arrayOfCoefficients = array;
        }
        public int DegreeIndex                              //property for degree
        {
            get
            {
                for (int i = arrayOfCoefficients.Length - 1; i > 0; i--)
                {
                    if (arrayOfCoefficients[i] == 0)
                        continue;
                    return i;
                }
                return 0;
            }
        }

        public override string ToString()
        {
            string result = "";
            for (int i = arrayOfCoefficients.Length-1; i >= 0; i--)
            {
                string sum = "";                        //"+" or "-" polynomial coefficient sign
                int degree = i + 1;
                if (arrayOfCoefficients[i] == 0)
                {
                    result += "";
                    continue;
                }
                else
                {
                    if (arrayOfCoefficients[i] > 0)
                    {
                        if (i == arrayOfCoefficients.Length-1)
                            sum = "";
                        else
                            sum = "+";
                    }
                    else
                        sum = "";
                    if (degree == 1)                                   //for х^1
                    {
                        result += sum + arrayOfCoefficients[i] + "x";
                    }
                    else
                    {
                        result += sum + arrayOfCoefficients[i] + "x" + "^" + degree;
                    }
                }
            }
            return result;
        }


        public int this[int degreeIndex]                          //indexer - access to the coefficient by the degree index
        {
            get
            {
                return arrayOfCoefficients[degreeIndex];
            }
            set
            {
                arrayOfCoefficients[degreeIndex] = value;
            }
        }

        public static Polynomial operator +(Polynomial left, Polynomial right)                  //sum overload
        {
            int biggerPolynom = left.DegreeIndex >= right.DegreeIndex ? left.DegreeIndex : right.DegreeIndex; //find the longest polynomial
            int[] result = new int[biggerPolynom+1];
            for (int i=biggerPolynom; i >=0; i--)
            {
                result[i] = left[i] + right[i];
            }
            return new Polynomial(result);
        }
        public static Polynomial operator -(Polynomial left, Polynomial right)                     //minus overload
        {
            int biggerPolynom = left.DegreeIndex >= right.DegreeIndex ? left.DegreeIndex : right.DegreeIndex; //find the longest polynomial
            int[] result = new int[biggerPolynom + 1];
            for (int i = biggerPolynom; i >= 0; i--)
            {
                result[i] = left[i] - right[i];
            }
            return new Polynomial(result);
        }

        public static Polynomial operator *(Polynomial left, Polynomial right)                  //multiply overload
        {
            int[] result = new int[left.DegreeIndex + 1 + right.DegreeIndex];
            for (int i = left.DegreeIndex; i>=0; i--)
            {
                for (int j=right.DegreeIndex; j>=0; j--)
                {
                    result[i+j] += left[i] * right[i];
                }
            }
            return new Polynomial(result);
        }
    }

}
