DELETE HAND_GEB
DBCC CHECKIDENT('Ergo.dbo.HAND_GEB', RESEED, 0)

--ADL
INSERT HAND_GEB
(
	Hand_Name,
	Hand_IMG
)

Values
(
	'ADL',
	'content/images/ADL.png'
)

--HDL
INSERT HAND_GEB
(
	Hand_Name,
	Hand_IMG
)

Values
(
	'HDL',
	'content/images/HDL.png'
)

--Wonen
INSERT HAND_GEB
(
	Hand_Name,
	Hand_IMG
)

Values
(
	'Wonen',
	'content/images/wonen.png'
)

--Mobiliteit
INSERT HAND_GEB
(
	Hand_Name,
	Hand_IMG
)

Values
(
	'Mobiliteit',
	'content/images/mobiliteit.png'
)

--Communicatie
INSERT HAND_GEB
(
	Hand_Name,
	Hand_IMG
)

Values
(
	'Communicatie',
	'content/images/communicatie.png'
)

--Vrije tijd en ontspanning
INSERT HAND_GEB
(
	Hand_Name,
	Hand_IMG
)

Values
(
	'Vrije tijd en Onstapnning',
	'content/images/vrijetijdenontspanning.png'
)

--Plannen en organiseren
INSERT HAND_GEB
(
	Hand_Name,
	Hand_IMG
)

Values
(
	'Plannen en Organiseren',
	'content/images/plannenenorganiseren.png'
)
