using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco;

public abstract class DAL<T> // T -> Tipo generico
{
    public abstract IEnumerable<T> Listar();
    public abstract void Adicionar(T obj);
    public abstract void Atualizar(T obj);
    public abstract void Deletar(T obj);
    public abstract T? RecuperarPeloNome(string nome);
}
