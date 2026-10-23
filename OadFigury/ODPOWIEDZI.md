Dzień 1

Część 1

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

Cześć 2

    1) Samochód - Pojazd: JEST, Samochód jest rodzajem pojazdu.
    2) Samochód - Silnik: MA, Samochód ma silnik.
    3) Zamówienie - Produkt: MA, Zamówienie zawiera produkty.
    4) Podzespół - Produkt: JEST, Podzespół jest rodzajem produktu.
    5) KlasaSzkolna - Uczeń: MA, Klasa ma uczniów.
    6) Uczeń - Osoba: JEST, Uczeń jest rodzajem osoby.
    7) Kwadrat - Prostokąt: MA, Dziedziczenie może naruszać zasadę podstawienia Liskov.
    8) Koszyk - Lista: MA, Koszyk zawiera listę produktów.

====================================================================================================

Dzień 2

Cześć 1: