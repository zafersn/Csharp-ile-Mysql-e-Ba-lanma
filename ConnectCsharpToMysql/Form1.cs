using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConnectCsharpToMysql
{
    public partial class Form1 : Form
    {
        private DBConnect dbConnect;

        public Form1()
        {
            InitializeComponent();

            dbConnect = new DBConnect();
        }


        //Insert button clicked
        private void bInsert_Click(object sender, EventArgs e)
        {
            dbConnect.Insert();
        }

        //Update button is clicked
        private void bUpdate_Click(object sender, EventArgs e)
        {
            dbConnect.Update();
        }

        //Delete button is clicked
        private void bDelete_Click(object sender, EventArgs e)
        {
            dbConnect.Delete();
        }

        //Select button is clicked
        private void bSelect_Click(object sender, EventArgs e)
        {
            List<string>[] list;
            list = dbConnect.Select();

            dgDisplay.Rows.Clear();
            for(int i = 0; i < list[0].Count; i++)
            {
                int number = dgDisplay.Rows.Add();
                dgDisplay.Rows[number].Cells[0].Value = list[0][i];
                dgDisplay.Rows[number].Cells[1].Value = list[1][i];
                dgDisplay.Rows[number].Cells[2].Value = list[2][i];
                dgDisplay.Rows[number].Cells[3].Value = list[3][i];
                dgDisplay.Rows[number].Cells[4].Value = list[4][i];
                dgDisplay.Rows[number].Cells[5].Value = list[5][i];
                dgDisplay.Rows[number].Cells[6].Value = list[6][i];
                dgDisplay.Rows[number].Cells[7].Value = list[7][i];
                dgDisplay.Rows[number].Cells[8].Value = list[8][i]; 
            }
        }

        //Count button clicked
        private void bCount_Click(object sender, EventArgs e)
        {
            int Count = dbConnect.Count();

            dgDisplay.Rows.Clear();
            int number = dgDisplay.Rows.Add();
            dgDisplay.Rows[number].Cells[0].Value = Count + "";
        }

   
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}