using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;
using Modelos;
using ProyectoRepuestosMotos.Interfaces;

namespace ProyectoRepuestosMotos.Pages.PaginaProductos;

partial class NuevoProducto
{
    [Inject] private IProductoServicio productoServicio { get; set; }
    [Inject] private NavigationManager navigationManager { get; set; }
    [Inject] SweetAlertService Swal { get; set; }

    private Producto produc = new Producto();

    protected async Task Guardar()
    {
        if (string.IsNullOrEmpty(produc.CodigoProducto) || string.IsNullOrEmpty(produc.Descripcion) || produc.Precio == 0 || produc.Existencia == 0)
        {
            return;
        }

        bool inserto = await productoServicio.Nuevo_Producto(produc);
        if (inserto)
        {
            await Swal.FireAsync("Felicidades", "Producto creado con exito", SweetAlertIcon.Success);
        }
        else
        {
            await Swal.FireAsync("Error", "Producto no se pudo crear", SweetAlertIcon.Error);
        }
        navigationManager.NavigateTo("/Productos");

    }

    protected async Task Cancelar()
    {
        navigationManager.NavigateTo("/Productos");
    }






}
