# DiapoStartup

DiapoStartup est une application console en C# conçue pour lancer automatiquement, au démarrage de Windows 10, une vidéo spécifique basée sur la semaine ISO de l'année. La vidéo, au format MP4, est lue via Windows Media Player en plein écran et en boucle.

## Fonctionnalités

- **Calcul de la semaine ISO** : Détermine automatiquement la semaine actuelle de l'année selon la norme ISO-8601.
- **Sélection dynamique de la vidéo** : Construit le chemin vers la vidéo en utilisant le format `F:\Diapo_accueille_SXX.mp4`, où `XX` représente le numéro de la semaine (avec 2 chiffres, ex. `Diapo_accueille_S10.mp4` pour la semaine 10).
- **Lancement automatique** : Peut être configurée pour se lancer automatiquement au démarrage de Windows (via un raccourci dans le dossier de démarrage ou une entrée dans le registre).
- **Utilisation de Windows Media Player** : La vidéo est lancée en mode plein écran et en répétition grâce à l’application native de Windows.

## Prérequis

- **Système d'exploitation** : Windows 10
- **Framework** : .NET Framework ou .NET Core (selon le projet choisi)
- **Vidéos** : Les vidéos doivent être au format MP4 et placées à la racine du lecteur F avec le nom au format `Diapo_accueille_SXX.mp4` (ex. `Diapo_accueille_S01.mp4` pour la semaine 1).
- **Lecteur multimédia** : Windows Media Player doit être installé sur le système.

## Installation et configuration

1. **Cloner le dépôt**  
   ```bash
   git clone https://github.com/votre-utilisateur/DiapoStartup.git
Ouvrir le projet dans Visual Studio
Lancez Visual Studio et ouvrez le fichier de solution fourni.

Compiler le projet

Sélectionnez la configuration souhaitée (Debug ou Release).

Compilez le projet via Build > Build Solution.

Configurer le lancement automatique
Vous avez deux options :

Option A : Raccourci dans le dossier de démarrage

Appuyez sur Win + R, tapez shell:startup et appuyez sur Entrée.

Créez un nouveau raccourci pointant vers l'exécutable compilé (DiapoStartup.exe).

Option B : Ajout d'une entrée dans le registre

Appuyez sur Win + R, tapez regedit et appuyez sur Entrée.

Naviguez jusqu'à HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run.

Créez une nouvelle valeur chaîne nommée, par exemple, DiapoStartup et définissez-la avec le chemin complet vers l'exécutable.

Utilisation
Au démarrage de Windows, l'application se lancera automatiquement, déterminera la semaine ISO en cours, et lancera la vidéo correspondante via Windows Media Player en mode plein écran et en répétition.

Licence
Ce projet est distribué sous licence MIT. Voir le fichier LICENSE pour plus de détails.
