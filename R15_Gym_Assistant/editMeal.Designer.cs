namespace R15_Gym_Assistant
{
    partial class editMeal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editMeal));
            this.textKolProteina = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.textObrok = new System.Windows.Forms.TextBox();
            this.labelKolProteina = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelObrok = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textKolProteina
            // 
            this.textKolProteina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textKolProteina.Location = new System.Drawing.Point(227, 312);
            this.textKolProteina.Name = "textKolProteina";
            this.textKolProteina.Size = new System.Drawing.Size(148, 26);
            this.textKolProteina.TabIndex = 42;
            // 
            // textID
            // 
            this.textID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textID.Location = new System.Drawing.Point(227, 157);
            this.textID.MaxLength = 25;
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(148, 26);
            this.textID.TabIndex = 40;
            // 
            // textObrok
            // 
            this.textObrok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textObrok.Location = new System.Drawing.Point(227, 232);
            this.textObrok.MaxLength = 25;
            this.textObrok.Name = "textObrok";
            this.textObrok.Size = new System.Drawing.Size(148, 26);
            this.textObrok.TabIndex = 41;
            // 
            // labelKolProteina
            // 
            this.labelKolProteina.AutoSize = true;
            this.labelKolProteina.BackColor = System.Drawing.Color.Transparent;
            this.labelKolProteina.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKolProteina.ForeColor = System.Drawing.Color.Yellow;
            this.labelKolProteina.Location = new System.Drawing.Point(10, 312);
            this.labelKolProteina.Name = "labelKolProteina";
            this.labelKolProteina.Size = new System.Drawing.Size(211, 28);
            this.labelKolProteina.TabIndex = 37;
            this.labelKolProteina.Text = "Količina proteina:";
            this.labelKolProteina.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(177, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 28);
            this.label1.TabIndex = 38;
            this.label1.Text = "ID:";
            // 
            // labelObrok
            // 
            this.labelObrok.AutoSize = true;
            this.labelObrok.BackColor = System.Drawing.Color.Transparent;
            this.labelObrok.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObrok.ForeColor = System.Drawing.Color.Yellow;
            this.labelObrok.Location = new System.Drawing.Point(132, 228);
            this.labelObrok.Name = "labelObrok";
            this.labelObrok.Size = new System.Drawing.Size(89, 28);
            this.labelObrok.TabIndex = 39;
            this.labelObrok.Text = "Obrok:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonDelete.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.ForeColor = System.Drawing.Color.Yellow;
            this.buttonDelete.Location = new System.Drawing.Point(253, 358);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(126, 41);
            this.buttonDelete.TabIndex = 43;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonUpdate.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.buttonUpdate.ForeColor = System.Drawing.Color.Yellow;
            this.buttonUpdate.Location = new System.Drawing.Point(395, 358);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(126, 41);
            this.buttonUpdate.TabIndex = 44;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(395, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(377, 185);
            this.dataGridView1.TabIndex = 45;
            // 
            // editMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textKolProteina);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textObrok);
            this.Controls.Add(this.labelKolProteina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelObrok);
            this.Name = "editMeal";
            this.Text = "Edit Meal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textKolProteina;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textObrok;
        private System.Windows.Forms.Label labelKolProteina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelObrok;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}