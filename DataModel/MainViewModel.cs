using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechAge.Common;

namespace TechAge.DataModel
{
    public class MainViewModel : BindableBase
    {
        public FakeItem DerniersNumeros { get; set; }
        public FakeItem LesTests { get; set; }
        public FakeItem AbonnezVous { get; set; }
        public FakeItem SuivezNous { get; set; }
        public FakeItem TousLesNumeros { get; set; }
        public FakeItem ContactezNous { get; set; }
        public FakeItem Forum { get; set; }
        public FakeItem ProchainsNumeros { get; set; }

        public ObservableCollection<FakeItem> Items { get; set; }


        public MainViewModel()
        {
            DerniersNumeros = new FakeItem()
            {
                Title = "Derniers Numeros",
                Id = Guid.NewGuid().ToString(),
                Description = "Voir les derniers numeros",
                Width = 300,
                Height = 150,
            };

            LesTests = new FakeItem()
            {
                Title = "Les tests",
                Id = Guid.NewGuid().ToString(),
                Description = "Voir les derniers tests",
                Width = 150,
                Height = 150,
            };

            AbonnezVous = new FakeItem()
            {
                Title = "Abonnez vous !",
                Id = Guid.NewGuid().ToString(),
                Description = "Abonnez vous",
                Width = 150,
                Height = 150,
            };

            ProchainsNumeros = new FakeItem()
            {
                Title = "Les prochains numéros...",
                Id = Guid.NewGuid().ToString(),
                Description = "Les prochains numéros...",
                Width = 300,
                Height = 150,
            };

            TousLesNumeros = new FakeItem()
            {
                Title = "Tous les numéros",
                Id = Guid.NewGuid().ToString(),
                Description = "Tous les numéros...",
                Width = 450,
                Height = 150,
            };


            Items = new ObservableCollection<FakeItem>()
            {
                AbonnezVous,
                ProchainsNumeros,
                TousLesNumeros,
                LesTests
            };
        }
    }
}
