namespace Core.Entity
{
    public class TipoDeExame
    {

        public int Id { get; private set; }
        public string NomeDoTipo { get; private set; }
        public string Descricao { get; private set; }
        public TipoDeExame(int id, string nomeDoTipo, string descricao)
        {
            Id = id;
            NomeDoTipo = nomeDoTipo;
            Descricao = descricao;
        }
    }
}
