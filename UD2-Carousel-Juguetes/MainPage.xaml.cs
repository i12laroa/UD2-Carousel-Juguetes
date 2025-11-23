using System.Collections.ObjectModel;
using UD2_Carousel_Juguetes.Models;

namespace UD2_Carousel_Juguetes
{
    public partial class MainPage : ContentPage
    {
        // ObservableCollection que contendrá los juguetes
        private ObservableCollection<Toy> List_Toys;

        public MainPage()
        {
            InitializeComponent();

            // Crear la lista de juguetes aleatorios
            RandomMakeToys();

            // Asignar la colección al CarouselView
            carouselToys.ItemsSource = List_Toys;
        }

        private void RandomMakeToys()
        {
            // Inicializar la colección
            List_Toys = new ObservableCollection<Toy>();

            // Arrays con datos para generar juguetes aleatorios
            string[] typeToys = { "Robot", "Muñeca", "Pelota", "Coche", "Puzzle",
                                      "Peluche", "Lego", "Tren", "Avión", "Dinosaurio" };

            string[] colours = { "#FF6B6B", "#4ECDC4", "#45B7D1", "#FFA07A",
                                "#98D8C8", "#F7DC6F", "#BB8FCE", "#85C1E2" };

            Random random = new Random();

            // Generar 8 juguetes aleatorios
            for (int i = 0; i < 8; i++)
            {
                List_Toys.Add(new Toy
                {
                    NameToy = typeToys[random.Next(typeToys.Length)] + " #" + (i + 1),
                    PriceToy = random.Next(10, 100),
                    ColourToy = colours[random.Next(colours.Length)],
                    AgeRecommended = random.Next(3, 13)
                });
            }
        }
    }
    }
}
