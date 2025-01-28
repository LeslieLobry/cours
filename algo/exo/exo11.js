var capital = prompt ("choississez votre capital : ")
var annee = 0
var taux = prompt("choisissez votre taux : ")
var capitalFinal = capital*2


// while (somme <= capital*2){ // !!ce que tu ne veux pas en condition 
//    somme = capital*Math.pow((1+taux/100),annee)
//    annee++

// }  
// alert("il vous faudra "+annee+" année pour doubler votre ")


// correction 

while (capital <= capitalFinal){
   capital *=(1+taux/100) // *= > capital=capital*(1+taux/100)
   annee++
}
alert("il vous faudra "+annee+" année pour doubler votr capital ")