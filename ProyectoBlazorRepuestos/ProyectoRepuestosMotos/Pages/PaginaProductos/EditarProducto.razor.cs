using Microsoft.AspNetCore.Components;
using ProyectoRepuestosMotos.Interfaces;
using CurrieTechnologies.Razor.SweetAlert2;
using Modelos;

namespace ProyectoRepuestosMotos.Pages.PaginaProductos;

partial class EditarProducto
{
    [Inject] private IProductoServicio _productoServicio { get; set; }

    [Inject] NavigationManager _navigationManager { get; set; }
    [Inject] SweetAlertService Swal { get; set; }

    [Parameter] public string Codigo_Producto { get; set; }

    Producto produc = new Producto();

    protected override async Task OnInitializedAsync()
    {
        if (!string.IsNullOrEmpty(Codigo_Producto))
        {
            produc= await _productoServicio.GetPorCodigo_Producto(Codigo_Producto);
        }
    }

    protected async Task Guardar()
    {
        //if (string.IsNullOrEmpty(produc.CodigoProducto) || string.IsNullOrEmpty(produc.Descripcion) || produc.Precio==0 || produc.Existencia==0)
        //{
        //    return;
        //}

        bool edito = await _productoServicio.Actualizar_Producto(produc);
        if (edito)
        {
            await Swal.FireAsync("Felicidades", "Producto actualizado con exito", SweetAlertIcon.Success);
        }
        else
        {
            await Swal.FireAsync("Error", "Producto no se pudo actualizar", SweetAlertIcon.Error);
        }
        _navigationManager.NavigateTo("/Productos");

    }






}
