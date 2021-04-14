
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
      this.tbxOutput = new System.Windows.Forms.TextBox();
      this.btnStop = new System.Windows.Forms.Button();
      this.btnSearch = new System.Windows.Forms.Button();
      this.lblTo = new System.Windows.Forms.Label();
      this.tbxTo = new System.Windows.Forms.TextBox();
      this.lblFrom = new System.Windows.Forms.Label();
      this.splitDataGrid = new System.Windows.Forms.SplitContainer();
      this.dataGridOutput = new System.Windows.Forms.DataGridView();
      this.rowFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.rowTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.rowDepartureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.rowArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.rowDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tbxFrom = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.splitInOut)).BeginInit();
      this.splitInOut.Panel1.SuspendLayout();
      this.splitInOut.Panel2.SuspendLayout();
      this.splitInOut.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitDataGrid)).BeginInit();
      this.splitDataGrid.Panel1.SuspendLayout();
      this.splitDataGrid.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridOutput)).BeginInit();
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
      this.splitInOut.Panel1.Controls.Add(this.tbxOutput);
      this.splitInOut.Panel1.Controls.Add(this.btnStop);
      this.splitInOut.Panel1.Controls.Add(this.btnSearch);
      this.splitInOut.Panel1.Controls.Add(this.lblTo);
      this.splitInOut.Panel1.Controls.Add(this.tbxTo);
      this.splitInOut.Panel1.Controls.Add(this.lblFrom);
      this.splitInOut.Panel1.Controls.Add(this.tbxFrom);
      // 
      // splitInOut.Panel2
      // 
      this.splitInOut.Panel2.Controls.Add(this.splitDataGrid);
      this.splitInOut.Size = new System.Drawing.Size(800, 689);
      this.splitInOut.SplitterDistance = 165;
      this.splitInOut.TabIndex = 0;
      // 
      // tbxOutput
      // 
      this.tbxOutput.Location = new System.Drawing.Point(316, 61);
      this.tbxOutput.Name = "tbxOutput";
      this.tbxOutput.Size = new System.Drawing.Size(100, 20);
      this.tbxOutput.TabIndex = 6;
      // 
      // btnStop
      // 
      this.btnStop.Location = new System.Drawing.Point(539, 79);
      this.btnStop.Name = "btnStop";
      this.btnStop.Size = new System.Drawing.Size(105, 23);
      this.btnStop.TabIndex = 5;
      this.btnStop.Text = "Stop";
      this.btnStop.UseVisualStyleBackColor = true;
      this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
      // 
      // btnSearch
      // 
      this.btnSearch.Location = new System.Drawing.Point(539, 45);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(105, 23);
      this.btnSearch.TabIndex = 4;
      this.btnSearch.Text = "Search route";
      this.btnSearch.UseVisualStyleBackColor = true;
      this.btnSearch.Click += new System.EventHandler(this.searchRoute);
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
      // tbxTo
      // 
      this.tbxTo.Location = new System.Drawing.Point(69, 86);
      this.tbxTo.Name = "tbxTo";
      this.tbxTo.Size = new System.Drawing.Size(139, 20);
      this.tbxTo.TabIndex = 2;
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
      this.splitDataGrid.Panel1.Controls.Add(this.dataGridOutput);
      this.splitDataGrid.Size = new System.Drawing.Size(800, 520);
      this.splitDataGrid.SplitterDistance = 483;
      this.splitDataGrid.TabIndex = 0;
      // 
      // dataGridOutput
      // 
      this.dataGridOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowFrom,
            this.rowTo,
            this.rowDepartureTime,
            this.rowArrivalTime,
            this.rowDuration});
      this.dataGridOutput.Location = new System.Drawing.Point(3, 0);
      this.dataGridOutput.Name = "dataGridOutput";
      this.dataGridOutput.Size = new System.Drawing.Size(472, 517);
      this.dataGridOutput.TabIndex = 0;
      // 
      // rowFrom
      // 
      this.rowFrom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.rowFrom.HeaderText = "From";
      this.rowFrom.Name = "rowFrom";
      // 
      // rowTo
      // 
      this.rowTo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.rowTo.HeaderText = "To";
      this.rowTo.Name = "rowTo";
      // 
      // rowDepartureTime
      // 
      this.rowDepartureTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.rowDepartureTime.HeaderText = "Departure Time";
      this.rowDepartureTime.Name = "rowDepartureTime";
      // 
      // rowArrivalTime
      // 
      this.rowArrivalTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.rowArrivalTime.HeaderText = "Arrival Time";
      this.rowArrivalTime.Name = "rowArrivalTime";
      // 
      // rowDuration
      // 
      this.rowDuration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.rowDuration.HeaderText = "Duration";
      this.rowDuration.Name = "rowDuration";
      // 
      // tbxFrom
      // 
      this.tbxFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
      this.tbxFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
      this.tbxFrom.Location = new System.Drawing.Point(69, 40);
      this.tbxFrom.Name = "tbxFrom";
      this.tbxFrom.Size = new System.Drawing.Size(140, 20);
      this.tbxFrom.TabIndex = 0;
      this.tbxFrom.TextChanged += new System.EventHandler(this.InputFrom);
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
      ((System.ComponentModel.ISupportInitialize)(this.splitDataGrid)).EndInit();
      this.splitDataGrid.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridOutput)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitInOut;
    private System.Windows.Forms.TextBox tbxTo;
    private System.Windows.Forms.Label lblFrom;
    private System.Windows.Forms.SplitContainer splitDataGrid;
    private System.Windows.Forms.DataGridView dataGridOutput;
    private System.Windows.Forms.DataGridViewTextBoxColumn rowFrom;
    private System.Windows.Forms.DataGridViewTextBoxColumn rowTo;
    private System.Windows.Forms.DataGridViewTextBoxColumn rowDepartureTime;
    private System.Windows.Forms.DataGridViewTextBoxColumn rowArrivalTime;
    private System.Windows.Forms.DataGridViewTextBoxColumn rowDuration;
    private System.Windows.Forms.Label lblTo;
    private System.Windows.Forms.Button btnStop;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.TextBox tbxOutput;
    private System.Windows.Forms.TextBox tbxFrom;
  }
}

