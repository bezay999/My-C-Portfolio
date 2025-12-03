namespace EscapeRoomAdventure;

public class FieldAgent
{
    public string Name { get; set; }
    public int SecretCode { get; set; }

    public FieldAgent(string name, int secretCode)
    {
        Name = name;
        SecretCode = secretCode;
    }
}