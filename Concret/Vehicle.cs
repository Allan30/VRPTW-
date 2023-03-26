using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace VRPTW.Concret
{
    public class Vehicle
    {
        public int Id;
        public int Capacity = 100;
        public LinkedList<Client> Clients;
        
        public Vehicle(int id, Client depot)
        {
            Id = id;
            Clients = new LinkedList<Client>();
            Clients.AddFirst(depot);
        }
        
        public int GetTravelledDistance()
        {
            /*
            var sum = 0;
            var currentPoint = Clients.First.Value.Coordinate;
            foreach (var client in Clients)
            {
                sum += client.Coordinate.GetDistance(currentPoint);
                currentPoint = client.Coordinate;
            }
            sum += Clients.First.Value.Coordinate.GetDistance(currentPoint);
            return sum;
            */
            var sum = Clients.Zip(Clients.Skip(1), (prevClient, nextClient) => prevClient.Coordinate.GetDistance(nextClient.Coordinate)).Sum();
            sum += Clients.Last.Value.Coordinate.GetDistance(Clients.First.Value.Coordinate);
            return sum;
        }
        
    }
}