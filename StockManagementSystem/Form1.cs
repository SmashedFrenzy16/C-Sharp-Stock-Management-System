using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static DialogResult PopupInput(string text, string inputText, ref string val)
        {
            Form inputForm = new Form();
            inputForm.Text = text;

            Label formLabel = new Label();
            formLabel.Text = inputText;

            TextBox inputBox = new TextBox();

            Button buttonOk = new Button();
            buttonOk.Text = "Confirm";
            buttonOk.DialogResult = DialogResult.OK;

            Button buttonCancel = new Button();
            buttonCancel.Text = "Cancel";
            buttonCancel.DialogResult = DialogResult.Cancel;

            formLabel.SetBounds(9, 20, 372, 13);
            inputBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            formLabel.AutoSize = true;
            inputForm.ClientSize = new Size(396, 107);
            inputForm.StartPosition = FormStartPosition.CenterScreen;

            inputForm.Controls.AddRange(new Control[] { formLabel, inputBox, buttonOk, buttonCancel });
            DialogResult result = inputForm.ShowDialog();

            val = inputBox.Text;

            return result;

        }

        struct Stock
        {
            public string name;
            public int number;
        }

        List<Stock> stockList = new List<Stock>();

        private void listStock_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();

            for (int i = 0; i < stockList.Count; i++)
            {
                listBox1.Items.Add($"ID: {i} Stock Name: {stockList[i].name}");
            }

        }

        private void registerStock_Click(object sender, EventArgs e)
        {

            string val = "";
            bool firstCondition = false;
            bool secondCondition = false;

            Stock newStock = new Stock();

            if (PopupInput("Register a new stock", "Enter in the name of the stock item", ref val) == DialogResult.OK)
            {

                newStock.name = val;

                firstCondition = true;

            }

            if (PopupInput("Register a new stock", "Enter in the name of the stock item", ref val) == DialogResult.OK)
            {

                newStock.number = (int)Convert.ToInt64(val);

                secondCondition = true;

            }

            if (firstCondition == true && secondCondition == true)
            {
                stockList.Add(newStock);
            }


        }

        private void deleteStock_Click(object sender, EventArgs e)
        {

            string val = "";
            int intVal;

            if (PopupInput("Delete a stock item", "Enter in the ID number of the stock item", ref val) == DialogResult.OK)
            {

                intVal = (int)Convert.ToInt64(val);

                stockList.RemoveAt(intVal);


            }

        }

        
    }


}

