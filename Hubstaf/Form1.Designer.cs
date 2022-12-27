namespace Hubstaf
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtresult = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox2 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.gunaComboBox2 = new Guna.UI.WinForms.GunaComboBox();
            this.gunaCheckBox1 = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaTextBox3 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox4 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.todoContainer = new Guna.UI.WinForms.GunaDataGridView();
            this.projectContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todoContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(135, 106);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(76, 21);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Software";
            // 
            // txtresult
            // 
            this.txtresult.BackColor = System.Drawing.Color.AliceBlue;
            this.txtresult.BaseColor = System.Drawing.Color.BlanchedAlmond;
            this.txtresult.BorderColor = System.Drawing.Color.BlanchedAlmond;
            this.txtresult.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtresult.FocusedBaseColor = System.Drawing.Color.White;
            this.txtresult.FocusedBorderColor = System.Drawing.Color.Transparent;
            this.txtresult.FocusedForeColor = System.Drawing.Color.Transparent;
            this.txtresult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresult.ForeColor = System.Drawing.Color.Black;
            this.txtresult.Location = new System.Drawing.Point(97, 49);
            this.txtresult.Name = "txtresult";
            this.txtresult.PasswordChar = '\0';
            this.txtresult.ReadOnly = true;
            this.txtresult.SelectedText = "";
            this.txtresult.Size = new System.Drawing.Size(160, 32);
            this.txtresult.TabIndex = 2;
            this.txtresult.Text = "00:00:00";
            this.txtresult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaTextBox2
            // 
            this.gunaTextBox2.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox2.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox2.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox2.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.gunaTextBox2.Location = new System.Drawing.Point(29, 262);
            this.gunaTextBox2.Name = "gunaTextBox2";
            this.gunaTextBox2.PasswordChar = '\0';
            this.gunaTextBox2.SelectedText = "";
            this.gunaTextBox2.Size = new System.Drawing.Size(271, 26);
            this.gunaTextBox2.TabIndex = 3;
            this.gunaTextBox2.Text = "Search Project";
            this.gunaTextBox2.TextChanged += new System.EventHandler(this.gunaTextBox2_TextChanged);
            this.gunaTextBox2.Enter += new System.EventHandler(this.gunaTextBox2_Enter);
            this.gunaTextBox2.Leave += new System.EventHandler(this.gunaTextBox2_Leave);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(52, 10);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(57, 17);
            this.gunaLabel2.TabIndex = 6;
            this.gunaLabel2.Text = "Hubstaff";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point(339, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 520);
            this.panel1.TabIndex = 7;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(351, 49);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(60, 21);
            this.gunaLabel3.TabIndex = 8;
            this.gunaLabel3.Text = "To-dos";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(351, 79);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(53, 13);
            this.gunaLabel4.TabIndex = 9;
            this.gunaLabel4.Text = "Software";
            // 
            // gunaComboBox1
            // 
            this.gunaComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox1.BaseColor = System.Drawing.Color.White;
            this.gunaComboBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gunaComboBox1.FocusedColor = System.Drawing.Color.Silver;
            this.gunaComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaComboBox1.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox1.FormattingEnabled = true;
            this.gunaComboBox1.Location = new System.Drawing.Point(355, 113);
            this.gunaComboBox1.Name = "gunaComboBox1";
            this.gunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox1.Size = new System.Drawing.Size(121, 26);
            this.gunaComboBox1.TabIndex = 10;
            this.gunaComboBox1.SelectedIndexChanged += new System.EventHandler(this.gunaComboBox1_SelectedIndexChanged);
            // 
            // gunaComboBox2
            // 
            this.gunaComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox2.BaseColor = System.Drawing.Color.White;
            this.gunaComboBox2.BorderColor = System.Drawing.Color.Silver;
            this.gunaComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaComboBox2.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox2.FormattingEnabled = true;
            this.gunaComboBox2.Location = new System.Drawing.Point(492, 113);
            this.gunaComboBox2.Name = "gunaComboBox2";
            this.gunaComboBox2.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox2.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox2.Size = new System.Drawing.Size(121, 26);
            this.gunaComboBox2.TabIndex = 11;
            this.gunaComboBox2.SelectedIndexChanged += new System.EventHandler(this.gunaComboBox2_SelectedIndexChanged);
            // 
            // gunaCheckBox1
            // 
            this.gunaCheckBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCheckBox1.CheckedOffColor = System.Drawing.Color.Gray;
            this.gunaCheckBox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaCheckBox1.FillColor = System.Drawing.Color.White;
            this.gunaCheckBox1.Location = new System.Drawing.Point(629, 113);
            this.gunaCheckBox1.Name = "gunaCheckBox1";
            this.gunaCheckBox1.Size = new System.Drawing.Size(116, 20);
            this.gunaCheckBox1.TabIndex = 12;
            this.gunaCheckBox1.Text = "Show Completed";
            this.gunaCheckBox1.CheckedChanged += new System.EventHandler(this.gunaCheckBox1_CheckedChanged);
            // 
            // gunaTextBox3
            // 
            this.gunaTextBox3.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox3.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox3.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox3.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaTextBox3.ForeColor = System.Drawing.Color.DimGray;
            this.gunaTextBox3.Location = new System.Drawing.Point(959, 113);
            this.gunaTextBox3.Name = "gunaTextBox3";
            this.gunaTextBox3.PasswordChar = '\0';
            this.gunaTextBox3.SelectedText = "";
            this.gunaTextBox3.Size = new System.Drawing.Size(151, 25);
            this.gunaTextBox3.TabIndex = 13;
            this.gunaTextBox3.Text = "Search to-dos";
            this.gunaTextBox3.TextChanged += new System.EventHandler(this.gunaTextBox3_TextChanged);
            this.gunaTextBox3.Enter += new System.EventHandler(this.gunaTextBox3_Enter);
            this.gunaTextBox3.Leave += new System.EventHandler(this.gunaTextBox3_Leave);
            // 
            // gunaTextBox4
            // 
            this.gunaTextBox4.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox4.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox4.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox4.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaTextBox4.ForeColor = System.Drawing.Color.DimGray;
            this.gunaTextBox4.Location = new System.Drawing.Point(355, 145);
            this.gunaTextBox4.Name = "gunaTextBox4";
            this.gunaTextBox4.PasswordChar = '\0';
            this.gunaTextBox4.SelectedText = "";
            this.gunaTextBox4.Size = new System.Drawing.Size(737, 25);
            this.gunaTextBox4.TabIndex = 14;
            this.gunaTextBox4.Text = "Create a to-do";
            this.gunaTextBox4.Enter += new System.EventHandler(this.gunaTextBox4_Enter);
            this.gunaTextBox4.Leave += new System.EventHandler(this.gunaTextBox4_Leave);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.Gainsboro;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.Black;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(1082, 145);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(28, 25);
            this.gunaButton1.TabIndex = 15;
            this.gunaButton1.Text = "+";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = null;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(706, 28);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Size = new System.Drawing.Size(160, 42);
            this.gunaButton2.TabIndex = 20;
            this.gunaButton2.Text = "Capture";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.gunaPanel2.Controls.Add(this.label1);
            this.gunaPanel2.Location = new System.Drawing.Point(2, 310);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(318, 44);
            this.gunaPanel2.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tesproj";
            // 
            // todoContainer
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.todoContainer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.todoContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.todoContainer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.todoContainer.BackgroundColor = System.Drawing.Color.White;
            this.todoContainer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.todoContainer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.todoContainer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.todoContainer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.todoContainer.ColumnHeadersHeight = 4;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.todoContainer.DefaultCellStyle = dataGridViewCellStyle12;
            this.todoContainer.EnableHeadersVisualStyles = false;
            this.todoContainer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.todoContainer.Location = new System.Drawing.Point(355, 192);
            this.todoContainer.Name = "todoContainer";
            this.todoContainer.RowHeadersVisible = false;
            this.todoContainer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.todoContainer.Size = new System.Drawing.Size(776, 236);
            this.todoContainer.TabIndex = 24;
            this.todoContainer.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.todoContainer.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.todoContainer.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.todoContainer.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.todoContainer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.todoContainer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.todoContainer.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.todoContainer.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.todoContainer.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.todoContainer.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.todoContainer.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.todoContainer.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.todoContainer.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.todoContainer.ThemeStyle.HeaderStyle.Height = 4;
            this.todoContainer.ThemeStyle.ReadOnly = false;
            this.todoContainer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.todoContainer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.todoContainer.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.todoContainer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.DimGray;
            this.todoContainer.ThemeStyle.RowsStyle.Height = 22;
            this.todoContainer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.todoContainer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // projectContainer
            // 
            this.projectContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.projectContainer.AutoScroll = true;
            this.projectContainer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.projectContainer.Location = new System.Drawing.Point(5, 360);
            this.projectContainer.Name = "projectContainer";
            this.projectContainer.Size = new System.Drawing.Size(328, 253);
            this.projectContainer.TabIndex = 26;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(354, 434);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 10;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(777, 167);
            this.gunaElipsePanel1.TabIndex = 27;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Hubstaf.Properties.Resources.stop_52px;
            this.pictureBox2.Location = new System.Drawing.Point(150, 181);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 52);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::Hubstaf.Properties.Resources.hubstaf_removebg_preview__2___1_;
            this.gunaPictureBox1.Location = new System.Drawing.Point(8, 10);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(38, 35);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.gunaPictureBox1.TabIndex = 5;
            this.gunaPictureBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hubstaf.Properties.Resources.pngkey_com_dr_strange_png_1568437__2_;
            this.pictureBox1.Location = new System.Drawing.Point(150, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 52);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1139, 613);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.projectContainer);
            this.Controls.Add(this.todoContainer);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.gunaTextBox4);
            this.Controls.Add(this.gunaTextBox3);
            this.Controls.Add(this.gunaCheckBox1);
            this.Controls.Add(this.gunaComboBox2);
            this.Controls.Add(this.gunaComboBox1);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.gunaTextBox2);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gunaLabel1);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.todoContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox2;
        private Guna.UI.WinForms.GunaTextBox txtresult;
        private Guna.UI.WinForms.GunaCheckBox gunaCheckBox1;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox2;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox4;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaDataGridView todoContainer;
        private System.Windows.Forms.FlowLayoutPanel projectContainer;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
    }
}

