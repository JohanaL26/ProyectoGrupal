using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;
using Modelos;
using ProyectoRepuestosMotos.Interfaces;

namespace ProyectoRepuestosMotos.Pages.FacturaPagina;

partial class DetalleFactura
{
    [Inject] private IFacturaServicio _facturaServicio { get; set; }
    private IEnumerable<FacturaNece> facturaLista { get; set; }
    [Inject] NavigationManager _navigationManager { get; set; }

    protected override async Task OnInitializedAsync()
    {
        facturaLista = await _facturaServicio.GetLista();

    }
}
