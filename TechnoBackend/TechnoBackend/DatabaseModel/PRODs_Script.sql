
DBCC CHECKIDENT('Ergo.dbo.PRODs', RESEED, 0)

--1		Buddy
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
	VALUES
	(
		'buddy',
		CONVERT(date, GETDATE(),101),
		'560x350x350mm',
		5000,
		646,
		0,
		'https://adoptbuddy.com/en/products/8-buddy-classic-edition.html',
		'Je hebt een wifi verbinding nodig om het apparaat volledig te kunnen gebruiken. Er mogen geen te hoge drempels in huis zijn (max 1,5 cm). Client moet Engels of Frans kunnen spreken (enige twee talen van de robot).',
		'Batterijduur tot 10 uur; Sensoren hoofd: Een range finder sensor; een temperatuursensor; Sensoren lichaam:  5 obstakel detecties; 3 range finder sensors; 5 grond detecties; Vier motoren met feedback controle / Tablet met een camera; een micro-phone; een audio output; een HDMI output; een USB output; Twee ingebouwde speakers; RGB led verlichting; 8 inch touchscreen; WiFi en Bluetooth; Maximale snelheid van 700 mm/s; Maximale hoogte drempels: 1,5 cm',
		'Je hebt een wifi verbinding nodig om het apparaat volledig te kunnen gebruiken; Er mogen geen te hoge drempels in huis zijn (max 1,5 cm); Client moet Engels of Frans kunnen spreken (enige twee talen van de robot).',
		'https://www.youtube.com/watch?v=51yGC3iytbY',
		1,
		3,
		CONVERT(date, GETDATE(),113)
	)

--2		Robotarm Jaco
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
VALUES
	(
		'Jaco',
		CONVERT(date, GETDATE(),101),
		'1050mm',
		5200,
		NULL,
		1,
		'http://focalmeditech.nl/nl/content/jaco',
		'Personal Robot ‘Jaco’ is een persoonlijk hulpmiddel voor personen zonder inzetbare handfunctie. De grijper van deze robot neemt allerlei dagelijkse handelingen over die de gebruiker niet meer handmatig kan uitvoeren  ‘Jaco’ wordt op een rolstoel geplaatst en kan door zijn gebruiker heel efficiënt bediend worden. Het aantal handelingen dat men met ‘Jaco’ kan uitvoeren is vrijwel oneindig. Heel belangrijk zijn de dagelijkse handelingen die iemand in staat stellen om zo zelfstandig mogelijk te functioneren.',
		'Laadvermogen: 1600 gram; Mate van vrijheid: 6 omwentelingen; Bereik van 900mm; Energieverbruik van maximaal 25w; 16 verschillende bewegingen mogelijk; gemaakt van carbon; lichtgewicht en met alle weersomstandigheden bruikbaar; Flexibele vingers aan de arm; Past zich aan, aan de afmetingen van het object',
		'Indicatie voor langdurige zorg; Moet plaatsbaar zijn op de rolstoel; Client moet de arm kunnen besturen met de joystick',
		'https://www.youtube.com/watch?v=iZYxJFROew8',
		1,
		2,
		DATEADD(YEAR,-4,GETDATE())
	)

--3		Schoenherkenning
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
VALUES
	(
		'Schoenherkenning',
		CONVERT(date, GETDATE(),101),
		'Op maat gemaakt',
		8312,
		NULL,
		NULL,
		'http://www.kmd.nl/assortiment/omgevingsbediening/raam-en-deurbediening/schoenherkenning',
		'Hoe krijg je toegang tot je appartement als je niet in staat bent een sleutel, drukknopje of iets dergelijks te bedienen? KMD bedacht daarvoor een unieke oplossing. Schoenherkenning! Met een speciale tegel die de schoen van de gebruiker herkent krijgt deze persoon exclusief toegang tot de centrale ruimte van het appartementen complex.  De tegel is door KMD op maat gemaakt en aangesloten op de bestaande elektrisch bediende deur. Het werkt heel comfortabel. Door eenvoudig over de speciale zwarte tegel te lopen gaat de voordeur open. Bij de voordeur van het appartement is een soortgelijke voorziening getroffen.',
		'Op maat gemaakte tegel voor de huisdeur; Schoen wordt herkend en de deur automatisch geopend',
		'',
		'',
		1,
		4,
		CONVERT(date, GETDATE(),113)
	)

--4		Automatische deur
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
VALUES
	(
		'Automatisch deur',
		CONVERT(date, GETDATE(),101),
		'Op maat gemaakt',
		3455,
		200,
		1,
		'https://www.google.nl/webhp?sourceid=chrome-instant&ion=1&espv=2&ie=UTF-8#q=automatische+deuren&*',
		'De automatische deuren werken volgens een sensor die detecteert of de cliënt voor de deur staat. Wanneer de sensor dit detecteert zal de deur vervolgens automatisch openen. De deuren zijn verkrijgbaar bij verschillende leveranciers in elke maat, zo kan de deur perfect op maat worden besteld. Tevens is er de mogelijkheid om te werken met automatische draaideuren of automatische schuifdeuren, al na gelang de wensen van de cliënt. Vrijwel elke deur kan geautomatiseerd worden in huis. Er hoeft zelfs geen nieuwe deur besteld te worden omdat er ook los een draaideur automaat besteld kan worden die deuren opent middels een knop. ',
		'Automatische deur met sensordetectie; Zowel draaideuren als schijfdeuren; Er kan ook alleen een draaideurautomaat besteld worden, deze kan elke deur automatiseren middels een knop; Kan geleverd worden met een rechte trek arm, verlengde trek arm en een duw arm; Middels een code vergrendelbare digitale programmaschakelaar geeft u tevens informatie over de status van de deur en de mogelijkheid om de automaat in de standen "automatisch", "alleen ingang", "alleen uitgang", "continu open", "vergrendeld", "handbediend" te zetten',
		'Draaideur automaat vereist een stroomtoevoer van netstroom; Client moet met draaideur automaat de knop kunnen bedienen; Sensor moet boven de deur geplaats worden; Noodstroomvoorziening nodig wanneer de stroom uitvalt',
		'https://www.youtube.com/watch?v=5p_a45p7olY',
		1,
		4,
		CONVERT(date, GETDATE(),113)
	)

--5		Elektrische gordijnen
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
VALUES
	(
		'Elektrische gordijnen',
		CONVERT(date, GETDATE(),101),
		'1,14m-4,14m',
		4500,
		139,
		0,
		'https://www.pahedomotica.nl/product/kallox-elektrische-gordijnrail-cl200t4m-complete-basisset/',
		'Op afstand bedienbare elektrische gordijnrails, open of sluit je gordijnen vanaf de bank met de bijgeleverde infrarood afstandsbediening. Of bespaar energie en voor de veiligheid d.m.v. automatisch openen en sluiten van de gordijnen m.b.v. een timer of domotica programma. De infrarood afstandsbediening codes kunnen geleerd worden door de meeste universele afstandsbedieningen.',
		'Gordijnrail is op lengte te maken tussen 1.14m. en 4.14m; Eén afstandsbediening kan 8 verschillende gordijnen bedienen; Stop op elke willekeurige positie bij het drukken op de “stop” knop;	Stopt automatisch wanneer het gordijn geheel gesloten of geopend is; Gordijnen zijn gewoon met de hand te openen en te sluiten;	Veilig en betrouwbaar; ontworpen met 12VDC adapter met Europees CE keurmerk; IR afstandsbediening heeft een bereik tot 12 meter; Openen van uit het midden, links of rechts; Gordijnrail kan makkelijk ingekort worden; Wordt geleverd met wand en plafond bevestigingsmateriaal',
		'Bediening werkt alleen met afstandsbediening; Afstandsbediening werkt niet op grotere afstanden; Deze rails hebben netstroom als voeding nodig, er moet dus een mogelijkheid zijn deze in te steken in het stopcontact',
		'https://www.youtube.com/watch?v=lAmKm62RrXI',
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)

--6		Vinci headphone
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
VALUES
	(
		'Vinci Smart',
		CONVERT(date, GETDATE(),101),
		'40mm',
		260,
		156,
		0,
		'https://www.kickstarter.com/projects/inspero/vinci-first-smart-3d-headphones-that-understand-yo',
		'De Vinci hoofdtelefoon kan op basis van stembesturing: muziek afspelen, bellen, zoekopdrachten uitvoeren, geeft informatie over locatie (GPS), tijd, het weer, hartslag, etc. Vinci’s technologie platform is gebouwd in ‘de cloud’ en wordt aangedreven door natuurlijke taalverwerking en kunstmatige intelligentie; het wordt dus steeds slimmer en slimmer. Dit kan omdat Vinci uw spraakpatroon en voorkeuren onthoudt. Hoe meer je Vinci draagt, hoe persoonlijker en intelligenter hij wordt!',
		'Krachtige dual-core ARM Cortex-A7 processor;	16 tot 32 GB geheugen; met een geheugen van 32 GB kun je wel tot 7000 MP3’s bewaren;	In 1,5 uur is Vinci opgeladen;	De batterijduur van Vinci gaat wel tot  +/- 3 weken mee;	Vinci is een super uitgebreid platform draaiend op basis van Android;	Vinci wordt aangedreven door Vinci Voice OS;	Maak verbinding met internet via WiFi of via 3G. Wanneer er geen internet aanwezig is, werkt Vinci ook in een offline modus; 	Vinci heeft een Bluetooth 4.1. connectie met je smartphone (iOS & Android) en computers. Ook kan via Bluetooth data gesynchroniseerd worden met je telefoon;	Het heeft een ergonomisch ontwerp: comfortabel voor alle type gebruikers; Regelmatige software-updates (automatische updates wanneer aangesloten op het internet) en vele spannende nieuwe apps en functies zijn in ontwikkeling',
		'In staat om omhoog/omlaag te swipen op zijkant van hoofdtelefoon om volume te regelen; Duidelijke spraak nodig voor het geven van een opdracht aan Vinci',
		'https://www.youtube.com/watch?v=c995ruHkISc',
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)

