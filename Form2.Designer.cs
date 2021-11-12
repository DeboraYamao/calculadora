namespace tds
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.txtvalora = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtvalorb = new System.Windows.Forms.TextBox();
            this.btnsomar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnsubtrair = new System.Windows.Forms.Button();
            this.btnmultiplicar = new System.Windows.Forms.Button();
            this.btndividir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtvalora
            // 
            resources.ApplyResources(this.txtvalora, "txtvalora");
            this.txtvalora.Name = "txtvalora";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtvalorb
            // 
            resources.ApplyResources(this.txtvalorb, "txtvalorb");
            this.txtvalorb.Name = "txtvalorb";
            // 
            // btnsomar
            // 
            resources.ApplyResources(this.btnsomar, "btnsomar");
            this.btnsomar.Name = "btnsomar";
            this.btnsomar.UseVisualStyleBackColor = true;
            this.btnsomar.Click += new System.EventHandler(this.btnsomar_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // lblResultado
            // 
            resources.ApplyResources(this.lblResultado, "lblResultado");
            this.lblResultado.Name = "lblResultado";
            // 
            // btnsubtrair
            // 
            resources.ApplyResources(this.btnsubtrair, "btnsubtrair");
            this.btnsubtrair.Name = "btnsubtrair";
            this.btnsubtrair.UseVisualStyleBackColor = true;
            this.btnsubtrair.Click += new System.EventHandler(this.btnsubtrair_Click);
            // 
            // btnmultiplicar
            // 
            resources.ApplyResources(this.btnmultiplicar, "btnmultiplicar");
            this.btnmultiplicar.Name = "btnmultiplicar";
            this.btnmultiplicar.UseVisualStyleBackColor = true;
            this.btnmultiplicar.Click += new System.EventHandler(this.btnmultiplicar_Click);
            // 
            // btndividir
            // 
            resources.ApplyResources(this.btndividir, "btndividir");
            this.btndividir.Name = "btndividir";
            this.btndividir.UseVisualStyleBackColor = true;
            this.btndividir.Click += new System.EventHandler(this.btndividir_Click);
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btndividir);
            this.Controls.Add(this.btnmultiplicar);
            this.Controls.Add(this.btnsubtrair);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnsomar);
            this.Controls.Add(this.txtvalorb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtvalora);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtvalora, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtvalorb, 0);
            this.Controls.SetChildIndex(this.btnsomar, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblResultado, 0);
            this.Controls.SetChildIndex(this.btnsubtrair, 0);
            this.Controls.SetChildIndex(this.btnmultiplicar, 0);
            this.Controls.SetChildIndex(this.btndividir, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtvalora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtvalorb;
        private System.Windows.Forms.Button btnsomar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnsubtrair;
        private System.Windows.Forms.Button btnmultiplicar;
        private System.Windows.Forms.Button btndividir;
    }
}