namespace DAL;
using BOL;
using System.Text.Json;
using System.Threading.Tasks;


public class DBManager
{
    public static List<Product> GetAllProducts(){
        List<Product> allproducts=new List<Product>();

        allproducts.Add(new Product{id=1,title="Gerbera",description="Wedding Flower",unitPrice=6,category="flower",balance=5000});
        allproducts.Add(new Product { id = 2, title = "Rose", description = "Valentine Flower", unitPrice = 15, category = "Flower", balance = 7000 });
        allproducts.Add(new Product { id = 3, title = "Lotus", description = "Worship Flower", unitPrice = 26, category = "Flower", balance = 3400 });
        allproducts.Add(new Product { id = 4, title = "Carnation", description = "Pink carnations signify a mother's love, red is for admiration and white for good luck", unitPrice = 16, category = "Flower", balance = 27000 });
        allproducts.Add(new Product { id = 5, title = "Lily", description = "Lilies are among the most popular flowers in the U.S.", unitPrice = 6, category = "Flower", balance = 1000 });
        allproducts.Add(new Product { id = 6, title = "Jasmine", description = "Jasmine is a genus of shrubs and vines in the olive family", unitPrice = 26, category = "Flower", balance = 2000 });
        allproducts.Add(new Product { id = 7, title = "Daisy", description = "Give a gift of these cheerful flowers as a symbol of your loyalty and pure intentions.", unitPrice = 36, category = "Flower", balance = 159 });
        allproducts.Add(new Product { id = 8, title = "Aster", description = "Asters are the September birth flower and the the 20th wedding anniversary flower.", unitPrice = 16, category = "Flower", balance = 67 });
        allproducts.Add(new Product { id = 9, title = "Daffodil", description = "Wedding Flower", unitPrice = 6, category = "Flower", balance = 5000 });
        allproducts.Add(new Product { id = 10, title = "Dahlia", description = "Dahlias are a popular and glamorous summer flower.", unitPrice = 7, category = "Flower", balance = 0 });
        allproducts.Add(new Product { id = 11, title = "Hydrangea", description = "Hydrangea is the fourth wedding anniversary flower", unitPrice = 12, category = "Flower", balance = 0 });
        allproducts.Add(new Product { id = 12, title = "Orchid", description = "Orchids are exotic and beautiful, making a perfect bouquet for anyone in your life.", unitPrice = 10, category = "Flower", balance = 700 });
        allproducts.Add(new Product { id = 13, title = "Statice", description = "Surprise them with this fresh, fabulous array of Statice flowers", unitPrice = 16, category = "Flower", balance = 1500 });
        allproducts.Add(new Product { id = 14, title = "Sunflower", description = "Sunflowers express your pure love.", unitPrice = 8, category = "Flower", balance = 2300 });
        allproducts.Add(new Product { id = 15, title = "Tulip", description = "Tulips are the quintessential spring flower and available from January to June.", unitPrice = 17, category = "Flower", balance = 10000 });
        return allproducts;
    }

    public static List<Product> GetAllProdFromFile(string path){
        if(File.Exists(path)){
            string jsonString=File.ReadAllText(path);
            List<Product>allProducts=JsonSerializer.Deserialize<List<Product>>(jsonString);
            return allProducts;
        }
        else{
            return GetAllProducts();
        }
    }

    public static Product GetByProductID(int id){
        List<Product> list = GetAllProducts();

        Product product=new Product {id = 1, title = "Gerbera", 
                                      description = "Wedding Flower",
                                      unitPrice = 6, category = "Flower",
                                      balance = 5000 };
        
        return product; 

    }
}
