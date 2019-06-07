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
using ChapooModel;
using ChapooLogica;
using MenuItem = ChapooModel.MenuItem;

namespace ChapooUI
{
    public partial class ManagementMenuForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private Menu_Service menuService = new Menu_Service();
        private List<MenuItem> menu;

        public ManagementMenuForm()
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManagementMenuForm_Load(object sender, EventArgs e)
        {
            GetMenu();
            DisplayListView(menu);

            HideAllControlls();
        }

        

        

        private void ListView_ViewMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            MenuItem menuItem = new MenuItem();

            ShowExistingListViewItems();

            if (ListView_ViewMenu.Items[0].Selected)
            {
                ClearAllTextFields();

                lbl_Supply.Show();
                txt_Supply.Show();

                IDDoesNotChange();
            }
            else
            {
                txt_Supply.Hide();
                lbl_Supply.Hide();

                if (ListView_ViewMenu.SelectedItems.Count > 0)
                {
                    menuItem = (MenuItem)ListView_ViewMenu.SelectedItems[0].Tag;
                    txt_ItemID.Text = menuItem.menu_ID.ToString();
                    txt_ItemNaam.Text = menuItem.naam;
                    txt_ItemCategorie.Text = menuItem.categorie;
                    txt_ItemPrijs.Text = menuItem.prijs.ToString();
                }
            }
        }

        private void txt_Supply_TextChanged(object sender, EventArgs e)
        {
            OnlyNumbersAllowed();
        }

        private void txt_ItemPrijs_TextChanged(object sender, EventArgs e)
        {
            OnlyNumbersAllowed();
        }

        private void txt_ItemID_TextChanged(object sender, EventArgs e)
        {
            OnlyNumbersAllowed();

            if (ListView_ViewMenu.Items[0].Selected)
            {
                
            }
            else
            {
                MenuItem item = new MenuItem();

                if (ListView_ViewMenu.SelectedItems.Count > 0)
                {
                    item = (MenuItem)ListView_ViewMenu.SelectedItems[0].Tag;
                }

                txt_ItemID.Text = item.menu_ID.ToString();
            }
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            

            if (ListView_ViewMenu.Items[0].Selected)
            {
                int ID = int.Parse(txt_ItemID.Text);
                string naam = txt_ItemNaam.Text;
                int prijs = int.Parse(txt_ItemPrijs.Text);
                string categorie = txt_ItemCategorie.Text;
                int voorraad = int.Parse(txt_Supply.Text);

                menuService.AddMenuItem(ID, naam, prijs, categorie, voorraad);
            }
            else
            {
                int ID = int.Parse(txt_ItemID.Text);
                string naam = txt_ItemNaam.Text;
                int prijs = int.Parse(txt_ItemPrijs.Text);
                string categorie = txt_ItemCategorie.Text;

                menuService.ChangeMenu(ID, naam, prijs, categorie);
            }

            GetMenu();
            DisplayListView(menu);

            HideAllControlls();
            ClearAllTextFields();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txt_ItemID.Text);

            menuService.RemoveItem(ID);

            GetMenu();
            DisplayListView(menu);

            HideAllControlls();
            ClearAllTextFields();
        }




        private void GetMenu()
        {
            menu = menuService.GetMenu();
        }

        private void DisplayListView(List<MenuItem> menu)
        {
            ListView_ViewMenu.Items.Clear();

            ListView_ViewMenu.View = View.Details;
            ListViewItem add = new ListViewItem("--");
            add.SubItems.Add("Klik hier omeen nieuw menu item toetevoegen");
            add.SubItems.Add("+");
            ListView_ViewMenu.Items.Add(add);
            foreach (MenuItem item in menu)
            {

                ListViewItem me = new ListViewItem(item.menu_ID.ToString());
                me.SubItems.Add(item.naam);
                me.SubItems.Add(item.prijs.ToString());
                me.SubItems.Add(item.categorie);
                me.Tag = item;

                ListView_ViewMenu.Items.Add(me);
            }
        }

        private void HideAllControlls()
        {
            txt_ItemID.Hide();
            txt_ItemCategorie.Hide();
            txt_ItemNaam.Hide();
            txt_ItemPrijs.Hide();
            txt_Supply.Hide();
            lbl_Category.Hide();
            lbl_ItemID.Hide();
            lbl_ItemName.Hide();
            lbl_Prijs.Hide();
            lbl_Supply.Hide();
            btn_Change.Hide();
            btn_Remove.Hide();
        }

        private void ShowExistingListViewItems()
        {
            txt_ItemID.Show();
            txt_ItemCategorie.Show();
            txt_ItemNaam.Show();
            txt_ItemPrijs.Show();
            lbl_Category.Show();
            lbl_ItemID.Show();
            lbl_ItemName.Show();
            lbl_Prijs.Show();
            btn_Change.Show();
            btn_Remove.Show();
        }

        private void ClearAllTextFields()
        {
            txt_ItemID.Clear();
            txt_ItemCategorie.Clear();
            txt_ItemNaam.Clear();
            txt_ItemPrijs.Clear();
            txt_Supply.Clear();
        }

        private void OnlyNumbersAllowed()
        {
            foreach (char ch in txt_ItemPrijs.Text)
            {
                if (!Char.IsNumber(ch))
                {
                    MessageBox.Show("U kunt hier alleen een cijfer invoeren...");
                    txt_ItemPrijs.Text = "";
                }
            }
        }

        private void IDDoesNotChange()
        {
            int nextMenuID;

            nextMenuID = menu[menu.Count - 1].menu_ID + 1;

            txt_ItemID.Text = nextMenuID.ToString();
        }

        
    }
}

