

// function abracadabra (){
//     let nom= prompt('quel est votre nom: ');
//     let prenom=prompt("quel est votre prenom:");
//     let age=prompt("quel est votre age:");
//     alert("Sapristi ! On ne m'avait pas prévenu que c'était vous, "+prenom+"! Euh... Je veux dire... Monsieur le grand magicien" +nom+ "! Cela fait déjà "+age+ "ans que vous faites rayonner notre contrée !")
// }
// abracadabra()


let poids = Number(prompt('quel est votre poids: '));
let taille = Number(prompt('quel est votre taille: '));  


function calculerIMC (poids, taille){

   
    let tailleM = taille/100;
    let tailleCarre =  Math.pow(tailleM,2);
    let imc = poids / tailleCarre;
    return imc
    
}
alert(calculerIMC(poids, taille))


// let poids   = prompt("Quel est votre poids ? (en kg)");
// let taille  = prompt("Quelle est votre taille ? (en cm)");
// function calculerIMC(poids, taille) {
    
//     // Converti la taille en centimètres => mètres
//     let tailleEnMetres = taille / 100;
  
//     // Calcule la taille à la puissance 2
//     let tailleCalculee = Math.pow(tailleEnMetres, 2);
  
//     // Calcule l'IMC
//     let resultat       = poids / tailleCalculee;

//     // Retourne notre résultat
//     return resultat;
  
//     // Version simplifiée de cette fonction : return poids / Math.pow((taille / 100), 2);

// }


// alert(calculerIMC(poids, taille));
