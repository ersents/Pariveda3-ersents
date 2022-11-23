namespace api
{
    public class Company
    {
        public Company(string name, string ticker, double sharePrice)
        {
            Name = name;
            Ticker = ticker;
            SharePrice = sharePrice;
            
        }

        public Company()
        {
        }

       
        

        public string Name { get; set; }
        public string Ticker { get; set; }
        public double SharePrice { get; set;}
        
        private static int count { get; set;}
        
        public void InsertCompany(string Name){

        }

        public static void IncCount(){
            count++;
        }
        public static void SetCount(int count){
            Company.count = count;
        }

        static public int GetCount(){
            return count;
        }
        public override string ToString(){
            return Name + "\t" + Ticker + "\t" + SharePrice ;
        }
        
    }
}