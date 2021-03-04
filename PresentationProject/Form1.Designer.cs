
namespace PresentationProject
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
            this.DataVeiwOutput = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstNameAnswer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LastNameAnswer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CityAnswer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CountryAnswer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PhoneNumberAnswer = new System.Windows.Forms.TextBox();
            this.AddNew = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.LastNameToBeFound = new System.Windows.Forms.TextBox();
            this.FindLastName = new System.Windows.Forms.Button();
            this.SearchType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LastNameToBeRemoved = new System.Windows.Forms.TextBox();
            this.RemoveFromList = new System.Windows.Forms.Button();
            this.FindLastNameToBeRemoved = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataVeiwOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // DataVeiwOutput
            // 
            this.DataVeiwOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataVeiwOutput.Location = new System.Drawing.Point(13, 118);
            this.DataVeiwOutput.Name = "DataVeiwOutput";
            this.DataVeiwOutput.RowTemplate.Height = 25;
            this.DataVeiwOutput.Size = new System.Drawing.Size(775, 320);
            this.DataVeiwOutput.TabIndex = 0;
            this.DataVeiwOutput.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataVeiwOutput_CellValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add new";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name *";
            // 
            // FirstNameAnswer
            // 
            this.FirstNameAnswer.Location = new System.Drawing.Point(0, 32);
            this.FirstNameAnswer.Name = "FirstNameAnswer";
            this.FirstNameAnswer.Size = new System.Drawing.Size(100, 23);
            this.FirstNameAnswer.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name *";
            // 
            // LastNameAnswer
            // 
            this.LastNameAnswer.Location = new System.Drawing.Point(135, 31);
            this.LastNameAnswer.Name = "LastNameAnswer";
            this.LastNameAnswer.Size = new System.Drawing.Size(100, 23);
            this.LastNameAnswer.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "City";
            // 
            // CityAnswer
            // 
            this.CityAnswer.Location = new System.Drawing.Point(264, 31);
            this.CityAnswer.Name = "CityAnswer";
            this.CityAnswer.Size = new System.Drawing.Size(100, 23);
            this.CityAnswer.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Country";
            // 
            // CountryAnswer
            // 
            this.CountryAnswer.Location = new System.Drawing.Point(406, 31);
            this.CountryAnswer.Name = "CountryAnswer";
            this.CountryAnswer.Size = new System.Drawing.Size(100, 23);
            this.CountryAnswer.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(551, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Phone Number";
            // 
            // PhoneNumberAnswer
            // 
            this.PhoneNumberAnswer.Location = new System.Drawing.Point(551, 31);
            this.PhoneNumberAnswer.Name = "PhoneNumberAnswer";
            this.PhoneNumberAnswer.Size = new System.Drawing.Size(100, 23);
            this.PhoneNumberAnswer.TabIndex = 11;
            // 
            // AddNew
            // 
            this.AddNew.Location = new System.Drawing.Point(689, 31);
            this.AddNew.Name = "AddNew";
            this.AddNew.Size = new System.Drawing.Size(75, 23);
            this.AddNew.TabIndex = 12;
            this.AddNew.Text = "Add to List";
            this.AddNew.UseVisualStyleBackColor = true;
            this.AddNew.Click += new System.EventHandler(this.AddNew_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Search";
            // 
            // LastNameToBeFound
            // 
            this.LastNameToBeFound.Location = new System.Drawing.Point(551, 80);
            this.LastNameToBeFound.Name = "LastNameToBeFound";
            this.LastNameToBeFound.Size = new System.Drawing.Size(100, 23);
            this.LastNameToBeFound.TabIndex = 14;
            // 
            // FindLastName
            // 
            this.FindLastName.Location = new System.Drawing.Point(689, 79);
            this.FindLastName.Name = "FindLastName";
            this.FindLastName.Size = new System.Drawing.Size(75, 23);
            this.FindLastName.TabIndex = 15;
            this.FindLastName.Text = "Find";
            this.FindLastName.UseVisualStyleBackColor = true;
            this.FindLastName.Click += new System.EventHandler(this.FindLastName_Click);
            // 
            // SearchType
            // 
            this.SearchType.FormattingEnabled = true;
            this.SearchType.Items.AddRange(new object[] {
            "All",
            "Last Name",
            "City",
            "Last Name (char)"});
            this.SearchType.Location = new System.Drawing.Point(406, 79);
            this.SearchType.Name = "SearchType";
            this.SearchType.Size = new System.Drawing.Size(121, 23);
            this.SearchType.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Removing";
            // 
            // LastNameToBeRemoved
            // 
            this.LastNameToBeRemoved.Location = new System.Drawing.Point(0, 79);
            this.LastNameToBeRemoved.Name = "LastNameToBeRemoved";
            this.LastNameToBeRemoved.Size = new System.Drawing.Size(142, 23);
            this.LastNameToBeRemoved.TabIndex = 18;
            // 
            // RemoveFromList
            // 
            this.RemoveFromList.Enabled = false;
            this.RemoveFromList.Location = new System.Drawing.Point(264, 80);
            this.RemoveFromList.Name = "RemoveFromList";
            this.RemoveFromList.Size = new System.Drawing.Size(75, 23);
            this.RemoveFromList.TabIndex = 19;
            this.RemoveFromList.Text = "Remove";
            this.RemoveFromList.UseVisualStyleBackColor = true;
            this.RemoveFromList.Click += new System.EventHandler(this.RemoveFromList_Click);
            // 
            // FindLastNameToBeRemoved
            // 
            this.FindLastNameToBeRemoved.Location = new System.Drawing.Point(149, 78);
            this.FindLastNameToBeRemoved.Name = "FindLastNameToBeRemoved";
            this.FindLastNameToBeRemoved.Size = new System.Drawing.Size(75, 23);
            this.FindLastNameToBeRemoved.TabIndex = 20;
            this.FindLastNameToBeRemoved.Text = "Find";
            this.FindLastNameToBeRemoved.UseVisualStyleBackColor = true;
            this.FindLastNameToBeRemoved.Click += new System.EventHandler(this.FindLastNameToBeRemoved_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FindLastNameToBeRemoved);
            this.Controls.Add(this.RemoveFromList);
            this.Controls.Add(this.LastNameToBeRemoved);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SearchType);
            this.Controls.Add(this.FindLastName);
            this.Controls.Add(this.LastNameToBeFound);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AddNew);
            this.Controls.Add(this.PhoneNumberAnswer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CountryAnswer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CityAnswer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LastNameAnswer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FirstNameAnswer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataVeiwOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataVeiwOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataVeiwOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FirstNameAnswer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LastNameAnswer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CityAnswer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CountryAnswer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PhoneNumberAnswer;
        private System.Windows.Forms.Button AddNew;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox LastNameToBeFound;
        private System.Windows.Forms.Button FindLastName;
        private System.Windows.Forms.ComboBox SearchType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox LastNameToBeRemoved;
        private System.Windows.Forms.Button RemoveFromList;
        private System.Windows.Forms.Button FindLastNameToBeRemoved;
    }
}

