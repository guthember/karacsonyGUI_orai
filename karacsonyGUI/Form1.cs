using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace karacsonyGUI
{
  public partial class Form1 : Form
  {
    List<int> napok = new List<int>();
    Keszlet keszlet = new Keszlet();
    public Form1()
    {
      InitializeComponent();
      NapokFeltoltese();

    }

    private void NapokFeltoltese()
    {
      for (int i = 1; i <= 40; i++)
      {
        napok.Add(i);
      }
    }
    private void NapokComboBox()
    {
      cbNap.Items.Clear();
      foreach (var n in napok)
      {
        cbNap.Items.Add(n.ToString());
      }
    }

    private void Form1_Shown(object sender, EventArgs e)
    {
      NapokComboBox();
      Nullazas();
      cbNap.SelectedIndex = 0;
      tbElkeszitett.Focus();
    }

    private void Nullazas()
    {
      tbEladott.Text = "0";
      tbElkeszitett.Text = "0";
      lblHiba.Text = "";
    }

    private void btnHozzaad_Click(object sender, EventArgs e)
    {
      int eladott = Convert.ToInt32(tbEladott.Text);
      int kesziett = Convert.ToInt32(tbElkeszitett.Text);
      int nap = napok[cbNap.SelectedIndex];

      if (NegativErtek(eladott, kesziett))
      {
        lblHiba.Text = "Negatív számot nem adhat meg!";
      }
      else if (Keszlethiany(eladott, kesziett))
      {
        lblHiba.Text = "Túl sok az eladott angyalka!";
      }
      else
      {
        Angyalka angyal = new Angyalka(kesziett, eladott, nap);
        keszlet.AngyalHozzaad(angyal);
        string sor = angyal.ToString() + $"\t=\t{keszlet.KeszletDb}";
        lbAdat.Items.Add(sor);
        tbElkeszitett.Focus();
        Nullazas();
        NapokEltuntetese(cbNap.SelectedIndex);
      }
    }

    private void NapokEltuntetese(int nap)
    {
      napok.RemoveRange(0, nap + 1);
      NapokComboBox();
      cbNap.SelectedIndex = 0;
    }

    private bool Keszlethiany(int eladott, int kesziett)
    {
      return keszlet.KeszletDb + kesziett < eladott;
    }

    private static bool NegativErtek(int eladott, int kesziett)
    {
      return eladott < 0 || kesziett < 0;
    }
  }
}
