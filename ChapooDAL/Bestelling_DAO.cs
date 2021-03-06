﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using ChapooModel;
using ChapooModel.Models;

namespace ChapooDAL
{
    public class Bestelling_DAO :Base
    {
        public void AddOrder(Bestelling bestelling)
        {
            int i;
            if (bestelling.betaald)
            {
                i = 1;
            }
            else
            {
                i = 0;
            }
            DateTime varDate = DateTime.Now;
            string format = "MM-dd-yyyy HH:mm:ss";
            string query = "SET IDENTITY_INSERT Bestelling OFF INSERT INTO Bestelling (tafel_ID, betaald, datum, commentaar) VALUES ('" + bestelling.tafel_ID + "', '" + i + "', '"+ varDate.ToString(format)+ "', '"+bestelling.commentaar+"')";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void AddOrderItem(OrderItem o)
        {
            string query = "SET IDENTITY_INSERT OrderItem OFF INSERT INTO OrderItem (bestelling_ID,  werknemer_ID, status, commentaar, aantal, menu_ID, tafelnummer) VALUES ('"+ o.bestelling_ID + "', '" + o.Werknemer.werknemer_ID + "', '" + o.Status + "', '" + o.Comment + "', '"+o.Aantal+"', '"+o.menuItem.menu_ID+"', '"+o.TafelNummer+ "')";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public Bestelling GetLatestOrder()
        {
            string query = "SELECT * FROM Bestelling WHERE bestelling_ID = (SELECT MAX(bestelling_ID) FROM Bestelling)";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            DataRow dr = dataTable.Rows[0];

            Bestelling bestelling = new Bestelling()
            {
                bestelling_ID = (int)dr["bestelling_ID"],
                tafel_ID = (int)dr["tafel_ID"],
                betaald = (bool)dr["betaald"],
                datum = (DateTime)dr["datum"]
            };

            return bestelling;
        }

        public void DeleteOrder(int bestellingID)
        {
                string query = string.Format("DELETE FROM Bestelling WHERE bestelling_ID = '{0}'", bestellingID);
                ExecuteEditQuery(query, new SqlParameter[0]);
        }
    }
}
