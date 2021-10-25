using System;

namespace CSHARP10_Features.Record_Struct;
class Current
{
    void Record()
    {
        var actor = new PersonCurrent("Tom", "Hanks");
        // Compile Error for the below line since it is immutable
        //actor.Surname = "Hiddlestone";
        Console.WriteLine(actor);
    }

    internal static void RecordStruct()
    {
        var actor = new PersonCurrentStruct("Tom", "Hanks");
        actor.Surname = "Hiddlestone";
        Console.WriteLine(actor);
    }

    internal static void RecordStructReadonly()
    {
        var actorReadonly = new PersonCurrentStructReadonly("Tom", "Hanks");
        // Compile Error for the below line since it is readonly
        //actorReadonly.Surname = "Hiddlestone";
    }
}

public record PersonCurrent(string Name, string Surname); // reference-type
public record struct PersonCurrentStruct(string Name, string Surname); // value-type
public readonly record struct PersonCurrentStructReadonly(string Name, string Surname); // value-type
