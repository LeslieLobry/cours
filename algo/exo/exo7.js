let age = prompt("quel est votre age :  ")
age = Number(age);
switch(age){
    case 3:
    case 4:
    case 5:
    case 6:
        alert("baby");
        break;
    case 7:
    case 8: 
        alert("Poussin")
        break
    case 9:
    case 10: 
        alert("pupille")
        break
    case 12: 
    case 11:
        alert("minime")
        break
    case 13: 
        alert("cadet")
        break
    default: 
        break
}
console.log(age)

//correction : 

if(age<6){
    alert("baby");
} else if (age <= 8) {
    alert("poussin");
}
// ainsi de suite