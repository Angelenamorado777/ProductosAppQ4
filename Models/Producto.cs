using SQLite;
[Table ("Producto")]
public class Producto
{
    [PrimaryKey, AutoIncrement]

    public int Id {get ; set;}
  
    [NotNull]
    public string Nombre {get ; set;} = string.Empty;

    public string Descripcion {get ; set;} = string.Empty;

    public decimal Precio {get ; set;}
    public Producto() {} 

}