

using System.Linq.Expressions;

Console.WriteLine("Rüya Manavına Hoş Geldiniz! ");

Console.WriteLine("Elma = 2TL");

Console.WriteLine("Armut = 3TL");

Console.WriteLine("Çilek = 2TL");

Console.WriteLine("Muz = 3TL");

Console.WriteLine("Diğer bütün meyveler = 4TL");


Console.Write($"Hangi meyveyi satın almak istersiniz? (Elma/Armut/Çilek/Muz/Diğer): ");

string fruit = Console.ReadLine();
string lowerCaseInput = fruit.ToLower();
//büyük küçük harf duyarlılığını ortadan kaldırmak için kullanıcıdan alığım fruit stringini ToLower ile küçülttüm.


switch (lowerCaseInput)
    {
  case "elma":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2TL ");
        break;
    case "armut":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3TL ");
        break;
    case "çilek":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3TL ");
        break;
    case "muz":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3tl");
        break;
    default:
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 4tl");
        break;

    }

//Alttaki ise if else bloğu ile yazılmış hali. Ben sorunu switch-case ile çözmenin mantıklı olduğunu düşünüyorum çünkü switch-casede
//direkt olarak sonuca gidiyor ve diğerlerini denemiyor ancak if else if çözümünde doğruyu bulana kadar her if in içine giriyor.
/*
if (lowerCaseInput == "elma")
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2TL ");
}
else if (lowerCaseInput == "armut")
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3TL ");
}
else if (lowerCaseInput == "çilek")
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3TL ");
}
else if (lowerCaseInput == "muz")
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3tl");
}
else
{
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 4tl");
}

*/











