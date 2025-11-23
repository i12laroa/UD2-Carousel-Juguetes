using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UD2_Carousel_Juguetes.Models;

namespace UD2_Carousel_Juguetes
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        // ObservableCollection que contendrá los juguetes
        private ObservableCollection<Toy> List_Toys;

        private Toy? _selectedToy;
        public Toy? SelectedToy
        {
            get => _selectedToy;
            set
            {
                if (_selectedToy != value)
                {
                    _selectedToy = value;
                    OnPropertyChanged();
                }
            }
        }

        public MainPage()
        {
            InitializeComponent();

            // Crear la lista de juguetes aleatorios
            RandomMakeToys();

            // Asignar la colección al CarouselView
            carouselToys.ItemsSource = List_Toys;

            BindingContext = this;
        }

        private void RandomMakeToys()
        {
            // Inicializar la colección
            List_Toys = new ObservableCollection<Toy>();

            // Arrays con datos para generar juguetes aleatorios
            string[] typeToys = { "Robot", "Muñeca", "Pelota", "Coche"};
            string[] imageToys = { "robot.jpg", "doll.jpg", "ball.jpg", "car.jpg" };

            Random random = new Random();

            var indexImages=0;
            foreach (string type in typeToys) {

                List_Toys.Add(new Toy
                {
                    NameToy = type,
                    PriceToy = random.Next(10, 100),
                    ImageToy = imageToys[indexImages],
                    AgeRecommended = random.Next(3, 13)
                });
                indexImages++;
            }
        }

        // Implementación de INotifyPropertyChanged
        public new event PropertyChangedEventHandler PropertyChanged;

        protected new void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
    }

