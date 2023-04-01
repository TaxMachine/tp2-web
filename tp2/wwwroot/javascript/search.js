/*
    * Récupère les résultats de la recherche
*/
const getSearchResults = async (searchTerm, category, favorite) => {
    var query = searchTerm ? `keyword=${searchTerm}` : "";
    query += searchTerm.length > 0 ? `&category=${category}` : "";
    query += category ? `category=${category}` : "";
    query += searchTerm.length > 0 ? `&favorite=${favorite}` : "";
    query += favorite ? `favorite=${favorite}` : "";
    console.log(query)
    const response = await fetch(`/api/search?${query}`);
    const data = await response.json();
    return data;
}
/*
    * Affiche les résultats de la recherche
*/
const displaySearchResults = async () => {
    const searchTerm = document.querySelector("#search").value;
    const category = document.querySelector("#category").value;
    const favorite = document.querySelector("#favorite").checked ? 1 : 0;
    const results = await getSearchResults(searchTerm, category, favorite);
    if (results.length == 0) {
        return document.querySelector("#searchResults").innerHTML = `
        <div class="card carte">
            <div class="card-body">
                <div class="row">
                    <div class="row">
                        <div class="col-12">
                            <h2>No results found</h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        `
    }
    results.forEach(result => {
        document.querySelector("#searchResults").innerHTML += `
        <div class="card carte">
            <div class="card-body">
                <div class="row">
                    <div class="row">
                        <div class="col-2">
                            <img src="${result.Field4}" class="img-fluid">
                        </div>
                        
                        <div class="col-10">
                            <h2>${result.Field0}</h2>
                            <h4>Category: ${result.Field1}</h3>
                            <p>${result.Field2}</p>
                        </div>
                    </div>
                <div class="col-12">
                    <img src="/cdn/upload/${result.Field5 == 1 ? "star-filled.png" : "star-clear.png"}" class="img-fluid fav" id="${result.Field0.replace(/ /g, "-")}">
                </div>
            </div>
        </div>
        `
    })
}
