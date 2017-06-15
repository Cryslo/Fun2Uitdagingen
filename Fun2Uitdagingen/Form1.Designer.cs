namespace Fun2Uitdagingen
{
    partial class Form1
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
            this.crt_char_btn = new System.Windows.Forms.Button();
            this.combo_class = new System.Windows.Forms.ComboBox();
            this.dg_sql = new System.Windows.Forms.DataGridView();
            this.combo_race = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_getchars = new System.Windows.Forms.Button();
            this.btn_getitems = new System.Windows.Forms.Button();
            this.btn_damage = new System.Windows.Forms.Button();
            this.nud_damage = new System.Windows.Forms.NumericUpDown();
            this.btn_repair = new System.Windows.Forms.Button();
            this.nud_repair = new System.Windows.Forms.NumericUpDown();
            this.nud_SetLevel = new System.Windows.Forms.NumericUpDown();
            this.btn_SetLevel = new System.Windows.Forms.Button();
            this.nud_CharID = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.getLoot = new System.Windows.Forms.Button();
            this.btn_GetItemsAboveLvl = new System.Windows.Forms.Button();
            this.nud_gial = new System.Windows.Forms.NumericUpDown();
            this.btn_selectView = new System.Windows.Forms.Button();
            this.btn_selectFunction = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_sql)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_damage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_repair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SetLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CharID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_gial)).BeginInit();
            this.SuspendLayout();
            // 
            // crt_char_btn
            // 
            this.crt_char_btn.Location = new System.Drawing.Point(12, 212);
            this.crt_char_btn.Name = "crt_char_btn";
            this.crt_char_btn.Size = new System.Drawing.Size(161, 44);
            this.crt_char_btn.TabIndex = 0;
            this.crt_char_btn.Text = "Create Character";
            this.crt_char_btn.UseVisualStyleBackColor = true;
            this.crt_char_btn.Click += new System.EventHandler(this.crt_char_btn_Click);
            // 
            // combo_class
            // 
            this.combo_class.FormattingEnabled = true;
            this.combo_class.Items.AddRange(new object[] {
            "Knight",
            "Warrior",
            "Warlock",
            "Rogue",
            "Ranger",
            "Berseker",
            "Paladin"});
            this.combo_class.Location = new System.Drawing.Point(12, 105);
            this.combo_class.Name = "combo_class";
            this.combo_class.Size = new System.Drawing.Size(161, 21);
            this.combo_class.TabIndex = 1;
            this.combo_class.Text = "Knight";
            // 
            // dg_sql
            // 
            this.dg_sql.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_sql.Location = new System.Drawing.Point(12, 283);
            this.dg_sql.Name = "dg_sql";
            this.dg_sql.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dg_sql.Size = new System.Drawing.Size(1032, 208);
            this.dg_sql.TabIndex = 3;
            this.dg_sql.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_sql_CellContentClick);
            // 
            // combo_race
            // 
            this.combo_race.FormattingEnabled = true;
            this.combo_race.Items.AddRange(new object[] {
            "Orc",
            "Human",
            "Troll",
            "Gnome",
            "Undead",
            "Dwarf"});
            this.combo_race.Location = new System.Drawing.Point(12, 145);
            this.combo_race.Name = "combo_race";
            this.combo_race.Size = new System.Drawing.Size(161, 21);
            this.combo_race.TabIndex = 4;
            this.combo_race.Text = "Orc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Race";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Class";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(15, 186);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 8;
            // 
            // btn_getchars
            // 
            this.btn_getchars.Location = new System.Drawing.Point(179, 212);
            this.btn_getchars.Name = "btn_getchars";
            this.btn_getchars.Size = new System.Drawing.Size(157, 44);
            this.btn_getchars.TabIndex = 9;
            this.btn_getchars.Text = "Get Characters";
            this.btn_getchars.UseVisualStyleBackColor = true;
            this.btn_getchars.Click += new System.EventHandler(this.refresh_dg_Click);
            // 
            // btn_getitems
            // 
            this.btn_getitems.Location = new System.Drawing.Point(969, 187);
            this.btn_getitems.Name = "btn_getitems";
            this.btn_getitems.Size = new System.Drawing.Size(75, 23);
            this.btn_getitems.TabIndex = 10;
            this.btn_getitems.Text = "Get Items";
            this.btn_getitems.UseVisualStyleBackColor = true;
            this.btn_getitems.Click += new System.EventHandler(this.btn_getitems_Click);
            // 
            // btn_damage
            // 
            this.btn_damage.Location = new System.Drawing.Point(953, 158);
            this.btn_damage.Name = "btn_damage";
            this.btn_damage.Size = new System.Drawing.Size(91, 23);
            this.btn_damage.TabIndex = 11;
            this.btn_damage.Text = "DamageItemID";
            this.btn_damage.UseVisualStyleBackColor = true;
            this.btn_damage.Click += new System.EventHandler(this.btn_damage_Click);
            // 
            // nud_damage
            // 
            this.nud_damage.Location = new System.Drawing.Point(910, 159);
            this.nud_damage.Name = "nud_damage";
            this.nud_damage.Size = new System.Drawing.Size(37, 20);
            this.nud_damage.TabIndex = 13;
            // 
            // btn_repair
            // 
            this.btn_repair.Location = new System.Drawing.Point(953, 129);
            this.btn_repair.Name = "btn_repair";
            this.btn_repair.Size = new System.Drawing.Size(91, 23);
            this.btn_repair.TabIndex = 14;
            this.btn_repair.Text = "RepairItemID";
            this.btn_repair.UseVisualStyleBackColor = true;
            this.btn_repair.Click += new System.EventHandler(this.btn_repair_Click);
            // 
            // nud_repair
            // 
            this.nud_repair.Location = new System.Drawing.Point(910, 129);
            this.nud_repair.Name = "nud_repair";
            this.nud_repair.Size = new System.Drawing.Size(37, 20);
            this.nud_repair.TabIndex = 15;
            // 
            // nud_SetLevel
            // 
            this.nud_SetLevel.Location = new System.Drawing.Point(342, 185);
            this.nud_SetLevel.Name = "nud_SetLevel";
            this.nud_SetLevel.Size = new System.Drawing.Size(37, 20);
            this.nud_SetLevel.TabIndex = 16;
            // 
            // btn_SetLevel
            // 
            this.btn_SetLevel.Location = new System.Drawing.Point(385, 162);
            this.btn_SetLevel.Name = "btn_SetLevel";
            this.btn_SetLevel.Size = new System.Drawing.Size(102, 44);
            this.btn_SetLevel.TabIndex = 17;
            this.btn_SetLevel.Text = "Set Charlevel";
            this.btn_SetLevel.UseVisualStyleBackColor = true;
            this.btn_SetLevel.Click += new System.EventHandler(this.btn_SetLevel_Click);
            // 
            // nud_CharID
            // 
            this.nud_CharID.Location = new System.Drawing.Point(342, 162);
            this.nud_CharID.Name = "nud_CharID";
            this.nud_CharID.Size = new System.Drawing.Size(37, 20);
            this.nud_CharID.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "CharID";
            // 
            // getLoot
            // 
            this.getLoot.Location = new System.Drawing.Point(342, 212);
            this.getLoot.Name = "getLoot";
            this.getLoot.Size = new System.Drawing.Size(145, 44);
            this.getLoot.TabIndex = 21;
            this.getLoot.Text = "Kill Enemy";
            this.getLoot.UseVisualStyleBackColor = true;
            this.getLoot.Click += new System.EventHandler(this.getLoot_Click);
            // 
            // btn_GetItemsAboveLvl
            // 
            this.btn_GetItemsAboveLvl.Location = new System.Drawing.Point(546, 186);
            this.btn_GetItemsAboveLvl.Name = "btn_GetItemsAboveLvl";
            this.btn_GetItemsAboveLvl.Size = new System.Drawing.Size(109, 20);
            this.btn_GetItemsAboveLvl.TabIndex = 22;
            this.btn_GetItemsAboveLvl.Text = "GetItemsAboveLvl";
            this.btn_GetItemsAboveLvl.UseVisualStyleBackColor = true;
            this.btn_GetItemsAboveLvl.Click += new System.EventHandler(this.btn_GetItemsAboveLvl_Click);
            // 
            // nud_gial
            // 
            this.nud_gial.Location = new System.Drawing.Point(506, 186);
            this.nud_gial.Name = "nud_gial";
            this.nud_gial.Size = new System.Drawing.Size(34, 20);
            this.nud_gial.TabIndex = 23;
            // 
            // btn_selectView
            // 
            this.btn_selectView.Location = new System.Drawing.Point(546, 212);
            this.btn_selectView.Name = "btn_selectView";
            this.btn_selectView.Size = new System.Drawing.Size(109, 26);
            this.btn_selectView.TabIndex = 24;
            this.btn_selectView.Text = "Select View";
            this.btn_selectView.UseVisualStyleBackColor = true;
            this.btn_selectView.Click += new System.EventHandler(this.btn_selectView_Click);
            // 
            // btn_selectFunction
            // 
            this.btn_selectFunction.Location = new System.Drawing.Point(546, 245);
            this.btn_selectFunction.Name = "btn_selectFunction";
            this.btn_selectFunction.Size = new System.Drawing.Size(109, 32);
            this.btn_selectFunction.TabIndex = 25;
            this.btn_selectFunction.Text = "Select Function";
            this.btn_selectFunction.UseVisualStyleBackColor = true;
            this.btn_selectFunction.Click += new System.EventHandler(this.btn_selectFunction_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 511);
            this.Controls.Add(this.btn_selectFunction);
            this.Controls.Add(this.btn_selectView);
            this.Controls.Add(this.nud_gial);
            this.Controls.Add(this.btn_GetItemsAboveLvl);
            this.Controls.Add(this.getLoot);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nud_CharID);
            this.Controls.Add(this.btn_SetLevel);
            this.Controls.Add(this.nud_SetLevel);
            this.Controls.Add(this.nud_repair);
            this.Controls.Add(this.btn_repair);
            this.Controls.Add(this.nud_damage);
            this.Controls.Add(this.btn_damage);
            this.Controls.Add(this.btn_getitems);
            this.Controls.Add(this.btn_getchars);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_race);
            this.Controls.Add(this.dg_sql);
            this.Controls.Add(this.combo_class);
            this.Controls.Add(this.crt_char_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_sql)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_damage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_repair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SetLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_CharID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_gial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button crt_char_btn;
        private System.Windows.Forms.ComboBox combo_class;
        private System.Windows.Forms.DataGridView dg_sql;
        private System.Windows.Forms.ComboBox combo_race;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_getchars;
        private System.Windows.Forms.Button btn_getitems;
        private System.Windows.Forms.Button btn_damage;
        private System.Windows.Forms.NumericUpDown nud_damage;
        private System.Windows.Forms.Button btn_repair;
        private System.Windows.Forms.NumericUpDown nud_repair;
        private System.Windows.Forms.NumericUpDown nud_SetLevel;
        private System.Windows.Forms.Button btn_SetLevel;
        private System.Windows.Forms.NumericUpDown nud_CharID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button getLoot;
        private System.Windows.Forms.Button btn_GetItemsAboveLvl;
        private System.Windows.Forms.NumericUpDown nud_gial;
        private System.Windows.Forms.Button btn_selectView;
        private System.Windows.Forms.Button btn_selectFunction;
    }
}

