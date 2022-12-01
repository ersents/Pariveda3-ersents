const baseUrl = 'https://localhost:7214/api/company'      

function PostCompany(){
    var companyName = document.getElementById("companyname").value;
    
     alert("Company: " +companyName )
  
}

function handleOnLoad(){
    getAllCompanies()
}

function getAllCompanies(){
    const allCompaniesUrl = baseUrl
    fetch(allCompaniesUrl).then(function(response){
        return response.json()
    }).then(function(json){
        console.log(json)
        createTable(json)
    })
}

function createTable(companies){
    let html = `<table class="table table-dark table-striped">
                    <tr>
                        <th>Company</th>
                        <th>Ticker</th>
                        <th>Shareprice</th>
                    </tr>`

    companies.forEach(company => {
        html += `<tr>
                    <td>${company.name}</td>
                    <td>${company.ticker}</td>
                    <td>${company.sharePrice}</td>
                </tr>`
    });
    html += `</table>`
    document.getElementById("companyList").innerHTML = html
}