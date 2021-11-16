using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_20211109
{
    public class Ucet
    {
        public string jmeno;
        public float stavPenez;
        public float maxVklad = 200000;

        public Ucet(string jmeno, float stavPenez)
        {
            this.jmeno = jmeno;
            this.stavPenez = stavPenez;
           

        }
        public void Vlozit(float vlozit)
        {
            if (vlozit <= 200000)
            {
                //vlozit += stavPenez;
                stavPenez += vlozit;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Můžeš vložit maximálně 200000");
            }
        }
        public void Vyber(float vyber)
        {
            if (vyber <= 200000)
            {
                stavPenez -= vyber;
            }
            else 
            {
                System.Windows.Forms.MessageBox.Show("Můžeš vybrat maximálně 200000");
            }
            
        }
        public void Platba(float platba)
        {
            if (platba <= 500000)
            {
              stavPenez -= platba;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Můžeš zaplatit maximálně 00000");
            }
        }
        











    }
}
