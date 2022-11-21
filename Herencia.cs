using System;

public class G:F
{
    private int s=9998833;
    public int gets(){
        return this.s;
    }
}

public class F
{
    private string x="Ferreiras, Castro";
    private double y=12.34E+12;
    private long z=987364354;
    protected byte w=34;
    
    public F(){

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
       G Objeto1 = new G();
       Console.WriteLine(Objeto1.gets());

    }

}

public class TesterClass
{
    public static void Main(String[] args){

        F Objeto1 = new F();
        Objeto1.verObjeto();
        
    }


}