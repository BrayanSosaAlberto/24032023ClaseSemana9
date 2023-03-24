using namespace ClaseAsincrona9.Models;
using namespace ClaseAsincrona9.DAO;

CrudProducto CrudProducto = new CrudProducto();
Producto Producto = new Producto();

Console.WriteLine("Menu");
Console.WriteLine("Por favor pulse el boton 1 para insertar un nuevo producto del que desee");
Console.WriteLine("Por favor pulse el boton 0 para cancelar el producto que deseo");
var Menu = Convert.ToInt32(Console.ReadLine());

switch (Menu)

{

    case 1:
        int bucle = 1;
        while (bucle == 1)
        {
            Console.WriteLine("Por favor ingrese el nombre del producto");
            Producto.Nombre = Console.ReadLine();
            Console.WriteLine("Por favor ingrese la descripcion del producto que desea");
            Producto.Descripcion = Console.ReadLine();
            Console.WriteLine("Por favor ingrese el precio de su producto 00.00");
            Producto.Precio = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Por favor ingrese la cantidad de producto en stock");
            Producto.Stock = Convert.ToInt32(Console.ReadLine());
            CrudProducto.AgregarProducto(Producto);
            Console.WriteLine("El producto que eligio se agrego perfectamente ");
            Console.WriteLine("Por favor pulsa el boton 1 para agregar otro producto que desee");
            Console.WriteLine("Por favor pulsa 0 para salir");
            bucle = Convert.ToInt32(Console.ReadLine());
        }
        break;
}
    