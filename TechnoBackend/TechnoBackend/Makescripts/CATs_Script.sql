DELETE CATs
DBCC CHECKIDENT('Ergo.dbo.CATs', RESEED, 0)

--Domotica
INSERT CATs
(
	CAT_Name,
	CAT_IMG
)	

VALUES
(
	'Domotica',
	'content/images/domotica.png'
)

--Servicerobots
INSERT CATs
(
	CAT_Name,
	CAT_IMG
)	

VALUES
(
	'Servicerobots',
	'content/images/servicerobots.png'
)
--Huishoudrobots
INSERT CATs
(
	CAT_Name,
	CAT_IMG
)	

VALUES
(
	'Huishoudrobots',
	'content/images/Huishoudrobots.png'
)
--Socialerobots
INSERT CATs
(
	CAT_Name,
	CAT_IMG
)	

VALUES
(
	'Socialerobots',
	'content/images/Socialerobots.png'
)
--Wearables
INSERT CATs
(
	CAT_Name,
	CAT_IMG
)	

VALUES
(
	'Wearables',
	'content/images/wearables.png'
)
--Apps en Software
INSERT CATs
(
	CAT_Name,
	CAT_IMG
)	

VALUES
(
	'Apps en Software',
	'content/images/Appsensoftware.png'
)
--Zorg op afstand en eHealth
INSERT CATs
(
	CAT_Name,
	CAT_IMG
)	

VALUES
(
	'Zorg op afstand en eHealth',
	'content/images/zorgopafstandeneHealth.png'
)