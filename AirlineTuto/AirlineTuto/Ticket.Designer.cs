﻿namespace AirlineTuto
{
    partial class Ticket
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ticket));
            this.label2 = new System.Windows.Forms.Label();
            this.PIdCb = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.PNatTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.PPassTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Fcode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.PAmtTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BookingDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookingDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(1149, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 37);
            this.label2.TabIndex = 43;
            this.label2.Text = "Tiket";
            // 
            // PIdCb
            // 
            this.PIdCb.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PIdCb.ForeColor = System.Drawing.Color.RoyalBlue;
            this.PIdCb.FormattingEnabled = true;
            this.PIdCb.Location = new System.Drawing.Point(1270, 531);
            this.PIdCb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PIdCb.Name = "PIdCb";
            this.PIdCb.Size = new System.Drawing.Size(176, 35);
            this.PIdCb.TabIndex = 66;
            this.PIdCb.SelectedIndexChanged += new System.EventHandler(this.PIdCb_SelectedIndexChanged);
            this.PIdCb.SelectionChangeCommitted += new System.EventHandler(this.PIdCb_SelectionChangeCommitted);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label10.Location = new System.Drawing.Point(955, 531);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 27);
            this.label10.TabIndex = 65;
            this.label10.Text = "ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label9.Location = new System.Drawing.Point(955, 473);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 27);
            this.label9.TabIndex = 64;
            this.label9.Text = "Nama";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // PNameTb
            // 
            this.PNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PNameTb.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNameTb.ForeColor = System.Drawing.Color.RoyalBlue;
            this.PNameTb.HintForeColor = System.Drawing.Color.Empty;
            this.PNameTb.HintText = "";
            this.PNameTb.isPassword = false;
            this.PNameTb.LineFocusedColor = System.Drawing.Color.Cyan;
            this.PNameTb.LineIdleColor = System.Drawing.Color.Blue;
            this.PNameTb.LineMouseHoverColor = System.Drawing.Color.CornflowerBlue;
            this.PNameTb.LineThickness = 4;
            this.PNameTb.Location = new System.Drawing.Point(1270, 462);
            this.PNameTb.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.PNameTb.Name = "PNameTb";
            this.PNameTb.Size = new System.Drawing.Size(173, 38);
            this.PNameTb.TabIndex = 63;
            this.PNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(955, 595);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 27);
            this.label8.TabIndex = 62;
            this.label8.Text = "Kewarganegaraan";
            // 
            // PNatTb
            // 
            this.PNatTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PNatTb.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNatTb.ForeColor = System.Drawing.Color.RoyalBlue;
            this.PNatTb.HintForeColor = System.Drawing.Color.Empty;
            this.PNatTb.HintText = "";
            this.PNatTb.isPassword = false;
            this.PNatTb.LineFocusedColor = System.Drawing.Color.Cyan;
            this.PNatTb.LineIdleColor = System.Drawing.Color.Blue;
            this.PNatTb.LineMouseHoverColor = System.Drawing.Color.CornflowerBlue;
            this.PNatTb.LineThickness = 4;
            this.PNatTb.Location = new System.Drawing.Point(1270, 580);
            this.PNatTb.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.PNatTb.Name = "PNatTb";
            this.PNatTb.Size = new System.Drawing.Size(177, 42);
            this.PNatTb.TabIndex = 61;
            this.PNatTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(955, 719);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 27);
            this.label6.TabIndex = 60;
            this.label6.Text = "Paspor";
            // 
            // PPassTb
            // 
            this.PPassTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PPassTb.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PPassTb.ForeColor = System.Drawing.Color.RoyalBlue;
            this.PPassTb.HintForeColor = System.Drawing.Color.Empty;
            this.PPassTb.HintText = "";
            this.PPassTb.isPassword = false;
            this.PPassTb.LineFocusedColor = System.Drawing.Color.Cyan;
            this.PPassTb.LineIdleColor = System.Drawing.Color.Blue;
            this.PPassTb.LineMouseHoverColor = System.Drawing.Color.CornflowerBlue;
            this.PPassTb.LineThickness = 4;
            this.PPassTb.Location = new System.Drawing.Point(1270, 704);
            this.PPassTb.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.PPassTb.Name = "PPassTb";
            this.PPassTb.Size = new System.Drawing.Size(173, 42);
            this.PPassTb.TabIndex = 59;
            this.PPassTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Fcode
            // 
            this.Fcode.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fcode.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Fcode.FormattingEnabled = true;
            this.Fcode.Location = new System.Drawing.Point(1270, 645);
            this.Fcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Fcode.Name = "Fcode";
            this.Fcode.Size = new System.Drawing.Size(176, 35);
            this.Fcode.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(955, 649);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 27);
            this.label5.TabIndex = 57;
            this.label5.Text = "Kode Penerbangan";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label11.Location = new System.Drawing.Point(955, 772);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 27);
            this.label11.TabIndex = 68;
            this.label11.Text = "Jumlah";
            // 
            // PAmtTb
            // 
            this.PAmtTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PAmtTb.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PAmtTb.ForeColor = System.Drawing.Color.RoyalBlue;
            this.PAmtTb.HintForeColor = System.Drawing.Color.Empty;
            this.PAmtTb.HintText = "";
            this.PAmtTb.isPassword = false;
            this.PAmtTb.LineFocusedColor = System.Drawing.Color.Cyan;
            this.PAmtTb.LineIdleColor = System.Drawing.Color.Blue;
            this.PAmtTb.LineMouseHoverColor = System.Drawing.Color.CornflowerBlue;
            this.PAmtTb.LineThickness = 4;
            this.PAmtTb.Location = new System.Drawing.Point(1270, 757);
            this.PAmtTb.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.PAmtTb.Name = "PAmtTb";
            this.PAmtTb.Size = new System.Drawing.Size(177, 42);
            this.PAmtTb.TabIndex = 67;
            this.PAmtTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label12.Location = new System.Drawing.Point(1121, 850);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 37);
            this.label12.TabIndex = 69;
            this.label12.Text = "Booking";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 112);
            this.panel1.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(71, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 44);
            this.label3.TabIndex = 78;
            this.label3.Text = "AirplaneTicketing";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Navy;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(15, 1243);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(208, 49);
            this.button4.TabIndex = 74;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Navy;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1753, 1222);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 49);
            this.button2.TabIndex = 73;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1988, 1222);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 49);
            this.button1.TabIndex = 72;
            this.button1.Text = "Book";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BookingDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.BookingDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BookingDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookingDGV.BackgroundColor = System.Drawing.Color.White;
            this.BookingDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookingDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BookingDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BookingDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BookingDGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BookingDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.BookingDGV.EnableHeadersVisualStyles = false;
            this.BookingDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BookingDGV.Location = new System.Drawing.Point(593, 910);
            this.BookingDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BookingDGV.Name = "BookingDGV";
            this.BookingDGV.ReadOnly = true;
            this.BookingDGV.RowHeadersVisible = false;
            this.BookingDGV.RowHeadersWidth = 51;
            this.BookingDGV.RowTemplate.Height = 24;
            this.BookingDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookingDGV.Size = new System.Drawing.Size(1173, 534);
            this.BookingDGV.TabIndex = 70;
            this.BookingDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.BookingDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.BookingDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BookingDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BookingDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BookingDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BookingDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.BookingDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BookingDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BookingDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BookingDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.BookingDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.BookingDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BookingDGV.ThemeStyle.HeaderStyle.Height = 25;
            this.BookingDGV.ThemeStyle.ReadOnly = true;
            this.BookingDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.BookingDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BookingDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.BookingDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BookingDGV.ThemeStyle.RowsStyle.Height = 24;
            this.BookingDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BookingDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 118);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2237, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BookingDGV);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.PAmtTb);
            this.Controls.Add(this.PIdCb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PNameTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PNatTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PPassTb);
            this.Controls.Add(this.Fcode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Ticket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.Ticket_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookingDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox PIdCb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PNameTb;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PNatTb;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PPassTb;
        private System.Windows.Forms.ComboBox Fcode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PAmtTb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Guna.UI.WinForms.GunaDataGridView BookingDGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}