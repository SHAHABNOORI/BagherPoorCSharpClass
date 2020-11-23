using System;

namespace MergeArraysSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var namesOne = new[] { "Ali", "Amir", "Navid" };
            var namesTwo = new[] { "Ali", "Amir", "Milad", "Hirad" };

            var test = Merge(namesOne, namesTwo);
        }

        static Result Find(string[] listOne, string[] listTwo, string name)
        {
            var x=new Result();

            x.IsFind = true;
            x.IsInArrayOne = true;

            return x;
        }

        static string[] Merge(string[] listOne, string[] listTwo)
        {
            var length = listOne.Length + listTwo.Length;
            var result = new string[length];
            var index = 0; foreach (var s in listOne)
            {

                result[index] = s;
                index++;
            }

            foreach (var item in listTwo)
            {
                var found = false;
                foreach (var s in result)
                {
                    if (item == s)
                    {
                        found = true;
                        break;
                    }

                }

                if (found == false)
                {
                    result[index] = item;
                    index++;
                }

            }

            return result;
        }

    }
}
