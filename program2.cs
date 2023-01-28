using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3_KAML
{

    public partial class program2 : Form
    {
        public program2()
        {
            InitializeComponent();
        }
        // mensaje que no nos deja ingresar un valor nulo o vacio
        private void agg_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("por favor ingrese un valor");
            }
            else
            {
                // serie if para clasificar los pesos de las personas por edades en diferentes listbox

                double peso = Convert.ToDouble(textBox1.Text);

                if (rb1.Checked)
                {
                    peso = lb1.Items.Add(peso);
                }
                else
                {
                    if (rb2.Checked)
                    {
                        peso = lb2.Items.Add(peso);
                    }
                    else
                    {
                        if (rb3.Checked)
                        {
                            peso = lb3.Items.Add(peso);
                        }
                        else
                        {
                            peso = lb4.Items.Add(peso);
                        }
                    }
                }
            }
            // limpiar la textbox y enfocarla
            textBox1.Clear();
            textBox1.Focus();
        }

        double niños, jovenes, adultos, mayores, tni;
            string en, ej, ea, em;
        // boton para calcular promedios
        private void button1_Click(object sender, EventArgs e)
        {
           // suma de valores de elementos de listbox 
            foreach (object item in lb1.Items)
            {
                niños += Convert.ToDouble(item);
               
            }
            //calculo del promedio dividiendo la sumatoria total con la cantidad de elementos en la listbox
            // para los niños
            en = lb1.Items.Count.ToString();
            double enT =double.Parse(en);
            tni =niños /enT ;
            n1.Text=(tni.ToString());
            // para los jovenes
            double tjov;
            foreach (object item in lb2.Items)
            {
                jovenes += Convert.ToDouble(item);
        
            }
            ej = lb2.Items.Count.ToString();
            double ejt = double.Parse(ej);
            tjov = jovenes / ejt;
            n2.Text = (tjov.ToString());
            // para los adultos
            double  tadult;
            foreach (object item in lb3.Items)
            {
                adultos += Convert.ToDouble(item);
          
            }
            ea = lb3.Items.Count.ToString();
            double eaT = double.Parse(ea);
            tadult = adultos / eaT;
            n3.Text = (tadult.ToString());

            // para los adultos mayores
            double tmay;
            foreach (object item in lb4.Items)
            {
                mayores += Convert.ToDouble(item);
            
            }
            em = lb4.Items.Count.ToString();
            double emt = double.Parse(em);
            tmay = niños / emt;
            n4.Text = (tmay.ToString());



        }
        // boton de regreso a menu principal 

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 menu = new Form1();
            menu.Show();
        }
    }
}
