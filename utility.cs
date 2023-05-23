namespace character
{
    using System.Reflection;

    class utilities
    {
        public static void Display(object obj)
        {
            var type = obj.GetType();
            PropertyInfo[] properties = type.GetProperties();
            {
                foreach (var item in properties)
                {
                    switch(item.PropertyType.ToString())
                    {
                        case "System.String":
                            { 
                                Console.WriteLine ("  {0}: {1}", item.Name, obj.GetType().GetProperty(item.Name).GetValue(obj,null));
                            }
                            break;
                        case "System.Collections.Generic.List`1[System.String]":
                            { Console.WriteLine ("  {0} {1}", item.Name, obj.GetType().GetProperty(item.Name).GetValue(obj,null));}
                            break;
                    }
                    //Console.WriteLine($" * {item.Name} {item.PropertyType}");
                }

                Console.WriteLine("--");
                Console.WriteLine();
             }
        }   
    }
}