using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

public abstract class calisan
{

    public abstract int maasinizNedir();


}

public class Genelmudur : calisan
{
    public int wage = 80000;
    public override int maasinizNedir()
    {
        Console.WriteLine("genel Müdürün maaşı" + wage + "dir");

        return wage;
    }


}

public class müdur : calisan
{
    public int wage = 60000;
    public override int maasinizNedir()
    {
        Console.WriteLine("Müdürün maaşı" + wage + "dir");

        return wage;
    }


}

public class programcı : calisan
{
    public int wage = 40000;
    public override int maasinizNedir()
    {
        Console.WriteLine("programcı maaşı" + wage + "dir");

        return wage;
    }


}

public class stajyer : calisan
{
    public int wage = 5000;
    public override int maasinizNedir()
    {
        Console.WriteLine("stajyer maaşı" + wage + "dir");

        return wage;
    }


}

public class ödev2
{
    public static void Main(string[] args)
    {
        Genelmudur genelmudur = new Genelmudur();
        genelmudur.maasinizNedir();
        müdur müdür = new müdur();
        müdür.maasinizNedir();
        programcı programcı = new programcı();
        programcı.maasinizNedir();
        stajyer stajyer = new stajyer();
        stajyer.maasinizNedir();
        int toplammaas = genelmudur.wage + müdür.wage + programcı.wage + stajyer.wage;
        Console.WriteLine("toplam maaş" +toplammaas + "dir"
            );
    }
}

