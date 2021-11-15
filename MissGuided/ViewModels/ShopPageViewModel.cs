using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using MissGuided.Infrastructure;
using MissGuided.Models;
using Xamarin.Forms.Internals;

namespace MissGuided.ViewModels
{
    public class SelectMasterViewModel
    {
        public Master Master { get; set; }
        public bool Selected { get; set; }
    }
    public class ShopPageViewModel: BindableBase
    {
        public ObservableCollection<Grouping<SelectMasterViewModel, Detail>> Masters { get; set; }
        public DelegateCommand<Grouping<SelectMasterViewModel, Detail>> HeaderSelectedCommand
        {
            get
            {
                return new DelegateCommand<Grouping<SelectMasterViewModel, Detail>>(g =>
                {
                    if (g == null) return;
                    g.Key.Selected = !g.Key.Selected;
                    if (g.Key.Selected)
                    {
                        Data.DataFactory.detailData.Where(i => (i.detailMaster.masterID == g.Key.Master.masterID))
                            .ForEach(g.Add);
                    }
                    else
                    {
                        g.Clear();
                    }
                });
            }
        }
        public ShopPageViewModel()
        {
            Masters = new ObservableCollection<Grouping<SelectMasterViewModel, Detail>>();
            var selectMasters =
                Data.DataFactory.detailData.Select(x => new SelectMasterViewModel { Master = x.detailMaster, Selected = false })
                    .GroupBy(sc => new { sc.Master.masterID })
                    .Select(g => g.First())
                    .ToList();
            selectMasters.ForEach(sc => Masters.Add(new Grouping<SelectMasterViewModel, Detail>(sc, new List<Detail>())));
        }
    }
}
