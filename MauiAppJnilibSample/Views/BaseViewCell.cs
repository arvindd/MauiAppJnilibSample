using MauiAppJnilibSample.ViewModels;
using ReactiveUI.Maui;
using Splat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppJnilibSample.Views
{
    public class BaseViewCell<TViewModel> : ReactiveViewCell<TViewModel>, IEnableLogger
                       where TViewModel : BaseViewModel
    {
        public BaseViewCell() { }
    }
}
