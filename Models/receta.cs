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
    private int tiempoEstimado;
    private string dificultad;

    public int CalcularEdad()
    {
        DateTime fechaActual = DateTime.Now;
        edad = fechaActual.Year - fechaDeNacimiento.Year;

        if (fechaActual.Month < fechaDeNacimiento.Month || (fechaActual.Month == fechaDeNacimiento.Month && fechaActual.Day < fechaDeNacimiento.Day))
        {
            edad--;
        }
        return edad;
    }

    public string DeterminarPlato()
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
        return plato;
    }

    public int CalcularTiempo(){

        if(tipoComida == "Caliente")
        {
            if(cantidadComensales <= 3){
                tiempoEstimado = 20;
            } else if (cantidadComensales <= 7){
                tiempoEstimado = 40;
            } else if (cantidadComensales >= 8){
                tiempoEstimado = 80;
            }
        }
        else if(tipoComida == "Fría")
        {
            if(cantidadComensales <= 3){
                tiempoEstimado = 10;
            } else if (cantidadComensales <= 7){
                tiempoEstimado = 20;
            } else if (cantidadComensales >= 8){
                tiempoEstimado = 40;
            }
        }
        return tiempoEstimado;
    }

    public string calcularDificultad(){
        if(presupuesto < 3000){
            if (cantidadComensales <= 3){
                dificultad = "Principiante";
            } else { dificultad = "Intermedio"; }
        }
        if(presupuesto >= 3000 && presupuesto <= 7000){
            dificultad = "Intermedio";
        }
        else 
        {
            if (cantidadComensales <= 7){
                dificultad = "Intermedio";
            } else {
                dificultad = "Avanzado";
            }
        }
        return dificultad;
    }
}
