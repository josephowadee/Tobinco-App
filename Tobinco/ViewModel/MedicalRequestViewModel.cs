using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using Tobinco.Model;
using Xamarin.Forms;

namespace Tobinco.ViewModel
{
    public class MedicalRequestViewModel : BindableObject
    {
        private ObservableCollection<MedialSuppliesModel> MedicalSupplies;
        private ObservableCollection<object> Selecteditems { get; set; }
        private string _selectionList;

        public MedicalRequestViewModel()
        {
            LoadSupplies();
            //Selecteditems.CollectionChanged += MedicalSuppliesSelecrted;
        }
        private MedialSuppliesModel selectedItem;
        public MedialSuppliesModel SelectedItem
        {
            get => selectedItem;
            set
            {
                SetProperty(ref selectedItem, value);
                if (value != null)
                    SelectedItem = null;
            }
        }

        private void SetProperty(ref MedialSuppliesModel selectedItem, MedialSuppliesModel value)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<MedialSuppliesModel> MedicalItems
        {
            get { return MedicalSupplies; }
            set
            {
                MedicalSupplies = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<object> MedicalSelectedItems
        {
            get { return Selecteditems; }
        }
        
        void LoadSupplies()
        {
            MedicalItems = new ObservableCollection<MedialSuppliesModel>() {
                 new MedialSuppliesModel
                 {
                     ItemImage="https://countrymedicalpharmacy.com/wp-content/uploads/2020/10/BLOPEN-GEL.jpg",
                     ItemTitle = "Blopen 30G Gel",
                     ItemDiscription = "",
                     ItemQuantity = 3430,
                     ItemPrice = 100,
                     
                 },
                 new MedialSuppliesModel
                 {
                     ItemImage="https://i0.wp.com/julitetpharmacy.com/wp-content/uploads/2021/02/WIN_20210206_13_56_51_Pro.jpg?fit=640%2C360&ssl=1",
                     ItemTitle = "Blopen Caplet",
                     ItemDiscription = "",
                     ItemQuantity = 4230,
                     ItemPrice = 100,
                 },
                 new MedialSuppliesModel
                 {
                     ItemImage="https://i0.wp.com/julitetpharmacy.com/wp-content/uploads/2021/03/WIN_20210306_15_25_23_Pro.jpg?fit=640%2C360&ssl=1",
                     ItemTitle = "Dicnac SR 75",
                     ItemDiscription = "",
                     ItemQuantity = 3470,
                     ItemPrice = 100,
                 },
                 new MedialSuppliesModel
                 {
                     ItemImage="https://www.pottershollow.com/opsiwygi/2020/08/e10.jpg",
                     ItemTitle = "FOLIGROW Blood Tonic",
                     ItemDiscription = "",
                     ItemQuantity = 45740,
                     ItemPrice = 100,
                 },
                 new MedialSuppliesModel
                 {
                     ItemImage="https://pbs.twimg.com/media/EZmfgL-WkAEYvud.jpg:large",
                     ItemTitle = "COLDRILIF",
                     ItemDiscription = "",
                     ItemQuantity = 7780,
                     ItemPrice = 100,
                 },new MedialSuppliesModel
                 {
                     ItemImage="https://www.tobincopharma.com/assets/demo/portfolio/LufartMockUp.png",
                     ItemTitle = "LUFART DS",
                     ItemDiscription = "",
                     ItemQuantity = 7680,
                     ItemPrice = 100,

                 },
                 new MedialSuppliesModel
                 {
                     ItemImage="https://pbs.twimg.com/media/EGcmthQWsAMa2_D.png",
                     ItemTitle = "Ibudol Plus",
                     ItemDiscription = "",
                     ItemQuantity = 7887,
                     ItemPrice = 100,
                 },
                 new MedialSuppliesModel
                 {
                     ItemImage="https://pbs.twimg.com/media/EGcmthQWsAMa2_D.png",
                     ItemTitle = "Ibudol ",
                     ItemDiscription = "",
                     ItemQuantity = 78264,
                     ItemPrice = 100,
                 },
                 new MedialSuppliesModel
                 {
                     ItemImage="https://countrymedicalpharmacy.com/wp-content/uploads/2020/10/ENTRAMOL-500MG-TABLET-24.png",
                     ItemTitle = "Entramol",
                     ItemDiscription = "",
                     ItemQuantity = 5573,
                     ItemPrice = 100,
                 },
                 new MedialSuppliesModel
                 {
                     ItemImage="https://www.shutterstock.com/image-photo/white-medical-pills-tablets-spilling-out-1388950559",
                     ItemTitle = "KOFOF",
                     ItemDiscription = "",
                     ItemQuantity = 5237,
                     ItemPrice = 100,
                 },
                 new MedialSuppliesModel
                 {
                     ItemImage="https://pbs.twimg.com/media/EJz6RXBWkAA-Zdh.png",
                     ItemTitle = "Ancigel & Ancigel-O ",
                     ItemDiscription = "",
                     ItemDiscount = 5,
                     ItemQuantity = 77436,
                     ItemPrice = 100,
                 },
                 new MedialSuppliesModel
                 {
                     ItemImage="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT4IZ4_okCO2azo58c88ikWW-aN8fvbzPQkXZSmM-mj3SFDs4JsfyKbKBXbKC_rbL7_EJg&usqp=CAU",
                     ItemTitle = "Omal Hygiene Products",
                     ItemDiscription = "",
                     ItemQuantity = 76463,
                     ItemPrice = 100,
                 },
                 
            };
        }
    }
}
