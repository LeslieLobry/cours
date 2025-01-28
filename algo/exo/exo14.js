// algo qui demande un nombre de départ et qui calcule la somme des entiers jusqu'à ce nombre
// exemple si on rentre 4; le programme doit calcul 1+2+3+4=10

let chiffre = Number(prompt("choissisez un chiffre : "))
let somme =0
for (let i = 1; i <= chiffre; i = i +1) { //++ =1 si tu veux un incrément + que 1 +=2
    // valeur ; //conditions(nombre de fois, ou montant....),//le pas (accrémentation)
    somme = somme+i
    console.log(somme)
}


//correction 

let input= Number(prompt("choissisez un chiffre : "))
let somme =0
let message = ""

for (let i = 1; i <= input; i = i +1) { //++ =1 si tu veux un incrément + que 1 +=2
    // valeur ; //conditions(nombre de fois, ou montant....),//le pas (accrémentation)
    somme +=i
    message += i + "+"
}
message += "="+somme
alert(message)


