# Example

В программе реализован алгоритм боя между двумя армиями. В каждой армии есть ковалерия и пешая часть армии. 
* Состав армии 1: Wizard (не более 1 в армии), Rohhirim, WoodenElf, Human, Elf.
* Состав армии 2: Goblin, Troll, UrukHai, Orc.

Армии заполняются произвольным образом.

Иерархия классов приведена на следующем рисунке: (под каждым классом указан диапазон силы каждого участника)
![example](http://savepic.ru/13333839.png)

Бой происходит в 3 раунда:
* 1 раунд: бой ковалерии
* 2 раунд: бой пеших
* 3 раунд: бой выживших участников

Перед сражением в каждом раунде произвольно выбирается участник, который первый наносит удар. При нанесении удара противник теряет силу на уровень силы атакующего. Противник погибает, если сила атакующего больше, чем его сила. А раунде побеждает та армия, у которой остались живые воины. 
