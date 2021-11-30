using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karacsonyGUI
{
  internal class Keszlet
  {
    List<Angyalka> angyalkak = new List<Angyalka>();

    private int keszletDb;

    public int KeszletDb
    {
      get { return keszletDb; }
      set { keszletDb = value; }
    }


    public void AngyalHozzaad(Angyalka angyal)
    {
      angyalkak.Add(angyal);
      KeszletDb += angyal.Elkeszitett - angyal.Eladott;
    }
  }
}
