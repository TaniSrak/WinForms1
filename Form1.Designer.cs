namespace WinForms1
{
    partial class frmMain
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
            btnTest = new Button();
            btmTest2 = new Button();
            lblTest = new Label();
            textBox = new TextBox();
            chBox = new CheckBox();
            radioBtm = new RadioButton();
            groupBox1 = new GroupBox();
            radioBtm2 = new RadioButton();
            chBox2 = new CheckBox();
            menuStrip1 = new MenuStrip();
            menu = new MenuStrip();
            видToolStripMenuItem = new ToolStripMenuItem();
            сбокуToolStripMenuItem = new ToolStripMenuItem();
            сверхуToolStripMenuItem = new ToolStripMenuItem();
            снизуToolStripMenuItem = new ToolStripMenuItem();
            файлToolStripMenuItem = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            добавитьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            fontDialog1 = new FontDialog();
            fontDialog2 = new FontDialog();
            printDialog = new PrintDialog();
            btnOpen = new Button();
            btnSaveFile = new Button();
            openFileDialog1 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // btnTest
            // 
            btnTest.Anchor = AnchorStyles.None;
            btnTest.Location = new Point(1129, 378);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(134, 48);
            btnTest.TabIndex = 0;
            btnTest.Text = "Нажми";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += Exit;
            // 
            // btmTest2
            // 
            btmTest2.Anchor = AnchorStyles.None;
            btmTest2.Location = new Point(1129, 322);
            btmTest2.Name = "btmTest2";
            btmTest2.Size = new Size(134, 48);
            btmTest2.TabIndex = 1;
            btmTest2.Text = "Проверка";
            btmTest2.UseVisualStyleBackColor = true;
            btmTest2.Click += TextChange;
            // 
            // lblTest
            // 
            lblTest.Anchor = AnchorStyles.None;
            lblTest.AutoSize = true;
            lblTest.Location = new Point(12, 407);
            lblTest.Name = "lblTest";
            lblTest.Size = new Size(99, 30);
            lblTest.TabIndex = 2;
            lblTest.Text = "Надпись";
            // 
            // textBox
            // 
            textBox.Location = new Point(129, 322);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.ScrollBars = ScrollBars.Both;
            textBox.Size = new Size(359, 237);
            textBox.TabIndex = 3;
            textBox.Text = "Напиши сюда";
            // 
            // chBox
            // 
            chBox.AutoSize = true;
            chBox.Checked = true;
            chBox.CheckState = CheckState.Checked;
            chBox.Location = new Point(897, 341);
            chBox.Name = "chBox";
            chBox.Size = new Size(97, 34);
            chBox.TabIndex = 4;
            chBox.Text = "chBox";
            chBox.UseVisualStyleBackColor = true;
            // 
            // radioBtm
            // 
            radioBtm.AutoSize = true;
            radioBtm.Checked = true;
            radioBtm.Location = new Point(20, 63);
            radioBtm.Name = "radioBtm";
            radioBtm.Size = new Size(127, 34);
            radioBtm.TabIndex = 5;
            radioBtm.TabStop = true;
            radioBtm.Text = "radioBtm";
            radioBtm.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioBtm2);
            groupBox1.Controls.Add(radioBtm);
            groupBox1.Location = new Point(529, 322);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(262, 217);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // radioBtm2
            // 
            radioBtm2.AutoSize = true;
            radioBtm2.Location = new Point(20, 103);
            radioBtm2.Name = "radioBtm2";
            radioBtm2.Size = new Size(139, 34);
            radioBtm2.TabIndex = 6;
            radioBtm2.Text = "radioBtm2";
            radioBtm2.UseVisualStyleBackColor = true;
            // 
            // chBox2
            // 
            chBox2.AutoSize = true;
            chBox2.Location = new Point(885, 386);
            chBox2.Name = "chBox2";
            chBox2.Size = new Size(109, 34);
            chBox2.TabIndex = 7;
            chBox2.Text = "chBox2";
            chBox2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(28, 28);
            menuStrip1.Location = new Point(0, 38);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1275, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // menu
            // 
            menu.ImageScalingSize = new Size(28, 28);
            menu.Items.AddRange(new ToolStripItem[] { видToolStripMenuItem, файлToolStripMenuItem, сохранитьToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(1275, 38);
            menu.TabIndex = 9;
            menu.Text = "menuStrip2";
            // 
            // видToolStripMenuItem
            // 
            видToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { сбокуToolStripMenuItem, сверхуToolStripMenuItem, снизуToolStripMenuItem });
            видToolStripMenuItem.Name = "видToolStripMenuItem";
            видToolStripMenuItem.Size = new Size(68, 34);
            видToolStripMenuItem.Text = "вид";
            // 
            // сбокуToolStripMenuItem
            // 
            сбокуToolStripMenuItem.Checked = true;
            сбокуToolStripMenuItem.CheckState = CheckState.Checked;
            сбокуToolStripMenuItem.Image = Properties.Resources.Снимок_экрана_2024_04_15_194939;
            сбокуToolStripMenuItem.Name = "сбокуToolStripMenuItem";
            сбокуToolStripMenuItem.Size = new Size(199, 40);
            сбокуToolStripMenuItem.Text = "сбоку";
            // 
            // сверхуToolStripMenuItem
            // 
            сверхуToolStripMenuItem.Checked = true;
            сверхуToolStripMenuItem.CheckState = CheckState.Checked;
            сверхуToolStripMenuItem.Name = "сверхуToolStripMenuItem";
            сверхуToolStripMenuItem.Size = new Size(199, 40);
            сверхуToolStripMenuItem.Text = "сверху";
            // 
            // снизуToolStripMenuItem
            // 
            снизуToolStripMenuItem.Name = "снизуToolStripMenuItem";
            снизуToolStripMenuItem.Size = new Size(199, 40);
            снизуToolStripMenuItem.Text = "снизу";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { удалитьToolStripMenuItem, добавитьToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(82, 34);
            файлToolStripMenuItem.Text = "файл";
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(225, 40);
            удалитьToolStripMenuItem.Text = "удалить";
            // 
            // добавитьToolStripMenuItem
            // 
            добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            добавитьToolStripMenuItem.Size = new Size(225, 40);
            добавитьToolStripMenuItem.Text = "добавить";
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(134, 34);
            сохранитьToolStripMenuItem.Text = "сохранить";
            // 
            // printDialog
            // 
            printDialog.UseEXDialog = true;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(1129, 454);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(131, 40);
            btnOpen.TabIndex = 10;
            btnOpen.Text = "Открыть";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += button1_Click;
            // 
            // btnSaveFile
            // 
            btnSaveFile.Location = new Point(1129, 500);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(131, 40);
            btnSaveFile.TabIndex = 11;
            btnSaveFile.Text = "Сохранить";
            btnSaveFile.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.DefaultExt = "txt;doc";
            openFileDialog1.FileName = "openFileDialog";
            openFileDialog1.Filter = "Текст|*.txt";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1275, 626);
            Controls.Add(btnSaveFile);
            Controls.Add(btnOpen);
            Controls.Add(chBox2);
            Controls.Add(groupBox1);
            Controls.Add(chBox);
            Controls.Add(textBox);
            Controls.Add(lblTest);
            Controls.Add(btmTest2);
            Controls.Add(btnTest);
            Controls.Add(menuStrip1);
            Controls.Add(menu);
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "Текстовое приложение";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTest;
        private Button btmTest2;
        private Label lblTest;
        private TextBox textBox;
        private CheckBox chBox;
        private RadioButton radioBtm;
        private GroupBox groupBox1;
        private RadioButton radioBtm2;
        private CheckBox chBox2;
        private MenuStrip menuStrip1;
        private MenuStrip menu;
        private ToolStripMenuItem видToolStripMenuItem;
        private ToolStripMenuItem сбокуToolStripMenuItem;
        private ToolStripMenuItem сверхуToolStripMenuItem;
        private ToolStripMenuItem снизуToolStripMenuItem;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private FontDialog fontDialog1;
        private FontDialog fontDialog2;
        private PrintDialog printDialog;
        private Button btnOpen;
        private Button btnSaveFile;
        private OpenFileDialog openFileDialog1;
    }
}
