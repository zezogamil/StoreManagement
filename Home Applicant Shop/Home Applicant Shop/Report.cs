using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Applicant_Shop
{
    public partial class Report : Form
    {

        public Report()
        {
            InitializeComponent();
            DataBase.ReadFromFile();
            PopulateListBoxFromDatabase();
            

        }

        private void Report_Load(object sender, EventArgs e)
        {
            comboBoxReports.SelectedIndex = 0;

        }

        private void comboBoxReports_MouseEnter(object sender, EventArgs e)
        {
            comboBoxReports.BackColor = Color.DeepSkyBlue;
            comboBoxReports.DroppedDown = true;
            comboBoxReports.FlatStyle = FlatStyle.Popup;
        }

        private void comboBoxReports_MouseLeave(object sender, EventArgs e)
        {
            comboBoxReports.DroppedDown = false;
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Main f1 = new Main();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            Add f2 = new Add();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void listBoxReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedproduct = listBoxReport.SelectedItem.ToString();
            if (!string.IsNullOrEmpty(selectedproduct))
            {
                string[] splittedproduct = selectedproduct.Split(',');
                Products products = DataBase.GetProduct<Products>(splittedproduct[0], splittedproduct[4]);
                UpdateLabels();
            }
            Refresh();

        }
        private void UpdateLabels()
        {
            Goodslbl.Text = DataBase.allProducts.Count.ToString();
            PopulateListBoxFromDatabase();
            Refresh();
        }
        private void comboBoxReports_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedType = comboBoxReports.SelectedItem.ToString();

            if (selectedType == "All")
            {

                PopulateListBoxFromDatabase();
            }
            else
            {

                FilterListBoxByType(selectedType);
            }
            Refresh();
        }
        private void PopulateListBoxFromDatabase()
        {

            listBoxReport.Items.Clear();


            foreach (var type in DataBase.allProducts.Keys)
            {
                foreach (var product in DataBase.allProducts[type])
                {
                    listBoxReport.Items.Add($"{product.Id}, {product.Model}, {product.Brand} , {product.Price}, {product.Type}");
                }
            }

            Goodslbl.Text = (DataBase.electronicList.Count + DataBase.fridgeList.Count + DataBase.consoleList.Count).ToString();
            Valuelbl.Text = (getElectornicsPrices() + getFridgePrices() + getConsolePrices()).ToString() + " $";
            Refresh();
        }

        
        private int getElectornicsPrices()
        {
            int etotalPrice = 0;
            for (int i = 0; i < DataBase.electronicList.Count; i++)
            {
                etotalPrice += DataBase.electronicList[i].Price;
            }
            return etotalPrice;
        }

        private int getFridgePrices()
        {
            int ftotalPrice = 0;
            for (int i = 0; i < DataBase.fridgeList.Count; i++)
            {
                ftotalPrice += DataBase.fridgeList[i].Price;
            }
            return ftotalPrice;
        }

        private int getConsolePrices()
        {
            int ctotalPrice = 0;
            for (int i = 0; i < DataBase.consoleList.Count; i++)
            {
                ctotalPrice += DataBase.consoleList[i].Price;
            }
            return ctotalPrice;
        }
        private void Epercentage()
        {
            if (DataBase.allProducts.Count > 0)
            {
                double Epercentage = ((double)DataBase.electronicList.Count / 
                    (DataBase.fridgeList.Count + DataBase.consoleList.Count + DataBase.electronicList.Count) * 100);
                Percentagelbl.Text = $"{Epercentage:F2} %";
            }
            
        }
        private void Fpercentage()
        {
            if (DataBase.allProducts.Count > 0)
            {
                double Fpercentage = ((double)DataBase.fridgeList.Count / (DataBase.fridgeList.Count + DataBase.consoleList.Count + DataBase.electronicList.Count) * 100);
                
                Percentagelbl.Text = $"{Fpercentage:F2} %";
            }
            
        }
        private void Cpercentage()
        {
            if (DataBase.allProducts.Count > 0)
            {
                double Cpercentage = ((double)DataBase.consoleList.Count / (DataBase.fridgeList.Count + DataBase.consoleList.Count + DataBase.electronicList.Count) * 100);
                Percentagelbl.Text = $"{Cpercentage:F2} %";
            }
        }
        private void FilterListBoxByType(string selectedType)
        {
            listBoxReport.Items.Clear();

            if (DataBase.allProducts.ContainsKey(selectedType))
            {
                foreach (var product in DataBase.allProducts[selectedType])
                {
                    listBoxReport.Items.Add($"{product.Id}, {product.Model}, {product.Brand} , {product.Price}, {product.Type}");
                }
            }
            

            Valuelbl.Text = "";
            switch (selectedType.Trim())
            {
                case "Electronics":
                    Goodslbl.Text = DataBase.electronicList.Count.ToString();
                    Valuelbl.Text = getElectornicsPrices().ToString() + " $";
                    Epercentage();
                    Refresh();
                    break;
                case "Fridge":
                    Goodslbl.Text = DataBase.fridgeList.Count.ToString();
                    Valuelbl.Text = getFridgePrices().ToString() + " $";
                    Fpercentage();
                    Refresh();
                    break;
                case "Console":
                    Goodslbl.Text = DataBase.consoleList.Count.ToString();
                    Valuelbl.Text = getConsolePrices().ToString() + " $";
                    Cpercentage();
                    Refresh();
                    break;
            }

           
        }
       
       
       

    }
}
