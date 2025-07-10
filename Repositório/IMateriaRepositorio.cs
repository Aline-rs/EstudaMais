using EstudaMais.Models;

namespace EstudaMais.Repositório
{
    public interface IMateriaRepositorio
    {
        List<MateriaModel> BuscarTodas();
        MateriaModel Adicionar(MateriaModel materia);
        MateriaModel ListarPorId(int id);
        MateriaModel Atualizar(MateriaModel materia);
        bool Apagar(int id);
    }
}