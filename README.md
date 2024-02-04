# LOLdle - Jeu de Devinettes de Personnages de League of Legends

## Auteurs

- Hugo Lefebvre
- Gaspard Cabecas Segura
- Leo Alves
- Jules Besson

## Description

LOLdle est un jeu interactif développé en C# avec une interface utilisateur Windows Presentation Foundation (WPF). Inspiré par le jeu populaire League of Legends (LoL), LOLdle propose une expérience amusante où les joueurs doivent deviner les personnages de LoL en se basant sur des indices sous forme d'emojis, ou en listant tous les personnages du jeu.

## Fonctionnalités

1. **Devinette Emoji :** Les joueurs reçoivent une série d'emojis représentant les traits ou les capacités des personnages de LoL, et doivent deviner de quel personnage il s'agit.

2. **Liste de Personnages :** Un défi où les joueurs doivent énumérer tous les personnages de LoL.

3. **Chargement de Données :** Les informations sur les personnages de LoL sont stockées dans un fichier JSON qui est ensuite transformé en objets pour une utilisation dans le jeu.

## Design Patterns Utilisés

1. **Singleton :** Assure qu'une classe n'a qu'une seule instance et fournit un point d'accès global à cette instance. Utilisé pour gérer l'accès aux données du jeu.

2. **Factory Method :** Utilisé pour créer des objets sans spécifier la classe exacte de l'objet qui sera créé. Cela est particulièrement utile pour la création de différents types de jeux ou de défis dans LOLdle.

3. **Observer :** Permet à un sujet de notifier une liste d'observateurs lorsque son état change. Utilisé pour la mise à jour de l'interface utilisateur en réponse aux changements de l'état du jeu.

4. **Actions :** Permet d'encapsuler une méthode avec un ensemble de paramètres spécifiques. Utilisé pour créer des interactions dynamiques dans l'interface utilisateur et les logiques de jeu.

## Comment Jouer

- Téléchargez et installez l'application.
- Choisissez le type de jeu (Devinette Emoji ou Liste de Personnages).
- Suivez les instructions à l'écran pour jouer.

## Configuration Requise

- Système d'exploitation Windows.
- .NET Framework (version spécifique).
