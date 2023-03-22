string[] snacks = { "sushi", "pizza", "burger", "chicken wings", "asian takeaway" };

Random rnd = new Random();

int randomIndex = rnd.Next(0, snacks.Length);

Console.WriteLine($"Tonight we are goning to eat {snacks[randomIndex]}.");
