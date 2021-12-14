using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proyecto319csharp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int a, b, lim, aux;
            lim = int.Parse(TextBox1.Text);
            a = 0;
            b = 1;
            String res = "0, ";
            for (int i = 2; i <= lim; i++)
            {
                aux = a;
                a = b;
                b = aux + a;
                res += (a.ToString() + ", ");
                if (i % 10 == 0 && i != 0) res += "\n";
            }
            TextBox2.Text = res;
        }

        //calculadora
        //funcion orden superior
        public int operación(Func<int,int,int> op, int num1,int num2) {
            return op(num1, num2);
        }
        //operaciones
        public int suma(int number1, int number2){
            return number1 + number2;
        }
        public int resta(int number1, int number2)
        {
            return number1 - number2;
        }
        public int mult(int number1, int number2)
        {
            return number1 * number2;
        }
        public int divi(int number1, int number2)
        {
            return number1 / number2;
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(TextBox3.Text);
            int b = int.Parse(TextBox4.Text);
            TextBox5.Text = (operación(suma, a, b)).ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(TextBox3.Text);
            int b = int.Parse(TextBox4.Text);
            TextBox5.Text = (operación(resta, a, b)).ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int a = int.Parse(TextBox3.Text);
            int b = int.Parse(TextBox4.Text);
            TextBox5.Text = (operación(mult, a, b)).ToString();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            int a = int.Parse(TextBox3.Text);
            int b = int.Parse(TextBox4.Text);
            TextBox5.Text = (operación(divi, a, b)).ToString();
        }

        //calculadora de matrices
        public int[,] matrices(Func<int[,], int[,], int[,]> op, int[,] mat1, int[,] mat2)
        {
            return op(mat1, mat2);
        }

        //operaciones
        public int[,] sumamat(int[,] mat1, int[,] mat2)
        {
            int[,] res = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    res[i, j] = mat1[i, j] + mat2[i, j];
                }
            }
            return res;
        }

        public int[,] resmat(int[,] mat1, int[,] mat2)
        {
            int[,] res = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    res[i, j] = mat1[i, j] - mat2[i, j];
                }
            }
            return res;
        }

        public int[,] mulmat(int[,] mat1, int[,] mat2)
        {
            int[,] res = new int[2, 2];
            int n = 2;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    res[i,j] = 0;
                    for (int k = 0; k < n; k++)
                    { 
                        res[i,j] += mat1[i, k] * mat2[k, j];
                    }
                }
            }
            return res;
        }

        

        protected void Button6_Click(object sender, EventArgs e)
        {
            int a = int.Parse(TextBox6.Text);
            int b = int.Parse(TextBox7.Text);
            int c = int.Parse(TextBox10.Text);
            int d = int.Parse(TextBox11.Text);
            int a1 = int.Parse(TextBox8.Text);
            int b1 = int.Parse(TextBox9.Text);
            int c1 = int.Parse(TextBox12.Text);
            int d1 = int.Parse(TextBox13.Text);

            int[,] m1 = new int[2, 2] { { a, b }, { c, d } };
            int[,] m2 = new int[2, 2] { { a1, b1 }, { c1, d1 } };
            int[,] res = matrices(sumamat, m1, m2);

            TextBox14.Text = res[0,0].ToString();
            TextBox15.Text = res[0,1].ToString();
            TextBox16.Text = res[1,0].ToString();
            TextBox17.Text = res[1,1].ToString();
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            int a = int.Parse(TextBox6.Text);
            int b = int.Parse(TextBox7.Text);
            int c = int.Parse(TextBox10.Text);
            int d = int.Parse(TextBox11.Text);
            int a1 = int.Parse(TextBox8.Text);
            int b1 = int.Parse(TextBox9.Text);
            int c1 = int.Parse(TextBox12.Text);
            int d1 = int.Parse(TextBox13.Text);

            int[,] m1 = new int[2, 2] { { a, b }, { c, d } };
            int[,] m2 = new int[2, 2] { { a1, b1 }, { c1, d1 } };
            int[,] res = matrices(resmat, m1, m2);

            TextBox14.Text = res[0, 0].ToString();
            TextBox15.Text = res[0, 1].ToString();
            TextBox16.Text = res[1, 0].ToString();
            TextBox17.Text = res[1, 1].ToString();
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            int a = int.Parse(TextBox6.Text);
            int b = int.Parse(TextBox7.Text);
            int c = int.Parse(TextBox10.Text);
            int d = int.Parse(TextBox11.Text);
            int a1 = int.Parse(TextBox8.Text);
            int b1 = int.Parse(TextBox9.Text);
            int c1 = int.Parse(TextBox12.Text);
            int d1 = int.Parse(TextBox13.Text);

            int[,] m1 = new int[2, 2] { { a, b }, { c, d } };
            int[,] m2 = new int[2, 2] { { a1, b1 }, { c1, d1 } };
            int[,] res = matrices(mulmat, m1, m2);

            TextBox14.Text = res[0, 0].ToString();
            TextBox15.Text = res[0, 1].ToString();
            TextBox16.Text = res[1, 0].ToString();
            TextBox17.Text = res[1, 1].ToString();
        }

        //criba

        protected void Button9_Click(object sender, EventArgs e)
        {
            int n = int.Parse(TextBox18.Text);
            bool[] marcados = new bool[n + 1];
            String res = "";
            int co = 0;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (!marcados[i])
                    for (int j = i * 2; j <= n; j += i)
                        marcados[j] = true;
            }

            for (int i = 2; i < marcados.Length; i++)
                if (marcados[i] == false)
                {
                    res += i.ToString() + ", ";
                    co++;
                    if (co % 10 == 0) res += "\n";
                }
            TextBox19.Text = res;
        }

        //separar % 2

        protected void Button10_Click(object sender, EventArgs e)
        {
            String[] cad = (TextBox20.Text).Split(' ');
            int[] nums = Array.ConvertAll(cad, int.Parse);
            String pares ="";
            String impares ="";
            int cop=0;
            int coi=0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    pares += nums[i] + ", ";
                    cop++;
                    if (cop % 10 == 0) pares += "\n";
                }
                else {
                    impares += nums[i] + ", ";
                    coi++;
                    if (coi % 10 == 0) impares += "\n";
                }
            }

            TextBox21.Text = pares;
            TextBox22.Text = impares;

        }



        
    }
}