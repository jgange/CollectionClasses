namespace character
{
    using System.Reflection;
    ﻿using System.Text.Json;
    using System.Runtime.Serialization.Json;
    using System.IO;
    using System.Text;

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
                            case "System.Int32":
                            {
                                Console.WriteLine ("{0}: {1}", item.Name, propval);
                            }
                            break;
                            
                            case "System.Nullable`1[System.Int32]":
                            {
                                Console.WriteLine ("{0}: {1}", item.Name, propval);
                            }
                            break;

                            case "System.String":
                            { 
                                Console.WriteLine ("{0}: {1}", item.Name, propval);
                            }
                            break;
                            case "System.Collections.Generic.List`1[System.String]":
                            {   
                                List<string> l = new List<string>();
                                l = (List<string>)propval;
                                    Console.WriteLine(item.Name);
                                    foreach (string i in l)
                                    {
                                        Console.WriteLine ("- {0}", i);
                                    }
                            }
                            break;
                            case "System.Collections.Generic.Dictionary`2[System.String,System.Int32]":
                            {
                                Dictionary<string,int> d = new Dictionary<string,int>();
                                d = (Dictionary<string,int>)propval;
                                Console.WriteLine(item.Name);
                                foreach (var entry in d)
                                {
                                    Console.WriteLine("   {0}: {1}",entry.Key, entry.Value);
                                }
                            };
                            break;
                            default: {Console.WriteLine(item.PropertyType.ToString());};
                            break;
                        }
                    }
                }
            Console.WriteLine();
            }
        }

        static public void WriteToDisk(string fileName, Object dataElement)
        {
            var systemJsonReadable = JsonSerializer.Serialize(dataElement, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            //Console.WriteLine(systemJsonReadable);
            //Console.WriteLine();
            File.WriteAllText(fileName, systemJsonReadable);
        }

        static public List<T>? ReadFromDisk<T>(string path)
        {
            StreamReader r = new StreamReader(path);
            string? json = r.ReadToEnd();
            return JsonSerializer.Deserialize<List<T>>(json);
        }
    }
}