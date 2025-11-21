public interface IDataBaseService
{
    public Task<List<Producto>> GetAllProductos();

    public Task<int> CreateProducto(Producto producto);

    public Task<int> UpdateProducto(Producto producto);

    public Task<int> DeleteProducto(Producto producto);
}
