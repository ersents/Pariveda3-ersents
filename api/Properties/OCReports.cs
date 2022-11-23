namespace api.Properties
{
    public class OCReports
    {
        private Company[] companies;

        public static bool Name { get; private set; }

        public OCReports(Company[] companies)
        {
            this.companies = companies;
        }
         public void PrintAllItems()
        {
            for(int i = 0; i < Company.GetCount(); i++)
            {
                System.Console.WriteLine(companies[i].ToString());
            }
        }

        static void PrintCompany(){
            System.Console.WriteLine();
        }

        
        
    }
}