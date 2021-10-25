namespace CSHARP10_Features.Null_Check;
class Current
{
    void Sample(string input)
    {
        System.ArgumentNullException.ThrowIfNull(input, nameof(input));
    }
}
