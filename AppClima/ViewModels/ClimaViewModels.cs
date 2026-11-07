
using AppClima.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppClima.ViewModels
{
    public partial class ClimaViewModels : ObservableObject
    {
        [ObservableProperty]
        private string cidade;
        [ObservableProperty]
        private string estado;
        [ObservableProperty]
        private DateTime atualizado;
        [ObservableProperty]
        private List<Clima> clima;
    }
}
