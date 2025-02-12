using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Modelos;

namespace ScreenSound.Banco;

public class MusicaDAL : DAL<Musica>
{
    public MusicaDAL(ScreenSoundContext context) : base(context) { }

    public Musica? RecuperarPeloNome(string nome)
    {
        return _context.Musica.FirstOrDefault(m => m.Equals(nome));
    }
}
