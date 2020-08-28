using Microsoft.VisualBasic.FileIO;
using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Threading;


namespace Zooshop
{
    class Zooshop
    {   //написать программу-зоомагазин.
        // Можно покупать животных.
        // можно покупать для них разную хуйню
        // можно выбирать пол, возраст и от этого будет зависеть цена
        //программа должа быть гипка для добавления какого нибудь говна
        enum Sex
        {
            Мужской,
            Женский
        }//пол
        enum Age
        {
           Молодой, 
           Зрелый, 
           Старый
        }//возраст
        enum AnimalView
        {
            Тигр, 
            Лев, 
            Кот, 
            Попугай,
            Собака
        }//вид животного
        struct AnimalСharacteristic
            {
            public Sex sex;
            public Age age;
            public AnimalView animalview;
            }//характеристика животного
        enum ProductView
        {
            Корм,
            Игрушки,
            Средства_личной_гигиены
        }//виды товаров
        public static void Animal(ref int  priceAnimal) //составление животного
            {
            AnimalСharacteristic animal = new AnimalСharacteristic();
            Console.WriteLine("У нас есть такие животные как:");
            Console.WriteLine("1 - Тигр");
            Console.WriteLine("2 - Лев");
            Console.WriteLine("3 - Кот");
            Console.WriteLine("4 - Попугай");
            Console.WriteLine("5 - Собака");
            Console.WriteLine("Введите номер нужного вам животного");
            int choice1 = 0;
            try
            {
                choice1 = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Вы неправильно осуществили ввод");
                Console.WriteLine("Повторите попытку");
                Console.ReadKey();
                Console.Clear();
                Animal(ref priceAnimal);
            }
            switch (choice1)
            {
                case 1:
                    animal.animalview = AnimalView.Тигр;
                    priceAnimal = 3000;
                    break;
                case 2:
                    animal.animalview = AnimalView.Лев;
                    priceAnimal = 4000;
                    break;
                case 3:
                    animal.animalview = AnimalView.Кот;
                    priceAnimal = 500;
                    break;
                case 4:
                    animal.animalview = AnimalView.Попугай;
                    priceAnimal = 1000;
                    break;
                case 5:
                    animal.animalview = AnimalView.Собака;
                    priceAnimal = 400;
                    break;
                default:
                    Console.WriteLine("Вы неправильно осуществили ввод");
                    Console.WriteLine("Повторите попытку");
                    Console.ReadKey();
                    Console.Clear();
                    Animal(ref priceAnimal);
                    break; 
            }
            Console.Clear();
            Console.WriteLine("Какой возраст вам нужен?");
            Console.WriteLine("1 - Молодой");
            Console.WriteLine("2 - Зрелый");
            Console.WriteLine("3 - Старый");
            int choice2 = Convert.ToInt32(Console.ReadLine());
            switch (choice2)
            {
                case 1:
                    animal.age = Age.Молодой;
                    priceAnimal+=500;
                    break;
                case 2:
                    animal.age = Age.Зрелый;
                    priceAnimal+=200;
                    break;
                case 3:
                    animal.age = Age.Старый;
                    break;
                default:
                    Console.WriteLine("Вы неправильно осуществили ввод");
                    Console.WriteLine("Повторите попытку");
                    Console.ReadKey();
                    Console.Clear();
                    Animal(ref priceAnimal);
                    break;
            }
            Console.Clear();
            Console.WriteLine("Введите пол:");
            Console.WriteLine("1 - Мужской");
            Console.WriteLine("2 - Женский");
            int choice3 = Convert.ToInt32(Console.ReadLine());
            switch (choice3)
            {
                case 1:
                    animal.sex = Sex.Мужской;
                    break;
                case 2:
                    animal.sex = Sex.Женский;
                    priceAnimal += 100;
                    break;
                default:
                    Console.WriteLine("Вы неправильно осуществили ввод");
                    Console.WriteLine("Повторите попытку");
                    Console.ReadKey();
                    Console.Clear();
                    Animal(ref priceAnimal);
                    break;

            }
            Console.Clear();
            Console.WriteLine("Ваш заказ:");
            Console.WriteLine("Животное  - {0}", animal.animalview);
            Console.WriteLine("Возраст  - {0}", animal.age);
            Console.WriteLine("Пол  - {0}", animal.sex);
            Console.WriteLine("Цена:{0}",priceAnimal);
            Console.ReadKey();
        }
         public static  void  Product(ref int priceProduct)//составление продукта
        {
            ProductView product = new ProductView();
            Console.WriteLine("У нас в наличии имеется:");
            Console.WriteLine("1 - Корм");
            Console.WriteLine("2 - Игрушки");
            Console.WriteLine("3 - Средства личной гигиены");
            Console.WriteLine("Введите номер нужного вам продукта");
            int choice2 = 0;
            try
            {
                choice2 = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
               
                Console.WriteLine("Вы неправильно осуществили ввод");
                Console.WriteLine("Повторите попытку");
                Console.ReadKey();
                Console.Clear();
                Animal(ref priceProduct);
            }
            switch (choice2)
            {
                case 1:
                    product = ProductView.Корм;
                    priceProduct = 100;
                    break;
                case 2:
                    product = ProductView.Игрушки;
                    priceProduct = 200;
                    break;
                case 3:
                    product = ProductView.Средства_личной_гигиены;
                    priceProduct = 300;
                    break;
                default:
                    Console.WriteLine("Вы неправильно осуществили ввод");
                    Console.WriteLine("Повторите попытку");
                    Console.ReadKey();
                    Console.Clear();
                    Product(ref priceProduct);
                    break;
            }
            Console.WriteLine("Ваш заказ:");
            Console.WriteLine(product);
            Console.WriteLine("Цена:{0}",priceProduct);
            Console.ReadKey();
        }
        public static void  Choice1( out int choice1)
        {
            Console.WriteLine("Что бы вы хотели приобрести?");
            Console.WriteLine("1 - животные");
            Console.WriteLine("2 - товары для животных");
            Console.WriteLine("Введите цифру нужного товара");
            choice1 = 0;
            try
            {
                choice1 = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Вы неправильно осуществили ввод");
                Console.WriteLine("Повторите попытку");
                Console.ReadKey();
                Console.Clear();
                Choice1(out choice1);
            }
            if (choice1>2 || choice1<1)
            {
                Console.WriteLine("Вы неправильно осуществили ввод");
                Console.WriteLine("Повторите попытку");
                Console.ReadKey();
                Console.Clear();
                Choice1(out choice1);
            }
        }//выбор товара или животного
        public static void Balance(ref int balance )
        {
            Console.WriteLine("Введите ваш баланс");
            try
            {
                balance = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Вы неправильно осуществили ввод");
                Console.WriteLine("Повторите попытку");
                Console.ReadKey();
                Console.Clear();
                Balance(ref balance);
            }
        }//баланс
        public static void Payment(int price, int balance)
        {
            if (price<=balance)
            {
                balance -= price;
                Console.WriteLine("Оплата произошла успешно");
            }
            else
            {
                Console.WriteLine("У вас недостаточно средств");
                Console.WriteLine("Вам не хватает: " + (price-balance));
                Console.WriteLine("Обновите баланс");
                try
                {
                    balance = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Вы неправильно осуществили ввод");
                    Console.WriteLine("Повторите попытку");
                    Console.ReadKey();
                    Console.Clear();
                    Payment(price,balance);
                }
                Payment(price,balance);
            }
        }//оплата
        static void Main(string[] args)
        {
            int price = 0;
            Console.WriteLine("Приветствуем в нашем зоомагазине!");
            int balance = 0;
            Balance(ref balance);
            int choice1;
            Console.Clear();
            Choice1(out choice1);
            Console.Clear();
            if (choice1 == 1)
            {
                Animal(ref price);
            }
            if (choice1 ==2)
            {
                Product(ref price);
            }
            Console.Clear();
            Payment( price, balance);
            Console.WriteLine("Спасибо за покупку");
            Console.ReadKey();
        }
    }
}
