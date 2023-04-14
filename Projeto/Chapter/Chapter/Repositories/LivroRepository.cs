
using Chapter.Contexts;
using Chapter.Models;

namespace Chapter.Repositories
{
    public class LivroRepository
    {
        private readonly ChapterContext _context;

        public LivroRepository(ChapterContext chapterContext)
        {
            _context = chapterContext;
        }

        public List<Livro> Listar()
        {
            return _context.Livros.ToList();
        }

        public Livro BuscarporId(int id)
        {
            return _context.Livros.Find(id)!;
        }

        public void Cadastrar(Livro livro) 
        {
            _context.Livros.Add(livro);
            _context.SaveChanges();
        }

        public void Atualizar (int id, Livro livro) 
        {
            Livro livroBuscado = _context.Livros.Find(id);

            if (livroBuscado != null) 
            {
                livroBuscado.Titulo = livro.Titulo;
                livroBuscado.QuantidadePagina = livro.QuantidadePagina;
                livroBuscado.Disponivel = livro.Disponivel;

            }

            _context.Livros.Update(livroBuscado);
            _context.SaveChanges();

        }
        public void Deletar (int id)
        {
            Livro livro = _context.Livros.Find(id);
            _context.Livros.Remove(livro);
            _context.SaveChanges();
        }
    }
}
