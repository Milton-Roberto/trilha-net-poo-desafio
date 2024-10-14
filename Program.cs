using DesafioPOO.Models;

Nokia nokiaTijoalao = new Nokia("123456789", "Tijolão", "11111", 12 );
Iphone iphoneNovo = new Iphone("987654321", "Iphone15", "22222", 64 );

nokiaTijoalao.Ligar();
nokiaTijoalao.ReceberLigacao();
nokiaTijoalao.InstalarAplicativo("WhatsApp");

iphoneNovo.Ligar();
iphoneNovo.ReceberLigacao();
iphoneNovo.InstalarAplicativo("Instagram");