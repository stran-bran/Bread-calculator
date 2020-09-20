namespace BreadMchine
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.typeOfBreadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noFoldBreadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foldBreadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtGFlour = new System.Windows.Forms.TextBox();
            this.lblGWater = new System.Windows.Forms.Label();
            this.lblGSalt = new System.Windows.Forms.Label();
            this.lblGYeast = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lnkLblRecipe = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCWater = new System.Windows.Forms.Label();
            this.lblCSalt = new System.Windows.Forms.Label();
            this.lblCYeast = new System.Windows.Forms.Label();
            this.txtCFlour = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.typeOfBreadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(382, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // typeOfBreadToolStripMenuItem
            // 
            this.typeOfBreadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noFoldBreadToolStripMenuItem,
            this.foldBreadToolStripMenuItem});
            this.typeOfBreadToolStripMenuItem.Name = "typeOfBreadToolStripMenuItem";
            this.typeOfBreadToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.typeOfBreadToolStripMenuItem.Text = "Recipes";
            // 
            // noFoldBreadToolStripMenuItem
            // 
            this.noFoldBreadToolStripMenuItem.Name = "noFoldBreadToolStripMenuItem";
            this.noFoldBreadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.noFoldBreadToolStripMenuItem.Text = "No Kneed Bread";
            this.noFoldBreadToolStripMenuItem.Click += new System.EventHandler(this.noFoldBreadToolStripMenuItem_Click);
            // 
            // foldBreadToolStripMenuItem
            // 
            this.foldBreadToolStripMenuItem.Name = "foldBreadToolStripMenuItem";
            this.foldBreadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.foldBreadToolStripMenuItem.Text = "Fold Bread";
            this.foldBreadToolStripMenuItem.Click += new System.EventHandler(this.foldBreadToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Flour:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Water:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Salt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Yeast:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(90, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(85, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Bread Calculator";
            // 
            // txtGFlour
            // 
            this.txtGFlour.Location = new System.Drawing.Point(75, 52);
            this.txtGFlour.Name = "txtGFlour";
            this.txtGFlour.Size = new System.Drawing.Size(100, 20);
            this.txtGFlour.TabIndex = 6;
            // 
            // lblGWater
            // 
            this.lblGWater.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGWater.Location = new System.Drawing.Point(75, 82);
            this.lblGWater.Name = "lblGWater";
            this.lblGWater.Size = new System.Drawing.Size(100, 21);
            this.lblGWater.TabIndex = 7;
            // 
            // lblGSalt
            // 
            this.lblGSalt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGSalt.Location = new System.Drawing.Point(75, 113);
            this.lblGSalt.Name = "lblGSalt";
            this.lblGSalt.Size = new System.Drawing.Size(100, 21);
            this.lblGSalt.TabIndex = 8;
            // 
            // lblGYeast
            // 
            this.lblGYeast.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGYeast.Location = new System.Drawing.Point(75, 144);
            this.lblGYeast.Name = "lblGYeast";
            this.lblGYeast.Size = new System.Drawing.Size(100, 21);
            this.lblGYeast.TabIndex = 9;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(93, 178);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lnkLblRecipe
            // 
            this.lnkLblRecipe.AutoSize = true;
            this.lnkLblRecipe.Location = new System.Drawing.Point(181, 29);
            this.lnkLblRecipe.Name = "lnkLblRecipe";
            this.lnkLblRecipe.Size = new System.Drawing.Size(42, 13);
            this.lnkLblRecipe.TabIndex = 11;
            this.lnkLblRecipe.TabStop = true;
            this.lnkLblRecipe.Text = "Tutorial";
            this.lnkLblRecipe.Visible = false;
            this.lnkLblRecipe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLblRecipe_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "gram or ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(178, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "gram or ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(178, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "gram or ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(178, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "gram or ";
            // 
            // lblCWater
            // 
            this.lblCWater.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCWater.Location = new System.Drawing.Point(229, 82);
            this.lblCWater.Name = "lblCWater";
            this.lblCWater.Size = new System.Drawing.Size(100, 21);
            this.lblCWater.TabIndex = 17;
            // 
            // lblCSalt
            // 
            this.lblCSalt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCSalt.Location = new System.Drawing.Point(229, 113);
            this.lblCSalt.Name = "lblCSalt";
            this.lblCSalt.Size = new System.Drawing.Size(100, 21);
            this.lblCSalt.TabIndex = 18;
            // 
            // lblCYeast
            // 
            this.lblCYeast.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCYeast.Location = new System.Drawing.Point(229, 144);
            this.lblCYeast.Name = "lblCYeast";
            this.lblCYeast.Size = new System.Drawing.Size(100, 21);
            this.lblCYeast.TabIndex = 19;
            // 
            // txtCFlour
            // 
            this.txtCFlour.Enabled = false;
            this.txtCFlour.Location = new System.Drawing.Point(229, 52);
            this.txtCFlour.Name = "txtCFlour";
            this.txtCFlour.Size = new System.Drawing.Size(100, 20);
            this.txtCFlour.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "cup(s)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "cup(s)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(340, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "tsp(s)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(340, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "tsp(s)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 213);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCFlour);
            this.Controls.Add(this.lblCYeast);
            this.Controls.Add(this.lblCSalt);
            this.Controls.Add(this.lblCWater);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lnkLblRecipe);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblGYeast);
            this.Controls.Add(this.lblGSalt);
            this.Controls.Add(this.lblGWater);
            this.Controls.Add(this.txtGFlour);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Bread Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem typeOfBreadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noFoldBreadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foldBreadToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtGFlour;
        private System.Windows.Forms.Label lblGWater;
        private System.Windows.Forms.Label lblGSalt;
        private System.Windows.Forms.Label lblGYeast;
        private System.Windows.Forms.Button btnCalculate;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.LinkLabel lnkLblRecipe;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCWater;
        private System.Windows.Forms.Label lblCSalt;
        private System.Windows.Forms.Label lblCYeast;
        private System.Windows.Forms.TextBox txtCFlour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

