namespace SMFPlay
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonPanic = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCOM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownTempo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTempo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "SMF(Standard MIDI FIle) Player for USB-PSG";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(14, 64);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "LoadMIDI";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(95, 66);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.ReadOnly = true;
            this.textBoxFileName.Size = new System.Drawing.Size(373, 19);
            this.textBoxFileName.TabIndex = 2;
            this.textBoxFileName.Text = "(No File Loaded !! )";
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(95, 121);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 23);
            this.buttonPlay.TabIndex = 3;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonPanic
            // 
            this.buttonPanic.Location = new System.Drawing.Point(176, 121);
            this.buttonPanic.Name = "buttonPanic";
            this.buttonPanic.Size = new System.Drawing.Size(75, 23);
            this.buttonPanic.TabIndex = 4;
            this.buttonPanic.Text = "Panic";
            this.buttonPanic.UseVisualStyleBackColor = true;
            this.buttonPanic.Click += new System.EventHandler(this.buttonPanic_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "COM PORT:";
            // 
            // textBoxCOM
            // 
            this.textBoxCOM.Location = new System.Drawing.Point(95, 36);
            this.textBoxCOM.Name = "textBoxCOM";
            this.textBoxCOM.Size = new System.Drawing.Size(59, 19);
            this.textBoxCOM.TabIndex = 6;
            this.textBoxCOM.Text = "COM6";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tempo Adjust";
            // 
            // numericUpDownTempo
            // 
            this.numericUpDownTempo.DecimalPlaces = 1;
            this.numericUpDownTempo.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownTempo.Location = new System.Drawing.Point(176, 94);
            this.numericUpDownTempo.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownTempo.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.numericUpDownTempo.Name = "numericUpDownTempo";
            this.numericUpDownTempo.Size = new System.Drawing.Size(51, 19);
            this.numericUpDownTempo.TabIndex = 8;
            this.numericUpDownTempo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 380);
            this.Controls.Add(this.numericUpDownTempo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCOM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonPanic);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SMF(Standard MIDI File) Player";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTempo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonPanic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCOM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownTempo;
    }
}

