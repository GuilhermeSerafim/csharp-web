using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Modelos;

namespace ScreenSound.Banco;

public class ArtistaDAL : DAL<Artista>
{
    public ArtistaDAL(ScreenSoundContext context) : base(context) { }

    public Artista? RecuperarPeloNome(string nomeArtista)
    {
        return _context.Artistas.FirstOrDefault(a => a.Nome.Equals(nomeArtista));
    }
 
}
