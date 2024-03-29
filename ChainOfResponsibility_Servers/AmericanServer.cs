﻿using System.Collections.Generic;
using System.Linq;
using System.Windows.Markup;

namespace ChainOfResponsibility_Servers
{
    public class AmericanServer : AbstractServer
    {
        public AmericanServer(AbstractServer Successor = null!) : base(Successor)
        {
            Information = new List<string>(new string[] 
            {
                "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                "Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type " +
                "and scrambled it to make a type specimen book.",
                "It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.",
                "It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, " +
                "and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", 
            });
        }
        public override void Search(string searchOptions)
        {
            SearchResults =
                Information.Where(x => x.ToLower().Contains(searchOptions.ToLower()))
                           .ToArray();

            if (successor != null && SearchResults.Length == 0)
            {
                successor.Search(searchOptions);
            }
        }

        public override void SetSuccessor(AbstractServer NewSuccessor)
        {
            successor = NewSuccessor;
        }
    }
}
