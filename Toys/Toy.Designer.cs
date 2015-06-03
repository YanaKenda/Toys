using System.ComponentModel;
using System.Windows.Forms;

namespace Toys
{
    partial class Toy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.ToyComboBox = new System.Windows.Forms.ComboBox();
            this.ToyLabel = new System.Windows.Forms.Label();
            this.NameToyLabel = new System.Windows.Forms.Label();
            this.AgeChildLabel = new System.Windows.Forms.Label();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.HardLevelTextBox = new System.Windows.Forms.TextBox();
            this.HardLevelLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.FieldComboBox1 = new System.Windows.Forms.ComboBox();
            this.FieldComboBox2 = new System.Windows.Forms.ComboBox();
            this.FieldComboBox3 = new System.Windows.Forms.ComboBox();
            this.PropertyLabel1 = new System.Windows.Forms.Label();
            this.PropertyLabel2 = new System.Windows.Forms.Label();
            this.PropertyLabel3 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.listObjects = new System.Windows.Forms.ListBox();
            this.change = new System.Windows.Forms.Button();
            this.ControlSum = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Plugin = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Transformation = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ToyComboBox
            // 
            this.ToyComboBox.FormattingEnabled = true;
            this.ToyComboBox.Location = new System.Drawing.Point(11, 25);
            this.ToyComboBox.Name = "ToyComboBox";
            this.ToyComboBox.Size = new System.Drawing.Size(121, 21);
            this.ToyComboBox.TabIndex = 0;
            this.ToyComboBox.SelectedIndexChanged += new System.EventHandler(this.ToyComboBox_SelectedIndexChanged);
            // 
            // ToyLabel
            // 
            this.ToyLabel.AutoSize = true;
            this.ToyLabel.Location = new System.Drawing.Point(12, 9);
            this.ToyLabel.Name = "ToyLabel";
            this.ToyLabel.Size = new System.Drawing.Size(71, 13);
            this.ToyLabel.TabIndex = 1;
            this.ToyLabel.Text = "Вид игрушки";
            // 
            // NameToyLabel
            // 
            this.NameToyLabel.AutoSize = true;
            this.NameToyLabel.Location = new System.Drawing.Point(12, 64);
            this.NameToyLabel.Name = "NameToyLabel";
            this.NameToyLabel.Size = new System.Drawing.Size(74, 13);
            this.NameToyLabel.TabIndex = 2;
            this.NameToyLabel.Text = "Имя игрушки";
            // 
            // AgeChildLabel
            // 
            this.AgeChildLabel.AutoSize = true;
            this.AgeChildLabel.Location = new System.Drawing.Point(12, 121);
            this.AgeChildLabel.Name = "AgeChildLabel";
            this.AgeChildLabel.Size = new System.Drawing.Size(94, 13);
            this.AgeChildLabel.TabIndex = 3;
            this.AgeChildLabel.Text = "Возраст ребенка";
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Cursor = System.Windows.Forms.Cursors.PanNE;
            this.AgeTextBox.Location = new System.Drawing.Point(12, 137);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(120, 20);
            this.AgeTextBox.TabIndex = 4;
            // 
            // HardLevelTextBox
            // 
            this.HardLevelTextBox.Location = new System.Drawing.Point(11, 193);
            this.HardLevelTextBox.Name = "HardLevelTextBox";
            this.HardLevelTextBox.Size = new System.Drawing.Size(117, 20);
            this.HardLevelTextBox.TabIndex = 5;
            // 
            // HardLevelLabel
            // 
            this.HardLevelLabel.AutoSize = true;
            this.HardLevelLabel.Location = new System.Drawing.Point(12, 177);
            this.HardLevelLabel.Name = "HardLevelLabel";
            this.HardLevelLabel.Size = new System.Drawing.Size(104, 13);
            this.HardLevelLabel.TabIndex = 6;
            this.HardLevelLabel.Text = "Степень твердости";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(12, 80);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(121, 20);
            this.NameTextBox.TabIndex = 7;
            // 
            // FieldComboBox1
            // 
            this.FieldComboBox1.FormattingEnabled = true;
            this.FieldComboBox1.Location = new System.Drawing.Point(11, 246);
            this.FieldComboBox1.Name = "FieldComboBox1";
            this.FieldComboBox1.Size = new System.Drawing.Size(121, 21);
            this.FieldComboBox1.TabIndex = 8;
            // 
            // FieldComboBox2
            // 
            this.FieldComboBox2.FormattingEnabled = true;
            this.FieldComboBox2.Location = new System.Drawing.Point(11, 295);
            this.FieldComboBox2.Name = "FieldComboBox2";
            this.FieldComboBox2.Size = new System.Drawing.Size(121, 21);
            this.FieldComboBox2.TabIndex = 9;
            // 
            // FieldComboBox3
            // 
            this.FieldComboBox3.FormattingEnabled = true;
            this.FieldComboBox3.Location = new System.Drawing.Point(11, 346);
            this.FieldComboBox3.Name = "FieldComboBox3";
            this.FieldComboBox3.Size = new System.Drawing.Size(121, 21);
            this.FieldComboBox3.TabIndex = 10;
            // 
            // PropertyLabel1
            // 
            this.PropertyLabel1.AutoSize = true;
            this.PropertyLabel1.Location = new System.Drawing.Point(12, 230);
            this.PropertyLabel1.Name = "PropertyLabel1";
            this.PropertyLabel1.Size = new System.Drawing.Size(35, 13);
            this.PropertyLabel1.TabIndex = 11;
            this.PropertyLabel1.Text = "label2";
            // 
            // PropertyLabel2
            // 
            this.PropertyLabel2.AutoSize = true;
            this.PropertyLabel2.Location = new System.Drawing.Point(12, 279);
            this.PropertyLabel2.Name = "PropertyLabel2";
            this.PropertyLabel2.Size = new System.Drawing.Size(35, 13);
            this.PropertyLabel2.TabIndex = 12;
            this.PropertyLabel2.Text = "label3";
            // 
            // PropertyLabel3
            // 
            this.PropertyLabel3.AutoSize = true;
            this.PropertyLabel3.Location = new System.Drawing.Point(12, 331);
            this.PropertyLabel3.Name = "PropertyLabel3";
            this.PropertyLabel3.Size = new System.Drawing.Size(35, 13);
            this.PropertyLabel3.TabIndex = 13;
            this.PropertyLabel3.Text = "label4";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(170, 347);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(127, 24);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "Добавить в список";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(422, 348);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(129, 23);
            this.save.TabIndex = 15;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            // 
            // listObjects
            // 
            this.listObjects.FormattingEnabled = true;
            this.listObjects.Location = new System.Drawing.Point(209, 25);
            this.listObjects.Name = "listObjects";
            this.listObjects.Size = new System.Drawing.Size(331, 212);
            this.listObjects.TabIndex = 16;
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(303, 348);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(113, 23);
            this.change.TabIndex = 17;
            this.change.Text = "Изменить";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // ControlSum
            // 
            this.ControlSum.AutoSize = true;
            this.ControlSum.Location = new System.Drawing.Point(170, 299);
            this.ControlSum.Name = "ControlSum";
            this.ControlSum.Size = new System.Drawing.Size(192, 17);
            this.ControlSum.TabIndex = 18;
            this.ControlSum.Text = "Сохранение контрольной суммы";
            this.ControlSum.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 24);
            this.button1.TabIndex = 19;
            this.button1.Text = "Сериализация";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Serialize_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(368, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 24);
            this.button2.TabIndex = 20;
            this.button2.Text = "Десериализация";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Deserialize_Click);
            // 
            // Plugin
            // 
            this.Plugin.Location = new System.Drawing.Point(402, 299);
            this.Plugin.Name = "Plugin";
            this.Plugin.Size = new System.Drawing.Size(127, 24);
            this.Plugin.TabIndex = 21;
            this.Plugin.Text = "Загрузить Plugin";
            this.Plugin.UseVisualStyleBackColor = true;
            this.Plugin.Click += new System.EventHandler(this.Plugin_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Transformation
            // 
            this.Transformation.AutoSize = true;
            this.Transformation.Location = new System.Drawing.Point(170, 275);
            this.Transformation.Name = "Transformation";
            this.Transformation.Size = new System.Drawing.Size(180, 17);
            this.Transformation.TabIndex = 22;
            this.Transformation.Text = "Преобразование XML в JSON ";
            this.Transformation.UseVisualStyleBackColor = true;
            this.Transformation.CheckedChanged += new System.EventHandler(this.Transformation_CheckedChanged);
            // 
            // Toy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 438);
            this.Controls.Add(this.Transformation);
            this.Controls.Add(this.Plugin);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ControlSum);
            this.Controls.Add(this.change);
            this.Controls.Add(this.listObjects);
            this.Controls.Add(this.save);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PropertyLabel3);
            this.Controls.Add(this.PropertyLabel2);
            this.Controls.Add(this.PropertyLabel1);
            this.Controls.Add(this.FieldComboBox3);
            this.Controls.Add(this.FieldComboBox2);
            this.Controls.Add(this.FieldComboBox1);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.HardLevelLabel);
            this.Controls.Add(this.HardLevelTextBox);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.AgeChildLabel);
            this.Controls.Add(this.NameToyLabel);
            this.Controls.Add(this.ToyLabel);
            this.Controls.Add(this.ToyComboBox);
            this.Name = "Toy";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox ToyComboBox;
        private Label ToyLabel;
        private Label NameToyLabel;
        private Label AgeChildLabel;
        private TextBox AgeTextBox;
        private TextBox HardLevelTextBox;
        private Label HardLevelLabel;
        private TextBox NameTextBox;
        private ComboBox FieldComboBox1;
        private ComboBox FieldComboBox2;
        private ComboBox FieldComboBox3;
        private Label PropertyLabel1;
        private Label PropertyLabel2;
        private Label PropertyLabel3;
        private Button AddButton;
        private ListBox listObjects;
        public Button save;
        private Button change;
        private CheckBox ControlSum;
        private Button button1;
        private Button button2;
        private Button Plugin;
        private OpenFileDialog openFileDialog;
        private CheckBox Transformation;
    }
}

