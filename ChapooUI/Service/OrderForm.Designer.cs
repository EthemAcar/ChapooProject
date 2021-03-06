﻿namespace ChapooUI
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listviewMenu = new System.Windows.Forms.ListView();
            this.mlblSoortBestelling = new MaterialSkin.Controls.MaterialLabel();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.lbl_Table = new MaterialSkin.Controls.MaterialLabel();
            this.btn_Terug = new MaterialSkin.Controls.MaterialFlatButton();
            this.mlblWerknemer = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // listviewMenu
            // 
            this.listviewMenu.Location = new System.Drawing.Point(12, 198);
            this.listviewMenu.Name = "listviewMenu";
            this.listviewMenu.Size = new System.Drawing.Size(334, 262);
            this.listviewMenu.TabIndex = 0;
            this.listviewMenu.UseCompatibleStateImageBehavior = false;
            this.listviewMenu.SelectedIndexChanged += new System.EventHandler(this.listviewMenu_SelectedIndexChanged);
            // 
            // mlblSoortBestelling
            // 
            this.mlblSoortBestelling.AutoSize = true;
            this.mlblSoortBestelling.Depth = 0;
            this.mlblSoortBestelling.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblSoortBestelling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblSoortBestelling.Location = new System.Drawing.Point(102, 122);
            this.mlblSoortBestelling.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblSoortBestelling.Name = "mlblSoortBestelling";
            this.mlblSoortBestelling.Size = new System.Drawing.Size(144, 24);
            this.mlblSoortBestelling.TabIndex = 1;
            this.mlblSoortBestelling.Text = "Soort Bestelling";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(12, 503);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(76, 72);
            this.btnAddItem.TabIndex = 3;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(106, 503);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(76, 72);
            this.btnRemoveItem.TabIndex = 4;
            this.btnRemoveItem.Text = "Remove";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(207, 503);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(169, 72);
            this.btnAddOrder.TabIndex = 5;
            this.btnAddOrder.Text = "Toevoegen";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // lbl_Table
            // 
            this.lbl_Table.AutoSize = true;
            this.lbl_Table.Depth = 0;
            this.lbl_Table.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_Table.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Table.Location = new System.Drawing.Point(11, 43);
            this.lbl_Table.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Table.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Table.Name = "lbl_Table";
            this.lbl_Table.Size = new System.Drawing.Size(53, 24);
            this.lbl_Table.TabIndex = 8;
            this.lbl_Table.Text = "Tafel";
            // 
            // btn_Terug
            // 
            this.btn_Terug.AutoSize = true;
            this.btn_Terug.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Terug.Depth = 0;
            this.btn_Terug.Icon = null;
            this.btn_Terug.Location = new System.Drawing.Point(282, 73);
            this.btn_Terug.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Terug.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Terug.Name = "btn_Terug";
            this.btn_Terug.Primary = false;
            this.btn_Terug.Size = new System.Drawing.Size(76, 36);
            this.btn_Terug.TabIndex = 9;
            this.btn_Terug.Text = "Terug";
            this.btn_Terug.UseVisualStyleBackColor = true;
            this.btn_Terug.Click += new System.EventHandler(this.btn_Terug_Click);
            // 
            // mlblWerknemer
            // 
            this.mlblWerknemer.AutoSize = true;
            this.mlblWerknemer.Depth = 0;
            this.mlblWerknemer.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblWerknemer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblWerknemer.Location = new System.Drawing.Point(128, 43);
            this.mlblWerknemer.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblWerknemer.Name = "mlblWerknemer";
            this.mlblWerknemer.Size = new System.Drawing.Size(106, 24);
            this.mlblWerknemer.TabIndex = 10;
            this.mlblWerknemer.Text = "Werknemer";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 587);
            this.Controls.Add(this.mlblWerknemer);
            this.Controls.Add(this.btn_Terug);
            this.Controls.Add(this.lbl_Table);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.mlblSoortBestelling);
            this.Controls.Add(this.listviewMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "OrderForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listviewMenu;
        private MaterialSkin.Controls.MaterialLabel mlblSoortBestelling;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnAddOrder;
        private MaterialSkin.Controls.MaterialLabel lbl_Table;
        private MaterialSkin.Controls.MaterialFlatButton btn_Terug;
        private MaterialSkin.Controls.MaterialLabel mlblWerknemer;
    }
}