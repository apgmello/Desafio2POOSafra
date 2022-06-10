namespace aula1OrientacaoAObjetos
{
    class Aluno
    {
        public string Nome { get; set; }
        public string RG { get; set; }
        public DateTime DataNascimento { get; set; } 
        public int Nota { get; set; }
        public Aluno()
        {
        }
        public Aluno(string nome):this()
        {
            Nome = nome;
        }
        public Aluno(string nome, string rG) : this(nome)
        {
            RG = rG;
        }
        public Aluno(string nome, string rG, DateTime dataNascimento) : this(nome, rG)
        {
            DataNascimento = dataNascimento;
        }

        public void Imprimir()
        {
            Console.WriteLine(Nome);
            Console.WriteLine(RG);
            Console.WriteLine(DataNascimento);
            Console.WriteLine(Nota);
        }
        public void Imprimir(bool apenasNota)
        {
            if (!apenasNota)
            {
                Imprimir();
            }
            Console.WriteLine(Nota);
        }


    }
}
