using Source;
namespace TestProject;


    public class UnitTest1
    {
        public Calculadora Contruirclasse()
    {
        string data = "02/02/2020";
        Calculadora calc = new Calculadora("02/02/2020");
        
        return calc;
    }


        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
    public void TestSomar(int val1, int val2, int resultado)
        {
            Calculadora calc = Contruirclasse();
            int resultadoCalculadora = calc.Somar(val1, val2);
            Assert.Equal(resultado, resultadoCalculadora);
        }


    [Theory]
    [InlineData(3, 2, 6)]
    [InlineData(4, 5, 20)]
    public void TestMultiplicar(int val1, int val2, int resultado)
    {
        Calculadora calc = Contruirclasse();
        int resultadoCalculadora = calc.Multiplicar(val1, val2);
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(6, 2, 3)]
    [InlineData(20, 5, 4)]
    public void TestDividir(int val1, int val2, int resultado)
    {
        Calculadora calc = Contruirclasse();
        int resultadoCalculadora = calc.Dividir(val1, val2);
        Assert.Equal(resultado, resultadoCalculadora);
    }


    [Theory]
    [InlineData(6, 2, 4)]
    [InlineData(20, 5, 15)]
    public void TestSubtrair(int val1, int val2, int resultado)
    {
        Calculadora calc = Contruirclasse();
        int resultadoCalculadora = calc.Subtrair(val1, val2);
        Assert.Equal(resultado, resultadoCalculadora);
    }


    [Fact]
    public void TestarDivisaoPorZero()
    {
        Calculadora calc = Contruirclasse();
        Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
    }

    [Fact]
    public void TestarHistorico()
    {
        Calculadora calc = Contruirclasse();

        calc.Somar(1, 2);
        calc.Somar(3, 6);
        calc.Somar(5, 15);
        calc.Somar(7, 33);
        calc.Somar(11, 2);

        var lista = calc.Historico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }
}
