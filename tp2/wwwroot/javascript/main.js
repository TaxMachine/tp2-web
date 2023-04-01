const
    init = () => {
        defaultitems()
    },
    defaultitems = () => {
        /**
         * Récupère les favoris de l'utilisateur
         * et les affiche dans la div #IDE
        */
        $.get('/api/items', async(data) => {
            let items = await data;
            parsed = JSON.parse(items)
            parsed.forEach(ide => {
                var checked = ide.Field5 == 1 ? "checked" : "";
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
                            <img src="/cdn/upload/${checked == 0 ? "star-clear.png" : "star-filled.png"}" class="img-fluid fav" id="${ide.Field0.replace(/ /g, "-")}">
                        </div>
                    </div>
                </div>
                `
                setTimeout(() => {
                    /**
                     * Ajoute un event listener sur l'élément avec l'id de l'IDE
                     * Au click, on appelle la fonction addFavorite avec l'IDE en paramètre
                     * et on change l'image de l'étoile
                     */
                    document.querySelector(`#${ide.Field0.replace(/ /g, "-")}`).addEventListener('click', () => {
                        console.log(`${ide.Field0.replace(/ /g, "-")} added to event listeners`)
                        switch (checked) {
                            case "":
                                addFavorite(ide.Field0)
                                checked = "checked"
                                document.querySelector(`#${ide.Field0.replace(/ /g, "-")}`).src = "/images/star-filled.png"
                            break
                            case "checked":
                                removeFavorite(ide.Field0)
                                checked = ""
                                document.querySelector(`#${ide.Field0.replace(/ /g, "-")}`).src = "/images/star-clear.png"
                            break
                        }
                    })
                }, 1000)
            });
        })
    },
    addFavorite = (ide) => {
        /** 
         * Ajoute un favori à la base de données
         */
        $.post('/api/favorites', JSON.stringify({name: ide}), (data) => {
            console.log(data);
        })
    },
    removeFavorite = (ide) => {
        /**
         * Supprime un favori de la base de données
         */
        $.ajax({
            url: '/api/favorites', 
            type: "DELETE",
            data: JSON.stringify({name: ide}), 
            success: function(data) {}
        })
    }