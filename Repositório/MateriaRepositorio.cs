using EstudaMais.Data;
using EstudaMais.Models;
using Microsoft.EntityFrameworkCore.Storage;

namespace EstudaMais.Repositório
{
    public class MateriaRepositorio : IMateriaRepositorio
    {
        private readonly BancoContext _bancoContext;
        public MateriaRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public MateriaModel Adicionar(MateriaModel materia)
        {
            _bancoContext.Materias.Add(materia);
            _bancoContext.SaveChanges();
            return materia;
        }

        public List<MateriaModel> BuscarTodas()
        {
            return _bancoContext.Materias.ToList();
        }
    }
}
