namespace karacsonyGUI
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.cbNap = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnHozzaad = new System.Windows.Forms.Button();
      this.lbAdat = new System.Windows.Forms.ListBox();
      this.tbElkeszitett = new System.Windows.Forms.TextBox();
      this.tbEladott = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.lblHiba = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // cbNap
      // 
      this.cbNap.FormattingEnabled = true;
      this.cbNap.Location = new System.Drawing.Point(5, 39);
      this.cbNap.Name = "cbNap";
      this.cbNap.Size = new System.Drawing.Size(93, 28);
      this.cbNap.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(5, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(93, 20);
      this.label1.TabIndex = 1;
      this.label1.Text = "Nap száma:";
      // 
      // btnHozzaad
      // 
      this.btnHozzaad.Location = new System.Drawing.Point(417, 36);
      this.btnHozzaad.Name = "btnHozzaad";
      this.btnHozzaad.Size = new System.Drawing.Size(102, 29);
      this.btnHozzaad.TabIndex = 2;
      this.btnHozzaad.Text = "Hozzáad";
      this.btnHozzaad.UseVisualStyleBackColor = true;
      this.btnHozzaad.Click += new System.EventHandler(this.btnHozzaad_Click);
      // 
      // lbAdat
      // 
      this.lbAdat.FormattingEnabled = true;
      this.lbAdat.ItemHeight = 20;
      this.lbAdat.Location = new System.Drawing.Point(5, 127);
      this.lbAdat.Name = "lbAdat";
      this.lbAdat.Size = new System.Drawing.Size(514, 284);
      this.lbAdat.TabIndex = 3;
      // 
      // tbElkeszitett
      // 
      this.tbElkeszitett.Location = new System.Drawing.Point(141, 39);
      this.tbElkeszitett.Name = "tbElkeszitett";
      this.tbElkeszitett.Size = new System.Drawing.Size(100, 26);
      this.tbElkeszitett.TabIndex = 4;
      // 
      // tbEladott
      // 
      this.tbEladott.Location = new System.Drawing.Point(275, 39);
      this.tbEladott.Name = "tbEladott";
      this.tbEladott.Size = new System.Drawing.Size(100, 26);
      this.tbEladott.TabIndex = 4;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(137, 16);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(87, 20);
      this.label2.TabIndex = 1;
      this.label2.Text = "Elkészített:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(271, 16);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(64, 20);
      this.label3.TabIndex = 1;
      this.label3.Text = "Eladott:";
      // 
      // lblHiba
      // 
      this.lblHiba.AutoSize = true;
      this.lblHiba.ForeColor = System.Drawing.Color.Red;
      this.lblHiba.Location = new System.Drawing.Point(137, 91);
      this.lblHiba.Name = "lblHiba";
      this.lblHiba.Size = new System.Drawing.Size(64, 20);
      this.lblHiba.TabIndex = 1;
      this.lblHiba.Text = "Eladott:";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(526, 421);
      this.Controls.Add(this.tbEladott);
      this.Controls.Add(this.tbElkeszitett);
      this.Controls.Add(this.lbAdat);
      this.Controls.Add(this.btnHozzaad);
      this.Controls.Add(this.lblHiba);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cbNap);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Angyalka";
      this.Shown += new System.EventHandler(this.Form1_Shown);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox cbNap;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnHozzaad;
    private System.Windows.Forms.ListBox lbAdat;
    private System.Windows.Forms.TextBox tbElkeszitett;
    private System.Windows.Forms.TextBox tbEladott;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label lblHiba;
  }
}

