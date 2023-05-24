using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restoran_Adisyon.ViewModel;

namespace Restoran_Adisyon.Model
{
    public class TabPageModel : BaseViewModel
    {
        public TabPageModel(string name, int id, bool isSelected)
        {
            this.Name = name;
            this.Id = id;
            IsSelected = isSelected;
        }
        public string Name { private set; get; }
        public int Id { private set; get; }
        public bool _IsSelected = false;
        public bool IsSelected
        {
            get
            {
                return _IsSelected;
            }
            set
            {
                _IsSelected = value;
                OnPropertyChanged("IsSelected");
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }

}
