
    static class CreateArray
    {
        public static object[] CreateAndWrite(int min, int max)
        {
            object[] myArray;
            myArray = new object[max - min + 1];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = min++;
            }

            Console.Write("In: ");
            for (int j = 0; j < myArray.Length; j++)
            {
                Console.Write($"{myArray[j]} ");
            }

            return myArray;
        }
    }
    public class Program
    {
        public static object GetOutput(int i)
        {
            return (i % 3, i % 4, i % 5, i % 7) switch
            {
                (0, 0, 0, 0) => "fizz-muzz-buzz-guzz",
                (0, 0, 0, _) => "fizz-muzz-buzz",
                (0, 0, _, 0) => "fizz-muzz-guzz",
                (0, _, 0, 0) => "fizz-buzz-guzz",
                (_, 0, 0, 0) => "muzz-buzz-guzz",
                (0,0,_,_) => "fizz-buzz",
                (0,_,0,_) => "good-boy",
                (_,0,_,0)=> "muzz-guzz",
                (0,_,_,0) => "fizz-guzz",
                (_,_,0,0)=> "buzz-guzz",
                (_,_,_,0) => "guzz",
                (_,_,0,_) => "cat",
                (_,0,_,_) => "buzz",
                (0,_,_,_) => "dog",
                _ => i
            };
        }
        public static void Main()
        {
            object[] newArray = CreateArray.CreateAndWrite(1, 50);

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = GetOutput((int)newArray[i]);
            }
            Console.WriteLine();
            Console.Write("Out: ");
            foreach (object item in newArray)
            {
                Console.Write($"{item} ");
            }

        }
    }

