/*
 * Created by SharpDevelop.
 * User: Windows 10
 * Date: 21/05/2022
 * Time: 13:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Modul5
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox Input_id;
		private System.Windows.Forms.Button btnopenupload;
		private System.Windows.Forms.Button btnsaveupload;
		private System.Windows.Forms.Button btnopendownload;
		private System.Windows.Forms.Button btnsavedownload;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.Input_id = new System.Windows.Forms.TextBox();
			this.btnopenupload = new System.Windows.Forms.Button();
			this.btnsaveupload = new System.Windows.Forms.Button();
			this.btnopendownload = new System.Windows.Forms.Button();
			this.btnsavedownload = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Khaki;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(350, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(208, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tes Download File";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Khaki;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(62, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(208, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tes Upload File";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.pictureBox1.Location = new System.Drawing.Point(62, 73);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(208, 152);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.pictureBox2.Location = new System.Drawing.Point(350, 73);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(208, 152);
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.LightGray;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(62, 308);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(496, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Data dari Database pvfile table Tablefile";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Gray;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Transparent;
			this.label4.Location = new System.Drawing.Point(350, 205);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(110, 20);
			this.label4.TabIndex = 5;
			this.label4.Text = "Input id gambar";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Input_id
			// 
			this.Input_id.BackColor = System.Drawing.SystemColors.Menu;
			this.Input_id.Location = new System.Drawing.Point(458, 206);
			this.Input_id.Name = "Input_id";
			this.Input_id.Size = new System.Drawing.Size(100, 20);
			this.Input_id.TabIndex = 6;
			// 
			// btnopenupload
			// 
			this.btnopenupload.BackColor = System.Drawing.Color.Aqua;
			this.btnopenupload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnopenupload.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnopenupload.Location = new System.Drawing.Point(80, 254);
			this.btnopenupload.Name = "btnopenupload";
			this.btnopenupload.Size = new System.Drawing.Size(75, 32);
			this.btnopenupload.TabIndex = 7;
			this.btnopenupload.Text = "Open File";
			this.btnopenupload.UseVisualStyleBackColor = false;
			this.btnopenupload.Click += new System.EventHandler(this.BtnopenuploadClick);
			// 
			// btnsaveupload
			// 
			this.btnsaveupload.BackColor = System.Drawing.Color.Lime;
			this.btnsaveupload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnsaveupload.Location = new System.Drawing.Point(178, 254);
			this.btnsaveupload.Name = "btnsaveupload";
			this.btnsaveupload.Size = new System.Drawing.Size(75, 32);
			this.btnsaveupload.TabIndex = 8;
			this.btnsaveupload.Text = "Save File";
			this.btnsaveupload.UseVisualStyleBackColor = false;
			this.btnsaveupload.Click += new System.EventHandler(this.BtnsaveuploadClick);
			// 
			// btnopendownload
			// 
			this.btnopendownload.BackColor = System.Drawing.Color.Aqua;
			this.btnopendownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnopendownload.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnopendownload.Location = new System.Drawing.Point(371, 254);
			this.btnopendownload.Name = "btnopendownload";
			this.btnopendownload.Size = new System.Drawing.Size(76, 32);
			this.btnopendownload.TabIndex = 9;
			this.btnopendownload.Text = "Open File";
			this.btnopendownload.UseVisualStyleBackColor = false;
			this.btnopendownload.Click += new System.EventHandler(this.BtnopendownloadClick);
			// 
			// btnsavedownload
			// 
			this.btnsavedownload.BackColor = System.Drawing.Color.Lime;
			this.btnsavedownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnsavedownload.Location = new System.Drawing.Point(470, 254);
			this.btnsavedownload.Name = "btnsavedownload";
			this.btnsavedownload.Size = new System.Drawing.Size(75, 32);
			this.btnsavedownload.TabIndex = 10;
			this.btnsavedownload.Text = "Save File";
			this.btnsavedownload.UseVisualStyleBackColor = false;
			this.btnsavedownload.Click += new System.EventHandler(this.BtnsavedownloadClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(62, 334);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(496, 187);
			this.dataGridView1.TabIndex = 11;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(616, 533);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnsavedownload);
			this.Controls.Add(this.btnopendownload);
			this.Controls.Add(this.btnsaveupload);
			this.Controls.Add(this.btnopenupload);
			this.Controls.Add(this.Input_id);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Modul5";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
