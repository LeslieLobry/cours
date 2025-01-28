var copie = prompt ("choississez votre nombre de copie : ")

if (copie <= 10 && copie >=0){
    prix= copie*0.5
 alert("le montante est de "+prix)
} else if(copie => 20 ){
    prix= copie*0.3
    alert("le montante est de "+prix)
} else if(copie => 0) {
    prix = copie*0.4
    alert("le montante est de "+prix)
}

// correction : 

if(copie <10){
    alert("le prix est de :"+copie*0.5 +"€")
} else if ( copie <= 20){
    alert("le prix est de :"+copie*0.4 +"€")
} else {
    alert("le prix est de :"+copie*0.3 +"€")
}
 

// ou plus simple et - de code : 

let coef = 0.3
if   (copie <10){
    coef = 0.5
} else if (copie <= 20){
    coef = 0.4
}
alert ("le prix est de :" +copie * coef+"€")