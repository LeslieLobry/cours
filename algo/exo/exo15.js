// ecrire algo qui permet d'afficher les tables de multiplication des nombres de 1 à 10 d'un seul coup


for (let i = 1; i <= 10; i++) {
    let message = ""
    message = "la table de  " + i + " est :"
    console.log(message)
    for (let j = 1; j <= 10; j++) { // attention de pas remettre i à la place de j sinon ça beug à l'infini :)

        console.log(i + "x" + j + "=" + (i * j))
    }
}