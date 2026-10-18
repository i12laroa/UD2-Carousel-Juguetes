using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UD2_Carousel_Juguetes.Models;

namespace UD2_Carousel_Juguetes
{
    public partial class MainPage : ContentPage
    {
        // ObservableCollection que contendrá los juguetes
        public ObservableCollection<Toy> List_Toys { get; } = new ObservableCollection<Toy>
        {
            new Toy { NameToy = "Robot", PriceToy = 0m, ImageToy = "robot.jpg", AgeRecommended = 0 },
            new Toy { NameToy = "Muñeca", PriceToy = 0m, ImageToy = "doll.jpg", AgeRecommended = 0 },
            new Toy { NameToy = "Pelota", PriceToy = 0m, ImageToy = "ball.jpg", AgeRecommended = 0 },
            new Toy { NameToy = "Coche", PriceToy = 0m, ImageToy = "car.jpg", AgeRecommended = 0 }
        };

        private Toy? _toyselected;
        public Toy? SelectedToy
        {
            get { return _toyselected; }
            set
            {
                _toyselected = value;
                OnPropertyChanged();
              
            }
        }

        public MainPage()
        {
            InitializeComponent();

            // Crear la lista de juguetes aleatorios
            RandomMakeToys();

            // Asignar la colección al CarouselView
            // carouselToys.ItemsSource = List_Toys;

            BindingContext = this;
        }

        private void RandomMakeToys()
        {
            string[] typeToys = { "Robot", "Muñeca", "Pelota", "Coche" };
            string[] imageToys = { "robot.jpg", "doll.jpg", "ball.jpg", "car.jpg" };
            Random random = new Random();

            List_Toys.Clear();
            List_Toys.Add(new Toy { NameToy = typeToys[0], PriceToy = random.Next(10,100), ImageToy = imageToys[0], AgeRecommended = random.Next(3,13) });
            List_Toys.Add(new Toy { NameToy = typeToys[1], PriceToy = random.Next(10,100), ImageToy = imageToys[1], AgeRecommended = random.Next(3,13) });
            List_Toys.Add(new Toy { NameToy = typeToys[2], PriceToy = random.Next(10,100), ImageToy = imageToys[2], AgeRecommended = random.Next(3,13) });
            List_Toys.Add(new Toy { NameToy = typeToys[3], PriceToy = random.Next(10,100), ImageToy = imageToys[3], AgeRecommended = random.Next(3,13) });
        }

       





    }
    }

