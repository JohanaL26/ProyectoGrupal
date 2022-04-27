using Microsoft.AspNetCore.Components;
using Modelos;
using ProyectoRepuestosMotos.Interfaces;
using CurrieTechnologies.Razor.SweetAlert2;


namespace ProyectoRepuestosMotos.Pages.FacturaPagina;

partial class FacturaNueva
{
    [Inject] private IProductoServicio _productoServicio { get; set; }
    private IEnumerable<Producto> productoLista { get; set; }
    [Inject] NavigationManager _navigationManager { get; set; }
    [Inject] SweetAlertService Swal { get; set; }
    [Inject] private IFacturaServicio _facturaServicio { get; set; }


    FacturaNece fac = new FacturaNece();

    protected override async Task OnInitializedAsync()
    {
        productoLista = await _productoServicio.GetLista();
    }

    protected async Task Guardar()
    {
        

        bool inserto = await _facturaServicio.Nuevo(fac);
        if (inserto)
        {
            await Swal.FireAsync("Felicidades", "Producto Comprado con exito", SweetAlertIcon.Success);
        }
        else
        {
            await Swal.FireAsync("Error", "Producto no se pudo comprar", SweetAlertIcon.Error);
        }
        _navigationManager.NavigateTo("/Factura/Nuevo");

    }
}