--7		Omate smartwatch wherecom S3
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
VALUES
	(
		'Omate Wherecom S3',
		CONVERT(date, GETDATE(),101),
		'37x38x13,9mm',
		1234,
		149,
		0,
		'http://www.omate.com/s3',
		'De Omate is een combinatie tussen een smartwatch en een GPS-tracker. Senioren die de weg kwijt raken kunnen via de GPS-tracker in het apparaatje snel worden teruggevonden. Ook kunnen senioren middels de smartwatch contact leggen met hun familie of mantelzorger op een eenvoudige manier. Contacten worden weergegeven middels grote pictogrammen of foto’s. Voor het gebruik van de Omate is geen technische kennis vereist.',
		'Android; 2G/3G, WIFI, Bleutooth; 4GB intern geheugen; GPS; 1,54 inch kleuren touchscreen; 320 x 320 Pixels; 600 mAh Batterij; 3 dagen batterijcapaciteit; SOS sneltoets',
		'WiFi aanwezig; mogelijkheid om de smartwatch op te laden; Naasten beschikbaar voor contact; Fysieke mogelijkheden om de smartwatch om te doen; Beschikken over een smartphone',
		'https://www.youtube.com/watch?v=pX0tJoUosfg',
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)

--8		Archos Smart Home 4G
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
VALUES
	(
		'Archos Smart Home',
		CONVERT(date, GETDATE(),101),
		'600x1900x1300mm',
		460,
		140,
		0,
		'http://www.archos.com/us/products/objects/chome/ash/index.html',
		'Huis besturingssysteem met o.a.; besturing van objecten, temperatuur en luchtvochtigheid meters, bewegingssensoren en camera''s. Het systeem kan bestuurd en bekeken worden via de tablet of smartphone. Het wordt geleverd met een volledig functionerende Android tablet',
		'2x weersensor (meet temperaturen tussen de -10 en 50 graden Celcius en vochtigheidsgehalte); 2x bewegingsdetector (met ingebouwde bewegingssensor, wordt met een magneet bevestigd op apparatuur); 2x mini webcam (VGA); Bereik: 20 meter; Geheugen: 4 GB; Android',
		'WiFi verbinding; In bezit van een Google account; In staat zijn om een tablet/smartphone te bedienen',
		'https://www.youtube.com/watch?v=cONkkGdhBQ0',
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)

--9		Dimo
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
VALUES
	(
		'Dimo',
		CONVERT(date, GETDATE(),101),
		'nvt',
		'nvt',
		'Onbekend',
		0,
		'https://domare.nl/nl/catalogus/domare/dimo-omgevingsbesturing/',
		'De Dimo behoort tot de nieuwste generatie omgevingsbesturing gebaseerd op het iOS besturingssysteem van Apple. De basis van deze omgevingsbesturing is een iPad of een iPod. De Dimo maakt het mogelijk om de meeste apparatuur in de woning te bedienen. Denk daarbij aan audio- en video apparatuur, openen en sluiten van deuren en gordijnen, bedienen zonwering, thermostaat, intercom, telefoon en verlichting. Afhankelijk van de mogelijkheden van de gebruiker wordt de omgevingsbesturing voor iedere gebruiker individueel ingericht. De Dimo is door middel van directe selectie (touch) en scannend te bedienen. De auditieve terugkoppeling zorgt ervoor dat de Dimo ook geschikt is wanneer de visus of cognitie van de gebruiker verminderd is. Wanneer de gebruiker zonder de iPad naar buiten gaat, kunnen toch enkele functies van de bediend worden met het infrarood kastje, bijvoorbeeld de voordeur of een oproepzender. De Dimo kan gemakkelijk en snel van de rolstoel naar een houder bij het bed of sta-op stoel worden verplaatst. De Dimo is voorzien van een krachtige radiofrequent- en infraroodzender. Tevens is de Dimo voorzien van een relaisuitgang, waarop bijvoorbeeld een oproepzender kan worden aangesloten. En door middel van hulp op afstand via het internet is het mogelijk om snel service te verlenen.',
		'Hardware: tablet/smartphone; Draaiend op Android + iOS; Oriëntatie: portrait of landscape; Auditieve ondersteuning: toon of spraak; Aantal relais uitgangen: 1; Type scanning: lineair of rij/kolom; Muisfunctionaliteit: nee; Infrarood uitsturing: ja; RF uitsturing: ja ; Gebruik van apps: alleen bij directe bediening; Hulp op afstand: ja ',
		'In bezit van een smartphone of tablet; In staat om een apparaat fysiek te bedienen',
		'https://www.youtube.com/watch?v=3TTVP84ON-A',
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)
--10	Busch-free @ Home
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
VALUES
	(
		'Busch-free@home',
		CONVERT(date, GETDATE(),101),
		'Verschillende afmetingen',
		'nvt',
		'Onbekend',
		0,
		'https://www.busch-jaeger.de/nl/producten/systemen/busch-freehome/#c91815',
		'Busch-free@home app maakt van uw huis een intelligente woning. Jaloezie, licht, verwarming, airco, deurcommunicatie of scènes: eenvoudig (op afstand) te bedienen met schakelaar aan de wand, met de laptop, tablet of smartphone. Dat geeft een volkomen nieuw gevoel van vrijheid en onafhankelijkheid van tijd en ruimte. Vanaf iedere plek in het huis of waar dan ook ter wereld kunt u het licht schakelen, jaloezieën bewegen of de ruimte op temperatuur brengen.
Eenvoudig, praktisch, comfortabel en energie-efficiënt. En bijzonder voordelig met slechts geringe meerkosten ten opzichte van een conventionele elektrische installatie.',
		'Hardware: tablet/smartphone; Draaiend op Android + iOS; Oriëntatie: portrait of landscape; Auditieve ondersteuning: toon of spraak; Aantal relais uitgangen: 1; Type scanning: lineair of rij/kolom; Muisfunctionaliteit: nee; Infrarood uitsturing: ja; RF uitsturing: ja ; Gebruik van apps: alleen bij directe bediening; Hulp op afstand: ja ',
		'In bezit van een smartphone of tablet; In staat om een apparaat fysiek te bedienen',
		'https://www.youtube.com/watch?v=3TTVP84ON-A',
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)

--11	Robot stofzuiger
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
VALUES
	(
		'iRobot Roomba',
		CONVERT(date, GETDATE(),101),
		'Diameter: 350mm Hoogte: 920mm',
		3850,
		300,
		0,
		'http://winkel.irobot.nl/nl/roomba-vacuum-cleaning/?lang=nl_NL&gclid=CNC67-WE6NICFTAz0wodR7oEEQ',
		'Een robotstofzuiger zuigt zelfstandig de vloer. Het werkt op een accu en kan verschillende soorten bewegingen over de ondergrond maken. Door middel van sensoren of GPS detecteert een robotstofzuiger objecten in de ruimte. Met zuigkracht en een ronddraaiende borstel vangt een robotstofzuiger stof op in een stofreservoir. iRobot Roomba 782 robotstofzuiger reinigt je woning wanneer je er niet bent of leuke dingen aan het doen bent; volledig automatisch. Zelfs als je slaapt en het donker is, omdat de unieke iRobot gebruik maakt van de iAdapt Adaptieve Navigatie Technologie waarbij geen licht nodig is. En elk type vloerbedekking zal de iRobot reinigen, want hij is geschikt voor zowel harde als zachte vloeren. De iRobot Roomba 782 robotstofzuiger wordt geleverd met het gepatenteerde 3-traps schoonmaaksysteem en maakt daarbij gebruik van twee tegen elkaar draaiende borstels gecombineerd met een krachtige vacuüm zuigmotor om vuil, stof, haar en andere verontreinigingen te verwijderen terwijl twee HEPA-filters de ruimte vrij houden van fijn stof en andere allergenen.',
		'Vermogen: 33W; Oplaadtijd: +-3uur; Gebruikstijd: +-90minuten; Bediening: tiptoetsen; Bereik: +-100m2; Kamer naar kamer functie: ja; Geschikt voor: harde en zachte vloerbedekking; Soort stofopvang: zakloos; Inhoud: 380ml; Indicatie vol: ja; Max. hoogte te nemen drempels: 2-2,5cm; Sensoren: 6; Geluidsniveau: ca. 61dB (Afhankelijk van de ondergrond, op tapijt minder als op bijvoorbeeld linoleum); Levensduurverlengend power management; Dual HEPA-filters; Programmeerfunctie (7 dagen per week); Timer; Werkt in het donker; Kleur: zilver',
		'Stroom voor opladen; Zelfstandig in staat zijn of inschakelen sociale omgeving om reservoir te legen; In staat zijn om op knop te drukken (er bestaan ook robotstofzuigers die bestuurbaar zijn via een app of afstandsbediening)',
		'https://www.youtube.com/watch?v=UjrZAaRKBHk',
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)

