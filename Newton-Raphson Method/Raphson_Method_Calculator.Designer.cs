namespace Secant_Method
{
    partial class Raphson_Method
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Raphson_Method));
            tbxFunction = new TextBox();
            lblNewton_Raphson_Method = new Label();
            panel_Details = new Panel();
            lblDetails = new Label();
            pbxDetails = new PictureBox();
            label1 = new Label();
            lblOutput = new Label();
            panel2 = new Panel();
            lblResult = new Label();
            btnClearAll = new Button();
            btnCalculate = new Button();
            lblTolerance = new Label();
            lblInitialGuess = new Label();
            lblFunction = new Label();
            tbxTolerance = new TextBox();
            tbxInitialGuess = new TextBox();
            lblCalculator = new Label();
            pbxExit = new PictureBox();
            guna2Elipse_Raphson_Method = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse_btnCalculate = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse_btnClearAll = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxDetails).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxExit).BeginInit();
            SuspendLayout();
            // 
            // tbxFunction
            // 
            tbxFunction.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbxFunction.Location = new Point(315, 36);
            tbxFunction.Name = "tbxFunction";
            tbxFunction.Size = new Size(245, 27);
            tbxFunction.TabIndex = 0;
            // 
            // lblNewton_Raphson_Method
            // 
            lblNewton_Raphson_Method.AutoSize = true;
            lblNewton_Raphson_Method.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNewton_Raphson_Method.ForeColor = Color.White;
            lblNewton_Raphson_Method.Location = new Point(69, 15);
            lblNewton_Raphson_Method.Name = "lblNewton_Raphson_Method";
            lblNewton_Raphson_Method.Size = new Size(598, 62);
            lblNewton_Raphson_Method.TabIndex = 1;
            lblNewton_Raphson_Method.Text = "Newton-Raphson Method";
            // 
            // panel_Details
            // 
            panel_Details.BackColor = Color.FromArgb(60, 91, 111);
            panel_Details.Controls.Add(lblDetails);
            panel_Details.Controls.Add(pbxDetails);
            panel_Details.Controls.Add(label1);
            panel_Details.Controls.Add(lblOutput);
            panel_Details.Controls.Add(panel2);
            panel_Details.Controls.Add(btnClearAll);
            panel_Details.Controls.Add(btnCalculate);
            panel_Details.Controls.Add(lblTolerance);
            panel_Details.Controls.Add(lblInitialGuess);
            panel_Details.Controls.Add(lblFunction);
            panel_Details.Controls.Add(tbxTolerance);
            panel_Details.Controls.Add(tbxInitialGuess);
            panel_Details.Controls.Add(tbxFunction);
            panel_Details.Location = new Point(41, 127);
            panel_Details.Name = "panel_Details";
            panel_Details.Size = new Size(645, 610);
            panel_Details.TabIndex = 2;
            // 
            // lblDetails
            // 
            lblDetails.AutoSize = true;
            lblDetails.Cursor = Cursors.Hand;
            lblDetails.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetails.ForeColor = Color.White;
            lblDetails.Location = new Point(493, 172);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(65, 23);
            lblDetails.TabIndex = 12;
            lblDetails.Text = "Details";
            lblDetails.Click += lblDetails_Click;
            // 
            // pbxDetails
            // 
            pbxDetails.Image = (Image)resources.GetObject("pbxDetails.Image");
            pbxDetails.Location = new Point(463, 171);
            pbxDetails.Name = "pbxDetails";
            pbxDetails.Size = new Size(34, 25);
            pbxDetails.SizeMode = PictureBoxSizeMode.Zoom;
            pbxDetails.TabIndex = 11;
            pbxDetails.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(482, 173);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 10;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOutput.ForeColor = Color.White;
            lblOutput.Location = new Point(88, 168);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(78, 25);
            lblOutput.TabIndex = 9;
            lblOutput.Text = "Results:";
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblResult);
            panel2.Location = new Point(83, 208);
            panel2.Name = "panel2";
            panel2.Size = new Size(477, 305);
            panel2.TabIndex = 8;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.ForeColor = Color.FromArgb(21, 52, 72);
            lblResult.Location = new Point(5, 6);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 0;
            // 
            // btnClearAll
            // 
            btnClearAll.BackColor = Color.FromArgb(223, 208, 184);
            btnClearAll.Cursor = Cursors.Hand;
            btnClearAll.FlatAppearance.BorderSize = 0;
            btnClearAll.FlatStyle = FlatStyle.Flat;
            btnClearAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClearAll.Location = new Point(336, 529);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(224, 45);
            btnClearAll.TabIndex = 7;
            btnClearAll.Text = "CLEAR ALL";
            btnClearAll.UseVisualStyleBackColor = false;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.FromArgb(223, 208, 184);
            btnCalculate.Cursor = Cursors.Hand;
            btnCalculate.FlatAppearance.BorderSize = 0;
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCalculate.Location = new Point(83, 529);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(224, 45);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "CALCULATE";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblTolerance
            // 
            lblTolerance.AutoSize = true;
            lblTolerance.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTolerance.ForeColor = Color.White;
            lblTolerance.Location = new Point(88, 130);
            lblTolerance.Name = "lblTolerance";
            lblTolerance.Size = new Size(108, 28);
            lblTolerance.TabIndex = 5;
            lblTolerance.Text = "Tolerance:";
            // 
            // lblInitialGuess
            // 
            lblInitialGuess.AutoSize = true;
            lblInitialGuess.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblInitialGuess.ForeColor = Color.White;
            lblInitialGuess.Location = new Point(88, 79);
            lblInitialGuess.Name = "lblInitialGuess";
            lblInitialGuess.Size = new Size(156, 28);
            lblInitialGuess.TabIndex = 4;
            lblInitialGuess.Text = "Initial guess Xi:";
            // 
            // lblFunction
            // 
            lblFunction.AutoSize = true;
            lblFunction.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFunction.ForeColor = Color.White;
            lblFunction.Location = new Point(88, 32);
            lblFunction.Name = "lblFunction";
            lblFunction.Size = new Size(138, 28);
            lblFunction.TabIndex = 3;
            lblFunction.Text = "Function f(x):";
            // 
            // tbxTolerance
            // 
            tbxTolerance.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbxTolerance.Location = new Point(315, 130);
            tbxTolerance.Name = "tbxTolerance";
            tbxTolerance.Size = new Size(245, 27);
            tbxTolerance.TabIndex = 2;
            // 
            // tbxInitialGuess
            // 
            tbxInitialGuess.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbxInitialGuess.Location = new Point(315, 83);
            tbxInitialGuess.Name = "tbxInitialGuess";
            tbxInitialGuess.Size = new Size(245, 27);
            tbxInitialGuess.TabIndex = 1;
            // 
            // lblCalculator
            // 
            lblCalculator.AutoSize = true;
            lblCalculator.Font = new Font("Copperplate Gothic Light", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCalculator.ForeColor = Color.White;
            lblCalculator.Location = new Point(270, 77);
            lblCalculator.Name = "lblCalculator";
            lblCalculator.Size = new Size(211, 32);
            lblCalculator.TabIndex = 3;
            lblCalculator.Text = "Calculator";
            // 
            // pbxExit
            // 
            pbxExit.Cursor = Cursors.Hand;
            pbxExit.Image = (Image)resources.GetObject("pbxExit.Image");
            pbxExit.Location = new Point(687, 6);
            pbxExit.Name = "pbxExit";
            pbxExit.Size = new Size(34, 31);
            pbxExit.SizeMode = PictureBoxSizeMode.Zoom;
            pbxExit.TabIndex = 4;
            pbxExit.TabStop = false;
            pbxExit.Click += pbxExit_Click;
            // 
            // guna2Elipse_Raphson_Method
            // 
            guna2Elipse_Raphson_Method.BorderRadius = 36;
            guna2Elipse_Raphson_Method.TargetControl = this;
            // 
            // guna2Elipse_btnCalculate
            // 
            guna2Elipse_btnCalculate.BorderRadius = 20;
            guna2Elipse_btnCalculate.TargetControl = btnCalculate;
            // 
            // guna2Elipse_btnClearAll
            // 
            guna2Elipse_btnClearAll.BorderRadius = 20;
            guna2Elipse_btnClearAll.TargetControl = btnClearAll;
            // 
            // Raphson_Method
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 52, 72);
            ClientSize = new Size(727, 781);
            Controls.Add(pbxExit);
            Controls.Add(panel_Details);
            Controls.Add(lblNewton_Raphson_Method);
            Controls.Add(lblCalculator);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Raphson_Method";
            StartPosition = FormStartPosition.CenterScreen;
            panel_Details.ResumeLayout(false);
            panel_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxDetails).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxExit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxFunction;
        private Label lblNewton_Raphson_Method;
        private Panel panel_Details;
        private Label lblTolerance;
        private Label lblInitialGuess;
        private Label lblFunction;
        private TextBox tbxTolerance;
        private TextBox tbxInitialGuess;
        private Label lblCalculator;
        private Button btnClearAll;
        private Button btnCalculate;
        private PictureBox pbxExit;
        private Label lblOutput;
        private Panel panel2;
        private Label lblResult;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_Raphson_Method;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_btnCalculate;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_btnClearAll;
        private Label label1;
        private Label lblDetails;
        private PictureBox pbxDetails;
    }
}
