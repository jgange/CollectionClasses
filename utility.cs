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
                    object? propval = obj.GetType().GetProperty(item.Name)?.GetValue(obj,null);
                    if (propval!=null)
                    {
                        switch(item.PropertyType.ToString())
                        {
                            case "System.String":
                            { 
                                Console.WriteLine ("{0}: {1}", item.Name, propval);
                            }
                            break;
                            case "System.Collections.Generic.List`1[System.String]":
                            {   List<string> l = new List<string>();
                                l = (List<string>)propval;
                                    Console.WriteLine(item.Name);
                                    foreach (string i in l)
                                    {
                                        Console.WriteLine ("- {0}", i);
                                    }
                            }
                            break;
                        }
                    }
                }
            Console.WriteLine();
            }
        }   
    }
}