# LA_1200

Rabbit: Suganthasri, Hassani, Karrer, Bürgi


| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|27.10 | 0.0.1   | Planung, organisierung, Programm konzeptioniert, Aufgaben/verantwortung verteilt, dokumentation angefangen, Arbeitspakete verteilt|
|3.11|0.0.2| User Stories und Arbeitspakete vervollständigt  |
|10.11| 1.0.0 | Programm fast fertig, noch 1 Fehler zu beseitigen|

## 1 Informieren

### 1.1 Vokabellernprogramm

Dies ist ein Programm welches eingegebene Wörter abfragt und die Lösung dann Ausg. 

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




### 1.3 Testfälle 

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.A  |Benutzer gibt Wörter ein und das Programm speichert das|Eingabe Wörter|Wörter speichern|
| 2.A  |Programm fragt ob der Benutzer weitere Wörter eingeben will| Ja| Benutzer kann weitere Wörter eingeben oder Computer fragt die Wörter ab| 
| 3.A  |Benutzer wird von Computer die Wörter abgefragt|nein| Was bedeutet .... übersetzt?|
| 4.A und 5.A|Benutzer gibt das richtige Wort ein|richtige Wort|Das Wort wird grün markiert|
| 4.A und 5. A|Benutzer gibt das falsche Wort ein|falsche Wort|Das Wort wird rot markiert|
| 6.A  |Benutzer will das Spiel wiederholen |Ja|Computer fragt wieder die Wörter ab|
| 6.B  |Benutzer will das Spiel nicht wieder|Nein|Möchten sie andere Voi-Satz erstellen|
| 7.A  |Benutzer will neue Voci-Satz erstellen |Ja|Das Programm fangt von vorne an|
| 8.A  |Benutzer will kein neue Voci-Satz erstellen |Nein|Das Programm zeigt den Ergebnis|
| 8.B  |Benutzer hat alle Wörter mindestens einmal zu beantworten versucht|letztes Wort wurde übersetzt|Sie haben ..% aller Wörter richtig geraten|
| 9.A  | Benutzer will das Spiel beenden| nein| Das Programm schliesst|


### 1.4 Diagramme 
![image](https://user-images.githubusercontent.com/111046257/198239363-194b2d74-c47c-4a1f-8865-942de8d61778.png)

## 2 Planen 

| AP-№ | Frist | Zuständig | Beschreibung     | geplante Zeit |
| ---- | ----- | --------- | ---------------- | ------------- |
| 1.A  | 3.11 |  Nicola   | Eingabe Vokabular |   45min       |
|2.B    |3.11| Nicola  | Schlaufe zur wiederholten Eingabe Vokabular| 5 min|
| 3.C | 3.11 |  Ava| Abfragen Vokabular|   35 min   |
|4.D  | 3.11 |  Sathana  | Richtig/Falsch   |  10 min  |
 |5.E | 3.11| Ava| Korrektur | 40 min|
 |6.F| 10.11| Ava | wiederholen| 10 min|
 |7.G| 10.11| Sathana| neuer Voci-Satz [y/n]| 50 min|
 | 8.I  | 10.11 | Marco  | Score |   45 min    |
 |9.J| 10.11| Nicola| Beenden| 30 min| 


Total: 270 min

## 4 Realisieren 

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |  3.11  |  Nicola |       45 min        |   45 min  |
| 2.B  |    3.11   | Nicola  |  5 min     |    10 min  |
| 4.D | 3.11| Sathana | 35 min | 40 min |
|5.E| 10.11 | Ava| 40 min| 55 min|
|6.F | 3.11| Ava | 10 min | 10 min |
|7.G| 10.11| Sathana| 50 min| 55 min| 
|8.I | 3.11| Marco| 45 min | 40 min|
| 9.J | 3.11| Nicola| Beenden| 30 min | 20 min|


## 5 Kontrollieren 

### 5.1 Testprotokoll 

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

 Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.


## 6 Auswerten 

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein. ava
