CREATE TABLE Personne (
    id INT PRIMARY KEY IDENTITY(1,1),     -- Identifiant unique
    nom NVARCHAR(50) NOT NULL,     
    prenom NVARCHAR(50) NOT NULL,     
    classe INT NOT NULL,                    
    datediplome DATETIME2,             
);

SELECT *
FROM Personne


DROP TABLE Personne
