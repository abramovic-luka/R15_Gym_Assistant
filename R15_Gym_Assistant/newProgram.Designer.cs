namespace R15_Gym_Assistant
{
    partial class newProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newProgram));
            this.textTjedno = new System.Windows.Forms.TextBox();
            this.textNaziv = new System.Windows.Forms.TextBox();
            this.labelTjedno = new System.Windows.Forms.Label();
            this.labelNaziv = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textTjedno
            // 
            this.textTjedno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textTjedno.Location = new System.Drawing.Point(243, 290);
            this.textTjedno.Name = "textTjedno";
            this.textTjedno.Size = new System.Drawing.Size(148, 26);
            this.textTjedno.TabIndex = 13;
            // 
            // textNaziv
            // 
            this.textNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textNaziv.Location = new System.Drawing.Point(243, 223);
            this.textNaziv.MaxLength = 25;
            this.textNaziv.Name = "textNaziv";
            this.textNaziv.Size = new System.Drawing.Size(148, 26);
            this.textNaziv.TabIndex = 12;
            // 
            // labelTjedno
            // 
            this.labelTjedno.AutoSize = true;
            this.labelTjedno.BackColor = System.Drawing.Color.Transparent;
            this.labelTjedno.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTjedno.ForeColor = System.Drawing.Color.Yellow;
            this.labelTjedno.Location = new System.Drawing.Point(14, 286);
            this.labelTjedno.Name = "labelTjedno";
            this.labelTjedno.Size = new System.Drawing.Size(223, 28);
            this.labelTjedno.TabIndex = 8;
            this.labelTjedno.Text = "Koliko puta tjedno:";
            // 
            // labelNaziv
            // 
            this.labelNaziv.AutoSize = true;
            this.labelNaziv.BackColor = System.Drawing.Color.Transparent;
            this.labelNaziv.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNaziv.ForeColor = System.Drawing.Color.Yellow;
            this.labelNaziv.Location = new System.Drawing.Point(158, 219);
            this.labelNaziv.Name = "labelNaziv";
            this.labelNaziv.Size = new System.Drawing.Size(79, 28);
            this.labelNaziv.TabIndex = 10;
            this.labelNaziv.Text = "Naziv:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(397, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 41);
            this.button1.TabIndex = 14;
            this.button1.Text = "SAVE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(397, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(375, 211);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(193, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID:";
            // 
            // textID
            // 
            this.textID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textID.Location = new System.Drawing.Point(243, 156);
            this.textID.MaxLength = 25;
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(148, 26);
            this.textID.TabIndex = 12;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonDelete.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.ForeColor = System.Drawing.Color.Yellow;
            this.buttonDelete.Location = new System.Drawing.Point(272, 358);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(119, 41);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // newProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textTjedno);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textNaziv);
            this.Controls.Add(this.labelTjedno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNaziv);
            this.Name = "newProgram";
            this.Text = "New Program";
            this.Load += new System.EventHandler(this.newProgram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textTjedno;
        private System.Windows.Forms.TextBox textNaziv;
        private System.Windows.Forms.Label labelTjedno;
        private System.Windows.Forms.Label labelNaziv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Button buttonDelete;
    }
}