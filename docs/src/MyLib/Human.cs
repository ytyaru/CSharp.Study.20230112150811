namespace MyLib;
public class Human
{
    public string Name { get; init; } = "名無しの権兵衛";
    public int Age { get; init; }
    public bool Valid() {
        if (this.Name.Length < 1 || 16 < this.Name.Length) { throw new ArgumentOutOfRangeException("名前は1〜16字以内であれ。"); }
        if (this.Age < 0 || 255 < this.Age) { throw new ArgumentOutOfRangeException("年齢は0〜255以内であれ。"); }
        return true;
    }
}
