using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace LearningLine.Practice
{
    [Serializable]
    public class SalesReceipt
    {
        string id;
        public string Id { get { return id; } set { id = value; } }

        DateTime date;
        public DateTime Date { get { return date; } set { date = value; } }

        int quantity;
        public int Quantity { get { return quantity; } set { quantity = value; } }

        string description;
        public string Description { get { return description; } set { description = value; } }
    }

    public static class SalesReceiptFile
    {
        public static SalesReceipt[] Read(string filename)
        {
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.None))
            {
                formatter.Binder = new SalesReceiptBinder();
                return (SalesReceipt[])formatter.Deserialize(stream);
            }
        }
        public static void Write(string filename, SalesReceipt[] receipts)
        {
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(stream, receipts);
            }
        }
        class SalesReceiptBinder : SerializationBinder
        {
            public override Type BindToType(string assemblyName, string typeName)
            {
                return typeof(SalesReceipt);
            }
        }
    }
}