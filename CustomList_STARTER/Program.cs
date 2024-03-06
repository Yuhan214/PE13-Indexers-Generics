namespace CustomList_STARTER
{

    // ****************************************************
    // * Enter your names and the current date here.      *
    // * Enter your names on the SAME LINE # 9 to force   *
    // * a merge conflict.                                *
    // ****************************************************
    // 



    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // Test the CustomList class!
            // ----------------------------------------------------------------

            // ***** Instantiation *****
            // 1. Instantiate a custom list of doubles with capacity of 2.
            //    Capacity 2 forces a resize quickly.
            CustomList myList = new CustomList(2);


            // ***** GetData/SetData Exceptions *****
            // 2. Test GetData and SetData's exceptions are properly working for an empty list.
            Console.WriteLine("--> List is empty. Exceptions should occur... <--");
            try
            {
                Console.WriteLine(myList.GetData(0));
            }
            catch (Exception error)
            {
                Console.WriteLine("Error occurred: " + error.Message);
            }

            try
            {
                myList.SetData(0, 12345.6789);
            }
            catch (Exception error)
            {
                Console.WriteLine("Error occurred: " + error.Message);
            }


            // ***** Add values to list *****
            // 3. Add data to the list
            myList.Add(2.5);
            myList.Add(4.2);
            myList.Add(592);
            myList.Add(912.68);
            myList.Add(1943.131);


            // ***** GetData *****
            // 4. Print all data in the list by retrieving each index
            // ** AFTER the list is generic...  change the calls to GetData to utilize the indexer instead. 
            Console.WriteLine("\n--> Values in my list <--");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList.GetData(i));
            }


            // ***** SetData *****
            // 5. Test the SetData method and reprint for confirmation
            myList.SetData(0, 0);
            myList.SetData(myList.Count - 1, myList.Count - 1);

            Console.WriteLine("\n--> Values in my list <--");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList.GetData(i));
            }


            // ***** GetData Exceptions *****
            // 6. Test that GetData's exceptions are properly working for
            //    a list that contains data. Test -1 and a too-large index.
            Console.WriteLine("\n--> List contains data. Exceptions should occur with invalid indices... <--");
            try
            {
                Console.WriteLine(myList.GetData(-1));
            }
            catch(Exception error)
            {
                Console.WriteLine("Error occurred: " + error.Message);
            }

            try
            {
                Console.WriteLine(myList.GetData(myList.Count));
            }
            catch (Exception error)
            {
                Console.WriteLine("Error occurred: " + error.Message);
            }


            // ***** SetData Exceptions *****
            // 7. Test that the SetData's exceptions are properly working for
            //    a list that contains data. Test -1 and a too-large index.
            try
            {
                myList.SetData(-1, 12345.6789);
            }
            catch (Exception error)
            {
                Console.WriteLine("Error occurred: " + error.Message);
            }

            try
            {
                myList.SetData(myList.Count, 12345.6789);
            }
            catch (Exception error)
            {
                Console.WriteLine("Error occurred: " + error.Message);
            }

            // ***** Count and Capacity *****
            // 8. Test the count and capacity properties.
            Console.WriteLine("\nCount: " + myList.Count);
            Console.WriteLine("Capacity: " + myList.Capacity);
        }
    }
}