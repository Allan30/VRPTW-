using System.Collections.Generic;

namespace VRPTW.AbstractObjects
{
    public interface ITransformations
    {
        void TwoOpt(LinkedList<IElement> graph, IElement node1, IElement node2);
        void RelocateIntra(LinkedList<IElement> graph, IElement node, IElement prevNode, IElement nextNode);
        void Reverse(LinkedList<IElement> graph);
        void ExchangeIntra(LinkedList<IElement> graph, IElement node1, IElement node2);

        void CrossExchange(LinkedList<IElement> graph1, LinkedList<IElement> graph2, (IElement first , IElement last) nodes1, (IElement first , IElement last) nodes2);
        void ExchangeInter(LinkedList<IElement> graph1, LinkedList<IElement> graph2, IElement node1, IElement node2);
        void RelocateInter(LinkedList<IElement> graph1, LinkedList<IElement> graph2, IElement node, IElement prevNode, IElement nextNode);
        
        
        
    }
}