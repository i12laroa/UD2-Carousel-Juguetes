using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace UD2_Carousel_Juguetes.Models
{
    public class Toy: INotifyPropertyChanged
    {
        public string? NameToy { get; set; }

        private decimal priceToy;
        public decimal PriceToy
        {
            get { return priceToy; } 
            set 
            { 
                priceToy = value; 
                OnPropertyChanged(); 
            }

        }
        public string? ImageToy { get; set; }
        public int AgeRecommended { get; set; }

        
        public Toy() { }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
