// la ville de tg à un taux d'accroissement de 0.89%
// écrire un algorithme donnant le nombre d'années nécessaire pour attenidre 120 000 hbts
//on sait qu'en 2015 la ville de Tourcoing comptait 96809 hbts
let habitant =96809
let conditions = 120000
let annee = 0
let taux = 0.0089

while ( habitant <= conditions){
    habitant = habitant*(1+taux)
   annee = annee+1

}
alert( annee +" " + habitant.toFixed(2) )