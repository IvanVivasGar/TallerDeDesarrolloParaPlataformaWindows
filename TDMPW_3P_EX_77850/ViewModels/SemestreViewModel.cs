using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TDMPW_3P_EX_77850.Models;

namespace TDMPW_3P_EX_77850.Models;

public partial class SemestreViewModel : ObservableObject
{
    [ObservableProperty]
    private Semestre _semestre;

    public SemestreViewModel(){
        Semestre = new Semestre{
            Nombre = "Materia",
            ValorParciales = [20, 20, 60],
            CalificacionParciales = [8, 9, 7]
        };
    }

    [RelayCommand]
    private void ActualizarNombre(String nuevoNombre){
        Semestre.Nombre = nuevoNombre;
        OnPropertyChanged(nameof(Semestre));
    }

    [RelayCommand]
    private void ActualizarValorParciales(IList<float> nuevosValoresParciales){
        Semestre.ValorParciales = nuevosValoresParciales.ToList();
        OnPropertyChanged(nameof(Semestre));
    }

    [RelayCommand]
    private void ActualizarCalificacionParciales(IList<float> nuevasCalificacionesParciales){
        Semestre.CalificacionParciales = nuevasCalificacionesParciales.ToList();
        OnPropertyChanged(nameof(Semestre));
    }
}
