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
    List<Connection> connections = new List<Connection>();
    List<StationBoard> stationboard = new List<StationBoard>();
    private void GetStationBoard(string station)
    {
      string approvedstation = transport.GetStations(station).StationList[0].Name;
      string stationid = transport.GetStations(station).StationList[0].Id;
      ListStationBoard(station, stationid);
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
      ListConnection(departure, arrival);
      for (int i = 0; i < 4; i++)
      {
        dataGridConnections.Rows.Add(new[]
        {
          connections[i].From.Station.Name,
          connections[i].To.Station.Name,
          connections[i].From.Departure.Value.ToString(),
          connections[i].To.Arrival.Value.ToString(),
          connections[i].Duration
        });
      }
    }

    private void btnStop_Click(object sender, EventArgs e)
    {
      DialogResult dialogresult = MessageBox.Show("Sind sie sicher, dass das Programm beendet werden soll?", "Programm beenden", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
      if (dialogresult == DialogResult.Yes)
      {
        Application.Exit();
      }
    }

    private void search(object sender, EventArgs e)
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
    private void ListStationBoard(string approvedstation, string id)
    {
      for (int i = 0; i < transport.GetStationBoard(approvedstation, id).Entries.Count; i++)
      {
        stationboard.Add(transport.GetStationBoard(approvedstation, id).Entries[i]);
      }
    }
   
    private void ListConnection(string departure, string arrival)
    {
      for (int i = 0; i < transport.GetConnections(departure, arrival).ConnectionList.Count; i++)
      {
        connections.Add(transport.GetConnections(departure, arrival).ConnectionList[i]);
      }
    }
    public void InputDestination_Changed(object sender, EventArgs e)
    {
      
      if (cbxFrom.Text.Length > 0)
      {
        List<Station> station = transport.GetStations(cbxFrom.Text).StationList;
        foreach (var Stationname in station)
        {
          cbxFrom.Items.Add(Stationname.Name);
        }
      }
    }

    public void InputDeparture_Changed(object sender, EventArgs e)
    {
      try
      {
        if (cbxTo.Text.Length > 0)
        {
          List<Station> station = transport.GetStations(cbxTo.Text).StationList;
          foreach (var Stationname in station)
          {
            cbxTo.Items.Add(Stationname.Name);
          }
        }
      }
      catch(NoNullAllowedException ex)
      {
        MessageBox.Show("Keine gültige Station gefunden"+ex);
      }
      

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
  }
}
