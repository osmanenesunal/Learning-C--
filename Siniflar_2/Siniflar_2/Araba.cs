using System;
using System.Collections.Generic;
using System.Text;



// KAPSÜL; 
// Get : Okutur
// Set : Değer ataması yapar.

//KALITIM; Bir sınıftaki alanları bşka sınıfa taşımak.
namespace Siniflar_2
{
    class Araba :ArabaDetay
    {
        public string renk;
      
        /*{
            get { return renk; }
            set { renk = value.ToLower(); }

        }*/
        public int hiz;
        public double motor;
        public char durum;
        public int fiyat;
        private int yil;
        private string marka;



        public int YIL
        { 
         get
         {
             return yil;
         }
         set
         {
             yil = Math.Abs(value);
         }
        
        
        
        }

        public string MARKA 
        {
            get
            {
                return marka;
            }
            set
            {
                marka = value.ToUpper(); 
            }
        
        }
            

        




    }
}
