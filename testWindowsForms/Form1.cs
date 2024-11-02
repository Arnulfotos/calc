using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testWindowsForms
{
    public partial class Calculadora : MaterialForm
    {
        string input;
        double val1 = 0, val2 = 0;
        string operation;
        public Calculadora()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }



      
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;
            Operacion.Text += button.Text;
           

        }


        void ClearOperation(object sender, EventArgs e)
        {
            Resultado.Text = "";
            Operacion.Text = "";
            val1 = 0;
            val2 = 0;
            input = "";


        }

        void OperationCalc(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (val1 == 0)
            {
                val1 = double.Parse(input);
            } else
            {
                val2 = double.Parse(input);
            }

            input = "";
            switch (button.Text)
            {
                case "+":
                    Resultado.Text = $"{val1 + val2}";
                    val1 = val1 + val2;
                    operation = "+";
                    Operacion.Text += "+";
                    break;
                case "-":
                    Resultado.Text = $"{val1 - val2}";
                    val1 = val1 - val2;
                    operation = "-";
                    Operacion.Text += "-";
                    break;
                case "*":
                    if (val2 == 0)
                    {
                        val2 = 1;
                    }
                    Resultado.Text = $"{val1 * val2}";
                    val1 = val1 * val2;
                    operation = "*";
                    Operacion.Text += "*";
                    break;
                case "/":
                    
                   if(val2 == 0)
                    {
                        val2 = 1;
                    }
                    Resultado.Text = $"{val1 / val2}";
                    val1 = val1 / val2;
                    operation = "/";
                    Operacion.Text += "/";
                    break;
            }
          


           


        }

      

        void Result(object sender, EventArgs e)
        {
             val2 = double.Parse(input);

            switch (operation)
            {
                case "+":
                    Resultado.Text = $"{val1 + val2}";
                    val1 = val1 + val2;
                    operation = "+";
                    //Operacion.Text += "+";
                    break;
                case "-":
                    Resultado.Text = $"{val1 - val2}";
                    val1 = val1 - val2;
                    operation = "-";
                    //Operacion.Text += "-";
                    break;
                case "*":
                    if (val2 == 0)
                    {
                        val2 = 1;
                    }
                    Resultado.Text = $"{val1 * val2}";
                    val1 = val1 * val2;
                    operation = "*";
                    //Operacion.Text += "*";
                    break;
                case "/":
                    if (val2 == 0)
                    {
                        MessageBox.Show("No se puede dividir entre cero");
                        Operacion.Text = "";
                        val1 = 0;
                        val2 = 0;
                        return;

                    }
                    Resultado.Text = $"{val1 / val2}";
                    val1 = val1 / val2;
                    operation = "/";
                    //Operacion.Text += "/";
                    break;
            }



            Operacion.Text = "";
           
        }
    }
}

