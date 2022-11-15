using PizzaApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PizzaApp
{
    public partial class MainPage : ContentPage
    {
        List<Pizza> pizzas;
        public MainPage()
        {
            InitializeComponent();
            pizzas = new List<Pizza>()
            {
                new Pizza {
                    Nom = "Végétarienne",
                    Prix = 5000,
                    Ingredients = new string[] {"Tomate", "Poivron", "Oignon"}
                },
                new Pizza {
                    Nom = "Montagnarde",
                    Prix = 6500,
                    Ingredients = new string[] {"Tomate", "Poivron", "Oignon", "Pomme de terre", "Roblechon"}
                },
                new Pizza {
                    Nom = "Carnivore",
                    Prix = 7500,
                    Ingredients = new string[] {"Tomate", "Poivron", "Oignon", "Fromages"}
                }
            };
            pizzasList.ItemsSource = pizzas;
        }
    }
}
