namespace Mostrador_de_Tabuada
{
    partial class tabuadaForm
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
            label1 = new Label();
            TabuadaDesejadatextBox = new TextBox();
            EnviarButton = new Button();
            TabuadalistBox = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 35);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 0;
            label1.Text = "Digite a tabuada desejada";
            // 
            // TabuadaDesejadatextBox
            // 
            TabuadaDesejadatextBox.Location = new Point(176, 32);
            TabuadaDesejadatextBox.Name = "TabuadaDesejadatextBox";
            TabuadaDesejadatextBox.Size = new Size(33, 23);
            TabuadaDesejadatextBox.TabIndex = 1;
            // 
            // EnviarButton
            // 
            EnviarButton.Location = new Point(231, 32);
            EnviarButton.Name = "EnviarButton";
            EnviarButton.Size = new Size(62, 23);
            EnviarButton.TabIndex = 3;
            EnviarButton.Text = "Enviar";
            EnviarButton.UseVisualStyleBackColor = true;
            EnviarButton.Click += EnviarButton_Click;
            // 
            // TabuadalistBox
            // 
            TabuadalistBox.FormattingEnabled = true;
            TabuadalistBox.ItemHeight = 15;
            TabuadalistBox.Location = new Point(28, 89);
            TabuadalistBox.Name = "TabuadalistBox";
            TabuadalistBox.Size = new Size(213, 214);
            TabuadalistBox.TabIndex = 4;
            // 
            // tabuadaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(337, 360);
            Controls.Add(TabuadalistBox);
            Controls.Add(EnviarButton);
            Controls.Add(TabuadaDesejadatextBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "tabuadaForm";
            Text = "Tabuada";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TabuadaDesejadatextBox;
        private Button EnviarButton;
        private ListBox TabuadalistBox;
    }
}
