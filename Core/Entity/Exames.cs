namespace Core.Entity
{
    public class Exames
    {
        public int Id { get; private set; }
        public string NomeDoExame { get; private set; }
        public string Observacao { get; private set; }
        public int IdTipoDeExame {get; private set; }
        public TipoDeExame TipoDeExame { get; private set; }
    }
}
