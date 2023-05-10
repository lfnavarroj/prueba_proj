namespace app.models;

public class Persona
{
    public Guid IdPersona { get; set; }
    public string Nombres { get; set; }
    public int Cedula { get; set; }
    public virtual ICollection<Cuenta> Cuentas { get; set; }
    
}