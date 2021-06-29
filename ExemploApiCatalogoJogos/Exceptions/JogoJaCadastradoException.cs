using System;

namespace ExemploApiCatalogoJogos.Exceptions
{
    public class JogoJaCadastradoException : Exception
    {
        public JogoJaCadastradoException()
            : base(" O Jogo ja está cadastrado")
        { }
    }
}
