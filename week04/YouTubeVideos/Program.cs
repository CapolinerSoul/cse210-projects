using System;

class Program
{
     public static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();

        Video video1 = new Video("Aprende C# en 10 Minutos", "Programación Global", 600);
        video1.addComment("Carlos Gomez", "¡Excelente tutorial! Muy claro todo.");
        video1.addComment("Ana Martinez", "Me sirvió un montón para el examen de la facultad.");
        video1.addComment("Luis Rodriguez", "¿Vas a subir una segunda parte? Saludos.");
        videoList.Add(video1);

        Video video2 = new Video("Receta de Pasta Casera Fácil", "Chef en Casa", 420);
        video2.addComment("Maria Lopez", "La probé esta noche y me quedó riquísima.");
        video2.addComment("Juan Perez", "No me salió la masa, ¿qué harinas recomendás?");
        video2.addComment("Elena Silva", "Me encantó el video, súper directo.");
        videoList.Add(video2);

        Video video3 = new Video("Resumen del Partido: Argentina vs Francia", "Deportes Total", 720);
        video3.addComment("Marcos Diaz", "Qué partido inolvidable, lloro cada vez que lo veo.");
        video3.addComment("Sofia Fernandez", "El mejor video de fútbol de la plataforma.");
        video3.addComment("Bautista Ruiz", "Partidazo. Excelente edición de los goles.");
        video3.addComment("Clara Benitez", "¡Qué final espectacular por favor!");
        videoList.Add(video3);

        foreach (Video vid in videoList)
        {
            Console.WriteLine("========================================");
            Console.WriteLine($"Title: {vid._title}");
            Console.WriteLine($"Author: {vid._author}");
            Console.WriteLine($"length: {vid._videoLengh} segundos");
            Console.WriteLine($"Quantity of commentss: {vid.numberComment()}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Comments:");
            
            foreach (Comment co in vid._comments)
            {
                Console.WriteLine($"- {co._commenter}: \"{co._text}\"");
            }
            Console.WriteLine("========================================\n");
        }
}
}