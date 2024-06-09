namespace TDMPW_3P_EX_77850.Models;

public class Materia
{
    public String? Nombre {get; set;}
    public List<string>? Rubros {get; set;} = new List<string>(new string[2]);
    public List<float>? ValorRubros {get; set;} = new List<float>(new float[2]);
    public List<float>? CalificacionRubros {get; set;} = new List<float>(new float[2]);
}