--12	Dweilrobot
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
VALUES
	(
		'Dweilrobot',
		CONVERT(date, GETDATE(),101),
		'178mmx170mmx84mm',
		1200,
		249,
		0,
		'https://store.irobot.com/default/floor-mopping-braava-robot-mop-irobot-braava-jet/B240020.html',
		'Een dweilrobot is een intelligent apparaat die zelfstandig vloeren dweilt. De dweilrobot schrobt en zuigt het vieze water van de vloer. De dweilrobot heeft een ingebouwd gps-systeem, hierdoor weet hij precies welk deel van de kamer nog gedweild moet worden. Klem een dweil onder de iRobot dweilrobot en kies het juiste programma. Hij werkt zowel droog tegen stof als nat tegen vlakken op de plavuizen of parketvloer. Voor hardnekkige vlekken sprayt hij zo nu en dan de vloer in met water en laat hij een glanzend resultaat achter. De dweilrobot vermijdt automatisch tapijten.',
		'Lithium Ion batterij; Automatisch opladen: nee; Automatisch hervatten: nee; Geschikt voor hoeken: ja; Dweilfunctie: ja; Navigatiemethode: systematisch; Timer: nee; Afstandssensoren: ja; Afgrondsensoren: ja; Botssensoren: ja; Kleur: wit',
		'Stroom voor opladen',
		'https://www.youtube.com/watch?v=TWxJeYOKF2c',
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)

--13	Schoonmaakrobot Roboscooper
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
VALUES
	(
		'Roboscooper',
		CONVERT(date, GETDATE(),101),
		'409mmx276mmx283mm',
		880,
		80,
		0,
		'http://www.robots.nu/schoonmaakrobot-roboscooper/',
		'Deze robot buddy houdt van opruimen en meehelpen. Deze robot is in staat om voorwerpen die op de vloer liggen te detecteren en, mits niet te groot en niet te zwaar, op te ruimen. Via een afstandsbediening kan hij bijgestuurd worden in rijrichting. Deze robot heeft 6 wielen waardoor hij over de meeste terreinen kan rollen. Hij vermijdt zelfs obstakels.',
		'WowWee Roboscooper; Materiaal: kunststof',
		'9 AA+AAA  batterijen',
		'https://www.youtube.com/watch?v=dciGBPq6JvY',
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)

--14	Beeldintercom
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
VALUES
	(
		'Beeldintercom',
		CONVERT(date, GETDATE(),101),
		'155mmx218mmx29mm',
		'Onbekend',
		669,
		0,
		'https://www.busch-jaeger.de/nl/producten/systemen/deurcommunicatie/busch-welcomepanel/',
		'Als de deurbel gaat hoeft er niet meer opgestaan te worden om naar de deur te lopen. Er is op de binnen unit altijd zicht op wat er bij de voordeur gebeurt, en voor de veiligheid worden er van degene die aanbelt automatisch 3 foto’s genomen (ook als er niemand thuis is). Het kan eenvoudig bediend worden met sneltoetsen. Het systeem is uitermate geschikt voor bestaande woningen vanwege de eenvoudige installatie. Optioneel kan het systeem ook bediend worden d.m.v. een app op de smartphone of tablet. Op deze manier kan de persoon ook zien wie er voor de deur is als deze niet thuis is, eventueel kan de persoon dan toch binnen gelaten worden.',
		'busch-welcomepanel; Hoogwaardige kleuren-TFT-touchdisplay met resolutie 800 X 480 (WVGA); Handsfree-spreekfunctie met ruis- en echo-onderdrukking voor een verstaanbare communicatie; Zes basistoetsen: oproepbeantwoording, deur openen, muteschakeling, lichtschakelaar, momentopname en instellingen snel en eenvoudig te bedienen; Meeluisterblokkering; Keuze uit 5 beltonen; In stand-by kan een elektrische fotolijst worden gekozen; Optioneel: vingerafdrukmodule, toetsenmodule, transpondermodule op buiten unit',
		'Stroom',
		'https://www.youtube.com/watch?time_continue=40&v=Te0XfWwB8yA',
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)

--15	Aanwezigheidsmelder
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
VALUES
	(
		'Aanwezigheidsmelder',
		CONVERT(date, GETDATE(),101),
		'Diameter: 106mm; Diepte: 57mm',
		240,
		46.95,
		0,
		'https://www.bol.com/nl/p/robus-aanwezigheidsmelder-inbouw-opbouw-360-pir/9200000052743862/?Referrer=ADVNLGOO002042-G-38445544793-S-271753398959-9200000052743862#product_specifications',
		'Ook wel Passief Infrarood (PIR) aanwezigheidsmelder genoemd – werken volgens hetzelfde principe als een bewegingsmelder: zij registreren de warmtestraling in hun omgeving respectievelijk in hun detectiekwaliteit. Een aanwezigheidsmelder is alleen veel gevoeliger dan een bewegingsmelder. Als er warmtestraling wordt gedetecteerd, bijvoorbeeld door een naderend persoon, dan zet de aanwezigheidsmelder deze straling om in een meetbaar, elektrisch signaal en wordt er een alarm gegeven en/of een bericht verzonden naar een verzorger.',
		'Robus universele opbouw/inbouw aanwezigheidsmelder RU360-01; Detectiebereik: 10m diameter bij 2,8m hoogte; Detectiehoek: 360 graden; Tijd instelling: 10sec - 40min; Maximaal 2000W gloeilamp/halogeen & 600W fluorescentie; Grote klemmen voor o.a. een makkelijke loop-in en loop-out; lux-settings: 10-2000lux',
		'',
		'',
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)

--16	Omate Yumi
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
VALUES
	(
		'Omate Yumi',
		CONVERT(date, GETDATE(),101),
		'295mmx175mmx162mm',
		'Onbekend',
		'Op aanvraag',
		0,
		'https://www.omate.com/yumi/',
		'Het is een familierobot, aangedreven door het besturingssysteem Android. Iedereen kan de robot ook dingen laten doen via spraakbesturing. Yumi kan gekoppeld worden aan het thuisnetwerk. Zo kan de robot een uber-taxi roepen, een liedje afspelen of vragen wat het weer wordt. Omdat het een robot is die aangedreven wordt door android, kan het ook alles doen wat een android apparaat kan. Er kunnen via Yumi video’s worden afgespeeld op een TV of games worden gespeeld.',
		'Omate Robotics Artificial Intelligence (ORAI 1.0) Powered by Android; Beeldscherm: 5" HD (720x1280); Draadloze verbinding via WiFi of Bluetooth; Boxen: Dual stereo speakers; Sensoren: 360 graden geluid lokalisatie, 5 ingebouwde microfoons; Taal: Engels',
		'WiFi of Bleutooth verbinding',
		'https://www.youtube.com/watch?v=S5UTZ-ljKKE',
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)

--17	Double 2 telepresence zorgrobot
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
VALUES
	(
		'Double 2 Telepresence robot',
		CONVERT(date, GETDATE(),101),
		'Hoogte: 1200-1500mm; breedte: 250mm',
		6000,
		2995,
		0,
		'http://www.roboticare.nl/telepresence-zorgrobot-double/',
		'Dit is een zorgrobot uit de USA. Hij is voorzien van een stabiel en snel onderstel waardoor communicatie op afstand makkelijk is. Besturing is eenvoudig middels de muis of het toetsenbord. Via een webcam en iPad wordt beeld en geluid verstuurd. Er kan direct persoonlijk en live contact worden gelegd zonder lijfelijk aanwezig te zijn. Artsen, thuiszorg, mantelzorg, iedereen kan in real-time persoonlijke gesprekken met de patiënt voeren. Ideaal voor zorg op afstand waarbij gedurende een periode regelmatig consult nodig is, of om een oogje in het zeil te houden bij bijv. dementerende ouderen. Hij kan worden opgeladen met een bijgeleverd docking station waar de robot ingezet wordt.',
		'Bewezen functionaliteit; Elegant, compact design; Werkt 8 uur op accu',
		'Werkt op een WiFi of Bleutooth verbinding, stroom voor opladen',
		'https://www.youtube.com/watch?v=oI5fryQMGss',
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)

