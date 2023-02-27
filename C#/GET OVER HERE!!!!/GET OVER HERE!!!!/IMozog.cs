using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GET_OVER_HERE
{

interface IMozog
{
    void Lefele();
    void Felfele();
}

class Lift : IMozog
{
    private int emeletekSzama;
    private int aktualisEmelet;

    public Lift(int emeletekSzama)
    {
        this.emeletekSzama = emeletekSzama;
        Random rnd = new Random();
        aktualisEmelet = rnd.Next(emeletekSzama);
    }

    public void Lefele()
    {
        if (aktualisEmelet > 0)
        {
            aktualisEmelet--;
        }
        else
        {
            throw new HibasIranyException("A lift már az alagsorban van!");
        }
        if (IsElromlott())
        {
            throw new Exception("A lift elromlott");
        }
    }

    public void Felfele()
    {
        if (aktualisEmelet < emeletekSzama - 1)
        {
            aktualisEmelet++;
        }
        else
        {
            throw new HibasIranyException("A lift már a legfelsõ emeleten van!");
        }
        if (IsElromlott())
        {
            throw new Exception("A lift elromlott");
        }
    }

    private bool IsElromlott()
    {
        Random rnd = new Random();
        return rnd.Next(100) == 0;
    }

    public override string ToString()
    {
        return "Aktuális emelet: " + aktualisEmelet;
    }
}

class HibasIranyException : Exception
{
    public HibasIranyException(string message) : base(message) { }
}
}