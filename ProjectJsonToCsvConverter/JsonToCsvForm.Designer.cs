namespace ProjectJsonToCsvConverter
{
    partial class JsonToCsvForm
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
            textBoxJson = new TextBox();
            textBoxCsv = new TextBox();
            textBoxUserInput = new TextBox();
            labelEndpoints = new Label();
            label1 = new Label();
            btnRequest = new Button();
            btnConvert = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBoxJson
            // 
            textBoxJson.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxJson.Location = new Point(12, 89);
            textBoxJson.Multiline = true;
            textBoxJson.Name = "textBoxJson";
            textBoxJson.ScrollBars = ScrollBars.Vertical;
            textBoxJson.Size = new Size(403, 556);
            textBoxJson.TabIndex = 2;
            textBoxJson.TextChanged += textBoxJson_TextChanged;
            // 
            // textBoxCsv
            // 
            textBoxCsv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxCsv.Location = new Point(648, 89);
            textBoxCsv.Multiline = true;
            textBoxCsv.Name = "textBoxCsv";
            textBoxCsv.ScrollBars = ScrollBars.Vertical;
            textBoxCsv.Size = new Size(510, 556);
            textBoxCsv.TabIndex = 5;
            // 
            // textBoxUserInput
            // 
            textBoxUserInput.Location = new Point(523, 23);
            textBoxUserInput.Name = "textBoxUserInput";
            textBoxUserInput.Size = new Size(354, 27);
            textBoxUserInput.TabIndex = 1;
            textBoxUserInput.Text = "name/peru";
            // 
            // labelEndpoints
            // 
            labelEndpoints.AutoSize = true;
            labelEndpoints.Location = new Point(306, 26);
            labelEndpoints.Name = "labelEndpoints";
            labelEndpoints.Size = new Size(211, 20);
            labelEndpoints.TabIndex = 4;
            labelEndpoints.Text = "https://restcountries.com/v3.1/";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(441, 253);
            label1.Name = "label1";
            label1.Size = new Size(146, 180);
            label1.TabIndex = 5;
            label1.Text = "Endpoints:\r\n- name/(name)\r\n  name/peru\r\n- region/(region)\r\n  (region/europe)\r\n- subregion/(region)\r\n  (subregion/europe)\r\n- capital/(capital)\r\n  (capital/llima)\r\n";
            // 
            // btnRequest
            // 
            btnRequest.Location = new Point(441, 89);
            btnRequest.Name = "btnRequest";
            btnRequest.Size = new Size(172, 51);
            btnRequest.TabIndex = 3;
            btnRequest.Text = "Request API";
            btnRequest.UseVisualStyleBackColor = true;
            btnRequest.Click += btnRequest_Click;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(441, 172);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(172, 46);
            btnConvert.TabIndex = 4;
            btnConvert.Text = "Convert to CSV";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 66);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 8;
            label2.Text = "JSON";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(884, 66);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 9;
            label3.Text = "CSV";
            // 
            // JsonToCsvForm
            // 
            AcceptButton = btnRequest;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 657);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnConvert);
            Controls.Add(btnRequest);
            Controls.Add(label1);
            Controls.Add(labelEndpoints);
            Controls.Add(textBoxUserInput);
            Controls.Add(textBoxCsv);
            Controls.Add(textBoxJson);
            Name = "JsonToCsvForm";
            Text = "JsonToCsv";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxJson;
        private TextBox textBoxCsv;
        private TextBox textBoxUserInput;
        private Label labelEndpoints;
        private Label label1;
        private Button btnRequest;
        private Button btnConvert;
        private Label label2;
        private Label label3;
    }
}
