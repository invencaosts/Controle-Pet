using ControledePet.Models;

namespace ControledePet.Repositorio
{
    public interface IPetRepositorio
    {
        List<PetModel> BuscarTodos();
        PetModel Adicionar(PetModel pet);
        PetModel ListarPorId(int id);
        PetModel Alterar(PetModel pet);
        bool Apagar(int id);

    }
}
