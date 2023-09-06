using NUnit.Framework;
using TestDateFormat;

namespace Library.Tests;

public class DataFormattersTests
{
    [SetUp]
    public void Setup()
    {
    }
//casos de prueba que comprueben que la funcion este bien implementada. Incluye casos de prueba para, al menos, los siguientes casos: 
//una fecha en formato correcto, una fecha que no tenga el formato correcto y una fecha en blanco
    [Test]
    public void TestChangeFormat_ValidDate() 
    {
        string inputDate = "15/04/2004";
        string expectedDate = "2004-04-15";
        string result = DateFormatter.ChangeFormat(inputDate);
        Assert.AreEqual(expectedDate, result);
        
    }
    [Test]
    public void TestChangeFormat_InvalidDate()
    {
        string inputDate = "15-04-2004"; // formato invalido
        string result = DateFormatter.ChangeFormat(inputDate);
        Assert.IsNull(result);
    }
    [Test]
    public void TestChangeFormat_NoDate()
    {
        string inputDate = "";
        string expectedDate = "";
        string result = DateFormatter.ChangeFormat(inputDate);
        Assert.AreEqual(expectedDate, result);
    }
    
}