using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

/* Question: Select "Yes" if the statement is true. Otherwise, select "No"
 * Class1 can be serialized by using the BinaryFormatter class
 * Class2 can be serialized by using the BinaryFormatter class
 * Class2 can be serialized by using the DataContractSerializer class
*/

namespace ClassFormatter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting ClassFormatter...");

            Class1 class1 = new Class1("Alvaro");
            Class2 class2 = new Class2();
            class2.Values = new List<string> { "Alvaro" };

            // To serialize the hashtable and its key/value pairs,  
            // you must first open a stream for writing. 
            // In this case, use a file stream.
            FileStream fs = new FileStream("DataFile.dat", FileMode.Create);

            Console.WriteLine("Starting BinaryFormatter serialization");
            // Construct a BinaryFormatter and use it to serialize the data to the stream.
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, class1);
                formatter.Serialize(fs, class2);
            }
            catch (SerializationException e)
            {
                // To serialize a class with BinaryFormatter, we must use the attribute [Serializable] for the class
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
                Console.WriteLine("Ended BinaryFormatter serialization");
            }

            Console.WriteLine("Starting DataContract serialization");

            MemoryStream stream1 = new MemoryStream();
            //Serialize the Record object to a memory stream using DataContractSerializer.  
            DataContractSerializer serializer = new DataContractSerializer(typeof(Class2));
            serializer.WriteObject(stream1, class2);
            serializer.ToString();

            Console.WriteLine("Ended DataContract serialization");

            Console.ReadLine();
        }
    }

    [DataContract]
    public class Class1
    {
        [DataMember]
        public string OneValue { get; set; }

        public Class1(string oneValue)
        {
            OneValue = oneValue;
        }
    }

    [DataContract]
    public class Class2
    {
        [DataMember]
        public List<string> Values { get; set; }

        public Class2(List<string> values)
        {
            Values = values;
        }

        public Class2() { }
    }
}
