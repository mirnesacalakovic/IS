namespace MeteoroloskiSenzor_Fabrika
{
    public class TemperaturaSenzorFabrika : SenzorFabrika
    {
        public override IMeteoroloskiSenzor GetSenzor()
        {
            return new TemperaturaSenzor();
        }
    }
}
