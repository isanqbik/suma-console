namespace test_suma_console;
using Xunit;

public class ProgramTests
{
    [Fact]
    public void Sumar_DosNumeros_RetornaSuma()
    {
        // Arrange
        int numero1 = 5;
        int numero2 = 3;

        // Act
        int resultado = Program.Sumar(numero1, numero2);

        // Assert
        Assert.Equal(8, resultado);
    }
}
