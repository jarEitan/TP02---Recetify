using System;

public class receta
{
    public string nombre { get; set; }
    public DateTime fechaDeNacimiento { get; set; }
    public string tipoComida { get; set; }
    public double presupuesto { get; set; }
    public int cantidadComensales { get; set; }

    private int edad;
    private string plato;

    public void CalcularEdad()
    {
        var nacimiento = fechaDeNacimiento.Date;
        var hoy = DateTime.Today;
        int resultado = hoy.Year - nacimiento.Year;
        if (hoy.Month < nacimiento.Month || (hoy.Month == nacimiento.Month && hoy.Day < nacimiento.Day))
        {
            resultado--;
        }
        edad = resultado;
    }

    public void DeterminarPlato()
    {
        if(tipoComida == "Caliente")
        {
            if(presupuesto >= 7000)
            {
                plato = "Pollo al horno con guarnición";
            }
            else if (presupuesto < 7000 && presupuesto >= 3000)
            {
                plato = "Arroz con verduras salteadas";
            }
            else if (presupuesto < 3000)
            {
                plato = "Fideos con mantecach";
            }
        }
        else if(tipoComida == "Fría")
        {
            if(presupuesto >= 7000)
            {
                plato = "Tabla de fiambres y quesos";
            }
            else if (presupuesto < 7000 && presupuesto >= 3000)
            {
                plato = "Ensalada completa con proteína";
            }
            else if (presupuesto < 3000)
            {
                plato = "Ensalada simple";
            }
        }
    }
}