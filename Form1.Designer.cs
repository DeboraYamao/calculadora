namespace tds
{
    partial class Form
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.lblfrase = new System.Windows.Forms.Label();
            this.lblmostra = new System.Windows.Forms.Label();
            this.txtfrase = new System.Windows.Forms.TextBox();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.btncalculadora = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblfrase
            // 
            resources.ApplyResources(this.lblfrase, "lblfrase");
            this.lblfrase.Name = "lblfrase";
            // 
            // lblmostra
            // 
            resources.ApplyResources(this.lblmostra, "lblmostra");
            this.lblmostra.Name = "lblmostra";
            // 
            // txtfrase
            // 
            resources.ApplyResources(this.txtfrase, "txtfrase");
            this.txtfrase.Name = "txtfrase";
            // 
            // btnmostrar
            // 
            resources.ApplyResources(this.btnmostrar, "btnmostrar");
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // btncalculadora
            // 
            resources.ApplyResources(this.btncalculadora, "btncalculadora");
            this.btncalculadora.Name = "btncalculadora";
            this.btncalculadora.UseVisualStyleBackColor = true;
            this.btncalculadora.Click += new System.EventHandler(this.btncalculadora_Click);
            // 
            // Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.btncalculadora);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.txtfrase);
            this.Controls.Add(this.lblmostra);
            this.Controls.Add(this.lblfrase);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfrase;
        private System.Windows.Forms.Label lblmostra;
        private System.Windows.Forms.TextBox txtfrase;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.Button btncalculadora;
    }
}

