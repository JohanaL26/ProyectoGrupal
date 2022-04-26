using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;
using Modelos;
using ProyectoRepuestosMotos.Interfaces;

namespace ProyectoRepuestosMotos.Pages.PaginaProductos;

partial class ListaProductos
{
    [Inject] private IProductoServicio _productoServicio { get; set; }
    private IEnumerable<Producto> productoLista { get; set; }
    [Inject] NavigationManager _navigationManager { get; set; }

    [Inject] SweetAlertService Swal { get; set; }

    protected override async Task OnInitializedAsync()
    {
        productoLista = await _productoServicio.GetLista();
    }

    //Producto prod = new Producto();

    //protected async Task Eliminar()
    //{
    //    bool elimino = false;

    //    SweetAlertResult result = await Swal.FireAsync(new SweetAlertOptions
    //    {
    //        Title = "¿Seguro que quiere eliminar el registro?",
    //        Icon = SweetAlertIcon.Question,
    //        ShowCancelButton = true,
    //        ConfirmButtonText = "Aceptar",
    //        CancelButtonText = "Cancelar"
    //    });

    //    if (!string.IsNullOrEmpty(result.Value))
    //    {
    //        elimino = await _productoServicio.Eliminar_Producto(prod);

    //        if (elimino)
    //        {
    //            await Swal.FireAsync("Felicidades", "Producto eliminado con exito", SweetAlertIcon.Success);
    //            _navigationManager.NavigateTo("/Productos");
    //        }
    //        else
    //        {
    //            await Swal.FireAsync("Error", "Producto no se pudo eliminar", SweetAlertIcon.Error);
    //        }
    //    }
    //}


}
