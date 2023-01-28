using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;



namespace Lab_3_KAML
{
    public partial class program1 : Form
    {
        public program1()
        {
            InitializeComponent();
        }

        // aca esta la parte que se programa para que el numero ingresado en la textbox se refleje en las listbox correspondientes al apretar un boton
        private void button1_Click(object sender, EventArgs e)
        {
        
            
            if (textadd.Text == "")
            {
                MessageBox.Show("por favor ingrese un valor");
            }
            else
            {
                double entero = Convert.ToDouble(textadd.Text);           

                    if (entero == 00)
                    {
                        entero = neutro.Items.Add(entero);

                    }
                    else
                    {
                        if (entero >= 1)
                        {
                            entero = positivo.Items.Add(entero);

                        }

                        else
                        {
                            entero = negativo.Items.Add(entero);

                        }
                    }
                    // limpiar la textbox y enfocarla
                textadd.Clear();
                textadd.Focus();
            }
        }

        double totp;
        // programa para sumar los items dentro de una listbox * numeros positivos *
        // y presentarlos, tambien presentar la cantidad de items en la listbox
        private void sump_Click(object sender, EventArgs e)
        {
            foreach(object item in positivo.Items)
            {
                totp += Convert.ToDouble(item);
                label2.Text = (totp).ToString();
                
            }
            label6.Text = positivo.Items.Count.ToString();
        }
        
        // programa para sumar los items dentro de la listbox *numeros negativos*
        // presentarlos asi como la cantidad de items que hay en la listbox.
        double totn;
        private void sumn_Click(object sender, EventArgs e)
        {
            foreach (object item in negativo.Items)
            {
                totn += Convert.ToDouble(item);
                label3.Text = (totn).ToString();
            }
            label8.Text = negativo.Items.Count.ToString();
        }


        // linea de codigo para contar los elementos neutros que fueron ingresados

        private void sumneu_Click(object sender, EventArgs e)
        {
           
            label4.Text = neutro.Items.Count.ToString();

        }
        // boton para regresar al menu principal
        private void button2_Click(object sender, EventArgs e)
           
        {
            this.Close();
            Form1 menu = new Form1();
            menu.Show();
        }


    }
}