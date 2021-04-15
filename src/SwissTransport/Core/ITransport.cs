namespace SwissTransport.Core
{
    using System.Threading.Tasks;

    using SwissTransport.Models;

    public interface ITransport
    {
        Stations GetStations(string query);

        StationBoardRoot GetStationBoardDate(string station, string id, string dateStation);
        StationBoardRoot GetStationBoard(string station, string id);

        Connections GetConnections(string fromStation, string toStation);

        Connections GetConnections(string fromStation, string toStation, string dateStation, string timeStation);
    }
}