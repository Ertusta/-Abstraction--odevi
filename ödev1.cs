using System;

public interface Is
{
 
    void Hız();
    void Deniz();
    void Hava();
}

public class BMW: Is
{
    public void Hız()
    {
        Console.WriteLine("BMW çok hızlı gider");
    }
    public void Deniz()
    {
        Console.WriteLine("BMW denizde yüzer");
    }
    public void Hava()
    {
        Console.WriteLine("BMW hava da uçar");
    }
}


public class Mercedes : Is
{
    public void Hız()
    {
        Console.WriteLine("Mercedes çok hızlı gidemez");
    }
    public void Deniz()
    {
        Console.WriteLine("Mercedes denizde yüzer");
    }
    public void Hava()
    {
        Console.WriteLine("Mercedes hava da uçar");
    }
}



public class Porche : Is
{
    public void Hız()
    {
        Console.WriteLine("Porche çok hızlı gidemez");
    }
    public void Deniz()
    {
        Console.WriteLine("Porche denizde yüzemez");
    }
    public void Hava()
    {
        Console.WriteLine("Porche hava da uçar");
    }
}

class ödev1
{
    static void Main()
    {
        BMW bmw = new BMW();
        bmw.Hız();
        bmw.Deniz();
        bmw.Hava();
        Mercedes mercedes = new Mercedes();
        mercedes.Hız();
        mercedes.Deniz();
        mercedes.Hava();
        Porche porche = new Porche();
        porche.Hız();
        porche.Deniz();
        porche.Hava();
    }
    
}
