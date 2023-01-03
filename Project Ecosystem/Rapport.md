#  Projet Ecosystème
## Introduction
Dans le cadre du laboratoire de concept informatique, il nous a été demandé de faire une simulation d'écosystème simplifié à l'aide de MAUI.
## Fonctionnement global
Dans l'ensemble, nous avons une classe Ecosystem qui va reprendre tous les partis de la simulation. Pour commencer, nous avons créé deux classes:
- Food qui a comme attribut un entier IsGood
		Ce dernier peut être soit positif soit négatif. Lorsque l'entier IsGood est positif c'est qu'il peut être mangé par les animaux et dans le cas 
		contraire il s'agit d'un déchet organique.
- LifeForm qui a comme attributs des entiers Energy et LifePoint
		Ces derniers servent à la gestion des points de vie et des réserves d'energie. Il faut savoir que lorsque les animaux n'ont plus de Energy,
		ils puisent dans le LifePoint.
Ensuite, pour pouvoir se nourir et se reproduire, les animaux ont besoin de voir et d'entrer en contact avec ce qui se trouve dans l'ecosysteme. Pour cela, 
nous avons créé des attributs ZoneView et ContactZone. Les plantes eux, ont un attribut ZoneSemis pour pouvoir se propager et ZoneRoot pour pouvoir consommer
les déchets organiques.
## Principes SOLID
Un des principes Solid qu'on a utilisé est le principe S, soit le principe de la responsabilité unique. En effet, nos classes et nos methodes n'ont qu'une seule
responsabilité. C'est aussi la raison pour laquelle nous avons mis nos attributs en privé.
L'autre principe Solid qu'on a utilisé est le principe O, soit le principe ouvert/fermé. Celui-ci affirme que les entités sont ouvertes aux extensions mais 
fermées aux modifications. C'est la raison pour laquelle nous avons utilisé la methode "getter".
## Diagrammes
"C:\Users\imane\Documents\POO\Project Ecosystem\Project Ecosystem\diagramme de classe.png"

"C:\Users\imane\Documents\POO\Project Ecosystem\Project Ecosystem\diagramme de sequence.png"
