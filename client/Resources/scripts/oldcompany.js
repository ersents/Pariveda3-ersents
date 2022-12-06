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
    let html = `<table class="table table-dark table-hover" style="margin-top:150px">
                <thead>
                    <tr>
                        <th>Company</th>
                        <th>Ticker</th>
                        <th>Shareprice</th>
                        <th>Delete</th>
                    </tr>
                </thead>`

    companies.forEach(company => {
        html += `<tbody>
                <tr>
                    <td>${company.name}</td>
                    <td>${company.ticker}</td>
                    <td>${company.sharePrice}</td>
                    <td><button onclick="deleteCompany('${company.name}')">Delete</button></td>";
                    
                </tr>
                </tbody>`
    });
    html += `</table>`
    document.getElementById("companyList").innerHTML = html
}
function deleteCompany(name = "Mike"){
    console.log('made it to the delete')
    const deleteCompaniesApiUrl = baseUrl + "/" + name;
    fetch(deleteCompaniesApiUrl, {
        method: "DELETE",
        headers: {
            "Accept": 'application/json',
            "Content-Type": 'application/json',
        }
    })
    .then((response)=>{
        getAllCompanies();
    });
}