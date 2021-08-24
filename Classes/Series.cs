namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        // Atributos
		private Genero Genero { get; set; }
		private string Titulo { get; set; }
		private string Descricao { get; set; }
		private int Ano { get; set; }
        private bool Excluido {get; set;}
        public int Id { get; private set; }

        // Métodos
        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
		{
			this.Id = id;
			this.Genero = genero;
			this.Titulo = titulo;
			this.Descricao = descricao;
			this.Ano = ano;
            this.Excluido = false;
		}
 public override string ToString()
		{
			// Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Gênero: \r\n " + this.Genero ;
            retorno += "Titulo: \r\n " + this.Titulo  ;
            retorno += "Descrição: \r\n " + this.Descricao ;
            retorno += "Ano de Início: \r\n " + this.Ano ;
            retorno += "Excluido: \r\n " + this.Excluido;
			return retorno;
		}
        public Serie()
        {
        }

        public string retornaTitulo => this.Titulo;

        public int retornaId()
		{
			return this.Id;
		}
        public bool retornaExcluido()
		{
			return this.Excluido;
		}
        public void Excluir() {
            this.Excluido = true;
        }
    }
}