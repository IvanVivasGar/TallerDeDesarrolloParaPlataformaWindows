using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TDMPW_3P_EX_77850.Models;

namespace TDMPW_3P_EX_77850.ViewModels;

public partial class MateriaViewModel : ObservableObject
{
    [ObservableProperty]
    private Materia _materia;

    public MateriaViewModel(){
        Materia = new Materia{
            Nombre = "Materia",
            Rubros = ["Trabajos", "Proyectos", "Examen"],
            ValorRubros = [30, 30, 40],
            CalificacionRubros = [10, 8, 9]
        };
    }

    [RelayCommand]
    private void ActualizarNombre(String nuevoNombre){
        Materia.Nombre = nuevoNombre;
        OnPropertyChanged(nameof(Materia));
    }

    [RelayCommand]
    private void ActualizarRubros(IList<string> nuevosRubros){
        Materia.Rubros = nuevosRubros.ToList();
        OnPropertyChanged(nameof(Materia));
    }

    [RelayCommand]
    private void ActualizarValorRubros(IList<float> nuevosValoresRubros){
        Materia.ValorRubros = nuevosValoresRubros.ToList();
        OnPropertyChanged(nameof(Materia));
    }

    [RelayCommand]
    private void ActualizarCalificacionRubros(IList<float> nuevasCalificacionesRubros){
        Materia.CalificacionRubros = nuevasCalificacionesRubros.ToList();
        OnPropertyChanged(nameof(Materia));
    }

    /*
    private void EjecutarMultiplesComandos(string nuevoNombre, IList<string> nuevosRubros, IList<float> nuevosValoresRubros, IList<float> nuevasCalificacionesRubros){
        ActualizarNombre(nuevoNombre);
        ActualizarRubros(nuevosRubros);
        ActualizarValorRubros(nuevosValoresRubros);
        ActualizarCalificacionRubros(nuevasCalificacionesRubros);
    }
    */
}
