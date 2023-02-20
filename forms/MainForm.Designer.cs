namespace Roulette
{
    partial class MainForm
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
            this.panelTable = new System.Windows.Forms.Panel();
            this.rtbEvents = new System.Windows.Forms.RichTextBox();
            this.nudStake = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblZsetonok = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnSpin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudStake)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTable
            // 
            this.panelTable.BackColor = System.Drawing.SystemColors.Control;
            this.panelTable.Location = new System.Drawing.Point(13, 12);
            this.panelTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTable.Name = "panelTable";
            this.panelTable.Size = new System.Drawing.Size(250, 390);
            this.panelTable.TabIndex = 0;
            // 
            // rtbEvents
            // 
            this.rtbEvents.BackColor = System.Drawing.Color.White;
            this.rtbEvents.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbEvents.Location = new System.Drawing.Point(269, 64);
            this.rtbEvents.Name = "rtbEvents";
            this.rtbEvents.ReadOnly = true;
            this.rtbEvents.Size = new System.Drawing.Size(313, 339);
            this.rtbEvents.TabIndex = 1;
            this.rtbEvents.Text = "";
            // 
            // nudStake
            // 
            this.nudStake.Location = new System.Drawing.Point(300, 35);
            this.nudStake.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudStake.Name = "nudStake";
            this.nudStake.Size = new System.Drawing.Size(120, 23);
            this.nudStake.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Zsetonok:";
            // 
            // lblZsetonok
            // 
            this.lblZsetonok.AutoSize = true;
            this.lblZsetonok.Location = new System.Drawing.Point(334, 12);
            this.lblZsetonok.Name = "lblZsetonok";
            this.lblZsetonok.Size = new System.Drawing.Size(31, 15);
            this.lblZsetonok.TabIndex = 5;
            this.lblZsetonok.Text = "1000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tét:";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(503, 12);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(79, 46);
            this.btnNewGame.TabIndex = 7;
            this.btnNewGame.Text = "Új játék";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.OnBtnNewGameClick);
            // 
            // btnSpin
            // 
            this.btnSpin.Location = new System.Drawing.Point(426, 12);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(71, 46);
            this.btnSpin.TabIndex = 8;
            this.btnSpin.Text = "Pörgetés";
            this.btnSpin.UseVisualStyleBackColor = true;
            this.btnSpin.Click += new System.EventHandler(this.OnBtnSpinClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 415);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblZsetonok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudStake);
            this.Controls.Add(this.rtbEvents);
            this.Controls.Add(this.panelTable);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Roulette";
            this.Load += new System.EventHandler(this.OnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.nudStake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public RichTextBox rtbEvents;
        private Label label1;
        private Label label2;
        private Button btnNewGame;
        public Label lblZsetonok;
        public NumericUpDown nudStake;
        private Button btnSpin;
        public Panel panelTable;
    }
}