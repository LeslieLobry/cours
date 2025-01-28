//afficher le 8eme valeur d'un tableau
let tableau = []  // précise que c'est un tableau 

tableau.push(12) //permet d'inserer elmt dans le tableau 
tableau.push(15) 
tableau.push(18)   


let valut = tableau[2]   // pour récupérer valeur 18
let taille = tableau.length
// pour récupérer toutes les valeurs

for(let i=0; i<taille ; i++){ /// on peut mettre directement tableau.length à la place de taille 
    console.log(tableau[i])
    
}

let tableau2 = []
 
    for (let i = 0; i<10; i++)
    {
        tableau2.push(prompt("...."))
    }
console.log(tableau[8])

// double entrée tableau 

let tableau2d = [[14,12,15],[9,17,15],[13,12,10], [9,10,12]]  // 4 étudiants avec 3 notes chacun

etudiant1 = tableau2d[0]  //pour récuper le tableau complet du 1er étudiant
etudiant1note1 = tableau2d[0][0]//pour récuper la 1ere note du 1er étudiant
console.log(etudiant1)
console.log(etudiant1note1)

for (let i = 0; i<4; i++){
    console.log("etudiant n"+(i+1))
    for(let j=0; j<3; j++){
        console.log("Note n"+ (j+1)+ ":" +tableau2d[i][j])
    }
}