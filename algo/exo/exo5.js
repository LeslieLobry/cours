var capital = prompt ("choississez votre capital : ")
var annee = prompt ("choississez le nombre d'année : ")
var taux = prompt("choisissez votre taux : ")



// if(taux>0){
//     pourcentage=taux/100
// } else if(capital <=0) {
//     alert(erreur)
// }
var calcul = capital*Math.pow((1+taux/100),annee)
alert("votre capital de base : "+capital+" € sera de "+calcul+" après "+annee+ " année et un taux de  " +taux +" soit un gain de :  "+(calcul-capital).toFixed(2))+"€"  


