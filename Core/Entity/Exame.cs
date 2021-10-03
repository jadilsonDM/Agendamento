namespace Core.Entity
{
    public class Exame
    {
        public int Id { get; private set; }
        public string NomeDoExame { get; private set; }
        public string Observacao { get; private set; }
        public TipoDeExame TipoDeExame { get; private set; }

        public Exame(int id, string nomeDoExame, string observacao, TipoDeExame tipoDeExame)
        {
            Id = id;
            NomeDoExame = nomeDoExame;
            Observacao = observacao;
            TipoDeExame = tipoDeExame;
        }
    }
}
