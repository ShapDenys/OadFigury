1) Circle: area 3,14, perimeter 6,28
   Rectangle: area 6,00, perimeter 10,00

2) Nie można utworzyć wystąpienia typu lub interfejsu abstrakcyjnego „Figure”

3) 'Element „Rectangle” nie implementuje odziedziczonej abstrakcyjnej składowej „Figure.Area()”

4) Circle: area 3,14, perimeter 6,28
   Rectangle: area 6,00, perimeter 10,00
   Triangle: area 6,00, perimeter 12,00

5) • abstract nie ma własnej implementacji, klasa dziedzicząca musi ją napisać.
     virtual ma gotową implementację, klasa dziedzicząca może ją zmienić, ale nie musi.

   • Bo Figura jest klasą abstrakcyjną, jest tylko ogólny wzór dla innych klas, np. Triangle, nie można tworzyć jej obiektów bezpośrednio

   • Za: Nie można tworzyć zwykłych, nieokreślonych produktów. Trzeba utworzyć konkretny produkt.
 	 Przeciw: Testy z new Produkt { ... } przestaną działać, ponieważ produktu abstrakcyjnego nie można tworzyć.