--18	PadBot telepresence robot
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
VALUES
	(
		'PadBot telepresence robot',
		CONVERT(date, GETDATE(),101),
		'Breedte: 266mm; diepte: 372mm; hoogte: 876mm',
		5000,
		1176,
		0,
		'http://www.padbot.com/',
		'De PadBot robot maakt het mogelijk voor ouderen om met vrienden, familie en de mantelzorger te communiceren, zowel verbaal als visueel, terwijl de PadBot fysiek meebeweegt. De oudere en mantelzorger kunnen snel en eenvoudig contact leggen op een wijze die voelt alsof iemand fysiek aanwezig is. Er zijn twee basistypes beschikbaar:  PadBot U1 (tablet niet inbegrepen) en PadBot P1 (met geïntegreerd scherm).',
		'Werkt met een afstandsbediening; Verrijdbaar bewegingssysteem;	Kantelbare kom;	System voor het voorkomen van botsingen; Automatische beantwoording; Automatisch oplaad ondersteunin; Accuduur: 8 uur; Oplaadduur: 6 uur; Standby tijd: 100 uur; Tablet niet inbegrepen ',
		'Voor 7 tot 10 inch tablets; iOS of Android; WiFi; Bluetooth',
		'https://www.youtube.com/watch?time_continue=37&v=C1_pX4SECdI',
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)

--19	GPS schoenzool 'Smart Sole'
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
VALUES
	(
		'Smart Sole',
		CONVERT(date, GETDATE(),101),
		'Schoenmaat 36 t/m 47',
		'Onbekend',
		200,
		0,
		'http://gpssmartsole.com/gpssmartsole/purchasing-outside-usa/',
		'De GPS Smart Sole is een inlegzool waarin onzichtbaar een zender is verwerkt. De GPS Smart Sole gebruikt een gelokaliseerde Sim kaart gekoppeld aan een GPS netwerk. Het kan een oplossing zijn voor mensen die dwalen. Het is mogelijk om via de bijbehorende portal en app een toegestaan wandelgebied af te bakenen. Zodra de wandelaar zich buiten het gebied begeeft wordt er een melding verzonden.',
		'Draadloos opladen via een oplegstation; Oplaadduur: 2 uur; Batterijduur: 1-2 dagen afhankelijk van het gebruik; Extra kosten: 34,95 per maand voor de monitoring service',
		'Abbonementskosten voor het gebruik; iOS of Android voor de app',
		'https://www.youtube.com/watch?v=6yTeX4QQXVo',
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)

--20	Beter  Zien-app
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
VALUES
	(
		'Beter Zien',
		CONVERT(date, GETDATE(),101),
		'nvt',
		'nvt',
		0,
		0,
		'http://ikwilbeterzien.nl/2014/01/beter-zien-app-bespaart-op-zorgkosten/',
		'Met de Beter Zien-app wordt tekst en beeld vergroot, waardoor deze beter te lezen en te zien zijn. Voor extra contrast zijn er zes verschillende kleurinstellingen. Tevens kan de app ook tekst voorlezen. ',
		'Vergroten van het beeld v.a. 2 tot 10 keer; Leeslampje;  Contrast verhogende filters (6 kleuren); Voorlezen van Nederlandse, Engelse,  Duitse of Spaanse tekst',
		'Lichtfunctie; iOS en Android',
		'',
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)

--21	Medido
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
VALUES
	(
		'Medido',
		CONVERT(date, GETDATE(),101),
		'Onbekend',
		'Onbekend',
		75,
		0,
		'http://www.medido.philips.nl/index.html',
		'De Philips Medido is een slimme medicijndispenser, die werkt met een volautomatisch uitgiftesysteem. Hij zorgt ervoor dat de juiste medicijnen op het juiste moment worden ontvangen en dat de gebruiker er aan herinnerd wordt deze in te nemen.',
		'Bediening door een druk op de OK-knop; Bij 5 seconden drukken op de OK-knop kom de eerstvolgende dosis medicatie eruit, zo kan medicatie ook worden meegenomen; Alarm als herinnering voor het nemen van de medicatie; Instellingen die aangepast kunnen worden; Tijdstip van uitgiftemoment; Volume en duur van het alarm voordat er een melding wordt verzonden, hierna kan er telefonisch contact worden opgenomen met de cliënt; Soorten verlichting: normaal, nachtstand of energiezuinig; Insnijlengte van het zakje; De taal; Mogelijkheid tot een extra alarm af te geven waarbij alleen tekst op het display wordt getoond. Bijvoorbeeld voor medicatie die niet in de medicatierol past; Batterijduur: 6 uur; Capaciteit 70-80 zakjes.',
		'Stroomvoorziening via stopcontact; Voorverpakte medicatie',
		'https://www.youtube.com/watch?time_continue=24&v=Zm0izkNNh2A',
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)

--22	HERO
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
VALUES
	(
		'HERO',
		CONVERT(date, GETDATE(),101),
		'Onbekend',
		'Onbekend',
		550,
		0,
		'https://herohealth.com/',
		'De HERO is een slimme medicijndispenser, die werkt met een volautomatisch uitgiftesysteem. Hij zorgt ervoor dat de juiste medicijnen op het juiste moment worden ontvangen en dat de gebruiker er aan herinnerd wordt deze in te nemen.',
		'Alles met één druk op de knop; Wordt aangepast op uw schema; Meldingen voor wanneer het tijd is om de medicatie te nemen; 10 beschikbare vakjes. Per soort tablet kan een vakje gevuld worden en erin geschoven worden; Mogelijk voor meerdere gebruikers; Met de HERO app kan de mantelzorger of andere dierbaren op afstand bijhouden of de medicatie is genomen; Dagelijks inzichten via de app; Waarschuwing als de medicatie bijna op is; Bijwerken met de nieuwste software updates; Beveiligingsmeldingen: op de app komt een melding als HERO wordt uitgetrokken of als het wordt geopend; HERO is afgesloten en beveiligd met een wachtwoord; Taal: Engels',
		'Internetverbinding; Stroomvoorziening',
		'https://www.youtube.com/watch?v=0g5lIK7IZw8',
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)

--23	MedAlert
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
VALUES
	(
		'MedAlert',
		CONVERT(date, GETDATE(),101),
		'nvt',
		'nvt',
		0,
		0,
		'https://play.google.com/store/apps/details?id=nl.freed.medalert',
		'Met deze gratis applicatie voor de iPhone en Android stellen medicijngebruikers zelf herinneringen in voor de momenten waarop zij medicatie moeten innemen. Het instellen van alerts is simpel. Wanneer u een herinnering invoert, kunt u aangeven welk medicijn en welke dosis u innemen, wanneer en hoe vaak. Op het moment dat u uw medicijnen moet innemen, geeft de smartphone een melding. MedAlert biedt bovendien een aantal handige extras zoals: inname-controle, voorraadbeheer en notities. Ook is de app geschikt voor de meest gebruikte anticonceptie middelen, rekening houdend met de cyclus.',
		'Beschikbaar voor iOS en Android; Verschillende functies op het gebied van medicatie inname; App wordt geupdate met nieuwe functies als deze mogelijk zijn',
		'Client moet een telefoon is tablet hebben om de app te kunnen gebruiken; App moet duidelijk uitgelegd en ingesteld worden; Telefoon en/of tablet moet wel ingeschakeld zijn om de app te laten werken',
		'https://www.youtube.com/watch?v=BRNVoziei7c',
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)

--24	Zorgriem Alarmknop
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
VALUES
	(
		'Zorgriem Alarmknop',
		CONVERT(date, GETDATE(),101),
		'92mmx44mmx17,9mm',
		74,
		370,
		0,
		'http://www.zorgriem.nl/bestel-de-zorgriem/',
		'Alle gemakken van vaste alarmering en tegelijkertijd ook nog zeer mobiel. U kunt op ieder moment zowel binnen als buiten uw huis alarmeren. De alarmknop is zeer gebruiksvriendelijk, eenvoudig in te zetten en direct klaar voor gebruik.',
		'Voor binnen en buiten gebruik; Locatiebepaling binnen en buiten; Leefcirkels en veilige zones; Spreekluister verbinding; Meldingen via sms, email, pushberichten etc.; Zorg en Particulier alarmcentrales; Totale service en onderhoud; GSM en GPRS; Standby tijd van 250 uur; Batterij Li-ion 1000 mAh',
		'Client moet functie bezitten om knoppen in te drukken; Mogelijkheid tot opladen moet er zijn',
		'https://www.youtube.com/watch?v=8PTkJz5n1RQ',
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)

--25	SensFloor
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
VALUES
	(
		'SensFloor',
		CONVERT(date, GETDATE(),101),
		'Afhankelijk van oppervlakte waar vloer geplaatst wordt',
		'Afhankelijk van de afmeting',
		'Op aanvraag',
		0,
		'www.sensfloor.nl',
		'De SensFloor bestaat uit een ondervloer met geïntegreerde sensoren. De SensFloor bestaat uit een ondervloer met geïntegreerde sensoren. De SensFloor kan dienen als valdetectie, maar ook voor het automatisch openen van deuren, het inschakelen van lichten en het monitoren van activiteiten. Op een vierkante meter bevinden zich, afhankelijk van het type vloer, 16 of 32 sensoren. De slimme vloer vervangt alle ondervloeren en kan voorzien worden van vrijwel alle soorten vloerbedekking: van laminaat tot vloertegels en van pvc tot tapijt. De sensoren in de ondervloer meten precies wat er allemaal gebeurt op de vloer.',
		'Licht inschakelen; Deuren openen of sluiten; Valdetectie; Indringersalarm; Monitoring van activiteit; Detectie van lekkage en aanwezigheidsherkenning; Badkamergedrag wordt geregistreerd; Onderhoud en service zijn geregeld door SensFloor; Vloer is altijd verbonden met de SensApp die gedownload kan worden op alle apparaten',
		'WiFi verbinding nodig voor de verbinding met de SensApp',
		'https://www.youtube.com/watch?v=5V2ovHKkYj0',
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)

