namespace api
{
    public class CompanyUtility
    {
        public List<Company> companies {get; set;}

        public CompanyUtility(List<Company> temp){
            companies = temp;
        }

        public void GetAllCompanies(){
            StreamReader inFile = new StreamReader("companies.txt");

            //priming read
            string line = inFile.ReadLine();

            while(line != null){
                string[] temp = line.Split("#");

                Company tempCompany = new Company();
                tempCompany.Name = temp[0];
                tempCompany.Ticker = temp[1];
                tempCompany.SharePrice = double.Parse(temp[2]);

                companies.Add(tempCompany);

                //update read
                line = inFile.ReadLine();
            }
            inFile.Close();
        }
    }
}