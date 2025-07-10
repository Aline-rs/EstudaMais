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

        public List<MateriaModel> BuscarTodas()
        {
            return _bancoContext.Materias.ToList();
        }


        public MateriaModel ListarPorId(int id)
        {
            return _bancoContext.Materias.FirstOrDefault(x => x.Id == id);
        }
        public MateriaModel Adicionar(MateriaModel materia)
        {
            _bancoContext.Materias.Add(materia);
            _bancoContext.SaveChanges();
            return materia;
        }

        public MateriaModel Atualizar(MateriaModel materia)
        {
            MateriaModel materiaDB = ListarPorId(materia.Id);
            if (materiaDB == null)
            {
                throw new System.Exception("Houve um erro na atualização da matéria");
            }

            materiaDB.NomeMateria = materia.NomeMateria;

            _bancoContext.Materias.Update(materiaDB);
            _bancoContext.SaveChanges();

            return materiaDB;
        }

        public bool Apagar(int id)
        {
            MateriaModel materiaDB = ListarPorId(id);
            if (materiaDB == null)
            {
                throw new System.Exception("Houve um erro na exclusão da matéria");
            }

            _bancoContext.Materias.Remove(materiaDB);
            _bancoContext.SaveChanges();
            return true;
        }
    }
}

