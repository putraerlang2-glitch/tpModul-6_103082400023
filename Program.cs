using System;
using tpModul6_103082400023;

try
    {
    SayaTubeVideo video = new SayaTubeVideo("“Tutorial Design By Contract Erlang");
    video.increasePlayCount(100);
    
    video.printVideoDetails();
    }

catch (Exception e)
    {
    Console.WriteLine("Ada Eror:" + e.Message);
}


