# homework-prac2

The idea of project is simulating fight between two teams of units, by calculating damage based on target`s mana or physical protection.

Hirearchy tree:

Unit - base class which represents single unit with properties;

AmmoTypeUnit - base class derived from unit, includes calculation of amount of ammo avaliable;

ManaTypeUnit - base class derived from unit, includes calculation of mana usage;

Footman - class derived from Unit, represents Footman with it`s properties;

Archer - class derived from AmmoTypeUnit, represents Archer with it`s properties;

Wizard - class derived from ManaTypeUnit, represents Wizard with it`s properties;


