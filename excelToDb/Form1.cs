
using ExcelDataReader;
using excelToDb.Data;
using excelToDb.Data.Context;
using excelToDb.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace excelToDb
{
    public partial class Form1 : Form
    {
        public List<Sample> DataList { get; set; }
        public Form1()
        {
            InitializeComponent();
            DataList = new List<Sample>();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (opDialog.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = opDialog.FileName;
                using (var stream = File.Open(txtFilePath.Text, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        do
                        {
                            while (reader.Read())
                            {
                            }
                        } while (reader.NextResult());

                        var result = reader.AsDataSet();
                        DataTable dtReservation = result.Tables[0];
                        DataTable dtHotels = result.Tables[1];
                        int i, n = dtReservation.Rows.Count;
                        for (i = 1; i < n; i++)
                        {
                            int reservationNo = Convert.ToInt32(dtReservation.Rows[i][0]);
                            DateTime createDate = Convert.ToDateTime(dtReservation.Rows[i][1]);
                            int pax = Convert.ToInt32(dtReservation.Rows[i][2]);
                            int hotelId = Convert.ToInt32(dtReservation.Rows[i][3]);
                            string hotelName = "";
                            int a, b = dtHotels.Rows.Count;
                            for (a = 1; a < b; a++)
                            {
                                if (dtHotels.Rows[a][0].ToString() == hotelId.ToString())
                                {
                                    hotelName = dtHotels.Rows[a][1].ToString();
                                    break;
                                }
                            }
                           
                            DataList.Add(new Sample()
                            {
                                Date = createDate,
                                HotelId = hotelId,
                                HotelName = hotelName,
                                ReservationNumber = reservationNo,
                                TotalPax = pax
                            });

                        }
                    }
                }
                gridControl1.DataSource = DataList;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnSendToDb_Click(object sender, EventArgs e)
        {
            DataContext dbContext = new DataContext();
            for (int i = 0; i < DataList.Count; i++)
            {
                Sample row = DataList[i];
                if (row.Selected == true)
                {
                    dbContext.Samples.Add(row);
                }
             
            }
            dbContext.SaveChanges();
            MessageBox.Show("Aktarım Tamamlandı");
        }
    }
}
