
// 3. NemesGaz osztály létrehozása
class NemesGaz : KemiaiElem
{
    public NemesGaz(string vegyjel, int rendszam) : base(vegyjel, rendszam, 8)
    {
        if (Focsoport != 8)
        {
            throw new ArgumentException("A nemesgázok főcsoportja mindig 8.");
        }
    }
}
