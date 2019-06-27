using System;

namespace ClassLibrary1
{
    public class IndexLibrary
    {
        /*Задание 1.
        * Создать класс, представляющий пользовательский массив с произвольной нижней границей нумерации элементов (как в Паскале), 
        * например, состоящий из 5 элементов с индексами 11, 12, 13, 14, 15. 
        * Определить: 
        * - свойства длины массива, 
        * - свойства нижней и верхней границы индекса, 
        * - индексатор для чтения и записи элемента по заданному индексу. 
        * Класс скомпилировать в динамическую библиотеку. В консольном приложении продемонстрировать работу созданного класса.
        */
        public int[] NumbaringArray;
        private int lowerBoundry;
        public int LowerBoundry         //property of lower boundry
        {
            get
            {
                return lowerBoundry;
            }
        }
        public int UpperBoundry         //property of upper boundry
        {
            get
            {
                return lowerBoundry - 1 + NumbaringArray.Length;
            }
        }
        public int LengthOfArray           //property length of array
        {
            get
            {
                return NumbaringArray.Length;
            }
        }
        public IndexLibrary(int[] array, int firstIndex)     //constructor
        {
            NumbaringArray = array;
            lowerBoundry = firstIndex;
        }
        public int this[int index]          //indexer
        {
            get
            {
                return NumbaringArray[index - lowerBoundry];
            }
            set
            {
                NumbaringArray[index - lowerBoundry] = value;
            }
        }

    }
}
