using System;
using System.Collections.Generic;

namespace Oef1
{
    internal class Stapel<T>
    {

        private List<T> Stapellijst = new List<T>();
        private List<T> stapellijstCopy = new List<T>();


        public void OpDeStapel(T toeTeVoegen)
        {
            Stapellijst.Add(toeTeVoegen);
        }

        public T vanDeStapel()
        {
            if (Stapellijst.Count <= 0)
            {
                throw new ArgumentNullException();
            }

            T updatedLijst = Stapellijst[Stapellijst.Count - 1];
            Stapellijst.RemoveAt(Stapellijst.Count - 1);

            return updatedLijst;
        }

        public void StapelLeegMaken()
        {
            Stapellijst.Clear();
        }


        public bool IsAanwezigOpStapel(T tezoeken)
        {
            foreach (T elements in Stapellijst)
            {

                if (elements.ToString() == tezoeken.ToString())
                {

                    return true;

                }

            }
          
            return false;

        }

        public override string ToString()
        {
            string lijst = "";

            foreach (T t in Stapellijst)
            {
                lijst += t.ToString() + " " + ",";
            }

            return lijst;
        }

        public List<T> lijstCopy()
        {
            stapellijstCopy = Stapellijst.GetRange(0 , Stapellijst.Count);

            return stapellijstCopy;
        }

    }
}
