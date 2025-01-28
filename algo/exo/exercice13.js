//ecrire un algo qui demande successivement 6 nombres à l'utilisateur, et qui lui dit ensuite quel était le plus grand parmi les 6
let final = 6
let pas = 1
let somme
let max = 0 // si on mets null permet de gérer les négatifs
for (let i = 1; i <= final; i = i + pas) { //++ =1 si tu veux un incrément + que 1 +=2
    // valeur ; //conditions,//le pas (accrémentation)
    somme = Number(prompt("entre un chiffre,nombre de fois:" + i))
    if (somme >= max) {  // on crée une variable pour stocker le chiffre pour avoir le plus grand 
        max = somme
    }
}
alert("votre plus grand chiffre est " + max)