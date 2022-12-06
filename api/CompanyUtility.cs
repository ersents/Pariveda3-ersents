namespace api
{
    public class CompanyUtility
    {
        public List<Company> companies {get; set;}

        public CompanyUtility(List<Company> temp){
            companies = temp;
        }

        public CompanyUtility(){
            
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

        public void SaveCompany(Company company){

            StreamWriter outFile = new StreamWriter("companies.txt", true);
            outFile.WriteLine();
            outFile.Write(company.Name+"#"+company.Ticker+"#"+company.SharePrice);
            outFile.Close();
        }

        public void DeleteCompany(string name) 
        {
            string tempFile = Path.GetTempFileName();
            using(var inFile = new StreamReader(@"companies.txt"))
            using(var outFile = new StreamWriter(tempFile))
            {
                string line = inFile.ReadLine();
                while(line != null)
                {
                    string[] temp = line.Split('#');
                    if(temp[0] != name)
                    {
                        outFile.WriteLine(line);
                    }
                    line = inFile.ReadLine();
                }
            }
            File.Delete("companies.txt");
            File.Move(tempFile, "companies.txt");
        }

    }


}