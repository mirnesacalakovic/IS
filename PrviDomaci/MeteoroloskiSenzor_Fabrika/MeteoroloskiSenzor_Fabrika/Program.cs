using MeteoroloskiSenzor_Fabrika;

//instanciranje fabrika
TemperaturaSenzorFabrika temperaturaFabrika = new TemperaturaSenzorFabrika();
VlaznostSenzorFabrika vlaznostFabrika = new VlaznostSenzorFabrika();

// instance senzora 
IMeteoroloskiSenzor temperatura = temperaturaFabrika.GetSenzor(); 
IMeteoroloskiSenzor vlaznost = vlaznostFabrika.GetSenzor();

temperatura.PrikupiPodatke();
vlaznost.PrikupiPodatke();

