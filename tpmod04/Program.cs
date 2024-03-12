using tpmod04;

internal class Program
{
    private static void Main(string[] args)
    {
        KodePos kodePosObj = new KodePos();

        // Memanggil method dari class KodePos
        string kodePosKebonwaru = kodePosObj.GetKodePos("Kebonwaru");
        Console.WriteLine("Kode Pos Kebonwaru: " + kodePosKebonwaru);

        string kodePosMargasari = kodePosObj.GetKodePos("Margasari");
        Console.WriteLine("Kode Pos Margasari: " + kodePosMargasari);

        string kodePosBatununggal = kodePosObj.GetKodePos("Batununggal");
        Console.WriteLine("Kode Pos Batununggal: " + kodePosBatununggal);
        Console.WriteLine("\n ==========================");

        //===============================================================================//

        // Membuat instance dari class DoorMachine
        DoorMachine door = new DoorMachine();

        // Mensimulasikan perubahan state
        Console.WriteLine(" ");
        door.Buka();
        door.Buka();
        door.Kunci();
        door.Kunci();
    }
}
