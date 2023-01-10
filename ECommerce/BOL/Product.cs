namespace BOL;
public class Product
{
    public int id {get;set;}
    public string title{get;set;}
    public string imageURL{get;set;}
    public string category{get;set;}
    public string description{get;set;}
    public float unitPrice{get;set;}
    public int balance{get;set;}
    public string paymentTerm{get;set;}
    public string delivery{get;set;}


    public Product(){

    }

    public Product(int productId, string title){
        this.id = productId;
        this.title = title;
        
    }

    public Product(int productId, string title, string brand, string category){
        this.id = productId;
        this.title = title;       
        this.category = category;
    }

     public Product(int productId, string title, string brand,
                    string category, float unitPrice, int balance){
        this.id = productId;
        this.title = title;
        this.category = category;
        this.unitPrice = unitPrice;
        this.balance = balance;
    }

    public Product(int productId, string title, string brand, string category,
                    float unitPrice, 
                    int balance, string description, string imageURL){
        this.id = productId;
        this.title = title;   
        this.category = category;
        this.unitPrice = unitPrice;
        this.balance = balance;
        this.description = description;
        this.imageURL = imageURL;
    }

}