--26	Maaltijdondersteuning Obi
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
VALUES
	(
		'Maaltijdondersteuning Obi',
		CONVERT(date, GETDATE(),101),
		'Onbekend',
		3360,
		5520,
		0,
		'http://www.focalmeditech.nl/nl/maaltijdondersteuning/obi',
		'De maaltijdrobot Obi zorgt ervoor dat de gebruiker weer volledig zelfstandig en overal kan eten. Door deze maaltijdondersteuning zorgt voor meer onafhankelijkheid.',
		'De positie kan gemakkelijk worden ingesteld door op de “leer” knop te drukken en de beweging eenmaal met de arm te maken; Te bedienden met een speciale joystick of knop; Essentiële onderdelen zijn vaatwasser bestendig; Draagbaar systeem; Herlaadbare batterij; Batterijduur: 2-4 uur; Oplaadduur: 1-2 uur',
		'Slikstoornissen tenzij Obi door een ervaren sliktherapeut geïndiceerd en veilig geacht wordt; Ernstige problemen met het kauwen. In dit geval kan Obi wel gebruikt worden indien het voedsel voldoende verkleind of vermalen is; Niet in staat zijn enig bedieningselement zoals een speciale joystick of knop te bedienen',
		'https://www.youtube.com/watch?time_continue=36&v=KHsgHHSJC6Y',
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)

--27	Assistep
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
VALUES
	(
		'Assistep',
		CONVERT(date, GETDATE(),101),
		'Ingeklapt: de rail steekt 10cm uit vanaf de muur. Als de hangreep is opgevouwen steekt deze 18cm uit vanaf de muur. In gebruik: neemt de greep in totaal 55 cm in beslag',
		'Onbekend',
		'Kostenindicatie: op aanvraag bij de leverancier en afhankelijk van uw soort trap',
		0,
		'http://www.mbility.nl/assistep/',
		'Assistep, de veilige trap assistent, is ontworpen voor mensen die hun gehele woning zelfstandig willen kunnen gebruiken. Het bestaat uit een trapleuning die geïnstalleerd is langs de trap, gekoppeld aan een handgreep die steun geeft bij het omhoog en omlaag lopen.',
		'Voor gebruik duwt u de handgreep voor u uit, wanneer u de handgreep omlaag trekt vergrendelt deze.
De handgreep vergrendeld automatisch als er te veel kracht wordt uitgeoefend of als de greep wordt losgelaten.
Handgreep is inklapbaar door een druk op de knop.
De hoogte van de handgreep kan aangepast worden met 30cm.
Soorten trappen: rechte trappen, L-draai trappen met/zonder overloop , U-draai trappen met/zonder overloop.',
		'Mogelijkheid om stapsgewijs trap te kunnen met ondersteuning
Maximum gewicht gebruiker: 120 kg
Aanbevolen lengte gebruiker: 120-200 cm',
		'https://www.youtube.com/watch?v=dZMyGQdXEyU',
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)
	
--28	Save-me
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
VALUES
	(
		'Save-me',
		CONVERT(date, GETDATE(),101),
		'Afmetingen: lengte: 300 mm en breedte: 18 mm',
		34,
		'Kosten: 10 euro eenmalig, premium diensten zijn per jaar en afhankelijk per pakket',
		0,
		'https://save-me.nu/shop',
		'Met Save-me heb je altijd je actuele persoonlijke en medische informatie bij de hand. Zo kunnen hulpverleners in geval van nood zo snel mogelijk de juiste hulp bieden en kan de familie ingelicht worden. Save-me geeft antwoord op de belangrijke vragen zoals: Wie ben je?, Wie moeten er worden ingelicht?, Wat is je bloedgroep?, Waar ben je verzekerd?, Heb je allergieën?, Gebruik je medicijnen, en zo ja in welke dosering?, Wil je gereanimeerd worden?, Heb je een donorcodicil?, Heb je aandoeningen?',
		'Onbeperkt producten koppelen aan de armband.
Een account voor het hele gezin.
Documenten uploaden op je persoonlijke pagina.
Gratis Save-me card.
Privacy instellingen kunnen aangepast worden.
Armband bestaat uit siliconen.
Het tekstplaatje en de veiligheidssluiting zijn van roestvrijstaal.
Eenvoudig op maat gemaakt.',
'Cliënt moet de armband wel omdoen 
Wifi is nodig om het persoonlijke profiel aan te passen
Pagina moet up to date gehouden worden. ',
		'https://www.youtube.com/watch?v=bQU6K9i5rDo',
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)
	
--29	Home Living concept
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
VALUES
	(
		'Home Living concept',
		CONVERT(date, GETDATE(),101),
		'nvt',
		'nvt',
		0,
		0,
		'https://www.deheermedicom.nl/Produkten/Zorg-apps/HomeLiving-Concept',
		'HomeLiving is een applicatie op een tablet die speciaal is ontwikkeld voor mensen die langer zelfstandig thuis blijven wonen. De HomeLiving applicatie maakt het mogelijk om eenvoudig te communiceren met familie, vrienden, kennissen en eventueel indien gewenst, een professionele zorgverlener. Steeds meer spelen de nu nog vitaal thuiswonende ouderen, in op de tijd dat het misschien net even fysiek en mentaal iets minder gaat. De HomeLiving past zich aan de veranderende behoefte van de bewoner aan. Het systeem groeit in feite mee met de toenemende (zorg)vraag.',
		'De HomeLiving beschikt over een knop ‘zorgoproep’. Via een druk op deze knop wordt er een melding verstuurd naar de mantelzorger, meldbank of professionelezorgverlener.   Met de HomeLiving kunnen niet alleen zorgoproepen worden gemaakt, maar kunnen ook andere functies worden gebruikt, namelijk; 
Reminders: hiermee kunnen korte berichten worden verstuurd om de bewoner ergens aan te laten herinneren en/of uit te nodigen, bijvoorbeeld medicijngebruik. 
Video- en/of audiocommunicatie: Hiermee kunnen bewoners chatten, bellen of beeldbellen met de mantelzorgers of professionele zorgaanbieders. 
Web-diensten: Vanuit de HomeLiving kunnen eenvoudig verschillende webpagina’s worden opgeroepen. 
Domotica: Binnen de HomeLiving is het “Klik aan/Klik uit” protocol geïntegreerd. Hierdoor is het mogelijk om eenvoudig deze producten te koppelen. Enkele mogelijkheden zijn het bedienen van verlichting, audiovisuele apparatuur, rolluiken en het regelen van de temperatuur.
Standaard Internetverbinding met WiFi
Optionele mogelijkheid om beeldbel verbinding op te bouwen
Optionele mogelijkheid om spraakverbinding op te bouwen 
Mogelijkheid om alarmen naar een groep mantelzorgers te sturen, of naar professionele zorgverlening
Koppeling met een centrale meldbank mogelijk
E-Health toepassingen, mogelijkheid voor metingen (gewicht, bloeddruk), maar ook teleconsultatie.',
		'Wifi verbinding nodig voor alle functionaliteiten
Cognitieve capaciteiten bezitten om product te bedienen',
		0,
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)
	
--30	Body dryer
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
VALUES
	(
		'Body dryer',
		CONVERT(date, GETDATE(),101),
		'Onbekend',
		'Onbekend',
		250,
		0,
		'Onbekend',
		'De Body dryer maakt afdrogen overbodig. Hij ziet uit als een weegschaal, waarbij ook het gewicht moet worden ingevoerd zodat de dryer weet hoeveel lucht hij moet blazen om het lichaam droog te krijgen. Hij kan met deze optie ook vertellen wat het gewicht is.',
		'Blaast droog in 30 seconden.
Zelf regelen van warme of koude lucht.',
'Persoon mag niet zwaarder zijn dan 147 kilogram.',
		'https://www.youtube.com/watch?v=iKEQ1W0QcYA',
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)
	
--31	Viega Eco Plus
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
VALUES
	(
		'Viega Eco Plus',
		CONVERT(date, GETDATE(),101),
		'1130mmx490mmx130-200mm',
		'Onbekend',
		865,
		0,
		'http://www.viega.nl/xchg/nl-nl/hs.xsl/7188.html ',
		'Dit is een individueel in de hoogte verstelbaar WC element, ontwikkeld voor gebruik zonder elektronica. De instelling van de hoogte vindt op dezelfde manier plaats als het in de hoogte afstellen van een bureaustoel. Op deze manier is er een individuele hoogte instelbaar van 8 cm verschil. Het element is voorzien van een flexibele afvoer en een variabele spoelbocht. ',
		'Viega Eco Plus
Bij standaard hoogte van het element (1130 mm) is het bereik van het keramiek van 40 t/m 48 mm instelbaar. 
Ook beschikbaar als hoekelement.',
		0,
		'https://www.youtube.com/watch?v=sKnnIJl5uUI ',
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)
	
