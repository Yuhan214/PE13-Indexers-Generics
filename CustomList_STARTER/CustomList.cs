using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList_STARTER
{
    /// <summary>
    /// A list of doubles with custom-written methods.
    /// </summary>
    internal class CustomList
    {
        // --------------------------------------------------------------------
        // Fields of the class
        // --------------------------------------------------------------------

        private double[] data;      // Underlying array that holds all list data
        private int count;          // Size of the list

        // **************************************************
        // * Answer the following question:                 *
        // * Why DON'T we need a field that holds the       *
        // * list's capacity?                               *
        // **************************************************
        // ANSWER: 
        //
        //


        // --------------------------------------------------------------------
        // Properties of the class
        // --------------------------------------------------------------------

        // **************************************************
        // * Answer the following questions:                *
        // * Why is the Count property get-only?            *
        // * Why not include a set?                         *
        // **************************************************
        // ANSWER: 
        //
        //

        /// <summary>
        /// Returns the current amount of data in the list.
        /// </summary>
        public int Count
        {
            get { return count; }
        }

        /// <summary>
        /// Returns the overall number of elements the internal data structure
        /// can hold before a resize operation.
        /// </summary>
        public int Capacity
        {
            get { return data.Length; }
        }


        // **************************************************
        // * Answer the following question:                 *
        // * Why DON'T we want a property that gets or sets *
        // * the data array?                                *
        // **************************************************
        // ANSWER: 
        //
        //

        /*
        // NOPE! Don't do this! Included simply to show what NOT to do.
        public double[] Data
        {
            get { return data; }
            set { data = value; }
        }
        */        


        // --------------------------------------------------------------------
        // Class Constructors
        // --------------------------------------------------------------------

        /// <summary>
        /// Instantiates a new list of doubles with a starting size of 4.
        /// </summary>
        public CustomList()
        {
            data = new double[4];
        }


        /// <summary>
        /// Instantiates a new list of doubles with a specified starting size.
        /// </summary>
        /// <param name="listSize">Initial size of the list.</param>
        public CustomList(int listSize)
        {
            data = new double[listSize];
        }


        // --------------------------------------------------------------------
        // Methods
        // --------------------------------------------------------------------

        /// <summary>
        /// Add new data to the list.
        /// </summary>
        /// <param name="item">Item to add to the next available spot.</param>
        public void Add(double item)
        {
            // **************************************************
            // * Comment this code.                             *
            // * WHAT does it do and, more importantly,         *
            // * WHY is it happening?                           *
            // **************************************************
            if (count == data.Length - 1)
            {
                IncreaseSizeAndCopyData();
            }

            // **************************************************
            // * Comment this code.                             *
            // * WHAT does it do and, more importantly,         *
            // * WHY is it happening?                           *
            // **************************************************
            data[count] = item;
            count++;
        }


        /// <summary>
        /// Doubles the size of the data array.
        /// </summary>
        public void IncreaseSizeAndCopyData()
        {
            // **************************************************
            // * Comment this code.                             *
            // * WHAT does it do and, more importantly,         *
            // * WHY is it happening?                           *
            // **************************************************
            if (count != data.Length - 1)
            {
                return;
            }

            // **************************************************
            // * Comment this code.                             *
            // * WHAT does it do and, more importantly,         *
            // * WHY is it happening?                           *
            // **************************************************
            double[] largerCopy = new double[data.Length * 2];

            for (int i = 0; i < data.Length; i++)
            {
                largerCopy[i] = data[i];
            }

            data = largerCopy;
        }


        /// <summary>
        /// Retrieve data at an index.
        /// </summary>
        /// <param name="index">Integer index between 0 and the list's count.</param>
        /// <returns>Data at a specified index.</returns>
        /// <exception cref="Exception">Thrown exception when the index is out of range.</exception>
        public double GetData(int index)
        {
            // **************************************************
            // * Comment this code.                             *
            // * WHAT does it do and, more importantly,         *
            // * WHY is it happening?                           *
            // **************************************************
            if (index >= 0 && index < count)
            {
                return data[index];
            }

            // **************************************************
            // * Comment this code.                             *
            // * WHAT does it do and, more importantly,         *
            // * WHY is it happening?                           *
            // **************************************************
            string exceptionMessage;
            if (count == 0)
            {
                exceptionMessage = "No data to retrieve, list is empty.";
            }
            else 
            {
                exceptionMessage = String.Format(
                    "Index {0} is out of range. Index must be between 0 and {1}",
                    index,
                    count - 1);
            }
            throw new IndexOutOfRangeException(exceptionMessage);
        }


        /// <summary>
        /// CHanges the value of a specific index
        /// </summary>
        /// <param name="index">Integer index between 0 and the lists's count.</param>
        /// <param name="newValue">Value to insert at the index.</param>
        /// <exception cref="IndexOutOfRangeException">Thrown exception when the index is out of range.</exception>
        public void SetData(int index, double newValue)
        {
            // **************************************************
            // * Comment this code.                             *
            // * WHAT does it do and, more importantly,         *
            // * WHY is it happening?                           *
            // **************************************************
            if (index >= 0 && index < count)
            {
                data[index] = newValue;
                return;
            }

            // **************************************************
            // * Comment this code.                             *
            // * WHAT does it do and, more importantly,         *
            // * WHY is it happening?                           *
            // **************************************************
            string exceptionMessage;
            if (count == 0)
            {
                exceptionMessage = "No data to change, list is empty.";
            }
            else
            {
                exceptionMessage = String.Format(
                    "Index {0} is out of range. Index must be between 0 and {1}",
                    index,
                    count - 1);
            }
            throw new IndexOutOfRangeException(exceptionMessage);
        }
    }
}
