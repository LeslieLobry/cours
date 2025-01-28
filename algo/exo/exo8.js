var AB = prompt("valeur de AB ")
var BC = prompt("valeur de BC ")
var CA = prompt("valeur de CA")


if (AB == BC) {  // vérifie un des coté
    if (BC == CA) { // si l'autre aussi == du coup équi
        alert("équilatéral")
    } else {
        alert("isolatéral en B ") 
    }
} else if (AB == CA) {
    alert("isolatéral en A ")
} else if (BC == CA) {
    alert("isolatéral en C ")
} else {
    alert("triangle pas isolatéral")
}