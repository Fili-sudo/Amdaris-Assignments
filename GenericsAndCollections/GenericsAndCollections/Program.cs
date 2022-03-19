// See https://aka.ms/new-console-template for more information


namespace GenericsAndCollections
{
    public class Program
    {
        public static void Main(String[] args)
        {
#if RELEASE
            int[] array = new int[] { 1, 2, 4, 3, 5, 6, 7, 8, 9, 10 };

            GenericCollection<int> collection = new GenericCollection<int>(array);
            collection.AddItem(1);
            collection.AddItem(2);
            collection.AddItem(3);
            collection.AddItem(4);
            collection.AddItem(5);
            collection.AddItem(6);
            for (int i = 0; i < collection.Index; i++)
            {
                Console.Write("{0} ", collection.GetIndex(i));
            }
            collection.Swap(2, 5);
            Console.WriteLine();
            for (int i = 0; i < collection.Index; i++)
            {
                Console.Write("{0} ", collection.GetIndex(i));
            }

            Console.WriteLine();

            GenericCollection<string> string_collection = new GenericCollection<string>();
            string_collection.AddItem("John");
            string_collection.AddItem("Daniel");
            string_collection.AddItem("Amanda");
            for (int i = 0; i < string_collection.Index; i++)
            {
                Console.Write("{0} ", string_collection.GetIndex(i));
            }

            Console.WriteLine();

            IShape[] shapesArray = new IShape[3]
            {
                new Circle(2,2),
                new Circle(3,2),
                new Rectangle(3,3,2),
            };
            GenericCollection<IShape> shape_collection = new GenericCollection<IShape>(shapesArray);
            shape_collection.AddItem(new Circle(7, 3));

            for (int i = 0; i < shape_collection.Index; i++)
            {
                shape_collection.GetIndex(i).Draw();
            }
#endif
            Fruit[] fruits = new Fruit[3];
            for (int i = 0; i < fruits.Length; i++)
            {
                try
                {
                    fruits[i] = new Orange(Colors.Blue, 300);
                }
                catch (InvalidColorException ex)
                {
                    Log(ex);
                }
                
            }
            Console.WriteLine();
            List<Fruit> list = new List<Fruit>()
            {
                new Orange(Colors.Red, 300),
                new Apple(Colors.Green, 150),
                new Orange(Colors.Orange, 175)
            };

            foreach (Fruit fruit in list)
            {
                Console.Write(fruit.ToString());
                Console.WriteLine(fruit.Weight);
            }
            list.Sort();
            foreach (Fruit fruit in list)
            {
                Console.Write(fruit.ToString());
                Console.WriteLine(fruit.Weight);
            }

            
            

            var filestream = File.Create("C:/Users/david/OneDrive/Desktop/Amdaris/Amdaris-Assignments/info.txt");

            var sw = new StreamWriter(filestream);
            
            foreach (Fruit fruit in list)
            {
                sw.Write(fruit);
                sw.WriteLine(fruit.Weight);
            }
            sw.Close();
        }
        private static void Log(Exception exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
}


