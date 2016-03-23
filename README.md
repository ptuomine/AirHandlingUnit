# README #

**# LIIKETOIMINTAKERROS JA GENEERISYYS: #**

* * Nyt on mahdollista luoda AirHandlingUnitteja millä tahansa kokoonpanolla tuetuista osista. 
* * Uuden osatyypin tekemiseen tarvittavaa työmäärää on myös minimoitu käyttämälle mm. Genericsiä. Tein 1. Generic tyyppisen PartFactory<T> luokan joka osaa luoda tarvittavan tyyppisen osan reflectioniä käyttäen. 
          - Uuden osatyypin tekeminen vaatii AirHandlingUnit projektiin vain uuden dataluokan sekä hyvin pienen päivityksen ProductCodeManager<T> luokkaan jossa pitää vain määritellä uuden osan tuotenumeron prefix. Sekin voitaisiin helposti hakea itse dataluokasta reflectionia käyttäen. 
* Palvelukerrokseen tarvitaan myös uusi Web Api kontrolleri koska rajapinta on staattinen. Tämäkin voitaisiin generalisoida NameValue rakenteella.
* UI kerrokseen tarvitaan päivitys Index.cshtml tiedostoon sekä uusi js tiedosto uuden osatyypin esittämiseen ja käsittelyyn. airhandlingunit.js tiedostoon pitää myös lisätä uuden osan valinta uunitin luonnissa. Tämä voitaisiin generalisoida meta tiedoilla jotka voitaisiin noutaa oman geneerisen .NET palvelun kautta esimerkiksi tietokannasta.
* Tätä harjoitusta voisi tehdä Coil tyypille joka on vielä toteuttamatta alkuperäisestä tehtävänannosta.
* Koko sovellus voitaisiin rakentaa meta data pohjaisesti jolloin mitään koodia ei tarvitse muuttaa tai lisätä kun halutaan luoda uusia osatyyppejä. Tämä on hyvin tuttua nykyisessä työssäni. 
* 
UI KERROS: 
•	Lisäsin Front-End projektin joka sisältää Web Api rajapinnan sekä UI:n.
•	UI demonstroi miten uusien erityyppisten Air Handling Unitien luominen lennosta on nyt mahdollista. Voit valita mitä tahansa osia ja luoda siitä Unitin.
•	UI: toteutus ja ulkoasu on hyvin yksinkertainen eikä edusta osaamiani tekniikoita. Jos tuota kehittäisin lisää niin käyttäisin Requirejs:ää moduulien käsittelyyn ja Knockout kirjastoa data bindingiin jotka ovat minulle hyvin tuttuja. AngularJs olisi myös hyvä vaihtoehto jota olen myös käyttänyt yhdessä projektissa. KendoUI olisi omiaan tekemään käyttöliittymästä vaikuttavan.
•	JavaScript moduulien geneerisyyttä on mietitty mutta geneerisyyden olisi voinut viedä vielä paljon pidemmällekin. 

DATA KERROS:
•	Data kerrosta ei ole ja siten tietoa ei persistoida. Jos vielä innostusta riittää niin lisää uuden DataLayer projektin jossa käytän Entity Frameworkiä josta minulla on kokemusta.

VIRHEENKÄSITELY JA LOGGAUS:
•	Ei ole toteutettu mutta tähän voisi käyttää esim. Log4Net:tiä
•	Aspect Oriented Programming tyyppistä ohjelmointia tukevaa PostSharp tyyppistä laajennusta voisi myös hyödyntää

UNIT TEST:
•	Lisäsin Unit test projektin testausta varten (komentorivin sijaan)
•	Testejä on nyt hyvin puutteellisesti
•	JavaScript testejä ei ole ollenkaan. Tähän käyttäisin jasmine frameworkiä koska se tukee Requirejs:ää.

KOMMENTIT:
•	Ohjelmakoodissa on nyt niukasti kommentteja ja niitä pitäisi lisätä