//

let nbrfois = 3
let somme
let max = 0
let total = 0
let bas = 0

for (let i = 1; i <= nbrfois; i++) { //++ =1 si tu veux un incrément + que 1 +=2
    // valeur ; //conditions,//le pas (accrémentation)
    somme = Number(prompt("entre un chiffre,nombre de fois:" + i))
    if (i == 1) {
        bas = somme // pour éviter que 0 soit le plus petit nombre 
        max = somme
    }
    if (somme >= max) { // on crée une variable pour stocker le chiffre pour avoir le plus grand 
        max = somme
    }
    if (somme <= bas) {
        bas = somme
    }
    total = total + somme
}

// alert("votre plus grand chiffre est " + max)
// alert("votre plus bas chiffre est " + bas)
// alert("la moyenne  est " + total / nbrfois)
// alert(total)

let exit = false;
while (!exit) {
    let input = prompt("1/ afficher la plus petite note \n 2/ afficher la plus grande note \n 3/ la moyenne  est \n")
    switch (input) {
        case "1":
            alert("votre plus bas chiffre est" + min)
            break
        case "2":
            alert("votre plus bas chiffre est" + max)
            break
        case "3":
            alert("votre plus bas chiffre est" + total / nbrfois)
            break
        default:
            exit = true
    }

}