--32	Geberit Aquaclean
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
VALUES
	(
		'Geberit Aquaclean',
		CONVERT(date, GETDATE(),101),
		'800mmx600mmx400mm',
		3000,
		3898,
		0,
		'https://www.frissebips.nl/douchewc-kopen/elektrische-douchewcs/geberit-aquaclean-mera-douchewc/ ',
		'Dit is een douche wc. Een WC en een ‘douche’ in een. Whirlspray douchetechnologie zorgt voor een grondige en aangename reiniging met een snelle en continue toevoer van warm water. De Turboflush spoeltechnologie, een oriëntatielicht, een föhnfunctie, een wc-deksel die automatisch opent en sluit, een toiletzitting met geïntegreerde verwarming en geurzuivering maken deel uit van dit toilet.',
		'Geberit Aquaclean Mera comfort
Douchefunctie achter en voor.
Verwarmde soft close toiletbril.
Hygiënische föhn.
Direct verwarmde waterstraal met boiler.
Persoonlijk instelbare menu’s.
Comfortabele reiniging met lucht en water.
Masserende waterstraal met massagestanden.
Geurafzuiging.
Automatische zelfreiniging sproeiers
Aansturing via intuïtieve afstandsbediening
Incl. wandcloset',
	   'Elektriciteit max. 2000W',
		'https://www.youtube.com/watch?v=4LhzuG9vMjg ',
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)
--33	Douchecabine Aqua Diamond
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
VALUES
	(
		'Douchecabine Aqua Diamond',
		CONVERT(date, GETDATE(),101),
		'2200mmx900mmx900mm',
		'Onbekend',
		899,
		0,
		'https://www.douche-concurrent.nl/douchecabine-aqua-diamond#specificaties',
		'De douchecabine aqua diamond is een gesloten kwartronde cabine van douche concurrent. Deze is afgewerkt met aluminium profielen, robuuste handvaten gefabriceerd uit RVS en de achterwanden zijn voorzien van spiegelveiligheidsglas van 5 mm dik. De douchecabine is voorzien van een handdouche en diverse douchefuncties. Naast de normale handdouche heeft de cabine ook een regendouche en 6 verstelbare massagejets. Bovendien kunt u gebruik maken van FM-radio d.m.v. het bedieningspaneel. Daarbij heeft de cabine ook LED verlichting die duurzaam en energiezuinig is. De douche kan ook voorzien worden van een zitje, waardoor het wassen makkelijker gaat. ',
		'•	Diamond Line
•	Veiligheidsglas
•	2 schuifdeuren
•	Hoek instap
•	Sta hoogte: 2000 mm
•	Voetmassage
•	Handdouche
•	Stortdouche
•	Massage jets
•	Alarmfunctie
•	Radio
•	Telefoonfunctie
•	Speaker
•	Ventilator
•	Verlichting
',
	   'Aansluitwaarde 230 V',
		'https://www.youtube.com/watch?v=_vfYrCyrYh4  ',
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)
--34	Toiletlift
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
VALUES
	(
		'Sanmedi Toiletlift TL-50',
		CONVERT(date, GETDATE(),101),
		'610mmx750mm',
		'Onbekend',
		1750,
		1,
		'http://www.sanmedi.nl/index.php?module=shop&shopID=1&articleID=1469&categoryID=125&page=0&manufacturerID=46',
		'Met de losse toiletverhogers kunt u uw standaard toiletpot met 6 of 10cm verhogen. De toiletlift vergemakkelijkt de transfer op en van het toilet. De toilet wc lift is in verschillende uitvoeringen beschikbaar. (sta-op hulp bij het toilet)',
		'•	WC kan 6 tot 10 cm verhoogd worden
•	Kan over de bestaande toiletpot gezet worden
•	Vergemakkelijkt de transfer naar de wc 
•	Vermindert de kans op vallen tijdens het maken van de transfer
•	Armondersteuning die in- en uitgeklapt kan worden
•	Instelbaar in verschillende posities
',
	   '•	Transfer moet staand uitgevoerd kunnen worden
•	Arm functie is nodig om de armleggers vast te kunnen houden
•	Cliënt moet zich positioneren
',
		'https://www.youtube.com/watch?v=ZWKoHfT_g3Y',
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)
--35	Philips Wake up Light
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
VALUES
	(
		'Philips Wake Up Light',
		CONVERT(date, GETDATE(),101),
		'146mmx199mmx192mm',
		'1110g',
		99.95,
		0,
		'https://www.bol.com/nl/p/philips-hf3520-01-wake-up-light-wit/9000000012677980/?Referrer=ADVNLGOO002017-G-20382627857-S-98538032177-9000000012677980',
		'De Philips HF3520/01 wake-up light helpt je om actiever en fitter wakker te worden. Van zon- en daglicht krijg je energie. Geïnspireerd door de zonsopgang maakt de Philips wake-up light gebruik van een combinatie van licht en geluid, waardoor je op een natuurlijke manier gewekt wordt. Het licht van de zonsopgangsimulatie verandert van zacht ochtendrood via warm oranje in helder geel licht. Dit in combinatie met prettige natuurgeluiden zorgt voor een goed begin van je dag.',
		'•	Prettig ontwaken met 5 natuurlijke geluiden
•	Display met automatische aanpassing
•	Aantal wekgeluiden: 5
•	Digitale FM-radio
•	Rubberen anti-slipmat
•	Sluimeren: tik op willekeurige plek voor sluimeren
•	Helderheid van het scherm: automatische aanpassing
•	Aantal keren alarm: 2
•	Sluimerduur: 9 minuten
•	Snoerlengte: 150 cm
•	Frequentie: 50/60 Hz
•	Type lamp: Lumiled Luxeon Rebel
•	Voltage: 240 V
•	Zonder UV-stralen
',
	   '•	Netstroom toevoer is noodzakelijk
•	Lampen moeten vervangen worden als deze kapot gaan
•	Snoer is maar 150 cm dus hiermee rekening houden m.b.t. afstand stopcontact
',
		'https://www.youtube.com/watch?v=7f3fuzHkOqI',
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)
--36	Fitbit Activity Tracker
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
VALUES
	(
		'Fitbit Charge 2 Activity Tracker',
		CONVERT(date, GETDATE(),101),
		'Small: Geschikt voor een polsomtrek van 140 mm - 170 mm
Large: Geschikt voor een polsomtrek van 170 mm - 206 mm
',
		'290g',
		149.95,
		0,
		'https://www.sporthorlogecenter.nl/product/735743/category-254522/fitbit-charge-2-black-silver-l.html',
		'De Fitbit Charge 2 is de opvolger van Fitbit Charge HR. De activity tracker zorgt ervoor dat zowel jouw dagelijkse activiteiten als jouw trainingen worden gemeten en geanalyseerd. PurePulse hartslagmeting zorgt ervoor dat jij gemakkelijk het uiterste uit jouw oefeningen kan halen, beter de calorieverbranding onder controle hebt en een duidelijk beeld hebt van jouw cardio fitness level. Dit alles terwijl de activity tracker jouw dagelijkse activiteiten ook nog eens meet. Het OLED scherm zorgt ervoor dat jij connected blijft met jouw smartphone.',
		'Meet de hele dag al jouw activiteiten
Meet aantal stappen, afstand, aantal trappen, aantal actieve minuten en verbrande calorieën.
Voorziet je van ademoefeningen om je adem volledig onder controle te krijgen
Smartphone notificaties zijn te ontvangen op het scherm
De tracker meet ook jouw kwaliteit van slapen. De app op je smartphone geeft de resultaten weer
In het dashboard van Fitbit in de app kan jij precies al jouw activiteiten bijhouden. Hier heb jij een goed overzicht van jouw fitheid, daarnaast zie je ook de vooruitgang die je boekt.
',
	   'Armband moet om gehouden worden om slaapritme te meten
Er zit geen ingebouwde GPS in
Is alleen spatwaterdicht, niet waterdicht
Na 5 dagen dient de activity tracker opgeladen te worden
',
		'https://www.youtube.com/watch?v=LuhkPUlcZCo',
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)
--37	Gita
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
VALUES
	(
		'Gita boodschappenrobot',
		CONVERT(date, GETDATE(),101),
		'Onbekend',
		'Onbekend',
		'Onbekend',
		0,
		'http://piaggiofastforward.com/gita.php ',
		'Gita heeft veel bagageruimte voor je spullen, rolt zelfstandig achter je aan of bezorgt gewoon even een pakketje voor je. Hij is erg stijlvol vormgegeven en zit bomvol hippe technologie. Met 360 graden camera’s, GPS en allerlei sensoren kan Gita zich moeiteloos navigeren over de straat of door de supermarkt. Technologie voor het ontwijken van obstakels en slimme software zorgt ervoor dat hij nergens tegenaan rijdt. Gita is beveiligd met vingerafdrukherkenning. Scan je vinger en Gita rolt achter je aan. ',
		'•	GPS
•	Maximale draagkracht tot 18 kilo
•	Maximale snelheid 35 km/h
•	Vingerafdrukherkenning
•	Accuduur: 8 uur
',
	   '•	In staat zijn om zelf boodschappen in Gita te stoppen
•	Beschikken over arm- en handfunctie
•	Stroom voor opladen
',
		'https://www.youtube.com/watch?v=hKdYAGQVb-k ',
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)
--38	The Dot Smartwatch
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
VALUES
	(
		'The Dot Smartwatch',
		CONVERT(date, GETDATE(),101),
		'43mmx12.5mm',
		'27g',
		298,
		0,
		'https://dotincorp.com/ ',
		'The Dot is een smartwatch met braille. Met deze smartwatch is het mogelijk om een bericht te versturen, de mail te checken, je hartslag in de gaten houden of gewoon kijken hoe laat het is. Wanneer The Dot wordt gesynchroniseerd met een smartphone, zendt deze alle gegevens door. Net zoals bij elke andere smartwatch. Ook kunnen er met het horloge korte berichtjes verstuurd worden via de knoppen die aan de zijkant zitten. The Dot is natuurlijk niet het eerste digitale apparaat dat is ontwikkeld voor blinden en slechtzienden. Maar veel van deze producten (zoals apps) gebruiken geluid. Dat is lastig, want door oordopjes kunnen geen omgevingsgeluiden meer gehoord worden en die zijn juist zo belangrijk als je niet kunt zien. De ontwikkelaars van de smartwatch wilden hier dus een einde aan maken.',
		'•	Lange batterijduur
•	Vier dynamische braillecellen per keer
•	Gemaakt van aluminium 
•	Leren polsband
•	Touch-sensor
•	Vibratie motor
•	Bluetooth
',
	   '•	Braille kunnen lezen
•	Beschikken over arm- en handfunctie
•	Stroom voor opladen
',
		'https://www.youtube.com/watch?v=wkXGERVYmDU',
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)

