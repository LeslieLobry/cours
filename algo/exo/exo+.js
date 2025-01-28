// let chiffreMystère = (Math.random()*100).toFixed(0) // chiffre aléatoire sans , 
let chiffreMystère = (Math.random()*100).toFixed(0)// chiffre aléatoire 
let tentative = 5
let nombre = Number(prompt("quel est le chiffre mystère (entre 1 et 100"))


while (nombre != chiffreMystère && tentative > 1  ){  // boucle car on ne sait pas en combien de fois l'utilisateur peut trouver mais on a un chiffre fixe (tant que )
     tentative = tentative -1

if(nombre > chiffreMystère){
    if (nombre >= 1 && nombre <= 100) {
        console.log(nombre)
    } else {
        alert("on a dit entre 1 et 100!")
        prompt("recommence")
    
    }
alert("c'est moins")
    nombre = prompt("essaye à nouveau, il vous reste : " +tentative)
}
 if (nombre < chiffreMystère){
    alert("c'est plus")
    nombre = prompt("essaye à nouveau, il vous reste : " +tentative)
} 
if (tentative <=1){
    alert ("vous avez perdu ! ")
}
}
 if (chiffreMystère==nombre){
   alert("bravo tu as trouvé il restait : "+tentative) 
}

