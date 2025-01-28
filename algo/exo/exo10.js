// l'exo est de demandé un chiffre compris entre 1 et 3 du coup si pas ok à chaque fois il remet la balise pour rentrer un autre nombre


let nbr = prompt('entrer un nombre entre 1 et 3')

while (nbr <1 || nbr >3 ){ // !!ce que tu ne veux pas en condition 
  alert("mauvaise valeur")
  nbr = prompt('entrer un nombre')
}  
alert("bravo")