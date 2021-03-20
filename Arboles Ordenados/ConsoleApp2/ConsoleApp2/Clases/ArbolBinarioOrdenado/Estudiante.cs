

/**
 *
 * @author Ruldin
 */
public class Estudiante : Comparador
{

    public string nombre;
    public string descripcion;

    public bool igualQue(object q)
    {
        return true;
    }

    public bool mayorIgualQue(object q)
    {
        Estudiante p2 = (Estudiante)q;
        return nombre.CompareTo(p2.nombre) >= 0;
    }

    public bool mayorQue(object q)
    {
        Estudiante p2 = (Estudiante)q;
        return nombre.CompareTo(p2.nombre) > 0;
    }

    public bool menorIgualQue(object q)
    {
        Estudiante p2 = (Estudiante)q;
        return nombre.CompareTo(p2.nombre) <= 0;
    }

    public bool menorQue(object op2)
    {

        Estudiante p2 = (Estudiante)op2;
        return nombre.CompareTo(p2.nombre) < 0;

    }
}


