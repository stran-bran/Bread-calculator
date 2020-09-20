using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreadMchine
{
    public partial class Form1 : Form
    {
        public string link;
        Ratio ingreCal = new Ratio();
        Recipe ingredient = new Recipe();
        public Form1()
        {
            InitializeComponent();
        }
        //change recipe no kneed bread
        private void noFoldBreadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //display current recipe and show tutorial link
            lblName.Text="No Kneed Bread";
            link = "https://youtu.be/4gmCrbBGQy0";
            lnkLblRecipe.Visible = true;
            //clear txtbox and label box
            clear();
            //apply ingredient ratio
            ingreCal.flourAPF = 1;
            ingreCal.water = 0.51;
            ingreCal.salt = 0.008;
            ingreCal.yeast = 0.002;
        }
        //change recipe to fold bread
        private void foldBreadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //display current recipe and show tutorial link
            lblName.Text = "Fold Bread";
            link = "https://youtu.be/-TL8aKrtkhE";
            lnkLblRecipe.Visible = true;
            //clear txtbox and label box
            clear();
            //apply ingredient ratio
            ingreCal.flourAPF = 1;
            ingreCal.water = 0.72;
            ingreCal.salt = 0.02;
            ingreCal.yeast = 0.004;
        }
        //access tutorial video
        private void lnkLblRecipe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(link);
        }
        //calculate
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //get amount of flour
                ingredient.flour = double.Parse(txtGFlour.Text);
                //calculate amount of other ingeredient needed
                ingredient.water = Math.Round((ingredient.flour * ingreCal.water), 2);
                ingredient.salt = Math.Round((ingredient.flour * ingreCal.salt), 2);
                ingredient.yeast = Math.Round((ingredient.flour * ingreCal.yeast), 2);
                //convert amount of ingredient to cups
                ingredient.cFlour = Math.Round(ingredient.flour * ingreCal.gFlourAPF, 2);
                ingredient.cWater = Math.Round(ingredient.water * ingreCal.gWater, 2);
                ingredient.cSalt = Math.Round(ingredient.salt * ingreCal.gSalt, 2);
                ingredient.cYeast = Math.Round(ingredient.yeast * ingreCal.gYeast, 2);
                display(ingredient.flour, ingredient.cFlour, ingredient.water, ingredient.cWater, ingredient.salt, ingredient.cSalt, ingredient.yeast, ingredient.cYeast);
            }
            catch
            {
                MessageBox.Show("Please enter a number");
            }
        }

        //functions
        public void display(double gf,double cf,double gw, double cw,double gs, double cs,double gy,double cy) {
            //display recipe in cups
            txtCFlour.Text = cf.ToString();
            lblCSalt.Text = cs.ToString();
            lblCWater.Text = cw.ToString();
            lblCYeast.Text = cy.ToString();
            //display recipe in gram
            lblGWater.Text = gw.ToString();
            lblGSalt.Text = gs.ToString();
            lblGYeast.Text = gy.ToString();
        }

        public void clear() {
            lblCSalt.Text = null;
            lblCWater.Text = null;
            lblCYeast.Text = null;
            lblGSalt.Text = null;
            lblGWater.Text = null;
            lblGYeast.Text = null;
            txtCFlour.Text = null;
            txtGFlour.Text = null;
        }
    }
}
