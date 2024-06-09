namespace TDMPW_3P_EX_77850.Models;

public class Semestre
{
    public String? Nombre{get; set;}
    public List<float> ValorParciales {get; set;} = new List<float>(new float[2]);
    public List<float> CalificacionParciales {get; set;} = new List<float>(new float[1]);
}
