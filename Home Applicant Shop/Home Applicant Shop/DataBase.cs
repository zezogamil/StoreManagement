using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Runtime.InteropServices;
using System.ComponentModel.Design;
using System.Windows.Forms;

namespace Home_Applicant_Shop
{

    public static class DataBase
    {
        public static Dictionary<string, List<Products>> allProducts = new Dictionary<string, List<Products>>();
        public static List<Electronic> electronicList = new List<Electronic>();
        public static List<Fridge> fridgeList = new List<Fridge>();
        public static List<Console> consoleList = new List<Console>();


        public static T GetProduct<T>(string id, string type) where T:Products {
            System.Console.WriteLine($"ID:{id}");
            System.Console.WriteLine($"Type:{type.Trim()}");

            switch (type.Trim()) {
                case "Electronics":
                    System.Console.WriteLine($"E1 Count:{electronicList.Count}");

                    for (int i = 0;i < electronicList.Count;i++)
                    {
                        if (electronicList[i].Id == id)
                        {
                            return electronicList[i] as T;
                        }
                    }
                    break;
                case "Fridge":
                    System.Console.WriteLine($"F1 Count:{fridgeList.Count}");

                    for (int i = 0; i < fridgeList.Count; i++)
                    {
                        if (fridgeList[i].Id == id)
                        {
                            return fridgeList[i] as T;
                        }
                    }
                    break;
                case "Console":
                    System.Console.WriteLine($"C1 Count:{consoleList.Count}");
                    for (int i = 0; i < consoleList.Count; i++)
                    {
                        if (consoleList[i].Id == id)
                        {
                            return consoleList[i] as T;
                        }
                    }
                    break;
            };
            return null;
        }

        public static List<Products> GetProductsByType(string type)
        {
            return allProducts[type.Trim()];
        }
        public static Products GetProducts(string id, string model, string type, string brand, int price)
        // int size, int release, bool smart, int capacity, int electricity,
        // int noise, int multiplayer, bool ps5, bool xbox)
        {
            List<Products> filteredProducts = new List<Products>();

            foreach (string key in allProducts.Keys)
            {
                for (int i = 0; i < allProducts[key].Count; i++)
                {
                    if ((allProducts[key][i].Id == id) &&
                        (allProducts[key][i].Model == model)
                        && (allProducts[key][i].Brand == brand)
                        && (allProducts[key][i].Price == price)
                        && (allProducts[key][i].Type == type))
                    {
                        return allProducts[key][i];
                    }
                }
            }
            return null;
        }
        public static Electronic GetElectronic(string id, string model, string type, string brand, int price, int size, int release, bool smart)
        {
            foreach (string key in allProducts.Keys)
            {
                for (int i = 0; i < allProducts[key].Count; i++)
                {
                    if ((allProducts[key][i].Id == id)
                        && (allProducts[key][i].Model == model)
                        && (allProducts[key][i].Brand == brand)
                        && (allProducts[key][i].Price == price)
                        && (allProducts[key][i].Type == type)
                        && (allProducts[key][i] is Electronic electronic &&
                        electronic.size == size
                        && electronic.Release == release
                        && electronic.smart == smart))
                    {
                        return electronic;
                    }
                }
            }
            return null;
        }
        public static Fridge GetFridge(string id, string model, string brand, int price, int capacity, int electricity, int noise)
        {
            foreach (string key in allProducts.Keys)
            {
                for (int i = 0; i < allProducts[key].Count; i++)
                {
                    if ((allProducts[key][i].Id == id)
                        && (allProducts[key][i].Model == model)
                        && (allProducts[key][i].Brand == brand)
                        && (allProducts[key][i].Price == price)
                        && (allProducts[key][i] is Fridge fridge &&
                        fridge.capacity == capacity
                        && fridge.electricity == electricity
                        && fridge.noise == noise))
                    {
                        return fridge;
                    }
                }
            }
            return null;
        }
        public static Console GetConsole(string id, string model, string brand, int price, int multiplay, bool ps5, bool xbox)
        {
            foreach (string key in allProducts.Keys)
            {
                for (int i = 0; i < allProducts[key].Count; i++)
                {
                    if ((allProducts[key][i].Id == id)
                        && (allProducts[key][i].Model == model)
                        && (allProducts[key][i].Brand == brand)
                        && (allProducts[key][i].Price == price)
                        && (allProducts[key][i] is Console console
                        && console.multiplay == multiplay
                        && console.ps5 == ps5
                        && console.xbox == xbox))
                    {
                        return console;
                    }
                }
            }
            return null;
        }

        public static void AddProduct<T>(string type, T product) where T : Products
        {
            if (!allProducts.ContainsKey(type))
            {
                allProducts.Add(type, new List<Products>());
            }
            allProducts[type].Add(product);

            if (product is Electronic electronic)
            {
                electronicList.Add(electronic);
            }
            else if (product is Fridge fridge)
            {
                fridgeList.Add(fridge);
            }
            else if (product is Console console)
            {
                consoleList.Add(console);
            }

            WriteToFile(product);
        }

        private static void WriteToFile<T>(T product) where T : Products
        {
            FileStream fs = new FileStream("DataBase.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            String productData = $"{product.Id};{product.Model};{product.Brand};{product.Price};{product.Type};";

            if (product is Electronic electronic)
            {
                productData += $"{electronic.size};{electronic.Release};{electronic.smart}";
            }
            else if (product is Fridge fridge)
            {
                productData += $"{fridge.capacity};{fridge.electricity};{fridge.noise}";
            }
            else if (product is Console console)
            {
                productData += $"{console.multiplay};{console.ps5};{console.xbox}";
            }

            sw.WriteLine(productData);
            
            sw.Close();
            fs.Close();
        }

        public static void ReadFromFile()
        {
            allProducts.Clear();
            electronicList.Clear();
            fridgeList.Clear();
            consoleList.Clear();
            FileStream fs = new FileStream("DataBase.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine().Trim();
                string[] splittedline = line.Split(';');
                string type = splittedline[4];

                if (!allProducts.ContainsKey(type))
                {
                    allProducts.Add(type, new List<Products>());
                }
                
                Products genericProduct = null;

                switch (type.Trim())
                {
                    case "Electronics":
                        Electronic newElectronic = new Electronic(splittedline);
                        electronicList.Add(newElectronic);
                        genericProduct = newElectronic as Products;
                        break;
                    case "Fridge":
                        Fridge newFridge = new Fridge(splittedline);
                        fridgeList.Add(newFridge);
                        genericProduct = newFridge as Products;
                        break;
                    case "Console":
                        Console newConsole = new Console(splittedline);
                        consoleList.Add(newConsole);
                        genericProduct = newConsole as Products;
                        break;
                };


                if (genericProduct != null)
                {
                    allProducts[type].Add(genericProduct);
                }
            }
            sr.Close();
            fs.Close();
        }
       
    }
}

