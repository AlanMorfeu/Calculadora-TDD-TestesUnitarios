
namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        private List<string> listaHistorico;

        public CalculadoraImp()
        {
            listaHistorico = new List<string>();
        }

        public int Somar(int num1, int num2)
        {
            int operacao = 1;
            int resultado = num1 + num2;
            this.AdicionarAoHistorico(operacao, num1, num2, resultado);
            return resultado ;
        }
        public int Subtrair(int num1, int num2)
        {   
            int operacao = 2;
            int resultado = num1 - num2;
            this.AdicionarAoHistorico(operacao, num1, num2, resultado);
            return resultado;
        }
        public int Multiplicar(int num1, int num2)
        {
            int operacao = 3;
            int resultado = num1 * num2;
            this.AdicionarAoHistorico(operacao, num1, num2, resultado);
            return resultado;
        }
        public int Dividir(int num1, int num2)
        {
            int operacao = 4;
            int resultado = num1 / num2;
            this.AdicionarAoHistorico(operacao, num1, num2, resultado);
            return resultado;
        }

        public List<string> Historico()
        {     
                   
            if (listaHistorico.Count > 3)
            {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            }
            return listaHistorico;
        }

        public void AdicionarAoHistorico(int operacao, int num1, int num2, int resultado)
        {
            string operacaoSimbolo = string.Empty;
            switch (operacao)
            {
                case 1:
                    operacaoSimbolo = "+";
                break;
                case 2:
                    operacaoSimbolo = "-";
                break;
                case 3:
                    operacaoSimbolo = "*";
                break;
                case 4:
                    operacaoSimbolo = "/";
                break;
            }
            listaHistorico.Insert(0, $"{num1} {operacaoSimbolo} {num2} = {resultado} - data: {DateTime.Now}");
        }


    }
}