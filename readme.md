# Francia rulett: a program leírása
Ez a program egy egyszerû francia rulett játékot valósít meg. Az alábbiakban leírom, hogyan mûködik a program, és hogyan lehet használni.

## Kezdõképernyõ
Amikor elindítjuk a programot, megjelenik a kezdõképernyõ, ahol az aktuális egyenlegünket láthatjuk, ami alapértelmezésben 1000 kredittel indul. A kezdõképernyõn találhatók a különbözõ gombok, amelyek segítségével a játékot irányíthatjuk.

## Játékmenet
A játékmenet nagyon egyszerû. Elõször is meg kell tennünk a tétünket, majd eldönthetjük, hogy melyik mezõre szeretnénk fogadni. A fogadások összege tetszõlegesen választható, de nem haladhatja meg az aktuális egyenlegünket. Amikor elkészültünk a fogadásokkal, meg kell nyomnunk a "Pörgetés" gombot, hogy elinduljon a rulettgolyó. A program véletlenszerû számot választ [0;36] intervallumból, majd megvizsgálja, hogy melyik fogadások nyertek és melyek vesztesek. A program kiszámítja a nyeremény összegét, majd hozzáadja azt az aktuális egyenlegünkhöz. Ezt követõen a játék folytatódik, és újra tétet kell tennünk a következõ körre.

## Fogadások
A játék során többféle fogadást tehetünk. Az alábbiakban felsoroljuk, melyek ezek:
- Egyenes fogadás (En plein): 35:1
- Passe (19-36): 1:1
- Manque (1-18): 1:1
- Pair (páros számok): 1:1
- Impair (páratlan számok): 1:1
- Piros (Rouge): 1:1
- Fekete (Noir): 1:1

## Új játék
Ha az egyenlegünk elfogy, akkor a program lehetõséget biztosít számunkra, hogy új játékot kezdjünk. Ehhez egyszerûen meg kell nyomnunk az "Új játék" gombot, és az egyenlegünk visszaáll 1000 kreditre.

## Összefoglalás
Ez egy egyszerû francia rulett játék, amely lehetõvé teszi a játékosok számára, hogy virtuális kreditet használva játsszanak. A játékosok elhelyezhetik a fogadásaikat a rulett asztalon, majd megtekinthetik, hogy nyertek-e vagy sem, miután az asztal lefutott.
A program segítségével a játékosok gyakorolhatják a francia rulett játékát, anélkül hogy valódi pénzt kockáztatnának.