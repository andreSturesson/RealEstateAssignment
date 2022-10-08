using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RealEstateBLL.Model.Residential
{
    [Serializable]
    public class Villa : Residential
    {
        private string plot;
        private bool garage;

        public Villa()
        {

        }
        public Villa(Address address, string plot, bool garage, int rooms, int size, LegalForm legalForm, string img) : base(address, rooms, size, legalForm, img)
        {
            this.plot = plot;
            this.garage = garage;
        }

        public string Plot
        {
            get { return plot; }
            set { plot = value; }
        }

        public bool Garage
        {
            get { return garage; }
            set { garage = value; }
        }

        public override void Change(Estate estate) // set which values ​​can be changed
        {
            Address = ((Villa)estate).Address;
            Plot = ((Villa)estate).Plot;
            Garage = ((Villa)estate).Garage;
            Rooms = ((Villa)estate).Rooms;
            Size = ((Villa)estate).Size;
            LegalForm = ((Villa)estate).LegalForm;
            Img = ((Villa)estate).Img;
        }

        public override string getObjectType()
        {
            return "Villa";
        }
    }
}
