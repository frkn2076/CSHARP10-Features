namespace CSHARP10_Features.Record_Struct;
class Current
{
    void Record()
    {
        var actor = new PersonCurrent("Tom", "Hanks");
        // Compile Error for the below line since it is immutable
        //actor.Surname = "Hiddlestone";
        System.Console.WriteLine(actor);
    }

    void RecordStruct()
    {
        var actor = new PersonCurrentStruct("Tom", "Hanks");
        actor.Surname = "Hiddlestone";
        System.Console.WriteLine(actor);
    }

    void RecordStructReadonly()
    {
        var actorReadonly = new PersonCurrentStructReadonly("Tom", "Hanks");
        // Compile Error for the below line since it is readonly
        //actorReadonly.Surname = "Hiddlestone";
    }
}

record PersonCurrent(string Name, string Surname); // reference-type
record struct PersonCurrentStruct(string Name, string Surname); // value-type
readonly record struct PersonCurrentStructReadonly(string Name, string Surname); // value-type
