# Francia rulett: a program le�r�sa
Ez a program egy egyszer� francia rulett j�t�kot val�s�t meg. Az al�bbiakban le�rom, hogyan m�k�dik a program, �s hogyan lehet haszn�lni.

## Kezd�k�perny�
Amikor elind�tjuk a programot, megjelenik a kezd�k�perny�, ahol az aktu�lis egyenleg�nket l�thatjuk, ami alap�rtelmez�sben 1000 kredittel indul. A kezd�k�perny�n tal�lhat�k a k�l�nb�z� gombok, amelyek seg�ts�g�vel a j�t�kot ir�ny�thatjuk.

## J�t�kmenet
A j�t�kmenet nagyon egyszer�. El�sz�r is meg kell tenn�nk a t�t�nket, majd eld�nthetj�k, hogy melyik mez�re szeretn�nk fogadni. A fogad�sok �sszege tetsz�legesen v�laszthat�, de nem haladhatja meg az aktu�lis egyenleg�nket. Amikor elk�sz�lt�nk a fogad�sokkal, meg kell nyomnunk a "P�rget�s" gombot, hogy elinduljon a rulettgoly�. A program v�letlenszer� sz�mot v�laszt [0;36] intervallumb�l, majd megvizsg�lja, hogy melyik fogad�sok nyertek �s melyek vesztesek. A program kisz�m�tja a nyerem�ny �sszeg�t, majd hozz�adja azt az aktu�lis egyenleg�nkh�z. Ezt k�vet�en a j�t�k folytat�dik, �s �jra t�tet kell tenn�nk a k�vetkez� k�rre.

## Fogad�sok
A j�t�k sor�n t�bbf�le fogad�st tehet�nk. Az al�bbiakban felsoroljuk, melyek ezek:
- Egyenes fogad�s (En plein): 35:1
- Passe (19-36): 1:1
- Manque (1-18): 1:1
- Pair (p�ros sz�mok): 1:1
- Impair (p�ratlan sz�mok): 1:1
- Piros (Rouge): 1:1
- Fekete (Noir): 1:1

## �j j�t�k
Ha az egyenleg�nk elfogy, akkor a program lehet�s�get biztos�t sz�munkra, hogy �j j�t�kot kezdj�nk. Ehhez egyszer�en meg kell nyomnunk az "�j j�t�k" gombot, �s az egyenleg�nk vissza�ll 1000 kreditre.

## �sszefoglal�s
Ez egy egyszer� francia rulett j�t�k, amely lehet�v� teszi a j�t�kosok sz�m�ra, hogy virtu�lis kreditet haszn�lva j�tsszanak. A j�t�kosok elhelyezhetik a fogad�saikat a rulett asztalon, majd megtekinthetik, hogy nyertek-e vagy sem, miut�n az asztal lefutott.
A program seg�ts�g�vel a j�t�kosok gyakorolhatj�k a francia rulett j�t�k�t, an�lk�l hogy val�di p�nzt kock�ztatn�nak.