/*
 * Created by SharpDevelop.
 * User: Windows 10
 * Date: 21/05/2022
 * Time: 13:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 
 /*====================================================================
   1. Memanggil Library yang akan digunakan dalam menjalankan program
  ====================================================================*/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;

namespace Modul5
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		/*====================================================================
		   2. Menghubungkan MySql terhadap SharpDeveloper serta 
			  mendeklarasikan variabel di program
		 ====================================================================*/
		string connectionSQL = "server=localhost; database=filepv; uid=root; password=;";
		Bitmap img;
		string pathimg;
		string SourceFilePath;
		string inputid;
		int intinputid;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		/*====================================================================
		   3. Mengupload File pada UploadFile
		 ====================================================================*/
		void BtnopenuploadClick(object sender, EventArgs e)
		{
			if(DialogResult.OK == openFileDialog1.ShowDialog())
			{
				img = new Bitmap(openFileDialog1.FileName);
				pictureBox1.Image=img;
				pathimg=openFileDialog1.FileName.ToString();
			}
		}
		
		/*====================================================================
		   	4. Menyimpan File pada UploadFile
		 ====================================================================*/
		void BtnsaveuploadClick(object sender, EventArgs e)
		{
			File2SqlBlob(pathimg);
			readData();
		}
		
		private void File2SqlBlob(string SourceFilePath){
			try{
				MySqlConnection koneksi = new MySqlConnection(connectionSQL);
				MySqlCommand cmd = new MySqlCommand("INSERT into tablefile(id,DataFile) values ("+incrementValueId()+",?Picture)", koneksi);
				System.IO.FileStream fs = new System.IO.FileStream(SourceFilePath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
				Byte[] b = new Byte[fs.Length];
				fs.Read(b, 0, b.Length);
				fs.Close();
				MySqlParameter P = new MySqlParameter("?picture", MySqlDbType.LongBlob, b.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, b);
				cmd.Parameters.Add(P);
				
				koneksi.Open();
				
				if(cmd.ExecuteNonQuery() == 1)
					MessageBox.Show("Gambar berhasil disimpan di database");
				koneksi.Close();
			}
			
			catch(MySqlException ex){
				MessageBox.Show(ex.Message);
			}
				readData();
		}//tutup method
		
		/*====================================================================
		   	5. Mengupload File pada DownloadFile
		 ====================================================================*/
		void BtnopendownloadClick(object sender, EventArgs e)
		{
			try{
				MySqlConnection koneksi = new MySqlConnection(connectionSQL);
				koneksi.Open();
				
				MySqlDataAdapter dataAdapter = new MySqlDataAdapter(new MySqlCommand("SELECT DataFile FROM tablefile WHERE Id ="+Input_id.Text, koneksi));
				DataSet dataSet = new DataSet();
				dataAdapter.Fill(dataSet);
				
				if(dataSet.Tables[0].Rows.Count == 1){
					Byte[] data = new Byte[0];
					data = (Byte[])(dataSet.Tables[0].Rows[0]["DataFile"]);
					MemoryStream mem = new MemoryStream(data);
					pictureBox2.Image = Image.FromStream(mem);
				}
				
				koneksi.Close();
				
			}
			
			catch(Exception ex){
				MessageBox.Show(ex.Message);
			}
		}  //tutup method
		
		/*====================================================================
		   	6. Menyimpan File pada DownloadFile
		 ====================================================================*/
		void BtnsavedownloadClick(object sender, EventArgs e)
		{
			DialogResult dr = saveFileDialog1.ShowDialog();
			if(dr == DialogResult.OK)
			{
				SaveFileDialog sfd = new SaveFileDialog();
				sfd.Filter = "Images|.png;.bmp;*.jpg";
				ImageFormat format = ImageFormat.Png;
				if(sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK){
					string ext = System.IO.Path.GetExtension(sfd.FileName);
					switch (ext){
						case ".jpg":
							format = ImageFormat.Jpeg;
							break;
						case ".bmp":
							format = ImageFormat.Bmp;
							break;
					} //tutup switch case
				}
			}
		}
		
		/*====================================================================
		   	7. Membuat Method Incerement  
		====================================================================*/
		private int incrementValueId(){ //untuk menambahkan index id
			
			int temp = 0;
			
			/*====================================================================
			  - Melakukan quarry Sql data image dengan melakukan adapter dari 
				database sehingga dapat membuka file dengan berdasarkan id yang 
				diinputkan user ke dalam variabel Sql
			  - Jika terjadi error, maka akan dialihkan ke variabel catch err
			 ====================================================================*/
			try{
				MySqlConnection db = new MySqlConnection(connectionSQL);
				db.Open();
				MySqlCommand dbcmd = db.CreateCommand();
				string sql = "SELECT max(Id) from tablefile";
				dbcmd.CommandText = sql;
				MySqlDataReader reader = dbcmd.ExecuteReader();
				while(reader.Read()){
					if(!reader.IsDBNull(0)){
						return Convert.ToInt16(reader.GetString(0))+1;
					}
				}
				return 0;
			}
			
			catch (MySqlException err){
				MessageBox.Show(err.ToString());
				return 0;
			}
		}
		
		/*====================================================================
		   	8. Membuat Method ReadData  
		====================================================================*/
		public void readData(){
			/*====================================================================
			  - Membuat koneksi ke database MySql agar dapat membaca data sehingga
			  	data pada database bisa ditampilkan
			 ====================================================================*/
			MySqlConnection koneksi = new MySqlConnection(connectionSQL);
			koneksi.Open();
			DataTable dt = new DataTable();
			MySqlDataAdapter da = new MySqlDataAdapter("SELECT * from tablefile", koneksi);
			da.Fill(dt);
			dataGridView1.DataSource = dt.DefaultView;
			koneksi.Close();                           
		}
	}
}
