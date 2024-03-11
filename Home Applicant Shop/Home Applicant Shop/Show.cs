using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Applicant_Shop
{
    public partial class Show : Form
    {
        public Show()
        {
            InitializeComponent();
            DataBase.ReadFromFile();
            PopulateListBoxFromDatabase();
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            Main f1 = new Main();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void Show_Load(object sender, EventArgs e)
        {
            comboBoxTypes.SelectedIndex = 0;
        }

        private void comboBoxTypes_MouseEnter(object sender, EventArgs e)
        {
            comboBoxTypes.BackColor = Color.LightGray;
            comboBoxTypes.DroppedDown = true;
            comboBoxTypes.FlatStyle = FlatStyle.Popup;
        }
        private void comboBoxTypes_MouseLeave(object sender, EventArgs e)
        {
            comboBoxTypes.BackColor = Color.White;
            comboBoxTypes.DroppedDown = false;
        }

        private void listBoxShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedproduct = listBoxShow.SelectedItem.ToString();
            string[] splittedproduct = selectedproduct.Split(',');
            Products products = DataBase.GetProduct<Products>(splittedproduct[0], splittedproduct[4]);
            UpdateLabels(products);
        }
        private void UpdateLabels(Products product)
        {
            ElectronicsGroupbox.Show();
            FridgeGroupbox.Show();  
            ConsoleGroupbox.Show();

            if (product != null)
            {
                IDlbl.Text = product.Id;
                BRANDLBL.Text = product.Brand;
                MDLlbl.Text = product.Model;
                PRICElbl.Text = product.Price.ToString() + " $";

                if (product is Electronic electronic)
                {
                    Sizelbl.Text = electronic.size.ToString() + " Inch";      
                    Releaselbl.Text = electronic.Release.ToString(); 
                    Smartlbl.Text = electronic.smart.ToString();     
                }
                else
                {
                    Sizelbl.Text = "_";
                    Releaselbl.Text = "_";
                    Smartlbl.Text = "_";
                }
                if (product is Fridge fridge)
                {
                    CAPlbl.Text = fridge.capacity.ToString() + " L";
                    Electlbl.Text = fridge.capacity.ToString() + " kWh";
                    Noiselbl.Text = fridge.capacity.ToString() + " dB";
                }
                else 
                {
                    CAPlbl.Text = "_";
                    Electlbl.Text = "_";
                    Noiselbl.Text = "_";
                }
                if (product is Console console)
                {
                    Multilbl.Text = console.multiplay.ToString() + " Players";
                    PS5lbl.Text = console.ps5.ToString();
                    Xboxlbl.Text = console.xbox.ToString();
                }
                else 
                {
                    Xboxlbl.Text = "_"; 
                    PS5lbl.Text = "_";  
                    Multilbl.Text = "_"; 
                }
            }
            else
            {
                IDlbl.Text = "_";
                BRANDLBL.Text = "_";
                MDLlbl.Text = "_";
                PRICElbl.Text = "_";
                Sizelbl.Text = "_";
                Releaselbl.Text = "_";
                Smartlbl.Text = "_";
            }
            Refresh();

            if (product is Electronic) 
            {
                FridgeGroupbox.Hide();
                ConsoleGroupbox.Hide();
            }
            if (product is Fridge) 

            { ElectronicsGroupbox.Hide();
              ConsoleGroupbox.Hide();
            }
            if (product is Console) 
            {
                ElectronicsGroupbox.Hide();
                FridgeGroupbox.Hide();
            }
            Refresh();
        }
        private void PopulateListBoxFromDatabase()
        {
            
            listBoxShow.Items.Clear();

            
            foreach (var type in DataBase.allProducts.Keys)
            {
                foreach (var product in DataBase.allProducts[type])
                {
                    listBoxShow.Items.Add($"{product.Id}, {product.Model}, {product.Brand} , {product.Price}, {product.Type}");
                }
            }
        }

        private void comboBoxTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = comboBoxTypes.SelectedItem.ToString();

            if (selectedType == "All")
            {
               
                PopulateListBoxFromDatabase();
            }
            else
            {
                
                FilterListBoxByType(selectedType);
            }
        }
        private void FilterListBoxByType(string selectedType)
        {
            listBoxShow.Items.Clear();

            if (DataBase.allProducts.ContainsKey(selectedType))
            {
                foreach (var product in DataBase.allProducts[selectedType])
                {
                    listBoxShow.Items.Add($"{product.Id}, {product.Model}, {product.Brand} , {product.Price}, {product.Type}");
                }
            }
        }
    }
}
