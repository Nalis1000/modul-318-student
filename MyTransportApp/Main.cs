using SwissTransport.Models;
using SwissTransport.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTransportApp
{
  public partial class Main : Form
  {

    public Main()
    {
      InitializeComponent();
    }
    ITransport transport = new Transport();
    
    private void CheckIfInput()
    {
      if (String.IsNullOrEmpty(cbxFrom.Text) && String.IsNullOrEmpty(cbxTo.Text))
      {
        btnSearch.Enabled = false;
      }
      else if (String.IsNullOrEmpty(cbxFrom.Text) && chkStationBoard.Checked)
      {
        btnSearch.Enabled = true;
      }
      else
      {
        btnSearch.Enabled = true;
      }
    }
    private void GetStationBoard(string station)
    {
      string approvedstation = transport.GetStations(station).StationList[0].Name;
      string stationid = transport.GetStations(station).StationList[0].Id;
      List<StationBoard> stationboard = transport.GetStationBoard(approvedstation, stationid).Entries;
      

      for (int i = 0; i < 5; i++)
      {
        dataGridStationBoard.Rows.Add(new[]
        {
            stationboard[i].Stop.Departure.ToString(),
            stationboard[i].Category,
            stationboard[i].To

        });
      }
    }
    private void GetRoute(string departure, string arrival)
    {
      List<Connection> connections = transport.GetConnections(departure, arrival).ConnectionList;
      for (int i = 0; i < 4; i++)
      {
        dataGridConnections.Rows.Add(new[]
        {
          connections[i].From.Departure.Value.ToString("HH:mm"),
          connections[i].From.Station.Name,
          connections[i].To.Station.Name,
          connections[i].To.Arrival.Value.ToString("HH:mm"),
          connections[i].Duration.Substring(6)
        });
      }
    }

    private void btnStop_Click(object sender, EventArgs e)
    {
      DialogResult dialogresult = MessageBox.Show("Sind sie sicher, dass das Programm beendet werden soll?", "Programm beenden",
        MessageBoxButtons.YesNo, MessageBoxIcon.Error);
      if (dialogresult == DialogResult.Yes)
      {
        Application.Exit();
      }
    }

    private void search(object sender, EventArgs e)
    {
      if (String.IsNullOrEmpty(dataGridConnections.Rows[0].Cells.ToString()))
      {
        if (chkStationBoard.Checked == true)
        {
          GetStationBoard(cbxFrom.Text);
        }
        else
        {
          GetRoute(cbxFrom.Text, cbxTo.Text);
        }

      }
    }
     
    public void InputDeparture_Changed(object sender, EventArgs e)
    {
      try
      {
        if (cbxFrom.Text.Length > 0 && cbxFrom.SelectedIndex == -1)
        {
          cbxFrom.DroppedDown = true;
          cbxFrom.Items.Clear();
          cbxFrom.Select(cbxFrom.Text.Length, 0);

          List<Station> station = transport.GetStations(cbxFrom.Text).StationList;
          if (cbxFrom.Text.Length >= 3)
          {
            foreach (var Stationname in station)
            {
              cbxFrom.Items.Add(Stationname.Name);
            }
          }
        }
      }
      catch
      {

      }
      CheckIfInput();
    }

    public void InputDestination_Changed(object sender, EventArgs e)
    {
      try
      {
        if (cbxTo.Text.Length > 0 && cbxTo.SelectedIndex == -1)
        {
          cbxTo.DroppedDown = true;
          cbxTo.Items.Clear();
          cbxTo.Select(cbxTo.Text.Length, 0);

          List<Station> station = transport.GetStations(cbxTo.Text).StationList;
          if (cbxFrom.Text.Length >= 3)
          {
            foreach (var stationname in station)
            {
              cbxTo.Items.Add(stationname.Name);
            }
          }
        }
      }
      catch{  }
      CheckIfInput();
    }
    
    private void StationBoardActive(object sender, EventArgs e)
    {
      if (chkStationBoard.Checked == true)
      {
        cbxTo.Enabled = false;
        btnSearch.Text = "Create Stationboard";
      }
      else
      {
        
        cbxTo.Enabled = true;
        btnSearch.Text = "Search Connections";
      }
    }

    private void Main_Load(object sender, EventArgs e)
    {
      dateDeparture.Value = DateTime.Now;
      CheckIfInput();
    }

  }
}
