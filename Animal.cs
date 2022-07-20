


public class Animal{

    // attributes
    private string species;
    private int numLegs;
    private double weight;
    public double Weight {
        get {return weight;}
    }
    private bool isMammal;
    private string color;

    // constructor
    public Animal(string sp, int legs, double wgt, bool isMam, string clr){
        species = sp;
        numLegs = legs;
        weight = wgt;
        isMammal = isMam; 
        color = clr;
    }

    public Animal(string sp, double wgt, string clr){
        species = sp;
        numLegs = 4;
        weight = wgt;
        isMammal = true;
        color = clr;
    }

    // methods
    public void eat(int foodWeight){
        weight += foodWeight;
    }

    public void showStats(){
        Console.WriteLine($"Species: {species}");
        Console.WriteLine($"Number of Legs: {numLegs}");
        Console.WriteLine($"Weight: {weight}");
        Console.WriteLine($"Is a Mammal?: {isMammal}");
        Console.WriteLine($"Color: {color}");
    }
}


