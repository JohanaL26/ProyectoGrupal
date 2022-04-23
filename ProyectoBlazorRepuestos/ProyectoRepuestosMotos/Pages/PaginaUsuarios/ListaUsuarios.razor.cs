

using Microsoft.AspNetCore.Components;
using Modelos;
using ProyectoRepuestosMotos.Interfaces;

namespace ProyectoRepuestosMotos.Pages.PaginaUsuarios;

partial class ListaUsuarios
{
    [Inject] private IUsuarioServicio _usuarioServicio { get; set; }
    private IEnumerable<Usuario> usuariosLista { get; set; }


    protected override async Task OnInitializedAsync()
    {
        usuariosLista = await _usuarioServicio.GetLista();
    }


}
