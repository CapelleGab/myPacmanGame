# 🎮 myPacmanGame

Un petit clone de Pac-Man développé avec [MonoGame](https://www.monogame.net/) et .NET 8.

---

## 🚀 Lancement du projet en mode développement

### ✅ Prérequis

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [MonoGame SDK](https://www.monogame.net/downloads/)
- Un éditeur comme [Visual Studio Code](https://code.visualstudio.com/) ou [Visual Studio 2022](https://visualstudio.microsoft.com/fr/)
- (Facultatif) `dotnet-mgcb` si tu veux compiler le contenu depuis la ligne de commande

```bash
dotnet tool install --global dotnet-mgcb
```

---

### 🛠️ Installation

1. Clone le projet :
```bash
git clone https://github.com/ton-pseudo/myPacmanGame.git
cd myPacmanGame
```

2. Restaure les dépendances :
```bash
dotnet restore
```

3. Compile et lance en mode développement :
```bash
dotnet run
```

---

### 🖼️ Pipeline de contenu (facultatif)

Le fichier de contenu est dans `Content/Content.mgcb`.  
Si tu ajoutes de nouveaux assets, n'oublie pas de recompiler le contenu :

```bash
dotnet mgcb build Content/Content.mgcb
```

---

### 📁 Structure du projet

```
myPacmanGame/
├── Game1.cs                # Classe principale MonoGame
├── Program.cs              # Point d’entrée .NET
├── Content/                # Assets (images, sons, etc.)
├── Entities/               # Logique des entités (joueur, fantômes, etc.)
├── bin/ & obj/             # Dossiers de build (ignorés par Git)
└── myPacmanGame.csproj     # Fichier projet C#
```

---

### 🎮 Contrôles

Voir [`CONTROLS.md`](./Docs/CONTROLS.md)

---

## 🧑‍💻 Auteur

> Développé par Gabin avec ❤️ en C# et MonoGame  
> N'hésitez pas à forker ou proposer des améliorations !

---

## 📜 Licence

Ce projet est sous licence MIT. Voir `LICENSE` pour plus d'informations.
