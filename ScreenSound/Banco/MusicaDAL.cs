using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Modelos;

namespace ScreenSound.Banco;

public class MusicaDAL
{
    private readonly ScreenSoundContext _context;

    public MusicaDAL(ScreenSoundContext context)
    {
        _context = context;
    }

    public IEnumerable<Musica> Listar()
    {
        return new List<Musica>();
    }

    public void Adicionar(Musica musica)
    {
        _context.Musica.Add(musica);
        _context.SaveChanges();
    }

    public void Deletar(Musica musica)
    {
        _context.Musica.Remove(musica);
        _context.SaveChanges();
    }

}
