using Microsoft.EntityFrameworkCore;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco;

public abstract class DAL<T> where T : class // T -> Tipo generico classe
{
    public readonly ScreenSoundContext _context;

    protected DAL(ScreenSoundContext context)
    {
        _context = context;
    }

    public IEnumerable<T> Listar()
    {
        // Quando você chama _context.Set<T>(), ele retorna um objeto do tipo DbSet<T>,
        // que representa uma tabela do banco de dados dentro do contexto.
        return _context.Set<T>().ToList();
    }
    public void Adicionar(T obj)
    {
        _context.Set<T>().Add(obj);
        _context.SaveChanges();
    }
    public void Atualizar(T obj)
    {
        _context.Set<T>().Update(obj);
        _context.SaveChanges();
    }
    public void Deletar(T obj)
    {
        _context.Set<T>().Remove(obj);
        _context.SaveChanges();
    }
}
