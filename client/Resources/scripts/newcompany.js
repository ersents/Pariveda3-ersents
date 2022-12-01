const baseUrl = "https://localhost:7214/api/Company";

function getCompany(){
    

    fetch(allCompanysApiUrl).then(function(response){
        console.log(response);
        return response.json();
    }).then(function(json){
        let html = "<ul>";
        json.forEach((company)=>{
            html += "<li>" + company.Name + company.Ticker + company.sharePrice + "</li>";
        });
        html += "</ul>";
        document.getElementById("companies").innerHTML = html;
        console.log(json);
    }).catch(function(error){
        console.log(error);
    });
}

function putCompany(companies){
    const allCompanysApiUrl = baseUrl;
    const sendCompany = {

        name: document.getElementById("companyname").value,
        ticker: document.getElementById("ticker").value,
        sharePrice: document.getElementById("shareprice").value,
        
    }
    fetch(allCompanysApiUrl, {
        method: "PUT",
        headers: {
            "Accept": 'application/json',
            "Content-Type": 'application/json',
        },
        body: JSON.stringify(sendCompany)
    })
    .then((response)=>{ //declared but never used, where would i use this
        companies = sendCompany;
        populateList();
        populateForm();
    });

}

function PostCompany(){
    var companyName = document.getElementById("companyname").value;
    var companyTicker = document.getElementById("ticker").value;
    var companySharePrice = document.getElementById("shareprice").value;
     alert("Company: " +companyName + " Ticker: " +companyTicker+ " Share Price: "+companySharePrice)
  
}


function PostCompany2(){
    const postCompanysApiUrl = baseUrl;
    const companyName = document.getElementById("companyname").value;
    const companyTicker = document.getElementById("ticker").value;
    const companySharePrice = document.getElementById("shareprice").value;
    console.log(companyName, companyTicker, companySharePrice)
    
    fetch(postCompanysApiUrl, {
        method: "POST",
        headers: {
            "Accept": 'application/json',
            "Content-Type": 'application/json',
        },
        body: JSON.stringify({
            Name: companyName,
            Ticker: companyTicker,
            SharePrice: companySharePrice
        })
    })
    .then((response)=>{
    console.log(response);
    // getCompany();
    });
}