namespace CSHARP10_Features.Constant_Interpolated_Strings;
class Current
{
    const string key = "1234";
    // const strings may be initialized using string interpolation with C# 10.0
    const string token = $"Bearer {key}";
}
