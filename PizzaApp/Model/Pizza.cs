using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp.Model
{
    public class Pizza
    {
        public string Nom { get; set; }
        public int Prix { get; set; }
        public string[] Ingredients { get; set; }

        public string PrixDevise { get { return Prix + " FCFA"; } }

        public string ListeIngredients { get { return String.Join(",", Ingredients); } }

        public Pizza() { }
    }
}
