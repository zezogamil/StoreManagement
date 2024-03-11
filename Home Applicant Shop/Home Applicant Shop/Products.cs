using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Applicant_Shop
{
    public class Products
    {
        protected string _id, _brand, _model, _type;
        protected int _price;


        public Products() { }
        public Products(string[] data)
        {
            if (data.Length >= 5)
            {
                _id = data[0];
                _model = data[1];
                _brand = data[2];
                _price = Convert.ToInt32(data[3]);
                _type = data[4];
            }
        }

        public Products(string id, string brand, string model, string type, int price)
        {
            _id = id;
            _brand = brand;
            _model = model;
            _type = type;
            _price = price;
        }

        public int Price
        {
            get { return _price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The Value of the product should be positive");
                }
                else
                {
                    _price = value;
                }
            }
        }

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
    }


    
    public class Electronic : Products
    {
        private int _release, _size;
        private bool _smart;

       
        public Electronic(string[] data): base(data)
        {
            _size = Convert.ToInt32(data[5]);
            _release = Convert.ToInt32(data[6]);
            _smart = Convert.ToBoolean(data[7]);
        }

        public Electronic(string id, string brand, string model, string type, int price, int release, int size, bool smart) 
            : base(id, brand, model, type, price)
        {
            _release = release;
            _size = size;
            _smart = smart;
        }
        public int Release
        {
            get { return _release; }
            set 
            {
                if (1900 > value || value <= 2030)
                {
                    throw new ArgumentException("Invailed, the release year is too old or too far in future");
                }
                else 
                {
                    _release = value;   
                }
            }
        }
        public int size 
        {
            get { return _size; }
            set 
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Please, be sure from the size");
                }
                else 
                {
                    _size = value;
                }
            }
        }
        public bool smart
        {
            get { return _smart; }
            set 
            {
                if (_smart == true)
                {
                    _smart = value;
                }
                else 
                {
                    _smart = false;
                }
            }
        }
    }
    public class Fridge : Products
    {
        private int _electricity, _capacity, _noise;

        public Fridge(string[] data): base(data)
        {
            _electricity = Convert.ToInt32(data[5]);
            _capacity = Convert.ToInt32(data[6]);
            _noise = Convert.ToInt32(data[7]);
        }

        public Fridge(string id, string brand, string model, string type, int price, int electricity, int capacity, int noise):
            base(id,brand,model,type,price)
        {
            _electricity = electricity;
            _capacity = capacity;
            _noise = noise;
        }
        public int electricity
        {
            get { return _electricity; }
            set 
            {
                if (value < 0 || value > 800) 
                {
                    throw new ArgumentException("Please, be sure from electricity power");
                }
                else 
                { 
                 _electricity = value;
                }
            }
        }
        public int capacity 
        {
            get { return _capacity; }
            set 
            {
                if (value < 0 || value > 100) 
                {
                    throw new ArgumentException("Please, be sure from the capacity");
                }
                else
                {
                 _capacity = value;
                }
            }
        }
        public int noise 
        {
            get { return _noise; }
            set 
            {
                if (value > 11)
                {
                    throw new ArgumentException("Noise level is from minimum 10 and maximum is 47");
                }
                else 
                {
                    _noise = value;
                }
            }
           
        }
    }
    public class Console : Products
    {
        private int _multiplay;
        private bool _ps5, _xbox;

        public Console(string[] data) : base(data)
        {
            _multiplay = Convert.ToInt32(data[5]);
            _ps5 = Convert.ToBoolean(data[6]); 
            _xbox = Convert.ToBoolean(data[7]);
        }
        public Console(string id, string brand, string model, string type, int price, int multiplay, bool ps5, bool xbox) 
            : base(id, brand, model, type, price)
        {
            _multiplay = multiplay; 
            _ps5 = ps5;
            _xbox = xbox;
        }
        public int multiplay 
        {
            get { return _multiplay; }
            set 
            {
                if (value == 1 || value == 2 || value == 4 ||
                    value == 8 || value == 16)
                {
                    _multiplay = value;
                }
                else 
                {
                    MessageBox.Show("The range of players is from 1 to 16 ");

                }
            }
        }
        public bool ps5
        {
            get { return _ps5; }    
            set 
            {
                if (_ps5 == true)
                {
                    _ps5 = value;
                }
                else 
                {
                    _ps5 = false;
                }
            }
        }
        public bool xbox
        {
            get { return _xbox; }
            set 
            {
                if (xbox == true)
                {
                    _xbox = value;
                }
                else
                {
                    _xbox = false;
                }
            }
        }

    }

     
}
