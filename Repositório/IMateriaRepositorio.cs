using EstudaMais.Models;

namespace EstudaMais.Repositório
{
    public interface IMateriaRepositorio
    {
        List<MateriaModel> BuscarTodas();
        MateriaModel Adicionar(MateriaModel materia);
    }
}
