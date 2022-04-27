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

    [Parameter] public string Codigo { get; set; }

    Producto produc = new Producto();

    protected override async Task OnInitializedAsync()
    {
        if (!string.IsNullOrEmpty(Codigo))
        {
            produc= await _productoServicio.GetPorCodigo(Codigo);
        }
    }

   

    






}
