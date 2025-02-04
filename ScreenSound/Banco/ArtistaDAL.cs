using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Modelos;

namespace ScreenSound.Banco;

public class ArtistaDAL
{
    public IEnumerable<Artista> Listar()
    {
        using var context = new ScreenSoundContext();
        return context.Artistas.ToList();
    }

 
}