--39	Lift ware bestek
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
	VALUES
	(
		'Lift ware bestek',
		CONVERT(date, GETDATE(),101),
		'Onbekend', --afmetingen niet opgegeven
		'Onbekend', --gewicht niet opgegeven
		195,
		0,
		'https://www.liftware.com/level/',
		'De Liftware elektronische lepel en vork met ingebouwde sensoren maken eten een stuk makkelijker. Sensoren in de lepel reageren op de trillingen van de hand en zorgen voor een tegenbeweging. Zo blijven lepel en vork stabiel in de hand liggen: er valt geen eten meer af en de gebruiker krijgt voldoende voedingsstoffen binnen. Met dit bestek wordt eten voor o.a. mensen  met Parkinson een stuk prettiger.',
	    'Stabilisator, Een laadstation, Lepel en Vork, USB kabel, Kabel voor Amerikaan elektriciteitsnet, Inclusief handleiding (Engelstalig),3 uur oplaadtijd, 3 tot 6 maaltijden per dag nuttigen, De vork of lepel kunnen onder de kraan of in de vaatwasser schoon worden gemaakt, Het handvat kan met een vochtige doek worden afgenomen',
		'Beschikken over arm- en handfunctie, Stroom voor opladen, Voor opladen in Nederland is een internationale stekker vereist of via de USB kabel in de computer',
		'https://www.youtube.com/watch?v=YNwfXeLlqsU ',
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)
	
--40	Zora
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
	VALUES
	(
		'Zora',
		CONVERT(date, GETDATE(),101),
		'0x0x57cm',
		12,
		15000,
		0,
		'http://www.consyst.nl/zora-zorgrobot/',
		'ZORA (Zorg Ouderen Revalidatie en Animatie) kan worden ingezet voor revalidatie, valdetectie en animatie van senioren. Zora robot wordt o.m. ingezet voor de activering van ouderen. De Zora zorgrobot kan communiceren, dansen, spelletjes spelen, voorlezen, de animatie aanvullen en bewegingsoefeningen doen. Deze combinatie is voor zorgtehuizen een reden om de robot in te zetten voor gymnastiek oefeningen. Zora doet het voor en de ouderen moeten de robot volgen. Bij de ouderen is Zora actief als motivator bij allerhande revalidatie- en bewegingsoefeningen. Zora zorgt dus voor meer menselijk contact en interactie.',
		'Spraakherkenning, Vier richtbare microfoons en luidsprekers voor communicatie, Wifi-adhoc, Telenet afstandsbediening, Voorleesfunctie, Bewegingsmogelijkheden zoals dansen',
		'Stroomvoorziening voor opladen, Wifi verbinding.',
		'http://www.kijk.nl/video/Rwb3lk5uSnQ2',
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)
	
--41	MyTaste recepten
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
	VALUES
	(
		'MyTaste recepten',
		CONVERT(date, GETDATE(),101),
		'nvt', --afmetingen niet opgegeven
		'nvt', --gewicht niet opgegeven
		0,
		0,
		'https://play.google.com/store/apps/details?id=com.mytaste.mytaste&hl=nl',	
		'Door gebruik te maken van myTaste, kun je alle recepten uit Nederlandse voedselblogs en websites eenvoudig vinden op één plek. Maak je eigen kookboeken, zodat je je favoriete recepten snel en makkelijk terug kunt vinden op je smartphone waar je ook bent! Maak handig gebruik van de app of ga naar de website myTaste.nl . Ontdek de kookboeken van andere gebruikers en ontdek welke recepten het meest populair zijn.',
		'Keuze uit recepten van alle landen over de hele wereld, Eigen receptenboek maken met het opslaan van gemaakte recepten, Populaire gerechten zijn een aparte categorie, Mogelijkheid tot vrij zoeken in de database van de recepten, Mogelijkheid om alles direct te delen via social media, Foodbloggers kunnen gevolgd worden met deze app, Push berichten als nieuwe gerechten gepost worden, Gebruikt ook mogelijk zonder social media account, Video’s zijn toegevoegd om het koken te vergemakkelijken',
		'Smartphone of tablet nodig om de app te gebruiken, Handigheid met het werken met apps is aan te raden',
		'nvt', --video niet opgegeven
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)
	
	
--42	Yoho app
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
	VALUES
	(
		'Yoho-app',
		CONVERT(date, GETDATE(),101),
		'nvt', --afmetingen niet opgegeven
		'nvt', --gewicht niet opgegeven
		0, --kosten niet opgegeven
		0,
		'http://www.hetbestezorgidee.nl/genomineerden-2016/yoho-app/ ',	
		'De Yoho-app staat voor ‘Young helps old’, en is een app waarbij hulpbehoevende senioren gekoppeld worden aan jongeren die een bijbaantje zoeken. Een nieuwe versie van ‘Heitje-voor-karweitje’! Veel tieners zoeken een bijbaan en willen tegen betaling van het minimumloon, dat ze ook in een supermarkt zouden krijgen, met alle plezier ouderen helpen. Denk bv. aan kleine klusjes zoals boodschappen doen of grasmaaien. Maar tieners kunnen eenzame ouderen ook helpen uitleggen wat ze met hun iPhone of iPad kunnen doen, of een wandeling maken.',
		'App voor Android of iOS',
		'Om kunnen gaan met smartphone of tablet',
		'https://www.youtube.com/watch?v=FPYQ7O44wb0',
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)
	
--43	MijnKassabon app
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
	VALUES
	(
		'MijnKassabon app',
		CONVERT(date, GETDATE(),101),
		'nvt', --afmetingen niet opgegeven
		'nvt', --gewicht niet opgegeven
		0,
		0,
		'https://play.google.com/store/apps/details?id=nl.mijnkassabon&hl=nl',
		'Van papieren kassabonnen naar mobiel. MijnKassabon zorgt voor digitalisering van aankoopbewijzen die altijd en overal te raadplegen zijn met een smartphone. In combinatie met krachtige analytische tools en koppelingen met boekhoudpakketten, biedt de digitale kassabon voor een ieder uitkomst.',
		'Download is gratis in de Playstore (Android) en Appstore (iOS), Account kunt u aanmaken met uw email of social media account, Zonder registratie werken kan ook, Een persoonlijke barcode voor al uw klantenkaarten, Raadpleeg de app bij een aankoop, voor een klantenkaart en/of voor het tonen van de barcode voor het ontvangen van de digitale kassabon, Alle aankoopbewijzen, garantieoverzichten en nog veel meer in een alles omvattende applicatie geschikt voor elke smartphone, Een eigen winkel aanmaken die niet in de lijst staat; wij hebben meer dan 100 voorgeprogrammeerde winkels in deze app. Staat jouw favoriete winkel er niet tussen? dan kun je deze gemakkelijk zelf aanmaken en toevoegen aan de bestaande lijst met winkels.',
		'Smartphone of tablet nodig om de app te gebruiken, Handigheid met het werken met apps is aan te raden, Klantenkaarten moeten wel eerst ingescand worden in de app, Niet elke barcodescanner in de winkel kan de barcode van het scherm aflezen, dit komt omdat zij nog gebruik maken van verouderde scan technieken. De kassier zal je klantenkaart dus handmatig moeten invoeren.',
		'https://www.youtube.com/watch?v=_Ms_paE-pkQ',
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)
	
