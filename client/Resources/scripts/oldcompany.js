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
    let html = ''
    companies.forEach(company => {
        html += `<p><b>${company.name}    ${company.ticker}    ${company.sharePrice} </b></p>`
    });
    document.getElementById("companyList").innerHTML = html
}