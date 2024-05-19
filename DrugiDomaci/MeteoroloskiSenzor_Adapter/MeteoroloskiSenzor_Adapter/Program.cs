using MeteoroloskiSenzor_Adapter;

TemperaturaSenzor temperaturaSenzor = new TemperaturaSenzor();
VlaznostSenzor vlaznostSenzor = new VlaznostSenzor();

IMeteoroloskiSenzor tempSenzAdapter = new TemperaturaSenzorAdapter(temperaturaSenzor);
IMeteoroloskiSenzor vlazSenzAdapter = new VlaznostSenzorAdapter(vlaznostSenzor);

tempSenzAdapter.PrikupiPodatke();
vlazSenzAdapter.PrikupiPodatke();