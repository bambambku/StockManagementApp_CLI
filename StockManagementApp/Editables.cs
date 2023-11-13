
class Editable
{
    public string? Name = null;
}

class User : Editable
{
    public string Name = "user";
    public string UserName { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public User(string username, string login, string password)
    {
        UserName = username;
        Login = login;
        Password = password;
    }
}

class Product : Editable
{
    public string Name = "product";
    public int? ProductID { get; set; }
    public string? ProductName { get; set; }
    public string? ProductDescription { get; set; }
    public string? ProductCategoryID { get; set; }
    public string? ProductCategoryName { get; set; }
    public string? ProductPrice { get; set; }
    public int? ProductQty { get; set; }
    private int? ProductLowQty { get; set; }

    public bool LowQtyChecker()
    {
        return ProductLowQty < 10;
    }
}

class Stock : Editable
{
    public string Name = "stock";
    public List<Product> ElectronicsList { get; set; }
    public List<Product> FoodList { get; set; }
    public List<Product> ClothingList { get; set; }
    public List<Product> ChemicalsList { get; set; }
}

class Customer : Editable
{
    public string Name = "customer";
    public int OrderID { get; set; }
    public string CustomerName { get; set; }
    public string CustomerPhone { get; set; }
    public string CustomerEmail { get; set; }
    public string CustomerAddress { get; set; }
}

class Order : Editable
{
    public string Name = "order";
    public int OrderID { get; set; }
    public int CustomerID { get; set; }
    public Dictionary<Product, int> OrderList = new();
    public DateTime OrderDate { get; set; }
}

class Users : Editable
{
    public List<User> usersList { get; set; }
    User CurrentUser { get; set; }

    public bool ValidateUser(string login)
    {
        return usersList.Any(user => user.Login == login);
    }

    public bool ValidatePassword(User user, string password)
    {
        return user.Password == password;
    }


}