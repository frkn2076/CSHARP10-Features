namespace CSHARP10_Features.Null_Check;
class Previous
{
    void Sample(string input)
    {
        if (input == null)
        {
            throw new System.ArgumentNullException(nameof(input));
        }
    }
}
