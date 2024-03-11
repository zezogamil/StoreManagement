using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Applicant_Shop
{
    public partial class Add : Form
    {
        
        public Add()
        {
            InitializeComponent();
           
        }



        private void Add_Load(object sender, EventArgs e)
        {
        }
       
        private void Backbtn_Click_1(object sender, EventArgs e)
        {
            Main f1 = new Main();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }
        
        private void comboBoxType_SelectedItem(object sender, EventArgs e)
        {

           
        }

        private void ProcedBtn_Click(object sender, EventArgs e)
        {
            string selectedOption = ComboBoxType.SelectedItem?.ToString();


            switch (selectedOption)
            {
                case "Electronics ":
                    GroupBoxElectronics.Enabled = true;
                    GroupBoxFridge.Enabled = false;
                    GroupBoxConsole.Enabled = false;
                    break;
                case "Fridge":
                    GroupBoxFridge.Enabled = true;
                    GroupBoxConsole.Enabled = false;
                    GroupBoxElectronics.Enabled = false;
                    break;
                case "Console":
                    GroupBoxConsole.Enabled = true;
                    GroupBoxFridge.Enabled = false;
                    GroupBoxElectronics.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void AddElectricBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txbRelease.Text, out int releaseYear) && (releaseYear < 2030 || releaseYear < 1900))
            {
                string randomID = GenerateRandomID();
                Electronic electronic = new Electronic(id: randomID, brand: txbBrand.Text, model: txbMdl.Text, type: ComboBoxType.SelectedItem?.ToString(), price: Convert.ToInt32(txbPrice.Text),
                release: Convert.ToInt32(txbRelease.Text), size: Convert.ToInt32(txbSize.Text), smart: Convert.ToBoolean(checkBoxSmart.Checked));
                DataBase.AddProduct(ComboBoxType.SelectedItem.ToString(), electronic);

                MessageBox.Show($"the Electronic products have been add to the store successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Invailed, the release year is too old or too far in future", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddFridgeBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txbCap.Text, out int capacity) && (capacity < 20 || capacity > 200)
)
            {
                MessageBox.Show($"Please, be sure from capacity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.TryParse(txbElec.Text, out int electricity) && (electricity < 100 || electricity > 800))
            {
                MessageBox.Show($"Please, be sure from electricity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.TryParse(txbNoise.Text, out int noise) && (noise == 0 || noise > 47)) 
            {
                MessageBox.Show($"Noise level is from minimum 10 and maximum is 47", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string randomID = GenerateRandomID();
                Fridge fridge = new Fridge(id: randomID, brand: txbBrand.Text, model: txbMdl.Text,
                type: ComboBoxType.SelectedItem?.ToString(), price: Convert.ToInt32(txbPrice.Text),
                electricity: Convert.ToInt32(txbElec.Text), capacity: Convert.ToInt32(txbCap.Text),
                noise: Convert.ToInt32(txbNoise.Text));

                DataBase.AddProduct(ComboBoxType.SelectedItem.ToString(), fridge);

                MessageBox.Show($"The Fridge have been added to the store successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddGameBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txbMulti.Text, out int multiplayer) && (multiplayer == 2 || multiplayer == 4 || multiplayer == 8 || multiplayer == 16))
            {
                string randomID = GenerateRandomID();
                Console console = new Console(
                id: randomID, brand: txbBrand.Text, model: txbMdl.Text, type: ComboBoxType.SelectedItem?.ToString(), price: Convert.ToInt32(txbPrice.Text),
                multiplay: Convert.ToInt32(txbMulti.Text), ps5: Convert.ToBoolean(checkBoxPS5.Checked), xbox: Convert.ToBoolean(checkBoXbox.Checked));

                DataBase.AddProduct(ComboBoxType.SelectedItem.ToString(), console);

                MessageBox.Show($"The Console game have been add to the store succesfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show($"The range of players is from 2 , 4 , 8 or 16 ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboBoxType_MouseEnter(object sender, EventArgs e)
        {
            ComboBoxType.BackColor = Color.LightGray;
            ComboBoxType.ForeColor = Color.Black;
            ComboBoxType.FlatStyle = FlatStyle.Popup;
            ComboBoxType.DroppedDown = true;
            
        }
        private void ComboBoxType_MouseLeave(object sender, EventArgs e)
        {
            ComboBoxType.BackColor = Color.White;
        }

        private string GenerateRandomID()
        {
            Random random = new Random();
            return random.Next(1000, 10000).ToString("D4");
        }
    }
}