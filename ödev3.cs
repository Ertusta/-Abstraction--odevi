using System;


interface YakıtTüketimi
{
    int YakıtTüketimi();
}

abstract class Araba
{
    public string Ad;
    public int fuel;

    public Araba(string ad, int fuel)
    {
        Ad = ad;
        this.fuel = fuel;
    }

}

class BMW : Araba, YakıtTüketimi
{
    public BMW() : base("BMW", 80) { }
    public int YakıtTüketimi()
    {
        return fuel;
    }
}

class Mercedes : Araba, YakıtTüketimi
{
    public Mercedes() : base("Mercedes", 70) { }
    public int YakıtTüketimi()
    {
        return fuel;
    }
}

class Porsche : Araba, YakıtTüketimi
{
    public Porsche() : base("Porsche", 60) { }
    public int YakıtTüketimi()
    {
        return fuel;
    }
}


class Program
{
    static void Main()
    {
        

        int toplamYakıt = 0;

        BMW bmw = new BMW();
        Mercedes mercedes = new Mercedes();
        Porsche porsche = new Porsche();

        toplamYakıt = bmw.fuel+mercedes.fuel + porsche.fuel;

        Console.WriteLine("toplam yakıt"+toplamYakıt+"dır");
    }
}




//Dizi birden fazla değişkeni yan yana pointerlara koyarak erişimizi kolaylaştıran yapıdır