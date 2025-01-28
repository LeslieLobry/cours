// concevoir un algo qui imprime, pour n saisi l'utilisateur ex pour 5
//1
//12
//123
//1234

let input = Number(prompt("mettre un chiffre"))
let message = ""


for(let i =1; i<=input; i++){
    for(let j=1; j<=i; j++){ 
        
        message += j
        if (j == i){
           message += "\n"     
        }
    }
}
console.log(message)

// avec une seule boucle 
let message =""
for (let i =1; i<=input; i++){
    message += + ""
    console.log(message)
}