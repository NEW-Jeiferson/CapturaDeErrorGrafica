namespace CapturaDeErrorGrafica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LBLResultado = new Label();
            TXTnumero = new TextBox();
            BTNProcesar = new Button();
            SuspendLayout();
            // 
            // LBLResultado
            // 
            LBLResultado.AutoSize = true;
            LBLResultado.Location = new Point(355, 78);
            LBLResultado.Name = "LBLResultado";
            LBLResultado.Size = new Size(103, 15);
            LBLResultado.TabIndex = 0;
            LBLResultado.Text = "Digite Un Numero";
            // 
            // TXTnumero
            // 
            TXTnumero.Location = new Point(355, 113);
            TXTnumero.Name = "TXTnumero";
            TXTnumero.Size = new Size(100, 23);
            TXTnumero.TabIndex = 1;
            // 
            // BTNProcesar
            // 
            BTNProcesar.Location = new Point(365, 159);
            BTNProcesar.Name = "BTNProcesar";
            BTNProcesar.Size = new Size(75, 23);
            BTNProcesar.TabIndex = 2;
            BTNProcesar.Text = "Procesar";
            BTNProcesar.UseVisualStyleBackColor = true;
            BTNProcesar.Click += BTNProcesar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTNProcesar);
            Controls.Add(TXTnumero);
            Controls.Add(LBLResultado);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBLResultado;
        private TextBox TXTnumero;
        private Button BTNProcesar;
    }
}
