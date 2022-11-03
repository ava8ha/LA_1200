# LA_1200

Rabbit: Suganthasri, Hassani, Karrer, Bürgi

ava

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|27.10 | 0.0.1   | Planung, organisierung, Programm konzeptioniert, Aufgaben/verantwortung verteilt, dokumentation angefangen, Arbeitspakete verteilt|
|3.11|0.0.2| User Stories und Arbeitspakete vervollständigt  |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Vokabellernprogramm

Dies ist ein Programm welches eingegebene Wörter abfragt und korrigiert. 

### 1.2 User Stories ava

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    | Eingabe Vokabular|  funktional    | Als User möchte ich, dass ich das Wort welches ich lernen will eingeben kann und die jeweilige Übersetzung danach. |
| 2  |mehrere Eingaben |Funktional/Rand|  Als User möcnhte ich beliebig viele Begriffe eingeben können und dass es mich fragt ob ich ein weiteres Wort einegen will nach jedem mal das ich habe.|
|3|Abfragen|funktional | Als User möchte ich das Wort welches mir vorgegeben wird, übersetzt eingeben|
|  4 | richtig/falsch | Rand  |als User möchte ich, dass es mir, nach dem ich Übersetzt habe, anzeigt ob ich richtig war oder nicht   |
|5 | korrektur | Qualität|Als User möchte ich, dass es mir die richtige schreibweise des Begriffes anzeigt | 
|6| wiederholen| Rand|Als User möchte ich, dass das Programm  ich fragt ob ich den gleichen Satz noch Mals üben will oder nicht| |
|7|neuer Satz| Rand| Als User möcte ich, dass nach dem ich zum gleichen Vokabular noch Mals üben, nein gesagt habe , es mich dann fragt ob ich einen neuen Satz eingeben und üben will oder nicht|
|8| Score| Qualität| als User möchte ich, dass am Ende des Üben, mir angezeigt wird wieviele Begriffe von wievielen ich richtig eingegeben habe.|
|9| beenden| Funktional |Als User möchte ich, dass nach dem ich zu "neuensatz einegeben?" nein gesagt habe, fertig bin und das Programm aufhört|




### 1.3 Testfälle nicola

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |              |         |                   |
| ...  |              |         |                   |

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme Sathana
![image](https://user-images.githubusercontent.com/111046257/198239363-194b2d74-c47c-4a1f-8865-942de8d61778.png)

## 2 Planen marco

| AP-№ | Frist | Zuständig | Beschreibung     | geplante Zeit |
| ---- | ----- | --------- | ---------------- | ------------- |
| 1.A  | 3.11 |  Nicola   | Eingabe Vokabular |   45min       |
|2.B    |3.11| Nicola  | Schlaufe zur wiederholten Eingabe Vokabular| 3 min|
| 3.C | 3.11 |  Ava| Abfragen Vokabular|   45 min   |
|4.D  | 3.11 |  Sathana  | Richtig/Falsch   |  35 min  |
 |5.E | 3.11| Ava| Korrektur | 40 min|
 |6.F| 10.11| Marco | wiederholen| 45 min|
 |7.G| 10.11| Sathana| neuer Voci-Satz [y/n]| 45 min|
 | 8.I  | 10.11 | Marco  | Score |   45 min    |
 |9.J| 10.11| Nicola| Beenden| 30 min|


Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden alle
progr. fragt user ob es die deutschen wörter lernen will oder die englischen. dann gibt das gegenteil an von dem was der user lernen will.

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren sathana

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren marco

### 5.1 Testprotokoll nicola

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten ava

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein. ava
