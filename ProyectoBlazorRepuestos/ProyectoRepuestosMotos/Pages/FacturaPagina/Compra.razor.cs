using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;
using ProyectoRepuestosMotos.Interfaces;
using Modelos;
namespace ProyectoRepuestosMotos.Pages.FacturaPagina;

partial class Compra
{
    [Inject] private IFacturaServicio _facturaServicio { get; set; }
    [Inject] private IProductoServicio _productoServicio { get; set; }
    [Inject] NavigationManager _navigationManager { get; set; }
    [Inject] SweetAlertService Swal { get; set; }
    [Parameter] public string Codigo { get; set; }

    Producto produc = new Producto();
    FacturaNece fac = new FacturaNece();

    protected override async Task OnInitializedAsync()
    {
        if (!string.IsNullOrEmpty(Codigo))
        {
            produc = await _productoServicio.GetPorCodigo(Codigo);
        }
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
