namespace DemoWebhallenLambda
{
    partial class FormSearch
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
            buttonLambda = new Button();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            minprisTxt = new TextBox();
            maxprisTxt = new TextBox();
            SuspendLayout();
            // 
            // buttonLambda
            // 
            buttonLambda.Location = new Point(451, 29);
            buttonLambda.Margin = new Padding(2, 2, 2, 2);
            buttonLambda.Name = "buttonLambda";
            buttonLambda.Size = new Size(166, 79);
            buttonLambda.TabIndex = 0;
            buttonLambda.Text = "Sök";
            buttonLambda.UseVisualStyleBackColor = true;
            buttonLambda.Click += buttonLambda_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(192, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 27);
            textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 54);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(174, 28);
            comboBox1.TabIndex = 2;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(28, 166);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(589, 184);
            listBox1.TabIndex = 3;
            // 
            // minprisTxt
            // 
            minprisTxt.Location = new Point(39, 123);
            minprisTxt.Name = "minprisTxt";
            minprisTxt.Size = new Size(125, 27);
            minprisTxt.TabIndex = 4;
            minprisTxt.Text = "0";
            // 
            // maxprisTxt
            // 
            maxprisTxt.Location = new Point(192, 123);
            maxprisTxt.Name = "maxprisTxt";
            maxprisTxt.Size = new Size(125, 27);
            maxprisTxt.TabIndex = 5;
            maxprisTxt.Text = "10000";
            // 
            // FormSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(maxprisTxt);
            Controls.Add(minprisTxt);
            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(buttonLambda);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormSearch";
            Text = "Webhallen sök produkter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLambda;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private TextBox minprisTxt;
        private TextBox maxprisTxt;
    }
}
