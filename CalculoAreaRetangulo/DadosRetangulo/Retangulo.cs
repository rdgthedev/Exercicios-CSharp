using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoAreaRetangulo.DadosRetangulo
{
    public class Retangulo
    {
        private int baseRetangulo;

        public int BaseRetangulo 
        {
            get
            {
                return baseRetangulo;
            }
            set
            {
                if(value > 0)
                {
                    baseRetangulo = value;
                    
                    
                }
            }
        }

        private int alturaRetangulo;

        public int AlturaRetangulo 
        {
            get
            {
                return alturaRetangulo;
            }
            set
            {
                if(value > 0) 
                {
                    alturaRetangulo = value;
                    
                }
            }
        }
        public int CalculaArea()
        {

                return this.BaseRetangulo * this.AlturaRetangulo; 

        }





    }
}
