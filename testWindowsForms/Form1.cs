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
        public Calculadora()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }



        double tempValue=0;
        string operacion = "";
        int howManyTimesHasAButtonBeenPresses = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;


            Operacion.Text += button.Text;
            howManyTimesHasAButtonBeenPresses += 1;
        }


        void ClearOperation(object sender, EventArgs e)
        {
            Operacion.Text = "";
            howManyTimesHasAButtonBeenPresses = 0;

        }

        void SumaOp(object sender, EventArgs e)
        {

            double tempValue = double.Parse(Operacion.Text);
            operacion = "+";
            Operacion.Text += "+";
            howManyTimesHasAButtonBeenPresses += 1;

        }

        void Result(object sender, EventArgs e)
        {

            switch (operacion)
            {
                case "+":
                    tempValue = tempValue + double.Parse(Operacion.Text.Substring(howManyTimesHasAButtonBeenPresses));
                    Resultado.Text = tempValue.ToString();
                    break;

            }
           

           
        }
    }
}

