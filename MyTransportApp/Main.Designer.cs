
namespace MyTransportApp
{
  partial class Main
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      this.splitInOut = new System.Windows.Forms.SplitContainer();
      this.timeDeparture = new System.Windows.Forms.DateTimePicker();
      this.chkStationBoard = new System.Windows.Forms.CheckBox();
      this.cbxTo = new System.Windows.Forms.ComboBox();
      this.lblDate = new System.Windows.Forms.Label();
      this.dateDeparture = new System.Windows.Forms.DateTimePicker();
      this.cbxFrom = new System.Windows.Forms.ComboBox();
      this.btnStop = new System.Windows.Forms.Button();
      this.btnSearch = new System.Windows.Forms.Button();
      this.lblTo = new System.Windows.Forms.Label();
      this.lblFrom = new System.Windows.Forms.Label();
      this.splitDataGrid = new System.Windows.Forms.SplitContainer();
      this.dataGridConnections = new System.Windows.Forms.DataGridView();
      this.rowDepartureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.rowFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.rowTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.rowArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.rowDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridStationBoard = new System.Windows.Forms.DataGridView();
      this.rowDeparture = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.rowTrack = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.rowDestinationStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.splitInOut)).BeginInit();
      this.splitInOut.Panel1.SuspendLayout();
      this.splitInOut.Panel2.SuspendLayout();
      this.splitInOut.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitDataGrid)).BeginInit();
      this.splitDataGrid.Panel1.SuspendLayout();
      this.splitDataGrid.Panel2.SuspendLayout();
      this.splitDataGrid.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridConnections)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridStationBoard)).BeginInit();
      this.SuspendLayout();
      // 
      // splitInOut
      // 
      this.splitInOut.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitInOut.Location = new System.Drawing.Point(0, 0);
      this.splitInOut.Name = "splitInOut";
      this.splitInOut.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitInOut.Panel1
      // 
      this.splitInOut.Panel1.Controls.Add(this.timeDeparture);
      this.splitInOut.Panel1.Controls.Add(this.chkStationBoard);
      this.splitInOut.Panel1.Controls.Add(this.cbxTo);
      this.splitInOut.Panel1.Controls.Add(this.lblDate);
      this.splitInOut.Panel1.Controls.Add(this.dateDeparture);
      this.splitInOut.Panel1.Controls.Add(this.cbxFrom);
      this.splitInOut.Panel1.Controls.Add(this.btnStop);
      this.splitInOut.Panel1.Controls.Add(this.btnSearch);
      this.splitInOut.Panel1.Controls.Add(this.lblTo);
      this.splitInOut.Panel1.Controls.Add(this.lblFrom);
      // 
      // splitInOut.Panel2
      // 
      this.splitInOut.Panel2.Controls.Add(this.splitDataGrid);
      this.splitInOut.Size = new System.Drawing.Size(800, 689);
      this.splitInOut.SplitterDistance = 165;
      this.splitInOut.TabIndex = 0;
      // 
      // timeDeparture
      // 
      this.timeDeparture.CustomFormat = "HH:mm";
      this.timeDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.timeDeparture.Location = new System.Drawing.Point(258, 128);
      this.timeDeparture.Name = "timeDeparture";
      this.timeDeparture.ShowUpDown = true;
      this.timeDeparture.Size = new System.Drawing.Size(103, 20);
      this.timeDeparture.TabIndex = 4;
      // 
      // chkStationBoard
      // 
      this.chkStationBoard.AutoSize = true;
      this.chkStationBoard.Location = new System.Drawing.Point(539, 128);
      this.chkStationBoard.Name = "chkStationBoard";
      this.chkStationBoard.Size = new System.Drawing.Size(104, 17);
      this.chkStationBoard.TabIndex = 7;
      this.chkStationBoard.Text = "Departure Board";
      this.chkStationBoard.UseVisualStyleBackColor = true;
      this.chkStationBoard.CheckedChanged += new System.EventHandler(this.StationBoardActive);
      // 
      // cbxTo
      // 
      this.cbxTo.FormattingEnabled = true;
      this.cbxTo.Location = new System.Drawing.Point(69, 80);
      this.cbxTo.Name = "cbxTo";
      this.cbxTo.Size = new System.Drawing.Size(139, 21);
      this.cbxTo.TabIndex = 2;
      this.cbxTo.TextUpdate += new System.EventHandler(this.InputDestination_Changed);
      // 
      // lblDate
      // 
      this.lblDate.AutoSize = true;
      this.lblDate.Location = new System.Drawing.Point(21, 135);
      this.lblDate.Name = "lblDate";
      this.lblDate.Size = new System.Drawing.Size(33, 13);
      this.lblDate.TabIndex = 9;
      this.lblDate.Text = "Date:";
      // 
      // dateDeparture
      // 
      this.dateDeparture.CustomFormat = "";
      this.dateDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dateDeparture.Location = new System.Drawing.Point(69, 128);
      this.dateDeparture.MaxDate = new System.DateTime(2021, 4, 15, 21, 25, 9, 0);
      this.dateDeparture.MinDate = new System.DateTime(2021, 4, 15, 0, 0, 0, 0);
      this.dateDeparture.Name = "dateDeparture";
      this.dateDeparture.Size = new System.Drawing.Size(182, 20);
      this.dateDeparture.TabIndex = 3;
      this.dateDeparture.Value = new System.DateTime(2021, 4, 15, 0, 0, 0, 0);
      // 
      // cbxFrom
      // 
      this.cbxFrom.FormattingEnabled = true;
      this.cbxFrom.Location = new System.Drawing.Point(69, 45);
      this.cbxFrom.Name = "cbxFrom";
      this.cbxFrom.Size = new System.Drawing.Size(139, 21);
      this.cbxFrom.TabIndex = 1;
      this.cbxFrom.TextUpdate += new System.EventHandler(this.InputDeparture_Changed);
      // 
      // btnStop
      // 
      this.btnStop.Location = new System.Drawing.Point(539, 79);
      this.btnStop.Name = "btnStop";
      this.btnStop.Size = new System.Drawing.Size(142, 23);
      this.btnStop.TabIndex = 6;
      this.btnStop.Text = "Stop";
      this.btnStop.UseVisualStyleBackColor = true;
      this.btnStop.Click += new System.EventHandler(this.Stop);
      // 
      // btnSearch
      // 
      this.btnSearch.Location = new System.Drawing.Point(539, 45);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(142, 23);
      this.btnSearch.TabIndex = 5;
      this.btnSearch.Text = "Search Connections";
      this.btnSearch.UseVisualStyleBackColor = true;
      this.btnSearch.Click += new System.EventHandler(this.search);
      this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search);
      // 
      // lblTo
      // 
      this.lblTo.AutoSize = true;
      this.lblTo.Location = new System.Drawing.Point(19, 89);
      this.lblTo.Name = "lblTo";
      this.lblTo.Size = new System.Drawing.Size(23, 13);
      this.lblTo.TabIndex = 3;
      this.lblTo.Text = "To:";
      // 
      // lblFrom
      // 
      this.lblFrom.AutoSize = true;
      this.lblFrom.Location = new System.Drawing.Point(18, 45);
      this.lblFrom.Name = "lblFrom";
      this.lblFrom.Size = new System.Drawing.Size(36, 13);
      this.lblFrom.TabIndex = 1;
      this.lblFrom.Text = "From: ";
      // 
      // splitDataGrid
      // 
      this.splitDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitDataGrid.Location = new System.Drawing.Point(0, 0);
      this.splitDataGrid.Name = "splitDataGrid";
      // 
      // splitDataGrid.Panel1
      // 
      this.splitDataGrid.Panel1.Controls.Add(this.dataGridConnections);
      // 
      // splitDataGrid.Panel2
      // 
      this.splitDataGrid.Panel2.Controls.Add(this.dataGridStationBoard);
      this.splitDataGrid.Size = new System.Drawing.Size(800, 520);
      this.splitDataGrid.SplitterDistance = 483;
      this.splitDataGrid.TabIndex = 0;
      // 
      // dataGridConnections
      // 
      this.dataGridConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridConnections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowDepartureTime,
            this.rowFrom,
            this.rowTo,
            this.rowArrivalTime,
            this.rowDuration});
      this.dataGridConnections.Location = new System.Drawing.Point(3, 0);
      this.dataGridConnections.Name = "dataGridConnections";
      this.dataGridConnections.ReadOnly = true;
      this.dataGridConnections.RowHeadersVisible = false;
      this.dataGridConnections.Size = new System.Drawing.Size(472, 517);
      this.dataGridConnections.TabIndex = 7;
      // 
      // rowDepartureTime
      // 
      this.rowDepartureTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.rowDepartureTime.HeaderText = "Departure Time";
      this.rowDepartureTime.Name = "rowDepartureTime";
      this.rowDepartureTime.ReadOnly = true;
      // 
      // rowFrom
      // 
      this.rowFrom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.rowFrom.HeaderText = "From";
      this.rowFrom.Name = "rowFrom";
      this.rowFrom.ReadOnly = true;
      // 
      // rowTo
      // 
      this.rowTo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.rowTo.HeaderText = "To";
      this.rowTo.Name = "rowTo";
      this.rowTo.ReadOnly = true;
      // 
      // rowArrivalTime
      // 
      this.rowArrivalTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.rowArrivalTime.HeaderText = "Arrival Time";
      this.rowArrivalTime.Name = "rowArrivalTime";
      this.rowArrivalTime.ReadOnly = true;
      // 
      // rowDuration
      // 
      this.rowDuration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.rowDuration.HeaderText = "Duration";
      this.rowDuration.Name = "rowDuration";
      this.rowDuration.ReadOnly = true;
      // 
      // dataGridStationBoard
      // 
      this.dataGridStationBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridStationBoard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowDeparture,
            this.rowTrack,
            this.rowDestinationStation});
      this.dataGridStationBoard.Location = new System.Drawing.Point(3, 0);
      this.dataGridStationBoard.Name = "dataGridStationBoard";
      this.dataGridStationBoard.ReadOnly = true;
      this.dataGridStationBoard.Size = new System.Drawing.Size(298, 517);
      this.dataGridStationBoard.TabIndex = 0;
      // 
      // rowDeparture
      // 
      this.rowDeparture.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.rowDeparture.HeaderText = "Departure";
      this.rowDeparture.Name = "rowDeparture";
      this.rowDeparture.ReadOnly = true;
      // 
      // rowTrack
      // 
      this.rowTrack.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.rowTrack.HeaderText = "Track";
      this.rowTrack.Name = "rowTrack";
      this.rowTrack.ReadOnly = true;
      // 
      // rowDestinationStation
      // 
      this.rowDestinationStation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.rowDestinationStation.HeaderText = "Destination";
      this.rowDestinationStation.Name = "rowDestinationStation";
      this.rowDestinationStation.ReadOnly = true;
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 689);
      this.Controls.Add(this.splitInOut);
      this.Name = "Main";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Main_Load);
      this.splitInOut.Panel1.ResumeLayout(false);
      this.splitInOut.Panel1.PerformLayout();
      this.splitInOut.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitInOut)).EndInit();
      this.splitInOut.ResumeLayout(false);
      this.splitDataGrid.Panel1.ResumeLayout(false);
      this.splitDataGrid.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitDataGrid)).EndInit();
      this.splitDataGrid.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridConnections)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridStationBoard)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitInOut;
    private System.Windows.Forms.Label lblFrom;
    private System.Windows.Forms.SplitContainer splitDataGrid;
    private System.Windows.Forms.DataGridView dataGridConnections;
    private System.Windows.Forms.Label lblTo;
    private System.Windows.Forms.Button btnStop;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.ComboBox cbxFrom;
    private System.Windows.Forms.Label lblDate;
    private System.Windows.Forms.DateTimePicker dateDeparture;
    private System.Windows.Forms.ComboBox cbxTo;
    private System.Windows.Forms.DataGridView dataGridStationBoard;
    private System.Windows.Forms.CheckBox chkStationBoard;
    private System.Windows.Forms.DataGridViewTextBoxColumn rowDeparture;
    private System.Windows.Forms.DataGridViewTextBoxColumn rowTrack;
    private System.Windows.Forms.DataGridViewTextBoxColumn rowDestinationStation;
    private System.Windows.Forms.DataGridViewTextBoxColumn rowDepartureTime;
    private System.Windows.Forms.DataGridViewTextBoxColumn rowFrom;
    private System.Windows.Forms.DataGridViewTextBoxColumn rowTo;
    private System.Windows.Forms.DataGridViewTextBoxColumn rowArrivalTime;
    private System.Windows.Forms.DataGridViewTextBoxColumn rowDuration;
    private System.Windows.Forms.DateTimePicker timeDeparture;
  }
}

