import random
import pygame

# Constants
SCREEN_WIDTH = 800
SCREEN_HEIGHT = 600

# I am trying to make a Factory Pattern for spawning Enemies

<<interface>> Spawnable (Creator), realized by Enemy and Asteroid (ConcreteProducts)

<<interface>> Spawner (Factory), realized by EnemySpawner and AsteroidSpawner (ConcreteCreators)

Spawner (Creator) depends on Spawnable (Product) and has a FactoryMethod to create the objects.

<<enumeration>> Colors (Enum), used to define the colors of the enemies (ex: RED = (255, 0, 0))

Enemies are squares with varying colors which dictate their health and speed.
Asteroids are gray circles with speed.
If either hit the player the game is over
If either are hit by a bullet they are destroyed
Spawnables move downwards at a their own speed and are removed when they leave the screen.

EnemySpawner is a factory that creates enemies with random colors and speeds.
AsteroidSpawner is a factory that creates asteroids with random speeds.
Factories need a FactoryMethod to create the objects.

please help me implement this in Python using pygame
