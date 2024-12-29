namespace Adressbok
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
            textBoxName = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPostalCode = new TextBox();
            textBoxAddress = new TextBox();
            textBoxCity = new TextBox();
            labelName = new Label();
            labelStreetAddress = new Label();
            labelPostalCode = new Label();
            labelCity = new Label();
            labelEmail = new Label();
            buttonSave = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            buttonSearch = new Button();
            textBoxPhone = new TextBox();
            labelTelephone = new Label();
            listViewResult = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeaderName = new ColumnHeader();
            columnHeaderAddress = new ColumnHeader();
            columnHeaderPostcalCode = new ColumnHeader();
            columnHeaderCity = new ColumnHeader();
            columnHeaderEmail = new ColumnHeader();
            columnHeaderPhone = new ColumnHeader();
            textBoxSearchName = new TextBox();
            textBoxSearchCity = new TextBox();
            groupBoxSearch = new GroupBox();
            groupBoxSearch.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(84, 66);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(490, 35);
            textBoxName.TabIndex = 0;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(84, 412);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(490, 35);
            textBoxEmail.TabIndex = 4;
            // 
            // textBoxPostalCode
            // 
            textBoxPostalCode.Location = new Point(84, 289);
            textBoxPostalCode.Name = "textBoxPostalCode";
            textBoxPostalCode.Size = new Size(160, 35);
            textBoxPostalCode.TabIndex = 2;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(84, 178);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(490, 35);
            textBoxAddress.TabIndex = 1;
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(273, 289);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(301, 35);
            textBoxCity.TabIndex = 3;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(84, 33);
            labelName.Name = "labelName";
            labelName.Size = new Size(70, 30);
            labelName.TabIndex = 5;
            labelName.Text = "Namn";
            // 
            // labelStreetAddress
            // 
            labelStreetAddress.AutoSize = true;
            labelStreetAddress.Location = new Point(84, 145);
            labelStreetAddress.Name = "labelStreetAddress";
            labelStreetAddress.Size = new Size(116, 30);
            labelStreetAddress.TabIndex = 6;
            labelStreetAddress.Text = "Gatuadress";
            // 
            // labelPostalCode
            // 
            labelPostalCode.AutoSize = true;
            labelPostalCode.Location = new Point(84, 256);
            labelPostalCode.Name = "labelPostalCode";
            labelPostalCode.Size = new Size(130, 30);
            labelPostalCode.TabIndex = 7;
            labelPostalCode.Text = "Postnummer";
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Location = new Point(273, 256);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(88, 30);
            labelCity.TabIndex = 8;
            labelCity.Text = "Post Ort";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(84, 379);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(64, 30);
            labelEmail.TabIndex = 9;
            labelEmail.Text = "Epost";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(74, 636);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(131, 40);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Spara";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(294, 636);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(131, 40);
            buttonUpdate.TabIndex = 7;
            buttonUpdate.Text = "Uppdatera";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(505, 636);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(131, 40);
            buttonDelete.TabIndex = 8;
            buttonDelete.Text = "Radera";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(854, 70);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(131, 40);
            buttonSearch.TabIndex = 9;
            buttonSearch.Text = "Sök";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(84, 511);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(490, 35);
            textBoxPhone.TabIndex = 5;
            // 
            // labelTelephone
            // 
            labelTelephone.AutoSize = true;
            labelTelephone.Location = new Point(84, 478);
            labelTelephone.Name = "labelTelephone";
            labelTelephone.Size = new Size(80, 30);
            labelTelephone.TabIndex = 16;
            labelTelephone.Text = "Telefon";
            // 
            // listViewResult
            // 
            listViewResult.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeaderName, columnHeaderAddress, columnHeaderPostcalCode, columnHeaderCity, columnHeaderEmail, columnHeaderPhone });
            listViewResult.FullRowSelect = true;
            listViewResult.GridLines = true;
            listViewResult.Location = new Point(709, 33);
            listViewResult.Name = "listViewResult";
            listViewResult.Size = new Size(1129, 513);
            listViewResult.TabIndex = 17;
            listViewResult.UseCompatibleStateImageBehavior = false;
            listViewResult.View = View.Details;
            listViewResult.SelectedIndexChanged += listViewResult_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.DisplayIndex = 6;
            columnHeader1.Width = 0;
            // 
            // columnHeaderName
            // 
            columnHeaderName.DisplayIndex = 0;
            columnHeaderName.Text = "Namn";
            columnHeaderName.Width = 200;
            // 
            // columnHeaderAddress
            // 
            columnHeaderAddress.DisplayIndex = 1;
            columnHeaderAddress.Text = "Gatuadress";
            columnHeaderAddress.Width = 220;
            // 
            // columnHeaderPostcalCode
            // 
            columnHeaderPostcalCode.DisplayIndex = 2;
            columnHeaderPostcalCode.Text = "Postnummer";
            columnHeaderPostcalCode.Width = 130;
            // 
            // columnHeaderCity
            // 
            columnHeaderCity.DisplayIndex = 3;
            columnHeaderCity.Text = "Post Ort";
            columnHeaderCity.Width = 175;
            // 
            // columnHeaderEmail
            // 
            columnHeaderEmail.DisplayIndex = 4;
            columnHeaderEmail.Text = "Epost";
            columnHeaderEmail.Width = 250;
            // 
            // columnHeaderPhone
            // 
            columnHeaderPhone.DisplayIndex = 5;
            columnHeaderPhone.Text = "Telefon";
            columnHeaderPhone.Width = 150;
            // 
            // textBoxSearchName
            // 
            textBoxSearchName.Location = new Point(6, 46);
            textBoxSearchName.Name = "textBoxSearchName";
            textBoxSearchName.PlaceholderText = "Sök på namn...";
            textBoxSearchName.Size = new Size(374, 35);
            textBoxSearchName.TabIndex = 18;
            // 
            // textBoxSearchCity
            // 
            textBoxSearchCity.Location = new Point(408, 46);
            textBoxSearchCity.Name = "textBoxSearchCity";
            textBoxSearchCity.PlaceholderText = "Sök på postort...";
            textBoxSearchCity.Size = new Size(374, 35);
            textBoxSearchCity.TabIndex = 19;
            // 
            // groupBoxSearch
            // 
            groupBoxSearch.Controls.Add(textBoxSearchName);
            groupBoxSearch.Controls.Add(textBoxSearchCity);
            groupBoxSearch.Controls.Add(buttonSearch);
            groupBoxSearch.Location = new Point(709, 560);
            groupBoxSearch.Name = "groupBoxSearch";
            groupBoxSearch.Size = new Size(1014, 116);
            groupBoxSearch.TabIndex = 20;
            groupBoxSearch.TabStop = false;
            groupBoxSearch.Text = "Sök";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1961, 865);
            Controls.Add(groupBoxSearch);
            Controls.Add(listViewResult);
            Controls.Add(labelTelephone);
            Controls.Add(textBoxPhone);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonSave);
            Controls.Add(labelEmail);
            Controls.Add(labelCity);
            Controls.Add(labelPostalCode);
            Controls.Add(labelStreetAddress);
            Controls.Add(labelName);
            Controls.Add(textBoxCity);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxPostalCode);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxName);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adressbok";
            groupBoxSearch.ResumeLayout(false);
            groupBoxSearch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxEmail;
        private TextBox textBoxPostalCode;
        private TextBox textBoxAddress;
        private TextBox textBoxCity;
        private Label labelName;
        private Label labelStreetAddress;
        private Label labelPostalCode;
        private Label labelCity;
        private Label labelEmail;
        private Button buttonSave;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Button buttonSearch;
        private TextBox textBoxResult;
        private TextBox textBoxPhone;
        private Label labelTelephone;
        private ListView listViewResult;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderAddress;
        private ColumnHeader columnHeaderPostcalCode;
        private ColumnHeader columnHeaderCity;
        private ColumnHeader columnHeaderEmail;
        private ColumnHeader columnHeaderPhone;
        private ColumnHeader columnHeader1;
        private TextBox textBoxSearchName;
        private TextBox textBoxSearchCity;
        private GroupBox groupBoxSearch;
    }
}
