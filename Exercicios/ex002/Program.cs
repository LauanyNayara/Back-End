Console.WriteLine("Digite sua placa");
string placa =  Console.ReadLine();

string final = placa.Substring(placa.Length-1,1);


if (final == "1" || final == "2"){
    Console.WriteLine($"Não pode rodar na Segunda");
}
else if (final == "3" || final == "4"){
    Console.WriteLine($"Não pode rodar na Terça");
}else if (final == "5" || final == "6"){
    Console.WriteLine($"Não pode rodar na Quarta");
}else if (final == "7" || final == "8"){
    Console.WriteLine($"Não pode rodar na Quinta");
} else if (final == "9" || final == "0"){
    Console.WriteLine($"Não pode rodar na Sexta");
};