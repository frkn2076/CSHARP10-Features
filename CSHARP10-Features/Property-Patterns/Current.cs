namespace CSHARP10_Features.Property_Patterns;
class Current
{
    void Sample()
    {
        var pet = new Pet("Daisy", "Magnus");
        var result = pet switch
        {
            { Owner.Length: 5 } => 2,
            { Owner.Length: 4 } => 1,
            _ => 0
        };
        System.Console.WriteLine(result);
    }
}