using System.Collections.Generic;
using System.Linq;
using VRPTW.AbstractObjects;

namespace VRPTW.Concret
{
    public class Routes : ISolution
    {
        public Client Depot { get; set; }
        public List<Client> Clients { get; set; }
        public List<Vehicle> Vehicles { get; set; }
        public static int Capacity { get; set; }
        
        public Routes(Client depot, List<Client> clients)
        {
            Depot = depot;
            Clients = clients;
        }
        
        public void AddVehicle()
        {
            Vehicles.Add(new Vehicle(Vehicles.Count, Capacity, Depot));
        }
        
        public float GetFitness()
        {
            return Vehicles.Sum(vehicle => vehicle.GetTravelledDistance());
        }

        public List<ISolution> GetNeighbours()
        {
            //TODO: Implement this method
            throw new System.NotImplementedException();
        }

        public void GenerateRandomSolution()
        {
            var currentVehicle = new Vehicle(Vehicles.Count, Capacity, Depot);
            foreach (var client in Clients)
            {
                if (!currentVehicle.AddClient(client))
                {
                    Vehicles.Add(currentVehicle);
                    currentVehicle = new Vehicle(Vehicles.Count, Capacity, Depot);
                };
            }
        }
    }
}