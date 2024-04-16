namespace Ac3
{
    partial class Form1
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            comboBoxComarca = new ComboBox();
            comboBoxAny = new ComboBox();
            textBoxClear5 = new TextBox();
            textBoxClear4 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            textBoxClear = new TextBox();
            textBoxClear3 = new TextBox();
            textBoxClear2 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonSave = new Button();
            buttonClear = new Button();
            groupBox2 = new GroupBox();
            textBoxLowerDom = new TextBox();
            textBoxHigherDom = new TextBox();
            textBoxAvg = new TextBox();
            textBox20kAbove = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            dataGridCSVOutput = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCSVOutput).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxComarca);
            groupBox1.Controls.Add(comboBoxAny);
            groupBox1.Controls.Add(textBoxClear5);
            groupBox1.Controls.Add(textBoxClear4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBoxClear);
            groupBox1.Controls.Add(textBoxClear3);
            groupBox1.Controls.Add(textBoxClear2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(22, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(581, 202);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestió de dades demográfiques de regions";
            // 
            // comboBoxComarca
            // 
            comboBoxComarca.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxComarca.FormattingEnabled = true;
            comboBoxComarca.ImeMode = ImeMode.NoControl;
            comboBoxComarca.Location = new Point(145, 56);
            comboBoxComarca.Name = "comboBoxComarca";
            comboBoxComarca.Size = new Size(94, 23);
            comboBoxComarca.Sorted = true;
            comboBoxComarca.TabIndex = 15;
            // 
            // comboBoxAny
            // 
            comboBoxAny.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAny.FormattingEnabled = true;
            comboBoxAny.ImeMode = ImeMode.NoControl;
            comboBoxAny.Location = new Point(33, 56);
            comboBoxAny.Name = "comboBoxAny";
            comboBoxAny.Size = new Size(94, 23);
            comboBoxAny.Sorted = true;
            comboBoxAny.TabIndex = 14;
            // 
            // textBoxClear5
            // 
            textBoxClear5.Location = new Point(443, 162);
            textBoxClear5.Name = "textBoxClear5";
            textBoxClear5.Size = new Size(122, 23);
            textBoxClear5.TabIndex = 13;
            // 
            // textBoxClear4
            // 
            textBoxClear4.Location = new Point(443, 127);
            textBoxClear4.Name = "textBoxClear4";
            textBoxClear4.Size = new Size(122, 23);
            textBoxClear4.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(328, 165);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 11;
            label7.Text = "Total";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(326, 127);
            label6.Name = "label6";
            label6.Size = new Size(111, 32);
            label6.TabIndex = 10;
            label6.Text = "Consum domèstic per càpita";
            // 
            // textBoxClear
            // 
            textBoxClear.Location = new Point(256, 56);
            textBoxClear.Name = "textBoxClear";
            textBoxClear.Size = new Size(100, 23);
            textBoxClear.TabIndex = 9;
            // 
            // textBoxClear3
            // 
            textBoxClear3.Location = new Point(168, 162);
            textBoxClear3.Name = "textBoxClear3";
            textBoxClear3.Size = new Size(100, 23);
            textBoxClear3.TabIndex = 6;
            // 
            // textBoxClear2
            // 
            textBoxClear2.Location = new Point(33, 162);
            textBoxClear2.Name = "textBoxClear2";
            textBoxClear2.Size = new Size(100, 23);
            textBoxClear2.TabIndex = 5;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(168, 127);
            label5.Name = "label5";
            label5.Size = new Size(152, 32);
            label5.TabIndex = 4;
            label5.Text = "Activitats econòmiques i fonts pròpies";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(33, 127);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 3;
            label4.Text = "Domèstic xarxa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(256, 32);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 2;
            label3.Text = "Població";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(145, 32);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Comarca";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 32);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "Any";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(516, 226);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Guardar";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(435, 226);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 23);
            buttonClear.TabIndex = 2;
            buttonClear.Text = "Netejar";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxLowerDom);
            groupBox2.Controls.Add(textBoxHigherDom);
            groupBox2.Controls.Add(textBoxAvg);
            groupBox2.Controls.Add(textBox20kAbove);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(615, 18);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(281, 142);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Estadístiques";
            // 
            // textBoxLowerDom
            // 
            textBoxLowerDom.BorderStyle = BorderStyle.None;
            textBoxLowerDom.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBoxLowerDom.ForeColor = Color.Blue;
            textBoxLowerDom.Location = new Point(194, 113);
            textBoxLowerDom.Name = "textBoxLowerDom";
            textBoxLowerDom.ReadOnly = true;
            textBoxLowerDom.Size = new Size(81, 16);
            textBoxLowerDom.TabIndex = 20;
            textBoxLowerDom.Text = "0";
            // 
            // textBoxHigherDom
            // 
            textBoxHigherDom.BorderStyle = BorderStyle.None;
            textBoxHigherDom.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBoxHigherDom.ForeColor = Color.Blue;
            textBoxHigherDom.Location = new Point(194, 86);
            textBoxHigherDom.Name = "textBoxHigherDom";
            textBoxHigherDom.ReadOnly = true;
            textBoxHigherDom.Size = new Size(81, 16);
            textBoxHigherDom.TabIndex = 19;
            textBoxHigherDom.Text = "0";
            // 
            // textBoxAvg
            // 
            textBoxAvg.BorderStyle = BorderStyle.None;
            textBoxAvg.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBoxAvg.ForeColor = Color.Blue;
            textBoxAvg.Location = new Point(194, 59);
            textBoxAvg.Name = "textBoxAvg";
            textBoxAvg.ReadOnly = true;
            textBoxAvg.Size = new Size(81, 16);
            textBoxAvg.TabIndex = 18;
            textBoxAvg.Text = "0";
            // 
            // textBox20kAbove
            // 
            textBox20kAbove.BorderStyle = BorderStyle.None;
            textBox20kAbove.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBox20kAbove.ForeColor = Color.Blue;
            textBox20kAbove.Location = new Point(194, 32);
            textBox20kAbove.Name = "textBox20kAbove";
            textBox20kAbove.ReadOnly = true;
            textBox20kAbove.Size = new Size(81, 16);
            textBox20kAbove.TabIndex = 14;
            textBox20kAbove.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(17, 113);
            label11.Name = "label11";
            label11.Size = new Size(134, 15);
            label11.TabIndex = 17;
            label11.Text = "Consum doméstic baix:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(17, 86);
            label10.Name = "label10";
            label10.Size = new Size(125, 15);
            label10.TabIndex = 16;
            label10.Text = "Consum doméstic alt:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(17, 58);
            label9.Name = "label9";
            label9.Size = new Size(85, 15);
            label9.TabIndex = 15;
            label9.Text = "Consum mitjá:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(17, 32);
            label8.Name = "label8";
            label8.Size = new Size(115, 15);
            label8.TabIndex = 14;
            label8.Text = "Problació (+20000):";
            // 
            // dataGridCSVOutput
            // 
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridCSVOutput.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridCSVOutput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCSVOutput.Location = new Point(12, 259);
            dataGridCSVOutput.Name = "dataGridCSVOutput";
            dataGridCSVOutput.ReadOnly = true;
            dataGridCSVOutput.Size = new Size(884, 150);
            dataGridCSVOutput.TabIndex = 4;
            dataGridCSVOutput.CellClick += dataGridCSVOutput_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 421);
            Controls.Add(dataGridCSVOutput);
            Controls.Add(groupBox2);
            Controls.Add(buttonClear);
            Controls.Add(buttonSave);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Software de gestión de datos. (Javier Fernández Cano)";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCSVOutput).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBoxClear5;
        private TextBox textBoxClear4;
        private Label label7;
        private Label label6;
        private TextBox textBoxClear;
        private TextBox textBoxClear3;
        private TextBox textBoxClear2;
        private Button buttonSave;
        private Button buttonClear;
        private GroupBox groupBox2;
        private TextBox textBoxLowerDom;
        private TextBox textBoxHigherDom;
        private TextBox textBoxAvg;
        private TextBox textBox20kAbove;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private DataGridView dataGridCSVOutput;
        private ComboBox comboBoxComarca;
        private ComboBox comboBoxAny;
    }
}
