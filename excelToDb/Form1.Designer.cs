
namespace excelToDb
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.opDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.txtFilePath = new DevExpress.XtraEditors.TextEdit();
            this.lblFileName = new DevExpress.XtraEditors.LabelControl();
            this.btnSend = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSelected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHotelId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHotelName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReservationNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSendToDb = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtFilePath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // opDialog
            // 
            this.opDialog.DefaultExt = "*.xls,*.xlsx";
            this.opDialog.FileName = "openFileDialog1";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(907, 96);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(94, 29);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Gözat";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilePath.Location = new System.Drawing.Point(83, 100);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(818, 22);
            this.txtFilePath.TabIndex = 1;
            // 
            // lblFileName
            // 
            this.lblFileName.Location = new System.Drawing.Point(12, 103);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(62, 16);
            this.lblFileName.TabIndex = 3;
            this.lblFileName.Text = "Dosya Yolu";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(1007, 96);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(94, 29);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Excelden Aktar";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.bindingSource1;
            this.gridControl1.Location = new System.Drawing.Point(12, 144);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1089, 445);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(excelToDb.Data.Entities.Sample);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSelected,
            this.colHotelId,
            this.colHotelName,
            this.colDate,
            this.colTotalPax,
            this.colReservationNumber});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colSelected
            // 
            this.colSelected.Caption = "Select";
            this.colSelected.FieldName = "Selected";
            this.colSelected.MinWidth = 25;
            this.colSelected.Name = "colSelected";
            this.colSelected.Visible = true;
            this.colSelected.VisibleIndex = 0;
            this.colSelected.Width = 94;
            // 
            // colHotelId
            // 
            this.colHotelId.FieldName = "HotelId";
            this.colHotelId.MinWidth = 25;
            this.colHotelId.Name = "colHotelId";
            this.colHotelId.OptionsColumn.ReadOnly = true;
            this.colHotelId.Visible = true;
            this.colHotelId.VisibleIndex = 1;
            this.colHotelId.Width = 94;
            // 
            // colHotelName
            // 
            this.colHotelName.FieldName = "HotelName";
            this.colHotelName.MinWidth = 25;
            this.colHotelName.Name = "colHotelName";
            this.colHotelName.OptionsColumn.ReadOnly = true;
            this.colHotelName.Visible = true;
            this.colHotelName.VisibleIndex = 2;
            this.colHotelName.Width = 94;
            // 
            // colDate
            // 
            this.colDate.FieldName = "Date";
            this.colDate.MinWidth = 25;
            this.colDate.Name = "colDate";
            this.colDate.OptionsColumn.ReadOnly = true;
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 3;
            this.colDate.Width = 94;
            // 
            // colTotalPax
            // 
            this.colTotalPax.FieldName = "TotalPax";
            this.colTotalPax.MinWidth = 25;
            this.colTotalPax.Name = "colTotalPax";
            this.colTotalPax.OptionsColumn.ReadOnly = true;
            this.colTotalPax.Visible = true;
            this.colTotalPax.VisibleIndex = 4;
            this.colTotalPax.Width = 94;
            // 
            // colReservationNumber
            // 
            this.colReservationNumber.FieldName = "ReservationNumber";
            this.colReservationNumber.MinWidth = 25;
            this.colReservationNumber.Name = "colReservationNumber";
            this.colReservationNumber.OptionsColumn.ReadOnly = true;
            this.colReservationNumber.Visible = true;
            this.colReservationNumber.VisibleIndex = 5;
            this.colReservationNumber.Width = 94;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 657);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1112, 26);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(94, 20);
            this.toolStripStatusLabel1.Text = "İsmail Sargın";
            // 
            // btnSendToDb
            // 
            this.btnSendToDb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendToDb.Location = new System.Drawing.Point(12, 609);
            this.btnSendToDb.Name = "btnSendToDb";
            this.btnSendToDb.Size = new System.Drawing.Size(178, 29);
            this.btnSendToDb.TabIndex = 7;
            this.btnSendToDb.Text = "Seçilenleri Aktar";
            this.btnSendToDb.Click += new System.EventHandler(this.btnSendToDb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 683);
            this.Controls.Add(this.btnSendToDb);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnBrowse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtFilePath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog opDialog;
        private DevExpress.XtraEditors.SimpleButton btnBrowse;
        private DevExpress.XtraEditors.TextEdit txtFilePath;
        private DevExpress.XtraEditors.LabelControl lblFileName;
        private DevExpress.XtraEditors.SimpleButton btnSend;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colHotelId;
        private DevExpress.XtraGrid.Columns.GridColumn colHotelName;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPax;
        private DevExpress.XtraGrid.Columns.GridColumn colReservationNumber;
        private DevExpress.XtraEditors.SimpleButton btnSendToDb;
        private DevExpress.XtraGrid.Columns.GridColumn colSelected;
    }
}

