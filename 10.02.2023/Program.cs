using System;

namespace _10._02._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pharmacy pharmacy = new Pharmacy();

            string option;

            do
            {
                Console.WriteLine("\n1. Derman yarat");
                Console.WriteLine("2. Dermanlara bax");
                Console.WriteLine("3. Endirimli dermanlari goster");
                Console.WriteLine("4. Verilmis endirim araliginda olan dermanlari goster");
                Console.WriteLine("5. Verilmis kateqoriya ucun dermanlari goster");
                Console.WriteLine("6. Verilmis kateqoriyada stokda nece dene derman qalib");

                Console.WriteLine("\nSecim edin:");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("Name:");
                        string name = Console.ReadLine();

                        Console.WriteLine("Category:");
                        string category = Console.ReadLine();

                        Console.WriteLine("Price:");
                        string priceStr = Console.ReadLine();
                        double price = Convert.ToDouble(priceStr);

                        Console.WriteLine("Discout price:");
                        string discountStr = Console.ReadLine();
                        double discount = Convert.ToDouble(discountStr);

                        Medicine medicine = new Medicine
                        {
                            Name = name,
                            Category = category,
                            Price = price,
                            DiscountPrice = discount
                        };

                        pharmacy.AddMedicine(medicine);
                        break;

                    case "2":
                        for (int i = 0; i < pharmacy.Medicinies.Length; i++)
                        {
                            Console.WriteLine($"\nName:  {pharmacy.Medicinies[i].Name}");
                            Console.WriteLine($"Price: {pharmacy.Medicinies[i].Price}");
                            Console.WriteLine($"Discount: {pharmacy.Medicinies[i].DiscountPrice}");
                            Console.WriteLine($"Category: {pharmacy.Medicinies[i].Category}");
                        }
                        break;

                    case "3":
                        for (int i = 0; i < pharmacy.Medicinies.Length; i++)
                        {
                            if (pharmacy.Medicinies[i].DiscountPrice > 0)
                            {
                                Console.WriteLine($"\nName:  {pharmacy.Medicinies[i].Name}");
                                Console.WriteLine($"Price: {pharmacy.Medicinies[i].Price}");
                                Console.WriteLine($"Discount: {pharmacy.Medicinies[i].DiscountPrice}");
                                Console.WriteLine($"Category: {pharmacy.Medicinies[i].Category}");
                            }
                        }
                        break;

                    case "4":
                        Console.WriteLine("min deyer:");
                        string minStr = Console.ReadLine();
                        int min = Convert.ToInt32(minStr);

                        Console.WriteLine("max deyer:");
                        string maxStr = Console.ReadLine();
                        int max = Convert.ToInt32(maxStr);

                        for (int i = 0; i < pharmacy.Medicinies.Length; i++)
                        {
                            if (pharmacy.Medicinies[i].DiscountPrice >= min && pharmacy.Medicinies[i].DiscountPrice <= max)
                            {
                                Console.WriteLine($"\nName:  {pharmacy.Medicinies[i].Name}");
                                Console.WriteLine($"Price: {pharmacy.Medicinies[i].Price}");
                                Console.WriteLine($"Discount: {pharmacy.Medicinies[i].DiscountPrice}");
                                Console.WriteLine($"Category: {pharmacy.Medicinies[i].Category}");
                            }
                        }
                        break;
                    case "5":
                        Console.WriteLine("Kateqoriyani daxil edin:");
                        string searchMedicine = Console.ReadLine();

                        for (int i = 0; i < pharmacy.Medicinies.Length; i++)
                        {
                            if (pharmacy.Medicinies[i].Category.Contains(searchMedicine))
                            {
                                Console.WriteLine($"\nName:  {pharmacy.Medicinies[i].Name}");
                                Console.WriteLine($"Price: {pharmacy.Medicinies[i].Price}");
                                Console.WriteLine($"Discount: {pharmacy.Medicinies[i].DiscountPrice}");
                            }
                        }
                        break;
                    case "6":
                        Console.WriteLine("Kateqoriyani daxil edin:");
                        string categoryy = Console.ReadLine();

                        int count = 0;

                        for (int i = 0; i < pharmacy.Medicinies.Length; i++)
                        {
                            if (pharmacy.Medicinies[i].Category == categoryy)
                            {
                                count++;
                            }
                        }
                        Console.WriteLine($"Bu kateqoriyada {count} derman qalib.");
                        break;
                    case "0":
                        Console.WriteLine("Proses bitdi!");
                        break;

                    default:
                        Console.WriteLine("Secim duzgun deyil!");
                        break;
                }

            }
            while (option != "0");
        }
    }
}
