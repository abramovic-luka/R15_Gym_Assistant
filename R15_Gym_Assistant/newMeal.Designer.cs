namespace R15_Gym_Assistant
{
    partial class newMeal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newMeal));
            this.buttonSave = new System.Windows.Forms.Button();
            this.textKolProteina = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.textObrok = new System.Windows.Forms.TextBox();
            this.labelKolProteina = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelObrok = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonSave.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.buttonSave.ForeColor = System.Drawing.Color.Yellow;
            this.buttonSave.Location = new System.Drawing.Point(323, 358);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(126, 41);
            this.buttonSave.TabIndex = 36;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textKolProteina
            // 
            this.textKolProteina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textKolProteina.Location = new System.Drawing.Point(227, 301);
            this.textKolProteina.Name = "textKolProteina";
            this.textKolProteina.Size = new System.Drawing.Size(148, 26);
            this.textKolProteina.TabIndex = 35;
            // 
            // textID
            // 
            this.textID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textID.Location = new System.Drawing.Point(227, 146);
            this.textID.MaxLength = 25;
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(148, 26);
            this.textID.TabIndex = 33;
            // 
            // textObrok
            // 
            this.textObrok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textObrok.Location = new System.Drawing.Point(227, 221);
            this.textObrok.MaxLength = 25;
            this.textObrok.Name = "textObrok";
            this.textObrok.Size = new System.Drawing.Size(148, 26);
            this.textObrok.TabIndex = 34;
            // 
            // labelKolProteina
            // 
            this.labelKolProteina.AutoSize = true;
            this.labelKolProteina.BackColor = System.Drawing.Color.Transparent;
            this.labelKolProteina.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKolProteina.ForeColor = System.Drawing.Color.Yellow;
            this.labelKolProteina.Location = new System.Drawing.Point(10, 301);
            this.labelKolProteina.Name = "labelKolProteina";
            this.labelKolProteina.Size = new System.Drawing.Size(211, 28);
            this.labelKolProteina.TabIndex = 24;
            this.labelKolProteina.Text = "Količina proteina:";
            this.labelKolProteina.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(177, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 28);
            this.label1.TabIndex = 28;
            this.label1.Text = "ID:";
            // 
            // labelObrok
            // 
            this.labelObrok.AutoSize = true;
            this.labelObrok.BackColor = System.Drawing.Color.Transparent;
            this.labelObrok.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObrok.ForeColor = System.Drawing.Color.Yellow;
            this.labelObrok.Location = new System.Drawing.Point(132, 217);
            this.labelObrok.Name = "labelObrok";
            this.labelObrok.Size = new System.Drawing.Size(89, 28);
            this.labelObrok.TabIndex = 29;
            this.labelObrok.Text = "Obrok:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(395, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(377, 195);
            this.dataGridView1.TabIndex = 23;
            // 
            // newMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textKolProteina);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textObrok);
            this.Controls.Add(this.labelKolProteina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelObrok);
            this.Controls.Add(this.dataGridView1);
            this.Name = "newMeal";
            this.Text = "New Meal";
            this.Load += new System.EventHandler(this.newMeal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textKolProteina;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textObrok;
        private System.Windows.Forms.Label labelKolProteina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelObrok;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}