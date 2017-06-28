CREATE DATABASE Ergo;

Delete EVENTs
DBCC CHECKIDENT('Ergo.dbo.EVENTs', RESEED, 0)

--Ergotherapie & Neurologie 
INSERT EVENTs
	(
		Event_Name,
		Event_Body,
		Event_Address,
		Event_Link,
		USERs_USER_Id
	)
	VALUES
	(
		'Ergotherapie & Neurologie',
		'Beste ergotherapeut, Patiënten met een neurologische aandoening leven vaak met (ernstige) lichamelijke en geestelijke beperkingen. De impact op het dagelijks leven is enorm. Op sociaal en sportief vlak, maar ook op het gebied van de loopbaan. Voor patiënten is de gang naar de neuroloog de eerste en belangrijkste stap. Maar zeker niet de enige. Een groot aantal patiënten heeft aanvullende behandeling nodig in de vorm van ergotherapie. Als leverancier van deze zorg is het van groot belang dat u nauwkeurig op de hoogte bent van de mogelijkheden en laatste ontwikkelingen binnen dit deel van uw vakgebied. Om hierin te voorzien organiseren wij op donderdag 22 juni 2017 een studiedag die geheel in het teken staat van ergotherapie bij neurologische aandoeningen. We geven inzicht in het beloop en de prognose van de diverse neurologische ziektebeelden en we zetten de belangrijkste aandachtspunten uit de verschillende Ergotherapeutische richtlijnen voor u op een rij. In de middag kunt u kiezen uit vier onderwerpen over de aanpak van zogenaamde restverschijnselen van neurologische aandoeningen. Zoals de patiënt met vermoeidheidsklachten, de patiënt met concentratie- en aandachtsproblemen of de patiënt met een bewegingsstoornis. Na deze (richtlijn) kennisupdate bent u weer helemaal bij op het gebied van Ergotherapie & Neurologie en nog beter in staat om maatwerk te leveren aan uw patiënten. U bent van harte welkom. Met vriendelijke groet, Steven Korteling, cursusmanager Mark Two Academy',
		'Postillion Hotel Utrecht Kosterijland 8 - Bunnik',
		'http://marktwo.nl/cursusaanbod/ergotherapie-neurologie',
		1
	)

--Zorgtotaal
INSERT EVENTs
	(
		Event_Name,
		Event_Body,
		Event_Address,
		Event_Link,
		USERs_USER_Id
	)
	VALUES
	(
		'Zorgtotaal',
		'Van 18 t/m 20 maart vindt Zorgtotaal plaats in de Jaarbeurs in Utrecht. Het grootste platform in de Benelux voor professionals werkzaam in de zorg. Hier vindt u een compleet aanbod van de nieuwste producten, technieken en diensten voor de intramurale- en de thuiszorg. Ook op het gebied van ergotherapie. Naast een groot exposantenaanbod, is er een uitgebreid inhoudelijk programma vol lezingen, demonstraties en simulaties. Het is bovendien dé plek om te netwerken en te leren hoe andere bedrijven en instellingen probleemoplossend te werk gaan. Zo kunt u bijvoorbeeld sessies bijwonen over hoe dementerende ouderen langer zelfstandig kunnen blijven wonen en wordt de kwaliteit van medische hulpmiddelen uitvoerig besproken.',
		'Jaarbeurs in Utrecht',
		'http://www.zorgtotaal.nl/nl-NL/Bezoeker.aspx',
		1
	)	

	--Ergotherapie & Mindfullness
INSERT EVENTs
	(
		Event_Name,
		Event_Body,
		Event_Address,
		Event_Link,
		USERs_USER_Id
	)
	VALUES
	(
		'Ergotherapie & Mindfullness',
		'Op donderdag 22 Juni om 09:30 tot 11:00 wordt er een evenement gehouden voor ergotherapeuten, hier wordt de focus gelegd op zowel de stoornis van de cliënt als op het lijden dat deze stoornis met zich meebrengt (bijvoorbeeld stress door een depressie). Daarom kan mindfulness een ideaal programma zijn om te integreren binnen de ergotherapeutische behandeling, omdat het leert om in het hier en nu te leven.',
		'Orteliuslaan 750 Utrecht',
		'https://ergotherapie.nl/agendabericht/ergotherapie-mindfullness/',
		1
	)	