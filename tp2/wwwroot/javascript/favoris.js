const 
    init = () => {
        render()
    },
    render = () => {
        /**
         * Récupère les favoris de l'utilisateur
         * et les affiche dans la div #IDE
        */
        $.get('/api/favorites', async(data) => {
            let fav = await data;
            JSON.parse(fav).forEach(ide => {
                document.querySelector("#IDE").innerHTML += `
                    <div class="card carte">
                        <div class="card-body">
                            <div class="row">
                                <div class="row">
                                    <div class="col-2">
                                        <img src="${ide.Field4}" class="img-fluid">
                                    </div>
                                    
                                    <div class="col-10">
                                        <h2>${ide.Field0}</h2>
                                        <h4>Category: ${ide.Field1}</h3>
                                        <p>${ide.Field2}</p>
                                    </div>
                                </div>
                            <div class="col-12">
                                <img
                                    src="/cdn/upload/trashcan.png"
                                    class="img-fluid fav" id="${ide.Field0.replace(/ /g, "-")}"
                                    alt="pic id code"
                                    onClick="removeFavorite('${ide.Field0.replace(/ /g, "-")}')"
                                    role="button"
                                    tabIndex="0"
                                />
                            </div>
                        </div>
                    </div>
                `
                /*
                Ajoute un event listener sur l'élément avec l'id de l'IDE
                Au click, on appelle la fonction removeFavorite avec l'IDE en paramètre
                et on supprime la div parente de l'élément cliqué
                */
                setTimeout(() => {
                    document.querySelector(`#${ide.Field0.replace(/ /g, "-")}`).addEventListener('click', () => {
                        removeFavorite(ide.Field0)
                        document.querySelector(`#${ide.Field0.replace(/ /g, "-")}`).parentNode.parentNode.parentNode.parentNode.remove()
                    })
                }, 1000)
            })
        })
    },
    removeFavorite = (IDE) => {
        /**
         * Supprime un favori de la base de données
         */
        $.ajax({
            url: '/api/favorites', 
            type: "DELETE",
            data: JSON.stringify({name: IDE}), 
            success: function(data) {}
        })
    }