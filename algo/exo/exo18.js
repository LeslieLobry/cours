let nbrA = Number(prompt("entrer une valeur A:"))
let nbrB = Number(prompt("entrer une valeur B"))
let resulta = max(nbrA,nbrB)



function max (a, b){
 let result = 0 // on mets 0 pour initialiser
 if(a>b){ // on vérifie si a et plus grand que b
    result=a // si oui on met dans le resultat
 }
 else{
    result=b // sinon on met b si il est plus grand 
 }
return result
}

alert("votre chiffre le plus grand des deux est :"+resulta)