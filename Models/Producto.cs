using SQLite;
[Table ("Producto")]

public class Producto
{
    [PrimaryKey, AutoIncrement]

    public int Id {get ; set;}
    [NotNull]

    public required string Nombre {get ; set;}

    public string? Descripcion {get ; set;}

    public decimal Precio {get ; set;}

}