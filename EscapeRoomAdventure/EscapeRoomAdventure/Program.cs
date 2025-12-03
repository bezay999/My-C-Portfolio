using System;
using EscapeRoomAdventure;
using File = EscapeRoomAdventure.File;

public class Program
{
    public static void Main(string[] args)
    {
        FieldAgent agent1 = new FieldAgent("James Bond", 007);
        FieldAgent agent2 = agent1;
        agent2.SecretCode = 009;
        
        Console.WriteLine(agent1.SecretCode);
        Console.WriteLine(agent2.SecretCode);

        File file1 = new File();
        file1.FileName = "Confidential.txt";
        file1.FileSize = 1024;
        File file2 = new File();
        file2.FileName = "Confidential.txt";
        file2.FileSize = 1024;
        
        bool sameFile = file1 ==  file2;
        Console.WriteLine(sameFile);
        
        Server server = new Server();
        server.Status = "Active";
        
        Server server2 = new Server();
        server2.Status = "Inactive";

        ISystems[] systems = new ISystems[]
            { server, server2 };
        foreach (ISystems system in systems)
        {
            system.Operate();
        }
    }
}