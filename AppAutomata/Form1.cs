using LogicaNegocio;
using System;
using System.Windows.Forms;

namespace AppAutomata
{
    public partial class Form1 : Form
    {
        Procesador procesador = new Procesador();
        public Form1()
        {
            InitializeComponent();
            foreach (var ejercicio in procesador.CargarEjercicios())
            {
                comboBox1.Items.Clear();
                comboBox2.Items.Add(ejercicio);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void ejercicioPresentacion1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    textBoxResultado.Text = procesador.Operaciones(comboBox1.SelectedIndex, textBox_x.Text, "Default");
                    break;
                case 1:
                    textBoxResultado.Text = procesador.OperacionesEjercicio2(comboBox1.SelectedIndex, textBox_x.Text,textBox_y.Text,textBox_z.Text, "Default");
                    break;
                case 2:
                    textBoxResultado.Text = procesador.OperacionesEjercicio3(comboBox1.SelectedIndex);
                    break;
                case 3:
                    textBoxResultado.Text = procesador.OperacionesEjercicio3_Parte2(comboBox1.SelectedIndex);
                    break;
                case 4:
                    textBoxResultado.Text = procesador.OperacionesEjercicio4(comboBox1.SelectedIndex);
                    break;
                case 5:
                    textBoxResultado.Text = procesador.OperacionesEjercicio5(comboBox1.SelectedIndex);
                    break;
                case 6:
                    textBoxResultado.Text = procesador.GenerarAutomataFinito(comboBox1.SelectedIndex,textBoxCadenaEntrada.Text);
                    break;
            } 
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (var item in procesador.CargarOperaciones(comboBox2.SelectedIndex))
            {
                comboBox1.Items.Add(item);
            }
        }
    }
}