using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karacsonyGUI
{
  internal class Angyalka
  {
    private int elkeszitett;

    public int Elkeszitett
    {
      get { return elkeszitett; }
      set { elkeszitett = value; }
    }

    private int eladott;

    public int Eladott
    {
      get { return eladott; }
      set { eladott = value; }
    }

    private int nap;

    public int Nap
    {
      get { return nap; }
      set { nap = value; }
    }

    public Angyalka(int elkeszitett, int eladott, int nap)
    {
      Elkeszitett = elkeszitett;
      Eladott = eladott;
      Nap = nap;
    }

    public override string ToString()
    {
      return $"{nap}.nap:\t+{elkeszitett}\t-{eladott}";
    }
  }
}
