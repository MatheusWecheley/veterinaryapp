namespace CRUD_PET.Views
{
    partial class PetView
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
            this.labelPet = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.tabPageDetail = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPetColour = new System.Windows.Forms.TextBox();
            this.txtPetType = new System.Windows.Forms.TextBox();
            this.txtPetName = new System.Windows.Forms.TextBox();
            this.txtPetId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPet
            // 
            this.labelPet.AutoSize = true;
            this.labelPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPet.Location = new System.Drawing.Point(27, 9);
            this.labelPet.Name = "labelPet";
            this.labelPet.Size = new System.Drawing.Size(50, 20);
            this.labelPet.TabIndex = 0;
            this.labelPet.Text = "PETS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labelPet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 39);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPageDetail);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(660, 411);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnEdit);
            this.tabPage1.Controls.Add(this.btnAddNew);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Controls.Add(this.txtSearch);
            this.tabPage1.Controls.Add(this.Search);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(652, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pet List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(549, 129);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 26);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(549, 97);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(86, 26);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(549, 65);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(86, 26);
            this.btnAddNew.TabIndex = 4;
            this.btnAddNew.Text = "Add new";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(27, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(516, 312);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(468, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 26);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(27, 33);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(435, 26);
            this.txtSearch.TabIndex = 1;
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Location = new System.Drawing.Point(24, 13);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(82, 17);
            this.Search.TabIndex = 0;
            this.Search.Text = "Search Pet:";
            // 
            // tabPageDetail
            // 
            this.tabPageDetail.Controls.Add(this.pictureBox1);
            this.tabPageDetail.Controls.Add(this.btnCancel);
            this.tabPageDetail.Controls.Add(this.btnSave);
            this.tabPageDetail.Controls.Add(this.txtPetColour);
            this.tabPageDetail.Controls.Add(this.txtPetType);
            this.tabPageDetail.Controls.Add(this.txtPetName);
            this.tabPageDetail.Controls.Add(this.txtPetId);
            this.tabPageDetail.Controls.Add(this.label4);
            this.tabPageDetail.Controls.Add(this.label3);
            this.tabPageDetail.Controls.Add(this.label2);
            this.tabPageDetail.Controls.Add(this.label1);
            this.tabPageDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageDetail.Location = new System.Drawing.Point(4, 22);
            this.tabPageDetail.Name = "tabPageDetail";
            this.tabPageDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDetail.Size = new System.Drawing.Size(652, 385);
            this.tabPageDetail.TabIndex = 1;
            this.tabPageDetail.Text = "Pet Details";
            this.tabPageDetail.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::CRUD_PET.Properties.Resources.gatinhofofo;
            this.pictureBox1.Location = new System.Drawing.Point(448, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 259);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(235, 254);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(176, 50);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(39, 254);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(176, 50);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtPetColour
            // 
            this.txtPetColour.Location = new System.Drawing.Point(249, 174);
            this.txtPetColour.Name = "txtPetColour";
            this.txtPetColour.Size = new System.Drawing.Size(162, 23);
            this.txtPetColour.TabIndex = 7;
            // 
            // txtPetType
            // 
            this.txtPetType.Location = new System.Drawing.Point(249, 65);
            this.txtPetType.Name = "txtPetType";
            this.txtPetType.Size = new System.Drawing.Size(162, 23);
            this.txtPetType.TabIndex = 6;
            // 
            // txtPetName
            // 
            this.txtPetName.Location = new System.Drawing.Point(39, 174);
            this.txtPetName.Name = "txtPetName";
            this.txtPetName.Size = new System.Drawing.Size(162, 23);
            this.txtPetName.TabIndex = 5;
            // 
            // txtPetId
            // 
            this.txtPetId.Location = new System.Drawing.Point(39, 65);
            this.txtPetId.Name = "txtPetId";
            this.txtPetId.Size = new System.Drawing.Size(162, 23);
            this.txtPetId.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pet Colour:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pet Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pet Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pet ID:";
            // 
            // PetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PetView";
            this.Text = "PetView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageDetail.ResumeLayout(false);
            this.tabPageDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.TabPage tabPageDetail;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.TextBox txtPetColour;
        private System.Windows.Forms.TextBox txtPetType;
        private System.Windows.Forms.TextBox txtPetName;
        private System.Windows.Forms.TextBox txtPetId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}