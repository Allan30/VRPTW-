using System.Collections.Generic;
using VRPTW.AbstractObjects;

namespace VRPTW.Concret
{
    public class Transformations : ITransformations
    {
        public void TwoOpt(LinkedList<IElement> graph, IElement node1, IElement node2)
        {
            throw new System.NotImplementedException();
        }

        public void RelocateIntra(LinkedList<IElement> graph, IElement node, IElement prevNode, IElement nextNode)
        {
            throw new System.NotImplementedException();
        }

        public void Reverse(LinkedList<IElement> graph)
        {
            throw new System.NotImplementedException();
        }

        public void ExchangeIntra(LinkedList<IElement> graph, IElement node1, IElement node2)
        {
            throw new System.NotImplementedException();
        }

        public void CrossExchange(LinkedList<IElement> graph1, LinkedList<IElement> graph2, (IElement first, IElement last) nodes1,
            (IElement first, IElement last) nodes2)
        {
            throw new System.NotImplementedException();
        }

        public void ExchangeInter(LinkedList<IElement> graph1, LinkedList<IElement> graph2, IElement node1, IElement node2)
        {
            throw new System.NotImplementedException();
        }

        public void RelocateInter(LinkedList<IElement> graph1, LinkedList<IElement> graph2, IElement node, IElement prevNode, IElement nextNode)
        {
            throw new System.NotImplementedException();
        }
    }
}