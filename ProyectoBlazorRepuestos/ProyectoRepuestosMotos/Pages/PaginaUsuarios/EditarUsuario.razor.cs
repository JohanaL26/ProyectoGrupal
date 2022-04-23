

using Microsoft.AspNetCore.Components;
using Modelos;
using ProyectoRepuestosMotos.Interfaces;

namespace ProyectoRepuestosMotos.Pages.PaginaUsuarios;

partial class EditarUsuario
{
    [Inject] private IUsuarioServicio _usuarioServicio { get; set; }

    [Parameter] public string Codigo { get; set; }

    Usuario user = new Usuario();

    protected override async Task OnInitializedAsync()
    {
        if (!string.IsNullOrEmpty(Codigo))
        {
            user = await _usuarioServicio.GetPorCodigo(Codigo);
        }
    }






}

enum Roles
{
    Seleccionar,
    Administrador,
    Usuario
}