# SOLID principles

Unity examples

## Single responsibility
(Assets/SOLID/SingleResponsibility)

Component approach. Every component has a responsibility with the intention of not having unexpected side-effects upon further modifications.
Improves maintainability and promotes extension through multiple classes.

## Open closed
(Assets/SOLID/OpenClosed)

The goal is to reuse existing code and have no need to modify it. Extensions should be made via inheritance/interfaces/events.
In this example the weapon has an OnShoot event and any projectile behaviour will be handled by a projectile launcher (BulletLauncher and MissileLauncher)

## Liskov substitution
(Assets/SOLID/LiskovSubstitution)

In this example we have Enemy subclasses that potentially handle TakeDamage() in different ways and at the same time they don't break the application nor the superclass itself. For example, EnemyGolem.cs uses its parent definition.

## Interface segregation
(Assets/SOLID/InterfaceSegregation)

The object does not need to depend on methods or properties that doesn't use. With the use of interfaces you can group and isolate functionality and use it only when an object requires it.

## Dependency inversion
(Assets/SOLID/DependencyInversion)

Attempt to not rely on low-level implementations and abstract functionality at high-level.
In this example the movement is considered generic making it usable for both players and AI. At the same time an interface handles the input values (used by both controllers).
