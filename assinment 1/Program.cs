double reciept_value;
string client_type;
Console.Write("enter client type (Regular , Silver , Gold) : ");
client_type = Console.ReadLine();
Console.Write("enter reciept value : ");
reciept_value = Convert.ToDouble(Console.ReadLine());
double descount;
switch (client_type) {
    case "Gold":
        descount = reciept_value * 2 / 10;
        break;
    case "Silver":
        descount = reciept_value / 10;
        break;
    case "Regular":
        descount = reciept_value * 5 / 100;
        break;
    default:
        Console.WriteLine("invaled client type");
        return 0;
}


if (reciept_value > 100) {
    switch (client_type)
    {
        case "Gold":
            descount += reciept_value * 5 / 100;
            break;
        case "Silver":
            descount += reciept_value * 3 / 100;
            break;
        case "Regular":
            descount += reciept_value * 2 / 100;
            break;
        default:
            Console.WriteLine("invaled client type");
            break;
    }

}

Console.WriteLine($"the descount value is : {descount}");
Console.WriteLine($"the final price is : {reciept_value - descount}");
return 0;