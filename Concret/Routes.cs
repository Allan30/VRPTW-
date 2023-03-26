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
        
        public Routes(Client depot, List<Client> clients)
        {
            Depot = depot;
            Clients = clients;
        }
        
        public void AddVehicle()
        {
            Vehicles.Add(new Vehicle(Vehicles.Count, Depot));
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
    }
}