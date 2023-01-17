namespace MyLib.Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestNewSimple()
    {
        MyLib.Human human = new();
        Assert.That(human.Age, Is.EqualTo(0));
        Assert.That(human.Name, Is.EqualTo("名無しの権兵衛"));
    }
    [Test]
    public void TestValidNameLenZero()
    {
        Assert.That(
            ()=>{MyLib.Human human = new(){Name=""}; human.Valid();},
            Throws
                .TypeOf<ArgumentOutOfRangeException>()
                .With.Message.EqualTo("名前は1〜16字以内であれ。 (Parameter 'Name')")
        );
    }
    [Test]
    public void TestValidAgeMinus()
    {
        Assert.That(
            ()=>{MyLib.Human human = new(){Age=-1}; human.Valid();},
            Throws
                .TypeOf<ArgumentOutOfRangeException>()
                .With.Message.EqualTo("年齢は0〜255以内であれ。 (Parameter 'Age')")
        );
    }
}
