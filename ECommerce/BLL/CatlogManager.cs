namespace BLL;
using BOL;
using DAL;
public class CatlogManager
{
    public List<Product> GetAllProducts(){
        List<Product> allproducts =new List<Product>();
        allproducts=DBManager.GetAllProducts();
        return allproducts;
    } 

    public Product GetProductById(int id){
        List<Product> allproducts = GetAllProducts();

        Product foundproduct = allproducts.Find((Product)=>Product.id == id);
        return foundproduct; 
    
    }
}
