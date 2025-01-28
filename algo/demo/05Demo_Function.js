// fonction qui divise
let firstNumber = 10
let secondaire =5
let resulta = division(firstNumber, secondaire)

console.log(resulta)

function division (a,b){
    let result =0; 
    if(b != 0){
        result = a/b
    }else{ // si on divise par 0
        console.log("division pas possible")
        return null
    }
    
    return result
}

// procedure (ne renvoi rien)
procedure()

function procedure (){
let firstNumber = 10
let secondaire =5
let resulta = division(firstNumber, secondaire)
console.log(resulta)
}