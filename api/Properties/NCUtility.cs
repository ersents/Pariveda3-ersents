namespace api.Properties
{
    public class NCUtility
    {
        private Company[] companies;
        public NCUtility(Company[] companies){
            this.companies =companies;
        }

  
//not sure if i need get all companies? this always confuses me
        // public void GetAllCompanies(){
        //     //3 steps: open ,process, close
        //     Company.SetCount(0);
        //     StreamReader inFile = new StreamReader("#"); //open
        //     string line = inFile.ReadLine(); //Prime read

        //     while(line != null){ //process and check
        //         string[] temp = line.Split("#");
        //         //string name, string ticker, double share price
        //         companies[Company.GetCount()] = new Company(temp[0], temp[1], double.Parse(temp[2]));
        //         Company.IncCount();

        //         line = inFile.ReadLine();
        //     }
        //     inFile.Close(); //close
        // }
        public void Save()
        {
            StreamWriter outFile = new StreamWriter("#"); //# placeholder
            for(int i = 0; i < Company.GetCount(); i++)
            {
                outFile.WriteLine();
            }
            outFile.Close();
        }
    }
}