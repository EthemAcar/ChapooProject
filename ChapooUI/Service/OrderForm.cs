﻿using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapooLogica;
using ChapooModel;
using MenuItem = ChapooModel.MenuItem;

namespace ChapooUI
{
    public partial class OrderForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private string sort;
        private List<MenuItem> menuList;

        public OrderForm(string sort)
        {
            this.sort = sort;
            InitializeComponent();
            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            GetMenus();
            GetOrder();
        }

        private void listviewMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        public void GetMenus()
        {
            menuList = new List<MenuItem>();

            listviewMenu.Items.Clear();
            
            if (sort == "Drinks")
            {
                mlblSoortBestelling.Text = "Drinken";
                Menu_Service menuService = new Menu_Service();
                menuList = menuService.GetDrinks();


            } else if (sort == "Lunch")
            {
                mlblSoortBestelling.Text = "Lunch";
                Menu_Service menuService = new Menu_Service();
                menuList = menuService.GetLunch();

            } else if (sort == "Diner")
            {
                mlblSoortBestelling.Text = "Diner";
                Menu_Service menuService = new Menu_Service();
                menuList = menuService.GetDiner();

            }

            foreach (MenuItem m in menuList)
            {
                ListViewItem li = new ListViewItem(m.naam);
                li.Tag = m;
                listviewMenu.Items.Add(li);

            }
            listviewMenu.View = View.Details;
            listviewMenu.Columns.Add("Naam");



        }

        public void GetOrder()
        {
            listviewOrder.Clear();

            listviewOrder.View = View.Details;
            listviewOrder.Columns.Add("Naam");
            listviewOrder.Columns.Add("Aantal");
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string name = listviewMenu.SelectedItems[0].Text;
            int aantal = 0;
            foreach (MenuItem m in menuList)
            {
                ListViewItem li = new ListViewItem(m.naam);
                
                if (name == m.naam)
                {
                    
                        li.SubItems.Add(aantal.ToString());
                        listviewOrder.Items.Add(li);
                    
                }
                
            }

            int increase = int.Parse(listviewOrder.SelectedItems[0].SubItems[1].Text);
            increase++;
            listviewOrder.SelectedItems[0].SubItems[1].Text = increase.ToString();
        }
        

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            //listviewOrder.SelectedItems();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            
        }
    }
}
