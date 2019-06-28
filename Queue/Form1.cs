using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queue
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

        private void Elave_Click(object sender, EventArgs e)
        {
           
            string daxiEdilen = Daxiledilecek.Text;
            int Novbedekiler = QueueC.Queuee.Count;
            if (daxiEdilen.Trim().Length > 0) {


                if (Novbedekiler < 20)
                {
                    
                    QueueC.Queuee.Enqueue("No"+QueueC.Id.ToString()+" "+daxiEdilen);
                    Novbe.Text = QueueC.Queuee.Peek();
                    Novbeler.Items.Clear();
                    int count = 0;
                    foreach(var dd in QueueC.Queuee)
                    {
                        if (count > 0)
                        {
                            Novbeler.Items.Add(dd);
                        }
                        count++;
                        
                    }
                    Daxiledilecek.Text = "";
                    QueueC.Id++;
                    txtNobedekiler.Text = "Novbede "+QueueC.Queuee.Count.ToString()+" nefer";
                }
                else
                {
                    MessageBox.Show("Novbe sayi dolmusdur zehmet olmasa gozleyin");
                }
            }
            else
            {
                MessageBox.Show("Duzgun Ad daxil edin");
            }
            
        }

        private void Cixar_Click(object sender, EventArgs e)
        {
            
            if (QueueC.Queuee.Count >1)
            {
                QueueC.Queuee.Dequeue();
                Novbe.Text = QueueC.Queuee.Peek();
                int count = 0;
                
                if (QueueC.Queuee.Count > 0)
                {
                    Novbeler.Items.Clear();
                    foreach (var dd in QueueC.Queuee)
                    {
                        if (count > 0)
                        {
                            Novbeler.Items.Add(dd);
                        }
                        count++;

                    }
                    txtNobedekiler.Text ="Novbede "+ QueueC.Queuee.Count.ToString()+" nefer";
                }
                else
                {
                    MessageBox.Show("Novbede kimse yoxdur");
                }
                
                
            }
            else
            {
                MessageBox.Show("Novbede kimse yoxdur");
                
            }
            
        }

        
    }
}
