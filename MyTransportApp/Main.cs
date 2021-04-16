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
    //Funktionen

    //Checks if the input textboxes are empty, if they are empty the search button gets disabled except DestinationBoard is checked
    private void CheckIfInput()
    {
      if (String.IsNullOrEmpty(cbxFrom.Text) && String.IsNullOrEmpty(cbxTo.Text))
      {
        btnSearch.Enabled = false;
      }
      else if (!String.IsNullOrEmpty(cbxFrom.Text) && chkStationBoard.Checked)
      {
        btnSearch.Enabled = true;
      }
      else if (!String.IsNullOrEmpty(cbxTo.Text) && !String.IsNullOrEmpty(cbxFrom.Text))
      {
        btnSearch.Enabled = true;

      }
    }
    //Gets data for the staionboard and inputs it into the stationboard
    private void GetStationBoard(string station, string date)
    {
      string approvedstation = transport.GetStations(station).StationList[0].Name;
      string stationid = transport.GetStations(station).StationList[0].Id;
      List<StationBoard> stationboard = transport.GetStationBoardDate(approvedstation, stationid, date).Entries;
      try
      {
        for (int i = 0; i < 5; i++)
        {
          dataGridStationBoard.Rows.Add(new[]
          {
            stationboard[i].Stop.Departure.ToString("dd.MM.yyyy HH:mm"),
            stationboard[i].Category,
            stationboard[i].To

        });
        }
      }
      catch
      {
        MessageBox.Show("Es wurde keine gültiger Abfahrtsort gewählt");
      }
    }
    //gets data for the connectionboard and inputs it intp the connectionboard
    private void GetRoute(string departure, string arrival, string date, string time)
    {
      try
      {
        List<Connection> connections = transport.GetConnections(departure, arrival, date, time).ConnectionList;
        for (int i = 0; i < 4; i++)
        {
          dataGridConnections.Rows.Add(new[]
          {
          connections[i].From.Departure.Value.ToString(),
          connections[i].From.Station.Name,
          connections[i].To.Station.Name,
          connections[i].To.Arrival.Value.ToString(),
          connections[i].Duration.Replace("d00", "")
        });
        }
      }
      catch
      {
        MessageBox.Show("Es wurde keine gültige Verbindung ausgewählt");
      }
    }

    //Events
    //stop button if someone wants to stop the program
    private void Stop(object sender, EventArgs e)
    {
      DialogResult dialogresult = MessageBox.Show("Sind sie sicher, dass das Programm beendet werden soll?", "Programm beenden",
        MessageBoxButtons.YesNo, MessageBoxIcon.Error);
      if (dialogresult == DialogResult.Yes)
      {
        Application.Exit();
      }
    }
    //decides on search buttonclick if the user wants stationsboard or connectionboard
    private void search(object sender, EventArgs e)
    {
      dataGridConnections.Rows.Clear();
      dataGridStationBoard.Rows.Clear();
      if (chkStationBoard.Checked == true)
        {
        string date = dateDeparture.Value.ToString("yyyy-MM-dd") + " " + timeDeparture.Value.ToString("HH:mm");
          GetStationBoard(cbxFrom.Text,date);
        }
        else
        {
          GetRoute(cbxFrom.Text, cbxTo.Text, dateDeparture.Value.ToString("yyyy-MM-dd"), timeDeparture.Value.ToString("HH:mm"));
        }

      
    }
     //makes suggestions if the user makes input into From
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
    // makes suggestions if the user makes input into to
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
    // checks if stationboard is selected
    private void StationBoardActive(object sender, EventArgs e)
    {
      if (chkStationBoard.Checked == true)
      {
        cbxTo.Enabled = false;
        btnSearch.Text = "Create Stationboard";
        CheckIfInput();
      }
      else
      {
        
        cbxTo.Enabled = true;
        btnSearch.Text = "Search Connections";
        CheckIfInput();
      }
      
    }

    private void Main_Load(object sender, EventArgs e)
    {
      dateDeparture.MaxDate = DateTime.Now.AddYears(5);
      dateDeparture.MinDate = DateTime.Now;      
      dateDeparture.Value = DateTime.Now;
      timeDeparture.Value = DateTime.Now;
      CheckIfInput();
    }

    
  }
}
