using Single_Responsibility_Odev;

Category category = new Category() { CategoryId = 1, CategoryName = "Telefon" };

CategoryRepository categoryRepository = new CategoryRepository();
categoryRepository.AddCategory(category);

Product product = new Product() { ProductId = 1, ProductName = "IPhone S6" };
ProductRepository ProductRepository = new ProductRepository();
ProductRepository.AddProduct(product);

Console.WriteLine("-------Aşağıdaki Örnek Yanlış Kullanım İçindir.--------");

//Yanlış Kullanım Örneği;

BadRepository badRepository= new BadRepository();

badRepository.AddProduct(product);
badRepository.AddCategory(category);