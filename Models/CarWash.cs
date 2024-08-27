using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Delegate;

namespace Models
{
    public class CarWash
    {
        private voitureDelegate etapeDeLavage;

        public CarWash()
        {
            etapeDeLavage += Préparer;
            etapeDeLavage += Laver;
            etapeDeLavage += Secher;
            etapeDeLavage += Finaliser;

            //etapeDeLavage += delegate (Voiture v) { Console.WriteLine("je prépare la voiture : {0}", v.Plaque); };
            //etapeDeLavage += delegate (Voiture v) { Console.WriteLine("je lave la voiture : {0}", v.Plaque); };
            //etapeDeLavage += delegate (Voiture v) { Console.WriteLine("je sèche la voiture : {0}", v.Plaque); };
            //etapeDeLavage += delegate (Voiture v) { Console.WriteLine("je finalise la voiture : {0}", v.Plaque); };
        }

        private void Préparer(Voiture v)
        {
            Console.WriteLine($"Je prépare la voiture {v.Plaque}");
        }
        private void Laver(Voiture v)
        {
            Console.WriteLine($"Je lave la voiture {v.Plaque}");
        }
        private void Secher(Voiture v)
        {
            Console.WriteLine($"Je séche la voiture {v.Plaque}");
        }
        private void Finaliser(Voiture v)
        {
            Console.WriteLine($"Je finalise la voiture {v.Plaque}");
        }

        public void Traiter(Voiture v) 
        {
            if (etapeDeLavage is not null)
            {
                etapeDeLavage(v);
            }

        }

    }
}
