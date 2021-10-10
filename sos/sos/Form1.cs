using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if (button1.Text == "s")
            {

            }
            else if (button1.Text == "o")
            {

            }
            else
            {
               
                button1.Text = "s";
                
                Random raskele = new Random();
            btn1:
                int hamle = raskele.Next(1, 10);
                string atack = hamle.ToString();
                switch (atack)                              
                {
                 
                      
                       
                    case "2":
                        if (button2.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button2.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button2.Text = "o";

                        }
                        break;
                    case "3":
                        if (button3.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button3.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button3.Text = "o";

                        }
                        break;
                    case "4":
                        if (button4.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button4.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button4.Text = "o";

                        }
                        break;
                    case "5":
                        if (button5.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button5.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button5.Text = "o";

                        }
                        break;
                    case "6":
                        if (button6.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button6.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button6.Text = "o";

                        }

                        break;
                    case "7":
                        if (button7.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button7.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button7.Text = "o";

                        }
                        break;
                    case "8":
                        if (button8.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button8.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button8.Text = "o";

                        }
                        break;
                    case "9":
                        if (button9.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button9.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button9.Text = "o";

                        }
                        break;
                }

                if (button3.Text =="s" && button2.Text=="o" && button1.Text=="s")
                {
                    button1.BackColor = Color.Red;
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Red;
                }
               if (button1.Text =="s" && button4.Text =="o" && button7.Text=="s")
                {
                    button1.BackColor = Color.Red;
                    button7.BackColor = Color.Red;
                    button4.BackColor = Color.Red;
                }
              if (button1.Text == "s" && button5.Text == "o" && button9.Text == "s")
                {
                    button1.BackColor = Color.Red;
                    button9.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                }
           
            if (button3.Text == "s" && button6.Text == "o" && button9.Text == "s")
            {
                button3.BackColor = Color.Red;
                button9.BackColor = Color.Red;
                button6.BackColor = Color.Red;
            }
                if (button7.Text == "s" && button8.Text == "o" && button9.Text == "s")
                {
                    button7.BackColor = Color.Red;
                    button9.BackColor = Color.Red;
                    button8.BackColor = Color.Red;
                }
                if (button2.Text == "s" && button5.Text == "o" && button8.Text == "s")
                {
                    button2.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                    button8.BackColor = Color.Red;
                }
                if (button3.Text == "s" && button6.Text == "o" && button9.Text == "s")
                {
                    button3.BackColor = Color.Red;
                    button9.BackColor = Color.Red;
                    button6.BackColor = Color.Red;
                }
                if (button3.Text == "s" && button5.Text == "o" && button7.Text == "s")
                {
                    button3.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                    button7.BackColor = Color.Red;
                }
                if (button4.Text == "s" && button5.Text == "o" && button6.Text == "s")
                {
                    button4.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                    button6.BackColor = Color.Red;
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "s")
            {

            }
            else if (button2.Text == "o")
            {

            }
            else
            {
                button2.Text = "s";
           
                Random raskele = new Random();
            btn1:
                int hamle = raskele.Next(0, 10);
           
                string atack = hamle.ToString();
                if(atack == "2")
                {
                    goto btn1;
                }
                switch (atack) { 
               
                    case "1":
                        if (button1.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button1.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button1.Text = "o";

                        }
      
                        break;
                    case "3":
                        if (button3.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button3.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button3.Text = "o";

                        }
                        break;
                    case "4":
                        if (button4.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button4.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button4.Text = "o";

                        }
                        break;
                    case "5":
                        if (button5.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button5.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button5.Text = "o";

                        }
                        break;
                    case "6":
                        if (button6.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button6.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button6.Text = "o";

                        }

                        break;
                    case "7":
                        if (button7.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button7.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button7.Text = "o";

                        }
                        break;
                    case "8":
                        if (button8.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button8.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button8.Text = "o";

                        }
                        break;
                    case "9":
                        if (button9.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button9.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button9.Text = "o";

                        }
                        break;
                }
                if (button3.Text == "s" && button2.Text == "o" && button1.Text == "s")
                {
                    button1.BackColor = Color.Red;
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Red;
                }
                if (button1.Text == "s" && button4.Text == "o" && button7.Text == "s")
                {
                    button1.BackColor = Color.Red;
                    button7.BackColor = Color.Red;
                    button4.BackColor = Color.Red;
                }
                if (button1.Text == "s" && button5.Text == "o" && button9.Text == "s")
                {
                    button1.BackColor = Color.Red;
                    button9.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                }

                if (button3.Text == "s" && button6.Text == "o" && button9.Text == "s")
                {
                    button3.BackColor = Color.Red;
                    button9.BackColor = Color.Red;
                    button6.BackColor = Color.Red;
                }
                if (button7.Text == "s" && button8.Text == "o" && button9.Text == "s")
                {
                    button8.BackColor = Color.Red;
                    button9.BackColor = Color.Red;
                    button7.BackColor = Color.Red;
                }
                if (button2.Text == "s" && button5.Text == "o" && button8.Text == "s")
                {
                    button2.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                    button8.BackColor = Color.Red;
                }
                if (button3.Text == "s" && button6.Text == "o" && button9.Text == "s")
                {
                    button3.BackColor = Color.Red;
                    button9.BackColor = Color.Red;
                    button6.BackColor = Color.Red;
                }
                if (button3.Text == "s" && button5.Text == "o" && button7.Text == "s")
                {
                    button3.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                    button7.BackColor = Color.Red;
                }
                if (button4.Text == "s" && button5.Text == "o" && button6.Text == "s")
                {
                    button4.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                    button6.BackColor = Color.Red;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "s")
            {

            }
            else if (button3.Text == "o")
            {

            }
            else
            {
                button3.Text = "s";
            
                Random raskele = new Random();
            btn1:
                int hamle = raskele.Next(0, 10);
         
                string atack = hamle.ToString();
                if (atack == "3")
                {
                    goto btn1;
                }
                switch (atack)
                {

                    case "1":
                        if (button1.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button1.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button1.Text = "o";

                        }

                        break;
                    case "2":
                        if (button2.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button2.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button2.Text = "o";

                        }
                        break;
                    case "4":
                        if (button4.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button4.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button4.Text = "o";

                        }
                        break;
                    case "5":
                        if (button5.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button5.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button5.Text = "o";

                        }
                        break;
                    case "6":
                        if (button6.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button6.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button6.Text = "o";

                        }

                        break;
                    case "7":
                        if (button7.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button7.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button7.Text = "o";

                        }
                        break;
                    case "8":
                        if (button8.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button8.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button8.Text = "o";

                        }
                        break;
                    case "9":
                        if (button9.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button9.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button9.Text = "o";

                        }
                        break;
                }
                if (button3.Text == "s" && button2.Text == "o" && button1.Text == "s")
                {
                    button1.BackColor = Color.Red;
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Red;
                }
                if (button1.Text == "s" && button4.Text == "o" && button7.Text == "s")
                {
                    button1.BackColor = Color.Red;
                    button7.BackColor = Color.Red;
                    button4.BackColor = Color.Red;
                }
                if (button1.Text == "s" && button5.Text == "o" && button9.Text == "s")
                {
                    button1.BackColor = Color.Red;
                    button9.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                }

                if (button3.Text == "s" && button6.Text == "o" && button9.Text == "s")
                {
                    button3.BackColor = Color.Red;
                    button9.BackColor = Color.Red;
                    button6.BackColor = Color.Red;
                }
                if (button7.Text == "s" && button8.Text == "o" && button9.Text == "s")
                {
                    button7.BackColor = Color.Red;
                    button9.BackColor = Color.Red;
                    button8.BackColor = Color.Red;
                }
                if (button2.Text == "s" && button5.Text == "o" && button8.Text == "s")
                {
                    button2.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                    button8.BackColor = Color.Red;
                }
                if (button3.Text == "s" && button6.Text == "o" && button9.Text == "s")
                {
                    button3.BackColor = Color.Red;
                    button9.BackColor = Color.Red;
                    button6.BackColor = Color.Red;
                }
                if (button3.Text == "s" && button5.Text == "o" && button7.Text == "s")
                {
                    button3.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                    button7.BackColor = Color.Red;
                }
                if (button4.Text == "s" && button5.Text == "o" && button6.Text == "s")
                {
                    button4.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                    button6.BackColor = Color.Red;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button6.Text == "s")
            {

            }
            else if (button6.Text == "o")
            {

            }
            else
            {
                button6.Text = "s";
           
                Random raskele = new Random();
            btn1:
                int hamle = raskele.Next(0, 10);
           
                string atack = hamle.ToString();
                if (atack == "6")
                {
                    goto btn1;
                }
                switch (atack)
                {

                    case "1":
                        if (button1.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button1.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button1.Text = "o";

                        }

                        break;
                    case "2":
                        if (button2.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button2.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button2.Text = "o";

                        }
                        break;
                    case "3":
                        if (button3.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button3.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button3.Text = "o";

                        }
                        break;
                    case "5":
                        if (button5.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button5.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button5.Text = "o";

                        }
                        break;
                    case "4":
                        if (button4.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button4.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button4.Text = "o";

                        }

                        break;
                    case "7":
                        if (button7.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button7.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button7.Text = "o";

                        }
                        break;
                    case "8":
                        if (button8.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button8.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button8.Text = "o";

                        }
                        break;
                    case "9":
                        if (button9.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button9.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button9.Text = "o";

                        }
                        break;
                }
                if (button3.Text == "s" && button2.Text == "o" && button1.Text == "s")
                {
                    button1.BackColor = Color.Red;
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Red;
                }
                if (button1.Text == "s" && button4.Text == "o" && button7.Text == "s")
                {
                    button1.BackColor = Color.Red;
                    button7.BackColor = Color.Red;
                    button4.BackColor = Color.Red;
                }
                if (button1.Text == "s" && button5.Text == "o" && button9.Text == "s")
                {
                    button1.BackColor = Color.Red;
                    button9.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                }

                if (button3.Text == "s" && button6.Text == "o" && button9.Text == "s")
                {
                    button3.BackColor = Color.Red;
                    button9.BackColor = Color.Red;
                    button6.BackColor = Color.Red;
                }
                if (button7.Text == "s" && button8.Text == "o" && button9.Text == "s")
                {
                    button7.BackColor = Color.Red;
                    button9.BackColor = Color.Red;
                    button8.BackColor = Color.Red;
                }
                if (button2.Text == "s" && button5.Text == "o" && button8.Text == "s")
                {
                    button2.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                    button8.BackColor = Color.Red;
                }
                if (button3.Text == "s" && button6.Text == "o" && button9.Text == "s")
                {
                    button3.BackColor = Color.Red;
                    button9.BackColor = Color.Red;
                    button6.BackColor = Color.Red;
                }
                if (button3.Text == "s" && button5.Text == "o" && button7.Text == "s")
                {
                    button3.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                    button7.BackColor = Color.Red;
                }
                if (button4.Text == "s" && button5.Text == "o" && button6.Text == "s")
                {
                    button4.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                    button6.BackColor = Color.Red;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "s")
            {

            }
            else if (button5.Text == "o")
            {

            }
            else
            {
                button5.Text = "s";
            
                Random raskele = new Random();
            btn1:
                int hamle = raskele.Next(0, 10);
                string atack = hamle.ToString();
                if (atack == "5")
                {
                    goto btn1;
                }
                switch (atack)
                {

                    case "1":
                        if (button1.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button1.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button1.Text = "o";

                        }

                        break;
                    case "2":
                        if (button2.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button2.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button2.Text = "o";

                        }
                        break;
                    case "4":
                        if (button4.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button4.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button4.Text = "o";

                        }
                        break;
                    case "3":
                        if (button3.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button3.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button3.Text = "o";

                        }
                        break;
                    case "6":
                        if (button6.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button6.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button6.Text = "o";

                        }

                        break;
                    case "7":
                        if (button7.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button7.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button7.Text = "o";

                        }
                        break;
                    case "8":
                        if (button8.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button8.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button8.Text = "o";

                        }
                        break;
                    case "9":
                        if (button9.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button9.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button9.Text = "o";

                        }
                        break;
                }
                if (button3.Text == "s" && button2.Text == "o" && button1.Text == "s")
                {
                    button1.BackColor = Color.Red;
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Red;
                }
                if (button1.Text == "s" && button4.Text == "o" && button7.Text == "s")
                {
                    button1.BackColor = Color.Red;
                    button7.BackColor = Color.Red;
                    button4.BackColor = Color.Red;
                }
                if (button1.Text == "s" && button5.Text == "o" && button9.Text == "s")
                {
                    button1.BackColor = Color.Red;
                    button9.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                }

                if (button3.Text == "s" && button6.Text == "o" && button9.Text == "s")
                {
                    button3.BackColor = Color.Red;
                    button9.BackColor = Color.Red;
                    button6.BackColor = Color.Red;
                }
                if (button7.Text == "s" && button8.Text == "o" && button9.Text == "s")
                {
                    button7.BackColor = Color.Red;
                    button9.BackColor = Color.Red;
                    button8.BackColor = Color.Red;
                }
                if (button2.Text == "s" && button5.Text == "o" && button8.Text == "s")
                {
                    button2.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                    button8.BackColor = Color.Red;
                }
                if (button3.Text == "s" && button6.Text == "o" && button9.Text == "s")
                {
                    button3.BackColor = Color.Red;
                    button9.BackColor = Color.Red;
                    button6.BackColor = Color.Red;
                }
                if (button3.Text == "s" && button5.Text == "o" && button7.Text == "s")
                {
                    button3.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                    button7.BackColor = Color.Red;
                }
                if (button4.Text == "s" && button5.Text == "o" && button6.Text == "s")
                {
                    button4.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                    button6.BackColor = Color.Red;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button4.Text == "s")
            {

            }
            else if (button4.Text == "o")
            {

            }
            else
            {
                button4.Text = "s";
            btn1:
                Random raskele = new Random();
                int hamle = raskele.Next(0, 10);
                string atack = hamle.ToString();
                if (atack == "4")
                {
                    goto btn1;
                }
                switch (atack)
                {

                    case "1":
                        if (button1.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button1.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button1.Text = "o";

                        }

                        break;
                    case "2":
                        if (button2.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button2.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button2.Text = "o";

                        }
                        break;
                    case "3":
                        if (button3.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button3.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button3.Text = "o";

                        }
                        break;
                    case "5":
                        if (button5.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button5.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button5.Text = "o";

                        }
                        break;
                    case "6":
                        if (button6.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button6.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button6.Text = "o";

                        }

                        break;
                    case "7":
                        if (button7.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button7.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button7.Text = "o";

                        }
                        break;
                    case "8":
                        if (button8.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button8.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button8.Text = "o";

                        }
                        break;
                    case "9":
                        if (button9.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button9.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button9.Text = "o";

                        }
                        break;
                }
                if (button3.Text == "s" && button2.Text == "o" && button1.Text == "s")
                {
                    button1.BackColor = Color.Red;
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Red;
                }
                if (button1.Text == "s" && button4.Text == "o" && button7.Text == "s")
                {
                    button1.BackColor = Color.Red;
                    button7.BackColor = Color.Red;
                    button4.BackColor = Color.Red;
                }
                if (button1.Text == "s" && button5.Text == "o" && button9.Text == "s")
                {
                    button1.BackColor = Color.Red;
                    button9.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                }

                if (button3.Text == "s" && button6.Text == "o" && button9.Text == "s")
                {
                    button3.BackColor = Color.Red;
                    button9.BackColor = Color.Red;
                    button6.BackColor = Color.Red;
                }
                if (button7.Text == "s" && button8.Text == "o" && button9.Text == "s")
                {
                    button7.BackColor = Color.Red;
                    button9.BackColor = Color.Red;
                    button8.BackColor = Color.Red;
                }
                if (button2.Text == "s" && button5.Text == "o" && button8.Text == "s")
                {
                    button2.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                    button8.BackColor = Color.Red;
                }
                if (button3.Text == "s" && button6.Text == "o" && button9.Text == "s")
                {
                    button3.BackColor = Color.Red;
                    button9.BackColor = Color.Red;
                    button6.BackColor = Color.Red;
                }
                if (button3.Text == "s" && button5.Text == "o" && button7.Text == "s")
                {
                    button3.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                    button7.BackColor = Color.Red;
                }
                if (button4.Text == "s" && button5.Text == "o" && button6.Text == "s")
                {
                    button4.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                    button6.BackColor = Color.Red;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button9.Text == "s")
            {

            }
            else if (button9.Text == "o")
            {

            }
            else
            {
                button9.Text = "s";
          
                Random raskele = new Random();
            btn1:
                int hamle = raskele.Next(0, 10);
                string atack = hamle.ToString();
                if (atack == "9")
                {
                    goto btn1;
                }
                switch (atack)
                {

                    case "1":
                        if (button1.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button1.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button1.Text = "o";

                        }

                        break;
                    case "2":
                        if (button2.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button2.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button2.Text = "o";

                        }
                        break;
                    case "4":
                        if (button4.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button4.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button4.Text = "o";

                        }
                        break;
                    case "5":
                        if (button5.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button5.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button5.Text = "o";

                        }
                        break;
                    case "6":
                        if (button6.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button6.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button6.Text = "o";

                        }

                        break;
                    case "7":
                        if (button3.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button3.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button3.Text = "o";

                        }
                        break;
                    case "8":
                        if (button8.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button8.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button8.Text = "o";

                        }
                        break;
                    case "3":
                        if (button3.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button3.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button3.Text = "o";

                        }
                        break;
                }
                if (button3.Text == "s" && button2.Text == "o" && button1.Text == "s")
                {
                    button1.BackColor = Color.Red;
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Red;
                }
                if (button1.Text == "s" && button4.Text == "o" && button7.Text == "s")
                {
                    button1.BackColor = Color.Red;
                    button7.BackColor = Color.Red;
                    button4.BackColor = Color.Red;
                }
                if (button1.Text == "s" && button5.Text == "o" && button9.Text == "s")
                {
                    button1.BackColor = Color.Red;
                    button9.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                }

                if (button3.Text == "s" && button6.Text == "o" && button9.Text == "s")
                {
                    button3.BackColor = Color.Red;
                    button9.BackColor = Color.Red;
                    button6.BackColor = Color.Red;
                }
                if (button7.Text == "s" && button8.Text == "o" && button9.Text == "s")
                {
                    button7.BackColor = Color.Red;
                    button9.BackColor = Color.Red;
                    button8.BackColor = Color.Red;
                }
                if (button2.Text == "s" && button5.Text == "o" && button8.Text == "s")
                {
                    button2.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                    button8.BackColor = Color.Red;
                }
                if (button3.Text == "s" && button6.Text == "o" && button9.Text == "s")
                {
                    button3.BackColor = Color.Red;
                    button9.BackColor = Color.Red;
                    button6.BackColor = Color.Red;
                }
                if (button3.Text == "s" && button5.Text == "o" && button7.Text == "s")
                {
                    button3.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                    button7.BackColor = Color.Red;
                }
                if (button4.Text == "s" && button5.Text == "o" && button6.Text == "s")
                {
                    button4.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                    button6.BackColor = Color.Red;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "s")
            {

            }
            else if (button8.Text == "o")
            {

            }
            else
            {
                button8.Text = "s";
           
                Random raskele = new Random();
            btn1:
                int hamle = raskele.Next(0, 10);
                string atack = hamle.ToString();
                if (atack == "8")
                {
                    goto btn1;
                }
                switch (atack)
                {

                    case "1":
                        if (button1.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button1.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button1.Text = "o";

                        }

                        break;
                    case "2":
                        if (button2.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button2.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button2.Text = "o";

                        }
                        break;
                    case "4":
                        if (button4.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button4.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button4.Text = "o";

                        }
                        break;
                    case "5":
                        if (button5.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button5.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button5.Text = "o";

                        }
                        break;
                    case "6":
                        if (button6.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button6.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button6.Text = "o";

                        }

                        break;
                    case "7":
                        if (button7.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button7.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button7.Text = "o";

                        }
                        break;
                    case "3":
                        if (button3.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button3.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button3.Text = "o";

                        }
                        break;
                    case "9":
                        if (button9.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button9.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button9.Text = "o";

                        }
                        break;
                }
                if (button3.Text == "s" && button2.Text == "o" && button1.Text == "s")
                {
                    button1.BackColor = Color.Red;
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Red;
                }
                if (button1.Text == "s" && button4.Text == "o" && button7.Text == "s")
                {
                    button1.BackColor = Color.Red;
                    button7.BackColor = Color.Red;
                    button4.BackColor = Color.Red;
                }
                if (button1.Text == "s" && button5.Text == "o" && button9.Text == "s")
                {
                    button1.BackColor = Color.Red;
                    button9.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                }

                if (button3.Text == "s" && button6.Text == "o" && button9.Text == "s")
                {
                    button3.BackColor = Color.Red;
                    button9.BackColor = Color.Red;
                    button6.BackColor = Color.Red;
                }
                if (button7.Text == "s" && button8.Text == "o" && button9.Text == "s")
                {
                    button7.BackColor = Color.Red;
                    button8.BackColor = Color.Red;
                    button9.BackColor = Color.Red;
                }
                if (button2.Text == "s" && button5.Text == "o" && button8.Text == "s")
                {
                    button2.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                    button8.BackColor = Color.Red;
                }
                if (button3.Text == "s" && button6.Text == "o" && button9.Text == "s")
                {
                    button3.BackColor = Color.Red;
                    button9.BackColor = Color.Red;
                    button6.BackColor = Color.Red;
                }
                if (button3.Text == "s" && button5.Text == "o" && button7.Text == "s")
                {
                    button3.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                    button7.BackColor = Color.Red;
                }
                if (button4.Text == "s" && button5.Text == "o" && button6.Text == "s")
                {
                    button4.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                    button6.BackColor = Color.Red;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button7.Text == "s")
            {

            }
            else if (button7.Text == "o")
            {

            }
            else
            {
                button7.Text = "s";
            
                Random raskele = new Random();
            btn1:
                int hamle = raskele.Next(0, 10);
                string atack = hamle.ToString();
                if (atack == "7")
                {
                    goto btn1;
                }
                switch (atack)
                {

                    case "1":
                        if (button1.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button1.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button1.Text = "o";

                        }

                        break;
                    case "2":
                        if (button2.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button2.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button2.Text = "o";

                        }
                        break;
                    case "4":
                        if (button4.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button4.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button4.Text = "o";

                        }
                        break;
                    case "5":
                        if (button5.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button5.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button5.Text = "o";

                        }
                        break;
                    case "6":
                        if (button6.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button6.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button6.Text = "o";

                        }

                        break;
                    case "3":
                        if (button3.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button3.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button3.Text = "o";

                        }
                        break;
                    case "8":
                        if (button8.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button8.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button8.Text = "o";

                        }
                        break;
                    case "9":
                        if (button9.Text == "s")
                        {
                            goto btn1;
                        }
                        else if (button9.Text == "o")
                        {
                            goto btn1;
                        }
                        else
                        {
                            button9.Text = "o";

                        }
                        break;
                }
                if (button3.Text == "s" && button2.Text == "o" && button1.Text == "s")
                {
                    button1.BackColor = Color.Red;
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Red;
                }
                if (button1.Text == "s" && button4.Text == "o" && button7.Text == "s")
                {
                    button1.BackColor = Color.Red;
                    button7.BackColor = Color.Red;
                    button4.BackColor = Color.Red;
                }
                if (button1.Text == "s" && button5.Text == "o" && button9.Text == "s")
                {
                    button1.BackColor = Color.Red;
                    button9.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                }

                if (button3.Text == "s" && button6.Text == "o" && button9.Text == "s")
                {
                    button3.BackColor = Color.Red;
                    button9.BackColor = Color.Red;
                    button6.BackColor = Color.Red;
                }
                if (button7.Text == "s" && button8.Text == "o" && button9.Text == "s")
                {
                    button7.BackColor = Color.Red;
                    button8.BackColor = Color.Red;
                    button9.BackColor = Color.Red;
                }
                if (button2.Text == "s" && button5.Text == "o" && button8.Text == "s")
                {
                    button2.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                    button8.BackColor = Color.Red;
                }
                if (button3.Text == "s" && button6.Text == "o" && button9.Text == "s")
                {
                    button3.BackColor = Color.Red;
                    button9.BackColor = Color.Red;
                    button6.BackColor = Color.Red;
                }
                if (button3.Text == "s" && button5.Text == "o" && button7.Text == "s")
                {
                    button3.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                    button7.BackColor = Color.Red;
                }
                if (button4.Text == "s" && button5.Text == "o" && button6.Text == "s")
                {
                    button4.BackColor = Color.Red;
                    button5.BackColor = Color.Red;
                    button6.BackColor = Color.Red;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.ResetText();
            button1.BackColor = Color.LightSkyBlue;
            button2.ResetText();
            button2.BackColor = Color.LightSkyBlue;
            button3.ResetText();
            button3.BackColor = Color.LightSkyBlue;
            button4.ResetText();
            button4.BackColor = Color.LightSkyBlue;
            button5.ResetText();
            button5.BackColor = Color.LightSkyBlue;
            button6.ResetText();
            button6.BackColor = Color.LightSkyBlue;
            button7.ResetText();
            button7.BackColor = Color.LightSkyBlue;
            button8.ResetText();
            button8.BackColor = Color.LightSkyBlue;
            button9.ResetText();
            button9.BackColor = Color.LightSkyBlue;
        }
    }
}
