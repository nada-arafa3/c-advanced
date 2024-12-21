using System.Collections;

namespace c__advanced
{
     internal class Program
    {
         static bool Exists<T>(List<T> list, Predicate<T> predicate)
        {

            foreach (T item in list)
            {
                if (!predicate(item)) { return false; }
                return true;
            }
       

        static void Main(string[] args)
        {


            #region session three
            List<int> list = new List<int>();
            list.Exists();

            #endregion



        }
        #region session two 



        #region 1

        static void Reverse(ArrayList arr)
        {
            for (int i = 0; i < arr.Count / 2; i++)
            {

                object temp = arr[i];
                arr[i] = arr[arr.Count - i - 1];

            }


        }
    }
    #endregion

    #region 2
    static List<int> EvenNUms(List<int> input)
        {
            List<int> result = new List<int>();
            foreach (int i in input) {
                if (i % 2 == 0) {
                    result.Add(i);

                } } } }

    #endregion



    #endregion

   


}
