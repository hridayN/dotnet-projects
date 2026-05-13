namespace CSharpConcepts
{
	public class LinqConcepts
	{
		public LinqConcepts()
		{
		}

        // .Take(int): Takes first int from the list
        // .Skip(int): Skips first int from the list
        private List<int> numList = new List<int>{ 1, 2, 3, 4, 5, 6, 7, 8, 9 };
		public List<int> GetEvens()
		{
			// Where: Result incldues condition for numbers divisble by 2
			return this.numList.Where(x => x % 2 == 0).ToList();
		}

		public bool IsListEven()
		{
			// All: Applies condition to every element of the list
			return this.numList.All(x => x % 2 == 0);
		}

		List<Product> products = new List<Product>
		{
			new Product { Name = "Laptop", Category = "Electronics", Price = 1200 },
			new Product { Name = "Smartphone", Category = "Electronics", Price = 800 },
			new Product { Name = "Chair", Category = "Furniture", Price = 200 }
		};

		public List<Product> GetProductsByCategory(string category)
		{
			return this.products.GroupBy(p => p.Category)
				.Select(x => new Product
				{
					Category = x.Key,
					Price = x.OrderBy(p => p.Price)
				});
		}
	}
}

