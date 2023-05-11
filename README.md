# Lab2TMPS 
Design patterns
Singleton
Builder
Prototype
Factory Method


1.	Singleton: Singleton este un pattern de design creational care asigură că o clasă are doar o singură instanță și oferă un punct global de acces la aceasta. 
    Acesta implică crearea unei clase cu un constructor privat și o metodă statică care returnează aceeași instanță a clasei de fiecare dată când este apelată. 
    Pattern-ul Singleton este util atunci când ar trebui să existe exact o singură instanță a unei clase, cum ar fi o conexiune la o bază de date sau un logger.
2.	Builder: Pattern-ul Builder este un pattern de design creational care permite construirea obiectelor complexe pas cu pas. Acesta separă construcția unui obiect de reprezentarea acestuia,
    permițând același proces de construcție să creeze reprezentări diferite. Pattern-ul implică o clasă director care controlează procesul de construcție și o clasă builder care furnizează instrucțiunile de 
    construcție pas cu pas. Pattern-ul Builder este util atunci când există mai multe moduri de a construi un obiect și doriți să abstrageți procesul de construcție.
3.	 Prototype: Pattern-ul Prototype este un pattern de design creational care permite crearea de copii ale obiectelor existente fără a face codul dependent de clasele lor.
     Acesta implică crearea unui obiect prototip care servește ca model pentru crearea de obiecte noi. 
     În loc să creați obiecte de la zero, puteți clona prototipul și să-l modificați după necesitate. Pattern-ul Prototype este util atunci când aveți un obiect existent pe care doriți să-l utilizați ca punct de pornire pentru crearea de obiecte noi, evitând complexitatea subclassing-ului.
4.	Factory Method: Pattern-ul Factory Method este un pattern de design creational care oferă o interfață pentru crearea de obiecte, dar permite subclaselor să decidă ce clasă să instantieze. 
     Acesta definește o metodă (metoda de fabrică) pe care subclasele o pot suprascrie pentru a crea obiecte de un anumit tip.
     Pattern-ul Factory Method permite delegarea creării de obiecte către subclase, promovând cuplarea slabă și permitând flexibilitate în crearea obiectelor. Este util atunci când doriți să furnizați o interfață generică pentru crearea de obiecte, dar tipul exact de obiect de creat este determinat de subclase.

Concluzie :
Toate aceste pattern-uri de design - Singleton, Builder, Prototype și Factory Method - oferă abordări eficiente și flexibile pentru crearea și utilizarea obiectelor într-un sistem software. Ele ne ajută să obținem code readability, reutilizabilitate și modularitate în proiectarea aplicațiilor.
