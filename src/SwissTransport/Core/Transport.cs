﻿namespace SwissTransport.Core
{
    using System;
    using System.Net;

    using Newtonsoft.Json;

    using SwissTransport.Models;

    public class Transport : ITransport, IDisposable
    {
        public const string WebApiHost = "http://transport.opendata.ch/v1/";

        protected readonly IHttpClient HttpClient =
            new HttpClient(CredentialCache.DefaultNetworkCredentials, WebRequest.DefaultWebProxy);

        public Stations GetStations(string query)
        {
            if (string.IsNullOrEmpty(query))
            {
                throw new ArgumentNullException(nameof(query));
            }

            var uri = new Uri($"{WebApiHost}locations?query={query}");
            return HttpClient.GetObject(uri, JsonConvert.DeserializeObject<Stations>);
        }

        public StationBoardRoot GetStationBoardDate(string station, string id, string dateTime)
        {
            if (string.IsNullOrEmpty(station))
            {
                throw new ArgumentNullException(nameof(station));
            }

            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentNullException(nameof(id));
            }

            var uri = new Uri($"{WebApiHost}stationboard?station={station}&id={id}&datetime={dateTime}");
            return HttpClient.GetObject(uri, JsonConvert.DeserializeObject<StationBoardRoot>);
        }
        public StationBoardRoot GetStationBoard(string station, string id)
        {
          if (string.IsNullOrEmpty(station))
          {
            throw new ArgumentNullException(nameof(station));
          }

          if (string.IsNullOrEmpty(id))
          {
            throw new ArgumentNullException(nameof(id));
          }

          var uri = new Uri($"{WebApiHost}stationboard?station={station}&id={id}");
          return HttpClient.GetObject(uri, JsonConvert.DeserializeObject<StationBoardRoot>);
        }
    public Connections GetConnections(string fromStation, string toStation,string dateStation, string timeStation)
        {
            if (string.IsNullOrEmpty(fromStation))
            {
                throw new ArgumentNullException(nameof(fromStation));
            }

            if (string.IsNullOrEmpty(toStation))
            {
                throw new ArgumentNullException(nameof(toStation));
            }

            var uri = new Uri($"{WebApiHost}connections?from={fromStation}&to={toStation}&date={dateStation}&time{timeStation}");
            return HttpClient.GetObject(uri, JsonConvert.DeserializeObject<Connections>);
        }
        public Connections GetConnections(string fromStation, string toStation)
        {
          if (string.IsNullOrEmpty(fromStation))
          {
            throw new ArgumentNullException(nameof(fromStation));
          }

          if (string.IsNullOrEmpty(toStation))
          {
            throw new ArgumentNullException(nameof(toStation));
          }

          var uri = new Uri($"{WebApiHost}connections?from={fromStation}&to={toStation}");
          return HttpClient.GetObject(uri, JsonConvert.DeserializeObject<Connections>);
        }


    public void Dispose()
        {
            HttpClient?.Dispose();
        }
    }
}