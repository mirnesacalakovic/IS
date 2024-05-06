namespace MeteoroloskiSenzor_Fabrika
{
    public class VlaznostSenzorFabrika : SenzorFabrika
    {
        public override IMeteoroloskiSenzor GetSenzor()
        {
            return new VlaznostSenzor();
        }
    }
}
