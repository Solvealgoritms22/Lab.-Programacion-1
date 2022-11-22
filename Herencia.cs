using System;

public class F:G
{
    private string x="Ferreiras, Castro";
    private double y=12.34E+12;
    private long z=987364354;
    protected byte w=34;
    
    public F(string x, double y, long z, byte w){
        this.x=x;
        this.y=y;
        this.z=z;
        this.w=w;
    }

    public string getX(){

      return this.x; 
    }

    public double getY(){
        
       return this.y; 
    }

    public long getZ(){

       return this.z; 
    }

    public void verObjeto(){
       Console.WriteLine(getX());
       Console.WriteLine(getY());
       Console.WriteLine(getZ());

    }

}

public class G
{
    private int s=98888833;
    
}

public class TesterClass
{
    public static void Main(String[] args){
        
        F Objeto1 = new F("Darling, Fajardo",13.34E+12,999364354,50);
        Objeto1.verObjeto();
        
    }


}