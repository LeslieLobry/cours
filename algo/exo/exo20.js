//ecrire un algo permettant de saisir 15 note
let tableau = []
let message = ""
for (let i = 1; i<=15; i++)
    {
        tableau.push(Number(prompt("entrer une valeur " +i)))
        
    }
for  (let i = 0; i<15; i++){ // permet d'afficher les valeurs à la ligne  on commence à 0 car tableau à 0 au commencement
message+=tableau[i]+"\n"
}
 alert(message)