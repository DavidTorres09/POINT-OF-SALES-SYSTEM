namespace Sol_PointOfSale.Presentation
{
    partial class Frm_Point_Of_Sale
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Point_Of_Sale));
            this.Tbc_principal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Find = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_List = new System.Windows.Forms.DataGridView();
            this.Maintenance = new System.Windows.Forms.TabPage();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
            this.Btn_cancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_new = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Update = new System.Windows.Forms.Button();
            this.brn_delete = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.brn_exit = new System.Windows.Forms.Button();
            this.pnl_title_form = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_totalregisters = new System.Windows.Forms.Label();
            this.Tbc_principal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_List)).BeginInit();
            this.Maintenance.SuspendLayout();
            this.pnl_title_form.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tbc_principal
            // 
            this.Tbc_principal.Controls.Add(this.tabPage1);
            this.Tbc_principal.Controls.Add(this.Maintenance);
            this.Tbc_principal.ItemSize = new System.Drawing.Size(100, 30);
            this.Tbc_principal.Location = new System.Drawing.Point(17, 70);
            this.Tbc_principal.Name = "Tbc_principal";
            this.Tbc_principal.SelectedIndex = 0;
            this.Tbc_principal.Size = new System.Drawing.Size(720, 404);
            this.Tbc_principal.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl_totalregisters);
            this.tabPage1.Controls.Add(this.btn_Search);
            this.tabPage1.Controls.Add(this.txt_Find);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgv_List);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(712, 366);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consultation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.btn_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Search.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Search.Location = new System.Drawing.Point(611, 36);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // txt_Find
            // 
            this.txt_Find.Location = new System.Drawing.Point(60, 38);
            this.txt_Find.Name = "txt_Find";
            this.txt_Find.Size = new System.Drawing.Size(545, 20);
            this.txt_Find.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search:";
            // 
            // dgv_List
            // 
            this.dgv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_List.Location = new System.Drawing.Point(22, 67);
            this.dgv_List.Name = "dgv_List";
            this.dgv_List.Size = new System.Drawing.Size(664, 243);
            this.dgv_List.TabIndex = 0;
            // 
            // Maintenance
            // 
            this.Maintenance.Controls.Add(this.btn_Save);
            this.Maintenance.Controls.Add(this.btn_return);
            this.Maintenance.Controls.Add(this.Btn_cancel);
            this.Maintenance.Controls.Add(this.textBox1);
            this.Maintenance.Controls.Add(this.label2);
            this.Maintenance.Location = new System.Drawing.Point(4, 34);
            this.Maintenance.Name = "Maintenance";
            this.Maintenance.Padding = new System.Windows.Forms.Padding(3);
            this.Maintenance.Size = new System.Drawing.Size(712, 366);
            this.Maintenance.TabIndex = 1;
            this.Maintenance.Text = "Maintenance";
            this.Maintenance.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.btn_Save.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Save.Location = new System.Drawing.Point(236, 83);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // btn_return
            // 
            this.btn_return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.btn_return.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_return.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_return.Location = new System.Drawing.Point(336, 83);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(75, 23);
            this.btn_return.TabIndex = 5;
            this.btn_return.Text = "Return";
            this.btn_return.UseVisualStyleBackColor = false;
            // 
            // Btn_cancel
            // 
            this.Btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_cancel.Location = new System.Drawing.Point(134, 83);
            this.Btn_cancel.Name = "Btn_cancel";
            this.Btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_cancel.TabIndex = 4;
            this.Btn_cancel.Text = "Cancel";
            this.Btn_cancel.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Point Of Sale";
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_new.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(125)))));
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_new.ImageKey = "new.png";
            this.btn_new.ImageList = this.imageList1;
            this.btn_new.Location = new System.Drawing.Point(21, 480);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 60);
            this.btn_new.TabIndex = 2;
            this.btn_new.Text = "New";
            this.btn_new.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_new.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_new.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "delete.png");
            this.imageList1.Images.SetKeyName(1, "exit_closethesession_close_6317.png");
            this.imageList1.Images.SetKeyName(2, "new.png");
            this.imageList1.Images.SetKeyName(3, "report.png");
            this.imageList1.Images.SetKeyName(4, "update.png");
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Update.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(125)))));
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Update.ImageKey = "update.png";
            this.Update.ImageList = this.imageList1;
            this.Update.Location = new System.Drawing.Point(102, 480);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 60);
            this.Update.TabIndex = 3;
            this.Update.Text = "Update";
            this.Update.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Update.UseVisualStyleBackColor = false;
            // 
            // brn_delete
            // 
            this.brn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.brn_delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(125)))));
            this.brn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brn_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.brn_delete.ImageKey = "delete.png";
            this.brn_delete.ImageList = this.imageList1;
            this.brn_delete.Location = new System.Drawing.Point(183, 480);
            this.brn_delete.Name = "brn_delete";
            this.brn_delete.Size = new System.Drawing.Size(75, 60);
            this.brn_delete.TabIndex = 4;
            this.brn_delete.Text = "Delete";
            this.brn_delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.brn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.brn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_report
            // 
            this.btn_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_report.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(125)))));
            this.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_report.ImageKey = "report.png";
            this.btn_report.ImageList = this.imageList1;
            this.btn_report.Location = new System.Drawing.Point(264, 480);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(75, 60);
            this.btn_report.TabIndex = 5;
            this.btn_report.Text = "Report";
            this.btn_report.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_report.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_report.UseVisualStyleBackColor = false;
            // 
            // brn_exit
            // 
            this.brn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.brn_exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(125)))));
            this.brn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brn_exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.brn_exit.ImageKey = "exit_closethesession_close_6317.png";
            this.brn_exit.ImageList = this.imageList1;
            this.brn_exit.Location = new System.Drawing.Point(345, 480);
            this.brn_exit.Name = "brn_exit";
            this.brn_exit.Size = new System.Drawing.Size(75, 60);
            this.brn_exit.TabIndex = 6;
            this.brn_exit.Text = "Exit";
            this.brn_exit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.brn_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.brn_exit.UseVisualStyleBackColor = false;
            // 
            // pnl_title_form
            // 
            this.pnl_title_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(94)))));
            this.pnl_title_form.Controls.Add(this.label3);
            this.pnl_title_form.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_title_form.Location = new System.Drawing.Point(0, 0);
            this.pnl_title_form.Name = "pnl_title_form";
            this.pnl_title_form.Size = new System.Drawing.Size(984, 52);
            this.pnl_title_form.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(18, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "Point of Sale";
            // 
            // lbl_totalregisters
            // 
            this.lbl_totalregisters.AutoSize = true;
            this.lbl_totalregisters.Location = new System.Drawing.Point(601, 331);
            this.lbl_totalregisters.Name = "lbl_totalregisters";
            this.lbl_totalregisters.Size = new System.Drawing.Size(85, 13);
            this.lbl_totalregisters.TabIndex = 4;
            this.lbl_totalregisters.Text = "Total registers: 0";
            // 
            // Frm_Point_Of_Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pnl_title_form);
            this.Controls.Add(this.brn_exit);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.brn_delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.Tbc_principal);
            this.Name = "Frm_Point_Of_Sale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Point_Of_Sale";
            this.Load += new System.EventHandler(this.Frm_Point_Of_Sale_Load);
            this.Tbc_principal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_List)).EndInit();
            this.Maintenance.ResumeLayout(false);
            this.Maintenance.PerformLayout();
            this.pnl_title_form.ResumeLayout(false);
            this.pnl_title_form.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tbc_principal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txt_Find;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_List;
        private System.Windows.Forms.TabPage Maintenance;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_return;
        private System.Windows.Forms.Button Btn_cancel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button brn_delete;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Button brn_exit;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel pnl_title_form;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_totalregisters;
    }
}