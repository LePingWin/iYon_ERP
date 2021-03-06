# iYon
## Groupe : 
- Loïc BINE
- Laurent FREYSS
- Julien GROLL
- Jean STILL

### Execution de l'application
Afin d'éxecuter le programme il faut double cliquer sur l'executable iYon_ERP.exe (application console). Par passer d'un jeu de test à un autre il suffira d'appuyer une touche du clavier.
L'application affichera un resultat du type :

```
------ INIT -----
DaysBeforeEmployeeOperational : 00:00:00.0000120
SimulationFilesPath : .\..\..\Datas
StartSimulationDate : 01/06/2018 00:00:00
Efficiency : 100%

------ Employees -----
Name: Laurent Freyss| HireDate: 01/01/2018 | Role: Developer
Name: Jean Still| HireDate: 01/01/2018 | Role: Developer
Name: Julien Groll| HireDate: 01/01/2018 | Role: Developer
Name: Loic Bine| HireDate: 01/01/2018 | Role: ProjectManager

------ Projects -----
Name: Airbus| Deadline:01/12/2018 18:00:00 | TotalWorkLoad: 190 days
Name: NINETENDO| Deadline:01/09/2018 18:00:00 | TotalWorkLoad: 100 days
Name: HTC VR| Deadline:01/01/2019 18:00:00 | TotalWorkLoad: 195 days

----- Results TestGame 1/4 ------
Project : NINETENDO | ProjectEnd : 05/07/2018
Detailled -- DevsTimeEnd : 05/07/2018 | ProjectManagementEnd : 05/07/2018

Project : Airbus | ProjectEnd : 30/08/2018
Detailled -- DevsTimeEnd : 13/09/2018 | ProjectManagementEnd : 30/08/2018

Project : HTC VR | ProjectEnd : 01/11/2018
Detailled -- DevsTimeEnd : 22/11/2018 | ProjectManagementEnd : 01/11/2018
```
Si le texte est en vert cela veut dire que tous les projets pourront être terminés dans les temps.
Si le texte est en rouge cela veut dire que les projets en rouge dépassent la deadline. 

### Hypothèses
On dispose de 4 personnes : 1 Chefs de Projets et 3 Développeurs

- Durée réelle : Durée théorique / Efficience (ex: 20 jours théorique / 80% = 25 jours réels)
- L'efficience est la même pour tous les projets
- 2 rôles : Chef de Projet ou Développeur. Les rôles ne sont pas cumulables 
- La priorité est de terminer les projets dont la date de fin est la plus proche de la date de début de simulation
- Employé utilisable au bout de 4 mois après l'embauche
- Les ressources sont interchangeables
- Les projets se suivent
- Un jour entammé est un jour complet consommé
- Pour la question E, les employés auront toujours 120% d'efficience

### Jeux de test 
Pour réaliser nos jeux de tests nous utilisons des fichiers json. Ce sont donc ces derniers à modifier pour changer le deroulement des jeux de tests de l'ERP.

- Dans le fichier : \iYon_ERP\Datas
- Config.json : Contient l'efficience des jeux de tests.
- Employees.json : Contenu de tous les employés disponibles dans l'application.
- Projects.json : Contenu de tous les projets disponibles dans l'application.
- JeuSetEtMatch.json : Contient une config, une liste d'employés et une liste de projets. Le lien vers les autres fichiers json de données se fait avec leurs ID.
- Si l'on souhaite rajouter, par exemple, un nouveau projet il faut le créer dans le fichier Projects.json et renseigner son ID dans le fichier JeuSetEtMatch.json

#### Question D
Pour arriver à finir dans les temps tous les projets il faut embaucher des personnes en dev et en gestion de projet.

#### Question E
Pour répondre à cette question nous avons eu deux version, la première : Si un employé devient opérationel lors d'un projet en cours il n'interviendra que sur le projet suivant (les jours entre le moment ou l'employé est opérationel et la fin du projet sont perdus)
Il aurait fallu embaucher :
- Trois développeurs
- Un chef de projet

Pour la deuxième version plus "logique" : Quand un employé devient opérationnel au plein milieu d'un projet, il est alors affecté directement au projet en cours.
Il faudra donc dans ce cas embaucher :
- Deux developpeurs
- Un chef de projet


Lien du GitHub : https://github.com/LePingWin/iYon_ERP
