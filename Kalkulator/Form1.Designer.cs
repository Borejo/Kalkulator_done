
using System;
using System.Windows.Forms;

namespace Kalkulator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Wynik = new System.Windows.Forms.TextBox();
            this.Dodawanie = new System.Windows.Forms.RadioButton();
            this.Odejmowaie = new System.Windows.Forms.RadioButton();
            this.Mnozenie = new System.Windows.Forms.RadioButton();
            this.Dzielenie = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.INT = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(23, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.groupBox1_PreviewKeyDown);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(197, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 31);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.groupBox1_PreviewKeyDown);
            // 
            // Wynik
            // 
            this.Wynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wynik.Location = new System.Drawing.Point(327, 58);
            this.Wynik.Name = "Wynik";
            this.Wynik.ReadOnly = true;
            this.Wynik.Size = new System.Drawing.Size(100, 31);
            this.Wynik.TabIndex = 3;
            this.Wynik.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.groupBox1_PreviewKeyDown);
            // 
            // Dodawanie
            // 
            this.Dodawanie.AutoSize = true;
            this.Dodawanie.Checked = true;
            this.Dodawanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dodawanie.Location = new System.Drawing.Point(20, 19);
            this.Dodawanie.Name = "Dodawanie";
            this.Dodawanie.Size = new System.Drawing.Size(36, 24);
            this.Dodawanie.TabIndex = 4;
            this.Dodawanie.TabStop = true;
            this.Dodawanie.Text = "+";
            this.Dodawanie.UseVisualStyleBackColor = true;
            this.Dodawanie.CheckedChanged += new System.EventHandler(this.Dodawanie_CheckedChanged);
            this.Dodawanie.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dzielenie_KeyDown);
            // 
            // Odejmowaie
            // 
            this.Odejmowaie.AutoSize = true;
            this.Odejmowaie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Odejmowaie.Location = new System.Drawing.Point(20, 42);
            this.Odejmowaie.Name = "Odejmowaie";
            this.Odejmowaie.Size = new System.Drawing.Size(32, 24);
            this.Odejmowaie.TabIndex = 5;
            this.Odejmowaie.Text = "-";
            this.Odejmowaie.UseVisualStyleBackColor = true;
            this.Odejmowaie.CheckedChanged += new System.EventHandler(this.Odejmowaie_CheckedChanged);
            this.Odejmowaie.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dzielenie_KeyDown);
            // 
            // Mnozenie
            // 
            this.Mnozenie.AutoSize = true;
            this.Mnozenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Mnozenie.Location = new System.Drawing.Point(20, 65);
            this.Mnozenie.Name = "Mnozenie";
            this.Mnozenie.Size = new System.Drawing.Size(33, 24);
            this.Mnozenie.TabIndex = 6;
            this.Mnozenie.Text = "*";
            this.Mnozenie.UseVisualStyleBackColor = true;
            this.Mnozenie.CheckedChanged += new System.EventHandler(this.Mnozenie_CheckedChanged);
            this.Mnozenie.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dzielenie_KeyDown);
            // 
            // Dzielenie
            // 
            this.Dzielenie.AutoSize = true;
            this.Dzielenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dzielenie.Location = new System.Drawing.Point(20, 88);
            this.Dzielenie.Name = "Dzielenie";
            this.Dzielenie.Size = new System.Drawing.Size(31, 24);
            this.Dzielenie.TabIndex = 7;
            this.Dzielenie.Text = "/";
            this.Dzielenie.UseVisualStyleBackColor = true;
            this.Dzielenie.CheckedChanged += new System.EventHandler(this.Dzielenie_CheckedChanged);
            this.Dzielenie.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dzielenie_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(303, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "=";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.groupBox1_PreviewKeyDown);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(327, 140);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(100, 38);
            this.OK.TabIndex = 9;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            this.OK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OK_KeyDown);
            this.OK.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.groupBox1_PreviewKeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dzielenie);
            this.groupBox1.Controls.Add(this.Mnozenie);
            this.groupBox1.Controls.Add(this.Odejmowaie);
            this.groupBox1.Controls.Add(this.Dodawanie);
            this.groupBox1.Location = new System.Drawing.Point(129, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(62, 119);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actions";
            this.groupBox1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.groupBox1_PreviewKeyDown);
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // INT
            // 
            this.INT.AutoSize = true;
            this.INT.Location = new System.Drawing.Point(23, 161);
            this.INT.Name = "INT";
            this.INT.Size = new System.Drawing.Size(119, 17);
            this.INT.TabIndex = 11;
            this.INT.Text = "Dzielenie całkowite";
            this.INT.UseVisualStyleBackColor = true;
            this.INT.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 218);
            this.Controls.Add(this.INT);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Wynik);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Kalkulator GCK";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void groupBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
                if (e.KeyCode == Keys.Enter)
                {
                    OK_Click(this, new EventArgs());
                }
            
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox Wynik;
        private System.Windows.Forms.RadioButton Dodawanie;
        private System.Windows.Forms.RadioButton Odejmowaie;
        private System.Windows.Forms.RadioButton Mnozenie;
        private System.Windows.Forms.RadioButton Dzielenie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.GroupBox groupBox1;
        private ErrorProvider error1;
        private CheckBox INT;
    }
}

