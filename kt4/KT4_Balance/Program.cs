using System;

namespace KT4_Balance
{
    public class Balance
    {
        public decimal Amount { get; }

        public Balance(decimal amount)
        {
            Amount = amount;
        }

        public static bool operator ==(Balance? a, Balance? b)
        {
            if (ReferenceEquals(a, b))
                return true;

            if (a is null || b is null)
                return false;

            return a.Amount == b.Amount;
        }

        public static bool operator !=(Balance? a, Balance? b) => !(a == b);

        public override bool Equals(object? obj)
        {
            return obj is Balance other && this == other;
        }

        public override int GetHashCode()
        {
            return Amount.GetHashCode();
        }

        public static bool operator <(Balance a, Balance b) => a.Amount < b.Amount;
        public static bool operator >(Balance a, Balance b) => a.Amount > b.Amount;
        public static bool operator <=(Balance a, Balance b) => a.Amount <= b.Amount;
        public static bool operator >=(Balance a, Balance b) => a.Amount >= b.Amount;

        public static bool operator true(Balance b) => b.Amount > 0;
        public static bool operator false(Balance b) => b.Amount <= 0;

        public override string ToString()
        {
            return $"{Amount:0.00} руб.";
        }
    }

    internal class Program
    {
        static void Main()
        {
            var b1 = new Balance(100m);
            var b2 = new Balance(100m);
            var b3 = new Balance(-50m);

            Console.WriteLine("КТ №4 — Перегрузка операторов");
            Console.WriteLine("Вариант 1 — Balance");
            Console.WriteLine();

            Console.WriteLine($"b1 = {b1}");
            Console.WriteLine($"b2 = {b2}");
            Console.WriteLine($"b3 = {b3}");
            Console.WriteLine();

            Console.WriteLine($"b1 == b2: {b1 == b2}");
            Console.WriteLine($"b1 == b3: {b1 == b3}");
            Console.WriteLine($"b1 != b3: {b1 != b3}");
            Console.WriteLine($"b1 > b3: {b1 > b3}");
            Console.WriteLine($"b1 < b3: {b1 < b3}");
            Console.WriteLine($"b1 >= b2: {b1 >= b2}");
            Console.WriteLine($"b3 <= b1: {b3 <= b1}");
            Console.WriteLine();

            if (b1)
            {
                Console.WriteLine("if (b1): баланс положительный");
            }

            if (b3)
            {
                Console.WriteLine("if (b3): баланс положительный");
            }
            else
            {
                Console.WriteLine("if (b3): баланс не положительный");
            }

            Console.WriteLine();
            Console.WriteLine($"b1.Equals(b2): {b1.Equals(b2)}");
            Console.WriteLine($"b1.GetHashCode() == b2.GetHashCode(): {b1.GetHashCode() == b2.GetHashCode()}");

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
