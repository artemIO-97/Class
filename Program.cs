using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var  inventory = new Inventory();
            var products = new Product();
           

            
                
           inventory.InputPrice(products);
           inventory.PrintInventory();
           inventory.CountProducts();
           inventory.SummPrice();
           inventory.SearchElements();


           
 
        }
    }
}
 public class Product
{
    public string Name;
    public double Price;
    public int Count;
}
public class Inventory
{
    public string[] Name = new string[10];
    public double[] Price = new double[10];
    public int[] Count = new int[10];
    char N ;
    int countInput = 0;
    public void InputPrice(Product productInInventory)
    {
            Console.WriteLine("Введите свойства продукта");
        for (int i = countInput; i<Name.Length; i++)
        {
            Console.Write(" Для выхода из заполнениея свойств введите N \n");
            N = Convert.ToChar(Console.ReadLine());
            if (N == 'N')
            {
                break;
            }
            else
            {
                Console.Write(" Введите название  ");
                productInInventory.Name =  Console.ReadLine();
                Console.Write(" Введите цену  ");
                productInInventory.Price = Convert.ToDouble(Console.ReadLine());
                Console.Write(" Введите колличество  ");
                productInInventory.Count = Convert.ToInt32(Console.ReadLine());
            }
            Name[i] = productInInventory.Name;
            Price[i] = productInInventory.Price;
            Count[i] = productInInventory.Count;
            countInput++;
        }
    }

    public void PrintInventory()
    {
    Console.WriteLine("Cодержимое инвентаря\n ");
        for ( int i = 0; i<countInput; i++)
        {
            Console.WriteLine($"Название |{Name[i]}|\t Цена |{Price[i]}|\t Колличество |{Count[i]}|");
        }
    }
    public void CountProducts()
    {
    
         int allCount = 0;
        for (int i = 0; i< Count.Length; i++)
        {
            allCount += Count[i];
        }
    Console.WriteLine($"Общее колличество продуктов{allCount}\n "); 

    }

    public void SummPrice()
    {
    
        double allPrice = 0;
        for(int i = 0; i<Price.Length; i++)
        {
            allPrice += Price[i];

        }
        
    Console.WriteLine($"Общая сумма{allPrice}\n");

}
    public void SearchElements()
    {
        Console.WriteLine("Введите название предмета который хотите найти\n");
        string searchElements = Console.ReadLine();
        for (int i =0; i < countInput; i++)
        {
            if (Name[i] == searchElements)
            {
                Console.WriteLine($"{Name[i]}\t {Price[i]}\t {Count[i]}");
            }
            
        }
            if (Name[countInput - 1] != searchElements)
            {
              Console.WriteLine("Error");

            }               


}
}

