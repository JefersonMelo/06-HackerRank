namespace Day_12_Inheritance
{

    /*
    * Construtor de classe
    * Parâmetros:
    * firstName - Uma string denotando o primeiro nome da pessoa.
    * lastName - Uma string denotando o sobrenome da pessoa.
    * id - Um número inteiro denotando o número de identificação da pessoa.
    * scores - Uma matriz de inteiros denotando as pontuações de teste da Pessoa.
    -- Escreva seu construtor aqui
    * Nome do método: Calcular
    * Retorno: um personagem que denota a nota.
    */

    class Aluno : Pessoa
    {
        private int[] testScores;
        private int soma;
        private int result;

        public Aluno( ) { }

        public Aluno( string primeiroNome, string ultimoNome, int id, int[] score )
        // : base (primeiroNome, ultimoNome., id) também poderia ser usado desta maneira
        {
            this.firstName = primeiroNome;
            this.lastName = ultimoNome;
            this.id = id;
            this.testScores = score;

        }

        public char Calculate( )
        {
            //int score = testScores.Sum() / testScores.Length; Sum() pertence ao System.Linq e é a forma abordada pelo hackerhank

            for (int i = 0; i < testScores.Length; i++)
            {
                this.soma += this.testScores[i];
            }

            this.result = soma / testScores.Length; ;

            if (this.result >= 90)
            {
                return 'O';
            }
            else if (this.result >= 80)
            {
                return 'E';
            }
            else if (this.result >= 70)
            {
                return 'A';
            }
            else if (this.result >= 55)
            {
                return 'P';
            }
            else if (this.result >= 40)
            {
                return 'D';
            }
            else if (this.result < 40)
            {
                return 'T';
            }

            return ' ';
        }
    }
}
