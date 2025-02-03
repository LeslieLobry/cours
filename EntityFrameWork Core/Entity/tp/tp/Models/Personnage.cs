using System;
using System.ComponentModel.DataAnnotations;

internal class Personnage
{
    public int  Id { get; set; }

    public string? Pseudo { get; set; }	 
    [Required]  
 	public int PointdsDeVie { get; set; }
    public int Armure { get; set; }
    public int Degats { get; set; }
    public DateTime DateCreation { get; set; }
    public int NombrePersonnesTues { get; set; }


    public override string ToString()
    {
        return $"{GetType().Name} :Pseudo = {Pseudo}, PointdsDeVie = {PointdsDeVie},Armure ={Armure} Degats = {Degats}, Date de création= {DateCreation}, kill : {NombrePersonnesTues}";
    }

}


