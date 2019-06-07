﻿using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using ChapooModel;
using ChapooDAL;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapooUI
{
    public partial class TableForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        Button[] btnList;
        Tafel_DAO table_dao = new Tafel_DAO();


        public TableForm(Inlog inlog)
        {
            InitializeComponent();

          
            lbl_Naam.Text = inlog.naam;

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            btnList = new Button[10] { btn_Tafel1, btn_Tafel2, btn_Tafel3, btn_Tafel4, btn_Tafel5, btn_Tafel6, btn_Tafel7, btn_Tafel8, btn_Tafel9, btn_Tafel10 };
        }

        private void TafelForm_Load(object sender, EventArgs e)
        {

            //Inlog_DAO inlog_DAO = new Inlog_DAO();
            BestelGerecht_DAO gerecht = new BestelGerecht_DAO();
            
            
            for (int i = 0; i < btnList.Length; i++)
            {
                if (table_dao.Occupied(i + 1) == true)
                {
                    btnList[i].BackColor = Color.Red;
                }
                else if (table_dao.Occupied(i + 1) == false)
                {
                    btnList[i].BackColor = Color.Green;
                }

                if (table_dao.Occupied(i + 1) == true && gerecht.OrderStatus(i + 1) == "nietafgeleverd")
                {
                    btnList[i].BackColor = Color.Yellow;
                }else if(table_dao.Occupied(i + 1) == true && gerecht.OrderStatus(i + 1) == "Bezig")
                {
                    btnList[i].BackColor = Color.Orange;
                }

            }
        }

        private void btn_Tafel9_Click(object sender, EventArgs e)
        {
            if(table_dao.Occupied(9) == true)
            {
                this.Hide();
                OrderActionForm orderForm = new OrderActionForm();
                orderForm.Show();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Wil je deze tafel op bezet zetten?", "Bezet zetten", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    table_dao.EditStatus(9, true);
                    this.Hide();
                    OrderActionForm orderForm = new OrderActionForm();
                    orderForm.Show();

                }
            }
        }

        private void btn_Tafel10_Click(object sender, EventArgs e)
        {
            if (table_dao.Occupied(10) == true)
            {
                this.Hide();
                OrderActionForm orderForm = new OrderActionForm();
                orderForm.Show();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Wil je deze tafel op bezet zetten?", "Bezet zetten", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    table_dao.EditStatus(10, true);
                    this.Hide();
                    OrderActionForm orderForm = new OrderActionForm();
                    orderForm.Show();

                }
            }
        }

        private void btn_Tafel8_Click(object sender, EventArgs e)
        {
            if (table_dao.Occupied(8) == true)
            {
                this.Hide();
                OrderActionForm orderForm = new OrderActionForm();
                orderForm.Show();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Wil je deze tafel op bezet zetten?", "Bezet zetten", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    table_dao.EditStatus(8, true);
                    this.Hide();
                    OrderActionForm orderForm = new OrderActionForm();
                    orderForm.Show();

                }
            }
        }

        private void btn_Tafel7_Click(object sender, EventArgs e)
        {
            if (table_dao.Occupied(7) == true)
            {
                this.Hide();
                OrderActionForm orderForm = new OrderActionForm();
                orderForm.Show();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Wil je deze tafel op bezet zetten?", "Bezet zetten", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    table_dao.EditStatus(7, true);
                    this.Hide();
                    OrderActionForm orderForm = new OrderActionForm();
                    orderForm.Show();

                }
            }
        }

        private void btn_Tafel6_Click(object sender, EventArgs e)
        {
            if (table_dao.Occupied(6) == true)
            {
                this.Hide();
                OrderActionForm orderForm = new OrderActionForm();
                orderForm.Show();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Wil je deze tafel op bezet zetten?", "Bezet zetten", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    table_dao.EditStatus(6, true);
                    this.Hide();
                    OrderActionForm orderForm = new OrderActionForm();
                    orderForm.Show();

                }
            }
        }

        private void btn_Tafel5_Click(object sender, EventArgs e)
        {
            if (table_dao.Occupied(5) == true)
            {
                this.Hide();
                OrderActionForm orderForm = new OrderActionForm();
                orderForm.Show();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Wil je deze tafel op bezet zetten?", "Bezet zetten", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    table_dao.EditStatus(5, true);
                    this.Hide();
                    OrderActionForm orderForm = new OrderActionForm();
                    orderForm.Show();

                }
            }
        }

        private void btn_Tafel4_Click(object sender, EventArgs e)
        {
            if (table_dao.Occupied(4) == true)
            {
                this.Hide();
                OrderActionForm orderForm = new OrderActionForm();
                orderForm.Show();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Wil je deze tafel op bezet zetten?", "Bezet zetten", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    table_dao.EditStatus(4, true);
                    this.Hide();
                    OrderActionForm orderForm = new OrderActionForm();
                    orderForm.Show();

                }
            }
        }

        private void btn_Tafel3_Click(object sender, EventArgs e)
        {
            if (table_dao.Occupied(3) == true)
            {
                this.Hide();
                OrderActionForm orderForm = new OrderActionForm();
                orderForm.Show();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Wil je deze tafel op bezet zetten?", "Bezet zetten", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    table_dao.EditStatus(3, true);
                    this.Hide();
                    OrderActionForm orderForm = new OrderActionForm();
                    orderForm.Show();

                }
            }
        }

        private void btn_Tafel2_Click(object sender, EventArgs e)
        {
            if (table_dao.Occupied(2) == true)
            {
                this.Hide();
                OrderActionForm orderForm = new OrderActionForm();
                orderForm.Show();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Wil je deze tafel op bezet zetten?", "Bezet zetten", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    table_dao.EditStatus(2, true);
                    this.Hide();
                    OrderActionForm orderForm = new OrderActionForm();
                    orderForm.Show();

                }
            }
        }

        private void btn_Tafel1_Click(object sender, EventArgs e)
        {
            if (table_dao.Occupied(1) == true)
            {
                this.Hide();
                OrderActionForm orderForm = new OrderActionForm();
                orderForm.Show();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Wil je deze tafel op bezet zetten?", "Bezet zetten", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    table_dao.EditStatus(1, true);
                    this.Hide();
                    OrderActionForm orderForm = new OrderActionForm();
                    orderForm.Show();

                }
            }
        }

        private void btn_Uitlog_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }
    }
}
