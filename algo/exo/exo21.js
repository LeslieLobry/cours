//ecrire un algorithme permettant la saisie des notes d'un classe de 15 étudiant pour 3 matières
let tableau = []
let message = ""
let etudiant = 3
let note = 3
for (let i = 0; i<etudiant; i++){
    
    let tableau2=[]
    for(let j=0; j<note; j++){
       
        tableau2.push(prompt("éléve "+([1+i])+" ecrire vos notes : "+([j+1])))
    }
    tableau.push(tableau2)
    
}
for  (let i = 0; i<etudiant; i++){ // permet d'afficher les valeurs à la ligne  on commence à 0 car tableau à 0 au commencement
    message+="numéro étudiant : "+(i+1)+ "les notes : "+  tableau[i]+"\n"
    }
console.log(tableau)
console.log(tableau.length) // nombre d'éléments
alert(message)