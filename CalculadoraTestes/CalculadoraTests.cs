using System;
using Calculadora.Services;
using Xunit;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
         _calc = new CalculadoraImp();
    }

    [Theory]
    [InlineData(2, 3, 5)]
    [InlineData(10, 10, 20)]
    public void DeveSomarValoresERetornarRespostaEsperada(int valor1, int valor2, int resultadoEsperada)
    {
        //Act
        int resultado = _calc.Somar(valor1, valor2);

        //Assert
        Assert.Equal(resultadoEsperada, resultado);
    }

    [Theory]
    [InlineData(3, 2, 1)]
    [InlineData(10, 1, 9)]
    public void DeveSubtrairValoresERetornarRespostaEsperada(int valor1, int valor2, int resultadoEsperada)
    {
        //Act
        int resultado = _calc.Subtrair(valor1, valor2);

        //Assert
        Assert.Equal(resultadoEsperada, resultado);
    }

    [Theory]
    [InlineData(2, 3, 6)]
    [InlineData(10, 10, 100)]
    public void DeveMultiplicarValoresERetornarRespostaEsperada(int valor1, int valor2, int resultadoEsperada)
    {
        //Act
        int resultado = _calc.Multiplicar(valor1, valor2);

        //Assert
        Assert.Equal(resultadoEsperada, resultado);
    }

    [Theory]
    [InlineData(3, 3, 1)]
    [InlineData(10, 10, 1)]
    public void DeveDividirValoresERetornarRespostaEsperada(int valor1, int valor2, int resultadoEsperada)
    {
        //Act
        int resultado = _calc.Dividir(valor1, valor2);

        //Assert
        Assert.Equal(resultadoEsperada, resultado);
    }

    [Theory]
    [InlineData(3, 0)]
    [InlineData(8, 0)]
    public void DeveLancarUmaExcecaoQuandoValorDivididoPorValorZero(int valor1, int valor2)
    {
        //Assert
        Assert.Throws<DivideByZeroException>( () => _calc.Dividir(valor1, valor2));
    }

    [Fact]
    public void DeveConter3UltimasOperacoesERetornar3UltimasOperacoes()
    {
        //Arrange
        _calc.Somar(1, 2);
        _calc.Somar(2, 5);
        _calc.Somar(3, 6);
        _calc.Somar(4, 7);

        int resultadoEsperada = 3;

        //Act
        var lista = _calc.Historico();
        var resultado = lista.Count;

        //Assert
        Assert.NotEmpty(lista);
        Assert.Equal(resultadoEsperada, resultado);
    }

    [Fact]
    public void DeveConter1OperacaoERetornar1Operacao()
    {
        //Arrange
        _calc.Somar(1, 2);

        int resultadoEsperada = 1;

        //Act
        var lista = _calc.Historico();
        var resultado = lista.Count;

        //Assert
        Assert.NotEmpty(lista);
        Assert.Equal(resultadoEsperada, resultado);
    }
}