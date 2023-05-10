namespace app.models;

public class Cuenta
{
    public Guid IdCuenta { get; set; }
    public string Nombre { get; set; }
    public int Cantidad { get; set; }
    public virtual Persona Persona { get; set; }
}