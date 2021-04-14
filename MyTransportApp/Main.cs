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
    
    private void GetRoute(string departure, string arrival)
    {
      List<string> connections = new List<string>();
      for (int i = 0; i < transport.GetConnections(departure, arrival).ConnectionList.Count; i++)
      {
        dataGridOutput.Rows.Add(new[]
        {
          transport.GetConnections(departure,arrival).ConnectionList[i].From.Station.Name,
          transport.GetConnections(departure,arrival).ConnectionList[i].To.Station.Name,
          transport.GetConnections(departure,arrival).ConnectionList[i].From.Departure.ToString(),
          transport.GetConnections(departure,arrival).ConnectionList[i].To.Arrival.ToString(),
          transport.GetConnections(departure,arrival).ConnectionList[i].Duration
        });
      }
    }

    private void btnStop_Click(object sender, EventArgs e)
    {
      DialogResult dialogresult=MessageBox.Show("Sind sie sicher, dass das Programm beendet werden soll?", "Programm beenden", MessageBoxButtons.YesNo,MessageBoxIcon.Error);
      if (dialogresult == DialogResult.Yes)
      {
          Application.Exit();
      }
    }

    private void searchRoute(object sender, EventArgs e)
    {
      GetRoute(tbxFrom.Text,tbxTo.Text); 
    }

    private void Main_Load(object sender, EventArgs e)
    {

      
    }

    private void InputFrom(object sender, EventArgs e)
    {
      tbxFrom.AutoCompleteMode = AutoCompleteMode.Suggest;
      tbxFrom.AutoCompleteSource = AutoCompleteSource.CustomSource;

      if (tbxFrom.Text.Length >= 3)
      {
        AutoCompleteStringCollection arr = new AutoCompleteStringCollection();
        for (int i = 0; i <= transport.GetStations(tbxFrom.Text).StationList.Count; i++)
        {
          arr.Add(transport.GetStations(tbxFrom.Text).StationList[i].Name);
        }
        tbxFrom.AutoCompleteCustomSource = arr;
      }

    }
     
    
  }
}
