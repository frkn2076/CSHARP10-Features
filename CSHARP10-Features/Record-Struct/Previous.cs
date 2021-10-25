using System;

namespace CSHARP10_Features.Record_Struct;
class Previous
{
    void Record()
    {
        var actor = new PersonCurrent("Tom", "Hanks");
        // Compile Error for the below line since it is immutable
        //actor.Surname = "Hiddlestone";
        Console.WriteLine(actor);
    }
}

public record PersonPrevious(string Name, string Surname); // reference-type
