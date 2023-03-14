using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace wDibujarLinea
{
    internal class clsDibujarLinea
    {
        private int xIni;
        private int xFin;
        private int yIni;
        private int yFin;
        private static int contar = 0;

        public clsDibujarLinea()
        {
            xFin = 0;
            xIni = 0;
            yFin = 0;
            yIni = 0;

        }

        public clsDibujarLinea(int xIni, int xFin, int yIni, int yFin)
        {
            this.xIni = xIni;
            this.xFin = xFin;
            this.yIni = yIni;
            this.yFin = yFin;
        }

        public clsDibujarLinea (double xIni, double xFin, double yIni, double yFin)
        {
            this.xIni = (int)xIni;
            this.xFin = (int)xFin;
            this.yIni = (int)yIni;
            this.yFin = (int)yFin;
        }

        public int  conseguirxIni()
        {
            return xIni;
        }
        public int conseguirxFin()
        {
            return xFin;
        }

        public int conseguiryIni()
        {
            return yIni;
        }
        public int conseguiryFin()
        {
            return yFin;
        }


        public void cambioXIni(int xIni)
        {
            this.xIni= xIni;
        }
        public void cambioXFin(int xFin)
        {
            this.xFin= xFin;
        }

        public void cambioYIni(int yIni)
        {
            this.yIni=yIni;
        }
        public void cambi0YFin(int yFin)
        {
            this.yFin=yFin;
        }

        public static int cuente()
        {
            contar += 1;
            return contar;
        }
    }
}
