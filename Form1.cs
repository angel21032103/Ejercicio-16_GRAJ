using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ejercicio_16_GRAJ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string palabra = txtpalabra.Text;

            if (EsPalindromo(palabra))
            {
                lbRespuesta.Text = "La frase es un palíndromo.";
            }
            else
            {
                lbRespuesta.Text = "La frase no es un palíndromo.";
            }
        }


        private bool EsPalindromo(string palabra)
        {
            Stack<char> pila = new Stack<char>();
            Queue<char> cola = new Queue<char>();

            palabra = palabra.Replace(" ", "").ToLower();

            foreach (char letra in palabra)
            {
                pila.Push(letra);
                cola.Enqueue(letra);
            }

         
            while (pila.Count > 0 && cola.Count > 0)
            {
                if (pila.Pop() != cola.Dequeue())
                {
                    return false; // No es un palíndromo
                }
            }

            return true; // Es un palíndromo
        }
    }
}
