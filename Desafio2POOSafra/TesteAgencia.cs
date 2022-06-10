namespace aula1OrientacaoAObjetos
{
    class TesteAgencia
    {
        public static void Main(string[] args)
        {
            Agencia a1 = new Agencia(6889);
            Agencia a2 = new Agencia(5874);

            Console.WriteLine(" Dados da primeira agência ");
            Console.WriteLine(" Número da agência " + a1.numero);

            Console.WriteLine(" ---------------- ");

            Console.WriteLine(" Dados da segunda agência ");
            Console.WriteLine(" Número da agência " + a2.numero);
        }
    }
}