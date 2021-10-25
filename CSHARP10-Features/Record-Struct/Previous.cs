namespace CSHARP10_Features.Record_Struct;
class Previous
{
    void Record()
    {
        var actor = new PersonPrevious("Tom", "Hanks");
        // Compile Error for the below line since it is immutable
        //actor.Surname = "Hiddlestone";
        System.Console.WriteLine(actor);
    }
}

record PersonPrevious(string Name, string Surname); // reference-type
