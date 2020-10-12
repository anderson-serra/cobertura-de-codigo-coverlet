namespace CoberturaDeCodigo.App
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public override string ToString()
        {
            if (string.IsNullOrWhiteSpace(Nome) || string.IsNullOrWhiteSpace(Sobrenome))
            {
                if (string.IsNullOrWhiteSpace(Nome) && string.IsNullOrWhiteSpace(Sobrenome))
                    return string.Empty;
                else if (string.IsNullOrWhiteSpace(Nome))
                    return Sobrenome;
                else
                    return Nome;
            }
            else
                return $"{Nome} {Sobrenome}";
        }
    }
}
