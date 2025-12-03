namespace EscapeRoomAdventure;

public class Server : ISystems
{
   public string Status { get ; set ; }
   

   public void Operate()
   {
      Console.WriteLine($"Status is {Status}");
   }
}