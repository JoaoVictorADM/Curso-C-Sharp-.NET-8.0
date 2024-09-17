using Indexadores;

Time time = new();

time[1] = "Palmeiras";
time[3] = "Santos";

try {
    time[-1] = "Vasco";  
} catch(Exception e){
    Console.WriteLine(e.Message);
}

try{
    time[1000] = "Flamengo";
} catch (Exception e){
    Console.WriteLine(e.Message);
}


