# Exercic en fin de chapite des delegate en C# OO

Définir dans un nouveau projet un nouveau type de délégué ne revoyant rien et recevant en paramètre une «Voiture ».

 La classe voiture contient :
 
 . une propriété « Plaque » de type string et en lecture seule
 
 . unconstructeur recevant le numéro de plaque en paramètre.
 
## Exercices :
 ### 1. Créer une classe Carwash contenant 5 méthodes
    
 . private void Préparer(Voiture v) qui affiche « je prépare la voiture : {plaque} »
 
 . private void Laver(Voiture v) qui affiche « je lave la voiture :{plaque} »
 
 . private void Secher(Voiture v) qui affiche « je sèche la voiture :{plaque} »
 
 . private void Finaliser(Voiture v) qui affiche « je finalise la voiture :{plaque} »
 
 . public voidTraiter(Voiture v) qui exécute les 4 méthodes précédentes dans l’ordre à l’aide d’un délégué.
 
 ### 2. Remplacer les méthodes par des méthodes anonymes
