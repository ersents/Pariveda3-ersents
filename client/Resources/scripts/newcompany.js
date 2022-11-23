function getCompany(){
    const allCompanysApiUrl = "https://localhost:7214/api/Company";

    fetch(allCompanysApiUrl).then(function(response){
        console.log(response);
        return response.json();
    }).then(function(json){
        let html = "<ul>";
        json.forEach((company)=>{
            html += "<li>" + company.Name + "ticker symbol" + company.Ticker + company.sharePrice + "</li>";
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

        name: document.getElementById("Name").value,
        ticker: document.getElementById("Ticker").value,
        sharePrice: document.getElementById("Share Price").value,
        
    }
    fetch(allCompanysApiUrl, {
        method: "PUT",
        headers: {
            "Accept": 'application/json',
            "Content-Type": 'application/json',
        },
        body: JSON.stringify(sendCompany)
    })
    .then((response)=>{
        companies = sendCompany;
        populateList();
        populateForm();
    });

}

function postBook(){
    const postCompanysApiUrl = baseUrl;
    const companyName = document.getElementById("Name").value;
    const companyTicker = document.getElementById("Ticker").value;
    const companySharePrice = document.getElementById("SharePrice").value;
    
    fetch(postCompanysApiUrl, {
        method: "POST",
        headers: {
            "Accept": 'application/json',
            "Content-Type": 'application/json',
        },
        body: JSON.stringify({
            name: companyName,
            ticker: companyTicker,
            sharePrice: companySharePrice
        })
})
.then((response)=>{
    console.log(response);
    getCompany();
});
}