class NemFem : KemiaiElem
{
    public NemFem(string vegyjel, int rendszam, int focsoport) : base(vegyjel, rendszam, focsoport)
    {
        if ((Focsoport + focsoport) % 8 != 0)
        {
            throw new ArgumentException("Két elem csak akkor reagálhat, ha a főcsoportok számának összege 8 osztható.");
        }
    }
}