--44	Boodschappenlijst app
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
	VALUES
	(
		'Boodschappenlijst app',
		CONVERT(date, GETDATE(),101),
		'nvt', --afmetingen niet opgegeven
		'nvt', --gewicht niet opgegeven
		0,
		0,
		'https://play.google.com/store/apps/details?id=com.shoppinglist&hl=nl',
		'Shopping List is de eenvoudigste manier om uw boodschappenlijstjes te organiseren. Het is minimalistisch, intuïtief en makkelijk te gebruiken, het houdt uw boodschappenlijstje bij zonder u lastig te vallen met complexe functies. De ontwikkeling van Shopping List wordt ondersteund door reclame - het kost u minder dan een kopje koffie om deze te verwijderen.',
		'Meerdere boodschappenlijstjes, Voeg producten toe aan de boodschappenlijstjes, Lijstjes delen per sms, e-mail, WhatsApp etc., Markeer items in uw boodschappenlijstje als "gekocht" of "in winkelwagen" • Sleep en plaats producten om ze te ordenen zoals u dat wilt, Bewerk items op de lijst (druk lang op een item en klik op het bewerk-pictogram), Bespaar tijd met behulp van de suggesties die verschijnen als u begint met het typen van een productnaam, Suggesties zijn gepersonaliseerd, Beheer de lijst met suggesties (meteen als ze verschijnen)',
		'Smartphone of tablet nodig om de app te gebruiken, Deze app vereist toegang tot internet, aangezien het een vereiste is voor de advertenties in de app.',
		'nvt', --video niet opgegeven
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)

--45	LOHAS bed
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
VALUES
	(
		'LOHAS Bed',
		CONVERT(date, GETDATE(),101),
		'Vergelijkbaar met de afmetingen van een ziekenhuisbed', --afmeting ziekenhuis bed?,
		'Onbekend', --niet opgegeven
		'Onbekend', --niet opgegeven
		0, --niet opgegeven
		'http://www.yankodesign.com/2017/01/23/a-little-sunshine-goes-a-long-way/',
		'Het LOHAS bed is een volledig functionerend ziekenhuisbed die comfortabel is voor patiënten en ouderen om in te slapen, rusten of herstellen. Een deel van het LOHAS bed kan transformeren in een rolstoel, hierdoor kan de ouderen zelfstandig de kamer verlaten.',
		'Een ziekenhuisbed dat kan transformeren in een rolstoel',
		null, --niet opgegeven
		null, --niet opgegeven
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)
	
--46	Zorgrobot Lea
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
VALUES
	(
		'Zorgrobot LEA',							--naam	
		CONVERT(date, GETDATE(),101),				--dat
		'Onbekend', --niet opgegeven 						--size
		'Onbekend', --niet opgegeven						--weight
		'Onbekend', --niet opgegeven						--cost
		0,
		'http://www.robotcaresystems.nl/robot-lea/ ',
		'Lean Eldery Assistant, (LEA) is een robot vermomd als rollator. Deze innovatieve robot zorgt ervoor dat ouderen langer zelfstandig kunnen blijven. LEA kan veel voor ouderen betekenen. Hij is als het ware hun persoonlijke assistent. De robot komt op commando naar je toe, hij helpt je bij het opstaan, bij het bewegen, maar herinnert je er ook aan wanneer je je medicijnen moet nemen. Via de ingebouwde communicatie van LEA kun je in contact treden met familie, zorgmedewerkers of een alarmcentrale. Met zijn speciale arm kan LEA daarnaast voorwerpen ophalen of van de vloer rapen. Dankzij LEA blijft iemand langer zelfredzaam. De gebruiker is minder afhankelijk van een partner, familie, zorgverlener en/of mantelzorger. De kwaliteit van leven wordt aanzienlijk bevorderd door LEA. Zorgverleners of familieleden houden meer tijd over om bijvoorbeeld sociale aandacht te bieden.',
		'Helpt bij het opstaan uit bed en stoel. Beschermt door stabiliteit en programmatuur. Stimuleert ouderen om lichamelijk actief te blijven. Speciale fitnessoefeningen en danspartner. Ingebouwde communicatiefunctie. Melding voor medicijngebruik, eten, drinken en activiteiten. Helpt bij de dagelijkse routine en doet metingen. Verwerking van dagelijkse gegevens van de gebruiker. Kan zichzelf verplaatsen op commando van gebruiker',
		'Stroom, Wifi verbinding',
		'https://www.youtube.com/watch?v=pPBNISd-8uo ',
		1,									
		1,
		CONVERT(date, GETDATE(),113)
	)
	
--47	ICIO
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
VALUES
	(
		'ICIO',	
		CONVERT(date, GETDATE(),101),				--dat
		'Onbekend', --niet opgegeven						--size
		'Onbekend', --niet opgegeven						--weight
		'Onbekend', --niet opgegeven						--cost
		0, --niet opgegeven						--covered
		'http://www.tuvie.com/icio-offers-effective-solution-of-transfer-vehicles-for-the-elderly-community',
		'Product beschrijving: De ICIO is een manier om de mobiliteit van ouderen te versterken. De ICIO verbetert de onafhankelijkheid, activiteit en verantwoordelijkheid van de ouderen. Een innovatief concept speciaal ontwikkeld voor ouderen en hun lang gekoesterde wensen. Hoe meer actief de ouderen worden door de ICIO hoe gezonder zij zullen worden en hoe minder eenzaam zij op den duur zullen worden. Mensen die het moeilijk vinden om te lopen en minder mobiel zijn kunnen met ICIO veel mobieler worden. De ICIO kan gebruikt worden als rollator, winkelwagen en zelfs scootmobiel. De mogelijkheden van de ICIO zijn eindeloos. ',
		'ICIO heeft een strak design waardoor het niet uitziet als een ouderwets hulpmiddel. Er is geluisterd naar de wensen van thuiswonende ouderen. Gebruik de ICIO als rollator, scootmobiel en zelfs winkelwagen. Met het touchpad kan de ICIO helemaal bestuurd en bediend worden',
		null, --niet opgegeven						--req
		null, --niet opgegeven						--mov
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)
	
--48	Foldimate
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
VALUES
	(
		'Foldimate',
		CONVERT(date, GETDATE(),101),
		'710x810x790mm ',
		30,
		800,
		0,
		'https://www.foldimate.com/',
		'De FoldiMate is een robot die je was strijkt en vouwt. Het enige wat jij moet doen is je (droge) was aan speciale washaken hangen, de machine doet de rest: hij stoomt je kleding en vouwt het op. In het apparaat kunnen maximaal 15 stuks kleding tegelijk. Het enige minpuntje aan de FoldiMate: hij doet alleen shirts, truien, jurkjes, eigenlijk dus alles waar mouwen aan zit. Broeken, handdoeken, ondergoed en beddengoed, alles zonder mouwen dus, moet je nog zelf doen.',
		'15 kledingstukken per keer, Tijdbesparend, Verbonden met wifi, 110-240 volt',
		'In staat om zelf de was op te hangen, Stroom,Wifi verbinding',
		'https://www.youtube.com/watch?v=swNgjX0xHC8 ',
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)

-- 49 Robear
INSERT PRODs
	(
		Prod_Name,
		PROD_DAT,
		PROD_SIZE,
		PROD_WEIGHT,
		PROD_COST,
		PROD_COVERED,
		PROD_AVAIL,
		PROD_DESC,
		PROD_SPEC,
		PROD_REQ,
		PROD_MOV,
		PROD_VIEWS,
		Prod_Val_User_USER_Id,
		Prod_Val_Dat
	)
VALUES
	(
		'Robear',
		CONVERT(date, GETDATE(),101),
		'160cm ',
		130,
		'Onbekend', --niet opgegeven --cost
		0,		-- niet opgegeven --covered
		'http://www.dailymail.co.uk/sciencetech/article-2966380/Japans-Robear-Strength-robot-face-bear.html',
		'De Robear is in staat taken uit te voeren zoals het tillen van een patiënt uit een bed en een rolstoel. Ook kan hij een patiënt ondersteunen zodat deze in staat is om op te staan. Robear bevat ook een aantal functies die het mogelijk maken om kracht uit te oefenen op een zachte manier. De Smart Rubber tactiele sensoren zijn volledig van rubber en maken het mogelijk dat de robot “krachtintensieve” taken kan uitvoeren, zoals het optillen van patiënten, op een voor mensen aangename wijze. De robot beschikt met zijn Smart Rubber tactiele sensoren over zachte handen. Hij kan gemakkelijk manoeuvreren in smalle ruimtes, zoals deuropeningen.',
		'Drie soorten sensoren, Lage tandwielverhouding, De ‘gewrichten’ van de robot bewegen zeer specifiek en geleidelijk, Kan inschatten hoeveel kracht hij nodig heeft a.d.h.v. het gewicht van de persoon',
		'Persoon mag niet meer dan 80 kg wegen',
		'https://www.youtube.com/watch?v=J3edDaPSdY4',
		1,
		1,
		CONVERT(date, GETDATE(),113)
	)
	SELECT * FROM PRODS
