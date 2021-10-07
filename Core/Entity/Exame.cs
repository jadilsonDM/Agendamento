namespace Core.Entity
{
    public class Exame
    {
        public int Id { get; private set; }
        public string NomeDoExame { get; private set; }
        public string Observacao { get; private set; }
        public int IdTipoExame { get; private set; }
        public TipoDeExame TipoDeExame { get; private set; }
        protected Exame()
        {

        }

        public Exame(int id, string nomeDoExame, string observacao, int idTipoExame)
        {
            Id = id;
            NomeDoExame = nomeDoExame;
            Observacao = observacao;
            IdTipoExame = idTipoExame;
        }

        public void Atualizar(string nomeDoExame, string observacao, int idTipoExame)
        {
            NomeDoExame = nomeDoExame;
            Observacao = observacao;
            IdTipoExame = idTipoExame;
        }
    }
}
