using System;
using System.Collections.Generic;
using System.Text;

namespace Act4_ExerciceSimple_NombreComplexe
{
    class NbrComplexe
    {
        private double _nombreReel1;
        private double _nombreReel2;

        public double NombreReel1{
            get{
                return _nombreReel1; 
            }
            set{
                _nombreReel1 = value; 
            }
        }

        public double NombreReel2{
            get{ 
                return _nombreReel2; 
            }
            set{
                _nombreReel2 = value; 
            }
        }

        public NbrComplexe(double _nombreReel1, double _nombreReel2)
        {
            this._nombreReel1 = NombreReel1;
            this._nombreReel2 = NombreReel2;
        }

        public string AfficheComplexe()
        {
            string complexe = $"({_nombreReel1.ToString("f2")}, {_nombreReel2.ToString("f2")})";
            return complexe;

        }

        public double CalculeModule()
        {
            double moduleComplexe = Math.Sqrt(Math.Pow(_nombreReel1, 2) + Math.Pow(_nombreReel2, 2));
            return moduleComplexe;
        }

        public void Ajout(double AjtReelle1, double AjtReelle2)
        {
            NombreReel1 += AjtReelle1;
            NombreReel2 += AjtReelle2;
        }
    }
}
