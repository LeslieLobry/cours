// boucle while

let i = 0
let som = 0
while (som <= 100) {
    i = i + 1 //i++  ou 
    som += i // som = som +i
}
alert("la valeur cherchée est N =" + i + "est la somme vaut" + som)


// ! attention si j'inverse : i et som le calcul n'est pas le meme 

while (som <= 100) {
    som += i // som = som +i
    i = i + 1 //i++  ou 

}
alert("la valeur cherchée est N =" + i + "est la somme vaut" + som)


// boucle For (pour)

let somme = 0

for (let i = 1; i <= 10; i++) { //++ =1 si tu veux un incrément + que 1 +=2
    // valeur ; //conditions,//le pas (accrémentation)
    somme += i // somme = somme+1
}

alert("la somme des 10 premiers entiers vaut : " + somme)


//on peut mettre aussi des variable

let somme = 0
let final = 10
let initial = 1
let pas = 1
for (let i = initial; i <= final; i = i + pas) { //++ =1 si tu veux un incrément + que 1 +=2
    // valeur ; //conditions,//le pas (accrémentation)
    somme += i // somme = somme+1
}

// do while

 let input
do {
    input= prompt("entrer une valeur entre 1 et 3")
} while (input < 1 || input > 3)
    alert("valeur entrée : "+input)


//boucle imbriquée

for(let i =0; i<6; i++){
    let message= ""
    for(let j=0; j<=i; j++){ // attention de pas remettre i à la place de j sinon ça beug à l'infini :)
        message += "0"
    }
    message += "*"
    console.log(message)
}