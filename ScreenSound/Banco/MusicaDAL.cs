using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Modelos;

namespace ScreenSound.Banco;

public class MusicaDAL : DAL<Musica>
{
    private readonly ScreenSoundContext _context;

    public MusicaDAL(ScreenSoundContext context)
    {
        _context = context;
    }

    public override IEnumerable<Musica> Listar()
    {
        return new List<Musica>();
    }

    public override void Adicionar(Musica musica)
    {
        _context.Musica.Add(musica);
        _context.SaveChanges();
    }

    public override void Deletar(Musica musica)
    {
        _context.Musica.Remove(musica);
        _context.SaveChanges();
    }

    public override Musica? RecuperarPeloNome(string nome)
    {
        return _context.Musica.FirstOrDefault(m => m.Equals(nome));
    }

    public override void Atualizar(Musica msc)
    {
        _context.Musica.Update(msc);
        _context.SaveChanges();
    }
}
