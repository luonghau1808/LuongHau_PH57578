namespace TestFinal.Test;

[TestFixture]
public class CaculatorTest
{
    private Caculator _caculator = null!;
    [SetUp]
    public void Setup()
    {
        _caculator = new Caculator();
    }
    // Áp dụng kĩ thuật phân vùng tương đương khi n là số lẻ dương
    // kqmm: n = 5
    // kqtt: 9
    [Test]
    public void TongCacSoLe_NLaSoLeDuong_ReturnKQMM()
    {
        var result = _caculator.TongSoLe(5);
        Assert.That(result, Is.EqualTo(9));
    }
    // Áp dụng kĩ thuật phân vùng tương đương khi n là số chẵn dương    
    // kqmm: n = 4
    // kqtt: 4
    [Test]
    public void TongCacSoLe_NLaSoChanDuong_ReturnKQMM()
    {
        var result = _caculator.TongSoLe(4);
        Assert.That(result, Is.EqualTo(4));
    }
    // Áp dụng kĩ thuật phân vùng tương đương khi n là số lẻ âm
    // kqmm: n = -3
    // kqtt:  0
    [Test]
    public void TongCacSoLe_NLaSoAm_ReturnKQMM()
    {
        var result = _caculator.TongSoLe(-3);
        Assert.That(result, Is.EqualTo(0));
    }
  // Áp dụng kĩ thuật phân vùng tương đương khi n là số chẵn âm
    // kqmm: n = -4
    // kqtt: 0
    [Test]
    public void TongCacSoLe_NLaSoChanAm_ReturnKQMM()
    {
        var result = _caculator.TongSoLe(-4);
        Assert.That(result, Is.EqualTo(0));
    }
    // Áp dụng kĩ thuật biên với n = 0
    // kqmm: n = 0
    // kqtt: 0
    [Test]
    public void TongCacSoLe_NLa0_ReturnKQMM()
    {
        var result = _caculator.TongSoLe(0);
        Assert.That(result, Is.EqualTo(0));
    }




}
