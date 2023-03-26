using System.Collections.Generic;

namespace VRPTW.AbstractObjects
{
    public interface ISolution
    {
        
        float GetFitness();
        List<ISolution> GetNeighbours();

    }
}