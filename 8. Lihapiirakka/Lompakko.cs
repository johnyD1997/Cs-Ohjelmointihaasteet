using System;
namespace Lihapiirakka;

class Lompakko
{
    double money = 0.0;
    public Lompakko(double money)
    {
        this.money = money;
    }

    public void Pay(double price)
    {
        if (this.money < price)
        {
            Console.WriteLine("Not enogh money!");
        }
        else 
        {
        this.money -= price;
        }
    }

    public void GetAMoney(double sum)
    {
        this.money += sum;
    }

    public override string ToString()
    {
        return $"Money in your wallet {money}";
    }
}
