﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using ChapooModel;

namespace ChapooDAL
{
    public class Menu_DAO : Base
    {
        public List<MenuItem> Db_Get_All_Menus()
        {
            string query = "SELECT * FROM [Menu]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<MenuItem> ReadTables(DataTable dataTable)
        {
            List<MenuItem> menu = new List<MenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem menuItem = new MenuItem()
                {
                    menu_ID = (int)dr["menu_Id"],
                    naam = (String)(dr["naam"].ToString()),
                    prijs = (int)dr["prijs"],
                    categorie = (String)(dr["categorie"].ToString()),
                    voorraad = (int)dr["vorraad"]

                };
                menu.Add(menuItem);
            }
            return menu;
        }

        public List<MenuItem> GetAllLunch()
        {
            string query = "SELECT menu_Id, naam, prijs, categorie, vorraad FROM [Menu]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<MenuItem> GetAllDiner()
        {
            string query = "SELECT menu_Id, naam, prijs, categorie, vorraad FROM [Menu]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<MenuItem> GetAllDrinks()
        {
            string query = "SELECT menu_ID, naam, prijs, categorie, vorraad FROM [Menu] ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void ChangeSupply(string name, int amount)
        {
            string query = "Update Menu set vorraad = " + amount + " where naam = '" + name + "'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void ChangeMenu(int ID, string naam, int prijs, string categorie)
        {
            string query = "UPDATE Menu SET naam = '" + naam + "', prijs = " + prijs + ", categorie = '" + categorie + "' WHERE menu_ID = " + ID;
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void AddMenuItem(int ID, string naam, int prijs, string categorie, int voorraad)
        {
            string query = "set identity_insert  Menu  ON insert into Menu (menu_ID, naam, prijs, categorie, vorraad) values(" + ID + ", '" + naam + "', " + prijs + ", '" + categorie + "', " + voorraad + ") set identity_insert  Menu  OFF";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}