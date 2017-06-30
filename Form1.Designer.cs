namespace Meine_Fußball_Mannschaft
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
            this.b_first = new System.Windows.Forms.Button();
            this.b_previous = new System.Windows.Forms.Button();
            this.b_next = new System.Windows.Forms.Button();
            this.b_last = new System.Windows.Forms.Button();
            this.p_box = new System.Windows.Forms.PictureBox();
            this.c_box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.t_name = new System.Windows.Forms.TextBox();
            this.t_vorname = new System.Windows.Forms.TextBox();
            this.t_position = new System.Windows.Forms.TextBox();
            this.t_nummer = new System.Windows.Forms.TextBox();
            this.t_seit = new System.Windows.Forms.TextBox();
            this.t_geboren = new System.Windows.Forms.TextBox();
            this.t_groesse = new System.Windows.Forms.TextBox();
            this.t_spieletore = new System.Windows.Forms.TextBox();
            this.t_gewicht = new System.Windows.Forms.TextBox();
            this.t_nation = new System.Windows.Forms.TextBox();
            this.t_laenderspiele = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.p_box)).BeginInit();
            this.SuspendLayout();
            // 
            // b_first
            // 
            this.b_first.Image = global::Meine_Fußball_Mannschaft.Properties.Resources.resultset_first;
            this.b_first.Location = new System.Drawing.Point(65, 583);
            this.b_first.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b_first.Name = "b_first";
            this.b_first.Size = new System.Drawing.Size(67, 62);
            this.b_first.TabIndex = 0;
            this.b_first.UseVisualStyleBackColor = true;
            this.b_first.Click += new System.EventHandler(this.b_first_Click);
            // 
            // b_previous
            // 
            this.b_previous.Image = global::Meine_Fußball_Mannschaft.Properties.Resources.resultset_previous;
            this.b_previous.Location = new System.Drawing.Point(140, 583);
            this.b_previous.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b_previous.Name = "b_previous";
            this.b_previous.Size = new System.Drawing.Size(67, 62);
            this.b_previous.TabIndex = 1;
            this.b_previous.UseVisualStyleBackColor = true;
            this.b_previous.Click += new System.EventHandler(this.b_previous_Click);
            // 
            // b_next
            // 
            this.b_next.Image = global::Meine_Fußball_Mannschaft.Properties.Resources.resultset_next;
            this.b_next.Location = new System.Drawing.Point(215, 583);
            this.b_next.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b_next.Name = "b_next";
            this.b_next.Size = new System.Drawing.Size(67, 62);
            this.b_next.TabIndex = 2;
            this.b_next.UseVisualStyleBackColor = true;
            this.b_next.Click += new System.EventHandler(this.b_next_Click);
            // 
            // b_last
            // 
            this.b_last.Image = global::Meine_Fußball_Mannschaft.Properties.Resources.resultset_last;
            this.b_last.Location = new System.Drawing.Point(289, 583);
            this.b_last.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b_last.Name = "b_last";
            this.b_last.Size = new System.Drawing.Size(67, 62);
            this.b_last.TabIndex = 3;
            this.b_last.UseVisualStyleBackColor = true;
            this.b_last.Click += new System.EventHandler(this.b_last_Click);
            // 
            // p_box
            // 
            this.p_box.Location = new System.Drawing.Point(65, 138);
            this.p_box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.p_box.Name = "p_box";
            this.p_box.Size = new System.Drawing.Size(291, 402);
            this.p_box.TabIndex = 4;
            this.p_box.TabStop = false;
            // 
            // c_box
            // 
            this.c_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c_box.FormattingEnabled = true;
            this.c_box.Location = new System.Drawing.Point(65, 54);
            this.c_box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c_box.Name = "c_box";
            this.c_box.Size = new System.Drawing.Size(367, 33);
            this.c_box.TabIndex = 0;
            this.c_box.SelectedIndexChanged += new System.EventHandler(this.c_box_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(419, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(419, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Vorname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(419, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Position:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(419, 278);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Rückennummer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(419, 327);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Im Verein seit:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(419, 377);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Geboren am:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(419, 426);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Größe (cm):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(419, 475);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Gewicht (kg):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(419, 524);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(222, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Spiele/Tore Bundesliga:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(419, 574);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 25);
            this.label10.TabIndex = 15;
            this.label10.Text = "Nation:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(419, 623);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 25);
            this.label11.TabIndex = 16;
            this.label11.Text = "Länderspiele:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(825, 54);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(178, 31);
            this.label12.TabIndex = 17;
            this.label12.Text = "VFB Stuttgart";
            // 
            // t_name
            // 
            this.t_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_name.Location = new System.Drawing.Point(692, 130);
            this.t_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.t_name.Name = "t_name";
            this.t_name.ReadOnly = true;
            this.t_name.Size = new System.Drawing.Size(319, 30);
            this.t_name.TabIndex = 18;
            // 
            // t_vorname
            // 
            this.t_vorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_vorname.Location = new System.Drawing.Point(692, 180);
            this.t_vorname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.t_vorname.Name = "t_vorname";
            this.t_vorname.ReadOnly = true;
            this.t_vorname.Size = new System.Drawing.Size(319, 30);
            this.t_vorname.TabIndex = 19;
            // 
            // t_position
            // 
            this.t_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_position.Location = new System.Drawing.Point(692, 229);
            this.t_position.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.t_position.Name = "t_position";
            this.t_position.ReadOnly = true;
            this.t_position.Size = new System.Drawing.Size(319, 30);
            this.t_position.TabIndex = 20;
            // 
            // t_nummer
            // 
            this.t_nummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_nummer.Location = new System.Drawing.Point(692, 278);
            this.t_nummer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.t_nummer.Name = "t_nummer";
            this.t_nummer.ReadOnly = true;
            this.t_nummer.Size = new System.Drawing.Size(319, 30);
            this.t_nummer.TabIndex = 21;
            // 
            // t_seit
            // 
            this.t_seit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_seit.Location = new System.Drawing.Point(692, 327);
            this.t_seit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.t_seit.Name = "t_seit";
            this.t_seit.ReadOnly = true;
            this.t_seit.Size = new System.Drawing.Size(319, 30);
            this.t_seit.TabIndex = 22;
            // 
            // t_geboren
            // 
            this.t_geboren.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_geboren.Location = new System.Drawing.Point(692, 377);
            this.t_geboren.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.t_geboren.Name = "t_geboren";
            this.t_geboren.ReadOnly = true;
            this.t_geboren.Size = new System.Drawing.Size(319, 30);
            this.t_geboren.TabIndex = 23;
            // 
            // t_groesse
            // 
            this.t_groesse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_groesse.Location = new System.Drawing.Point(692, 426);
            this.t_groesse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.t_groesse.Name = "t_groesse";
            this.t_groesse.ReadOnly = true;
            this.t_groesse.Size = new System.Drawing.Size(319, 30);
            this.t_groesse.TabIndex = 24;
            // 
            // t_spieletore
            // 
            this.t_spieletore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_spieletore.Location = new System.Drawing.Point(692, 524);
            this.t_spieletore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.t_spieletore.Name = "t_spieletore";
            this.t_spieletore.ReadOnly = true;
            this.t_spieletore.Size = new System.Drawing.Size(319, 30);
            this.t_spieletore.TabIndex = 25;
            // 
            // t_gewicht
            // 
            this.t_gewicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_gewicht.Location = new System.Drawing.Point(692, 475);
            this.t_gewicht.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.t_gewicht.Name = "t_gewicht";
            this.t_gewicht.ReadOnly = true;
            this.t_gewicht.Size = new System.Drawing.Size(319, 30);
            this.t_gewicht.TabIndex = 26;
            // 
            // t_nation
            // 
            this.t_nation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_nation.Location = new System.Drawing.Point(692, 574);
            this.t_nation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.t_nation.Name = "t_nation";
            this.t_nation.ReadOnly = true;
            this.t_nation.Size = new System.Drawing.Size(319, 30);
            this.t_nation.TabIndex = 27;
            // 
            // t_laenderspiele
            // 
            this.t_laenderspiele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_laenderspiele.Location = new System.Drawing.Point(692, 623);
            this.t_laenderspiele.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.t_laenderspiele.Name = "t_laenderspiele";
            this.t_laenderspiele.ReadOnly = true;
            this.t_laenderspiele.Size = new System.Drawing.Size(319, 30);
            this.t_laenderspiele.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.t_laenderspiele);
            this.Controls.Add(this.t_nation);
            this.Controls.Add(this.t_gewicht);
            this.Controls.Add(this.t_spieletore);
            this.Controls.Add(this.t_groesse);
            this.Controls.Add(this.t_geboren);
            this.Controls.Add(this.t_seit);
            this.Controls.Add(this.t_nummer);
            this.Controls.Add(this.t_position);
            this.Controls.Add(this.t_vorname);
            this.Controls.Add(this.t_name);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.c_box);
            this.Controls.Add(this.p_box);
            this.Controls.Add(this.b_last);
            this.Controls.Add(this.b_next);
            this.Controls.Add(this.b_previous);
            this.Controls.Add(this.b_first);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Meine Fußball-Mannschaft";
            ((System.ComponentModel.ISupportInitialize)(this.p_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_first;
        private System.Windows.Forms.Button b_previous;
        private System.Windows.Forms.Button b_next;
        private System.Windows.Forms.Button b_last;
        private System.Windows.Forms.PictureBox p_box;
        private System.Windows.Forms.ComboBox c_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox t_name;
        private System.Windows.Forms.TextBox t_vorname;
        private System.Windows.Forms.TextBox t_position;
        private System.Windows.Forms.TextBox t_nummer;
        private System.Windows.Forms.TextBox t_seit;
        private System.Windows.Forms.TextBox t_geboren;
        private System.Windows.Forms.TextBox t_groesse;
        private System.Windows.Forms.TextBox t_spieletore;
        private System.Windows.Forms.TextBox t_gewicht;
        private System.Windows.Forms.TextBox t_nation;
        private System.Windows.Forms.TextBox t_laenderspiele;
    }
}

