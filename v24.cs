namespace v24
{
    class Kalkulator
    {
       public int umum = 4;
       
       private int privasi = 5;

       protected int khusus = 6;

       public int hasil(){
        return this.privasi;
       }
    }

    class Rumus:Kalkulator
    {
       public int tampil(){
           return this.khusus;
       }
    }
}