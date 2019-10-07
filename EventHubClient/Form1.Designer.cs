namespace EventHubClient
{
    partial class FormEventHubClient
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
            this.components = new System.ComponentModel.Container();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxParameters = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSASKey = new System.Windows.Forms.TextBox();
            this.labelSASKeyName = new System.Windows.Forms.Label();
            this.textBoxSASKeyName = new System.Windows.Forms.TextBox();
            this.labelPublisher = new System.Windows.Forms.Label();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.labelEventHub = new System.Windows.Forms.Label();
            this.textBoxEventHub = new System.Windows.Forms.TextBox();
            this.labelNamespace = new System.Windows.Forms.Label();
            this.textBoxNamespace = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelSASToken = new System.Windows.Forms.Label();
            this.textBoxSASToken = new System.Windows.Forms.TextBox();
            this.labelURL = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.groupBoxDataParams = new System.Windows.Forms.GroupBox();
            this.labelInterval = new System.Windows.Forms.Label();
            this.numericUpDownTimerInterval = new System.Windows.Forms.NumericUpDown();
            this.labelMaximum = new System.Windows.Forms.Label();
            this.labelMinimum = new System.Windows.Forms.Label();
            this.numericUpDownRangeMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRangeMin = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxParameters.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxDataParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimerInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRangeMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRangeMin)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(833, 66);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(84, 29);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(833, 107);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(84, 29);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // groupBoxParameters
            // 
            this.groupBoxParameters.Controls.Add(this.label1);
            this.groupBoxParameters.Controls.Add(this.textBoxSASKey);
            this.groupBoxParameters.Controls.Add(this.labelSASKeyName);
            this.groupBoxParameters.Controls.Add(this.textBoxSASKeyName);
            this.groupBoxParameters.Controls.Add(this.labelPublisher);
            this.groupBoxParameters.Controls.Add(this.textBoxPublisher);
            this.groupBoxParameters.Controls.Add(this.labelEventHub);
            this.groupBoxParameters.Controls.Add(this.textBoxEventHub);
            this.groupBoxParameters.Controls.Add(this.labelNamespace);
            this.groupBoxParameters.Controls.Add(this.textBoxNamespace);
            this.groupBoxParameters.Location = new System.Drawing.Point(12, 12);
            this.groupBoxParameters.Name = "groupBoxParameters";
            this.groupBoxParameters.Size = new System.Drawing.Size(515, 208);
            this.groupBoxParameters.TabIndex = 24;
            this.groupBoxParameters.TabStop = false;
            this.groupBoxParameters.Text = "Event Hub Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "SAS Key";
            // 
            // textBoxSASKey
            // 
            this.textBoxSASKey.Location = new System.Drawing.Point(14, 166);
            this.textBoxSASKey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSASKey.Name = "textBoxSASKey";
            this.textBoxSASKey.Size = new System.Drawing.Size(364, 26);
            this.textBoxSASKey.TabIndex = 32;
            // 
            // labelSASKeyName
            // 
            this.labelSASKeyName.AutoSize = true;
            this.labelSASKeyName.Location = new System.Drawing.Point(386, 135);
            this.labelSASKeyName.Name = "labelSASKeyName";
            this.labelSASKeyName.Size = new System.Drawing.Size(118, 20);
            this.labelSASKeyName.TabIndex = 31;
            this.labelSASKeyName.Text = "SAS Key Name";
            // 
            // textBoxSASKeyName
            // 
            this.textBoxSASKeyName.Location = new System.Drawing.Point(13, 131);
            this.textBoxSASKeyName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSASKeyName.Name = "textBoxSASKeyName";
            this.textBoxSASKeyName.Size = new System.Drawing.Size(364, 26);
            this.textBoxSASKeyName.TabIndex = 30;
            // 
            // labelPublisher
            // 
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Location = new System.Drawing.Point(386, 100);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(74, 20);
            this.labelPublisher.TabIndex = 29;
            this.labelPublisher.Text = "Publisher";
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.Location = new System.Drawing.Point(13, 96);
            this.textBoxPublisher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.Size = new System.Drawing.Size(364, 26);
            this.textBoxPublisher.TabIndex = 28;
            // 
            // labelEventHub
            // 
            this.labelEventHub.AutoSize = true;
            this.labelEventHub.Location = new System.Drawing.Point(388, 65);
            this.labelEventHub.Name = "labelEventHub";
            this.labelEventHub.Size = new System.Drawing.Size(84, 20);
            this.labelEventHub.TabIndex = 27;
            this.labelEventHub.Text = "Event Hub";
            // 
            // textBoxEventHub
            // 
            this.textBoxEventHub.Location = new System.Drawing.Point(14, 61);
            this.textBoxEventHub.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxEventHub.Name = "textBoxEventHub";
            this.textBoxEventHub.Size = new System.Drawing.Size(363, 26);
            this.textBoxEventHub.TabIndex = 26;
            // 
            // labelNamespace
            // 
            this.labelNamespace.AutoSize = true;
            this.labelNamespace.Location = new System.Drawing.Point(386, 30);
            this.labelNamespace.Name = "labelNamespace";
            this.labelNamespace.Size = new System.Drawing.Size(94, 20);
            this.labelNamespace.TabIndex = 25;
            this.labelNamespace.Text = "Namespace";
            // 
            // textBoxNamespace
            // 
            this.textBoxNamespace.Location = new System.Drawing.Point(13, 26);
            this.textBoxNamespace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNamespace.Name = "textBoxNamespace";
            this.textBoxNamespace.Size = new System.Drawing.Size(364, 26);
            this.textBoxNamespace.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelSASToken);
            this.groupBox1.Controls.Add(this.textBoxSASToken);
            this.groupBox1.Controls.Add(this.labelURL);
            this.groupBox1.Controls.Add(this.textBoxURL);
            this.groupBox1.Location = new System.Drawing.Point(12, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(944, 100);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculated URL and SAS Token";
            // 
            // labelSASToken
            // 
            this.labelSASToken.AutoSize = true;
            this.labelSASToken.Location = new System.Drawing.Point(752, 64);
            this.labelSASToken.Name = "labelSASToken";
            this.labelSASToken.Size = new System.Drawing.Size(169, 20);
            this.labelSASToken.TabIndex = 11;
            this.labelSASToken.Text = "Event Hub SAS Token";
            // 
            // textBoxSASToken
            // 
            this.textBoxSASToken.Location = new System.Drawing.Point(14, 61);
            this.textBoxSASToken.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSASToken.Name = "textBoxSASToken";
            this.textBoxSASToken.Size = new System.Drawing.Size(732, 26);
            this.textBoxSASToken.TabIndex = 10;
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Location = new System.Drawing.Point(752, 29);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(121, 20);
            this.labelURL.TabIndex = 9;
            this.labelURL.Text = "Event Hub URL";
            // 
            // textBoxURL
            // 
            this.textBoxURL.Enabled = false;
            this.textBoxURL.Location = new System.Drawing.Point(14, 26);
            this.textBoxURL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(732, 26);
            this.textBoxURL.TabIndex = 8;
            this.textBoxURL.Text = "https://<yournamespace>.servicebus.windows.net/<yourhub>/publishers/<deviceID>/me" +
    "ssages";
            // 
            // groupBoxDataParams
            // 
            this.groupBoxDataParams.Controls.Add(this.label2);
            this.groupBoxDataParams.Controls.Add(this.labelInterval);
            this.groupBoxDataParams.Controls.Add(this.numericUpDownTimerInterval);
            this.groupBoxDataParams.Controls.Add(this.labelMaximum);
            this.groupBoxDataParams.Controls.Add(this.labelMinimum);
            this.groupBoxDataParams.Controls.Add(this.numericUpDownRangeMax);
            this.groupBoxDataParams.Controls.Add(this.numericUpDownRangeMin);
            this.groupBoxDataParams.Location = new System.Drawing.Point(533, 12);
            this.groupBoxDataParams.Name = "groupBoxDataParams";
            this.groupBoxDataParams.Size = new System.Drawing.Size(255, 208);
            this.groupBoxDataParams.TabIndex = 26;
            this.groupBoxDataParams.TabStop = false;
            this.groupBoxDataParams.Text = "Data Parameters";
            // 
            // labelInterval
            // 
            this.labelInterval.AutoSize = true;
            this.labelInterval.Location = new System.Drawing.Point(148, 29);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(61, 20);
            this.labelInterval.TabIndex = 17;
            this.labelInterval.Text = "Interval";
            // 
            // numericUpDownTimerInterval
            // 
            this.numericUpDownTimerInterval.Location = new System.Drawing.Point(6, 26);
            this.numericUpDownTimerInterval.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownTimerInterval.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownTimerInterval.Name = "numericUpDownTimerInterval";
            this.numericUpDownTimerInterval.Size = new System.Drawing.Size(135, 26);
            this.numericUpDownTimerInterval.TabIndex = 16;
            this.numericUpDownTimerInterval.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // labelMaximum
            // 
            this.labelMaximum.AutoSize = true;
            this.labelMaximum.Location = new System.Drawing.Point(149, 120);
            this.labelMaximum.Name = "labelMaximum";
            this.labelMaximum.Size = new System.Drawing.Size(76, 20);
            this.labelMaximum.TabIndex = 15;
            this.labelMaximum.Text = "Maximum";
            // 
            // labelMinimum
            // 
            this.labelMinimum.AutoSize = true;
            this.labelMinimum.Location = new System.Drawing.Point(149, 92);
            this.labelMinimum.Name = "labelMinimum";
            this.labelMinimum.Size = new System.Drawing.Size(72, 20);
            this.labelMinimum.TabIndex = 14;
            this.labelMinimum.Text = "Minimum";
            // 
            // numericUpDownRangeMax
            // 
            this.numericUpDownRangeMax.Location = new System.Drawing.Point(7, 117);
            this.numericUpDownRangeMax.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownRangeMax.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownRangeMax.Name = "numericUpDownRangeMax";
            this.numericUpDownRangeMax.Size = new System.Drawing.Size(135, 26);
            this.numericUpDownRangeMax.TabIndex = 13;
            this.numericUpDownRangeMax.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // numericUpDownRangeMin
            // 
            this.numericUpDownRangeMin.Location = new System.Drawing.Point(7, 90);
            this.numericUpDownRangeMin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownRangeMin.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownRangeMin.Name = "numericUpDownRangeMin";
            this.numericUpDownRangeMin.Size = new System.Drawing.Size(135, 26);
            this.numericUpDownRangeMin.TabIndex = 12;
            this.numericUpDownRangeMin.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(826, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(102, 63);
            this.panel1.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Range";
            // 
            // FormEventHubClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 339);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxDataParams);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxParameters);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormEventHubClient";
            this.Text = "Event Hub Client";
            this.groupBoxParameters.ResumeLayout(false);
            this.groupBoxParameters.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxDataParams.ResumeLayout(false);
            this.groupBoxDataParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimerInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRangeMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRangeMin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBoxParameters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSASKey;
        private System.Windows.Forms.Label labelSASKeyName;
        private System.Windows.Forms.TextBox textBoxSASKeyName;
        private System.Windows.Forms.Label labelPublisher;
        private System.Windows.Forms.TextBox textBoxPublisher;
        private System.Windows.Forms.Label labelEventHub;
        private System.Windows.Forms.TextBox textBoxEventHub;
        private System.Windows.Forms.Label labelNamespace;
        private System.Windows.Forms.TextBox textBoxNamespace;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelSASToken;
        private System.Windows.Forms.TextBox textBoxSASToken;
        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.GroupBox groupBoxDataParams;
        private System.Windows.Forms.Label labelInterval;
        private System.Windows.Forms.NumericUpDown numericUpDownTimerInterval;
        private System.Windows.Forms.Label labelMaximum;
        private System.Windows.Forms.Label labelMinimum;
        private System.Windows.Forms.NumericUpDown numericUpDownRangeMax;
        private System.Windows.Forms.NumericUpDown numericUpDownRangeMin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}

