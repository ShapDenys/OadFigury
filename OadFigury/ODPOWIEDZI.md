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

Zadanie 1: Błąd kompilacji
           CS0506: 'Service.Description()': cannot override inherited member 'Product.Description()' because it is not marked virtual, abstract, or override
           Metoda w klasie bazowej musi być oznaczona modyfikatorem virtual, aby można było ją przesłonić za pomocą słowa kluczowego override w klasie pochodnej.

Zadanie 2:  Się skompiluje, ale z ostrzeżeniem
            CS0108: 'Dog.Bark()' hides inherited member 'Animal.Bark()'. Use the new keyword if hiding was intended.
            Dodanie słowa kluczowego override do metody w klasie Dog

Zadanie 3: Błąd kompilacji
           CS0534: 'Square' does not implement inherited abstract member 'Figure2.Area()'
           Zaimplementowanie metody abstrakcyjnej Pole() w klasie Kwadrat

Zadanie 4: Błąd kompilacji
           CS0144: Cannot create an instance of the abstract type or interface 'Figure2'
           Utworzenie instancji klasy pochodnej zamiast klasy abstrakcyjnej Figure2: