namespace R15_Gym_Assistant
{
    partial class new_program
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(new_program));
            this.buttonMeal = new System.Windows.Forms.Button();
            this.buttonTraining = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMeal
            // 
            this.buttonMeal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMeal.BackgroundImage")));
            this.buttonMeal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMeal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonMeal.Location = new System.Drawing.Point(399, 159);
            this.buttonMeal.Name = "buttonMeal";
            this.buttonMeal.Size = new System.Drawing.Size(177, 240);
            this.buttonMeal.TabIndex = 1;
            this.buttonMeal.UseVisualStyleBackColor = true;
            this.buttonMeal.Click += new System.EventHandler(this.buttonMeal_Click);
            // 
            // buttonTraining
            // 
            this.buttonTraining.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonTraining.BackgroundImage")));
            this.buttonTraining.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTraining.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonTraining.Location = new System.Drawing.Point(216, 159);
            this.buttonTraining.Name = "buttonTraining";
            this.buttonTraining.Size = new System.Drawing.Size(177, 240);
            this.buttonTraining.TabIndex = 2;
            this.buttonTraining.UseVisualStyleBackColor = true;
            this.buttonTraining.Click += new System.EventHandler(this.buttonTraining_Click);
            // 
            // new_program
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.buttonMeal);
            this.Controls.Add(this.buttonTraining);
            this.Name = "new_program";
            this.Text = "New Program";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMeal;
        private System.Windows.Forms.Button buttonTraining;
    }
}