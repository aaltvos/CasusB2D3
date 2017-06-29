Delete USERs
DBCC CHECKIDENT('Ergo.dbo.USERs', RESEED, 0)

--Security level: 4   Beheerder / supervisor
Insert USERs
	(
		Ergo.dbo.USER_Name,
		USER_PW,
		USER_Sec,
		USER_Val_dat,
		USER_Made_Work,
		USER_email
	)
	VALUES
	(
		'Beheerder',
		'Beheerder12',
		4,
		DATEADD(day,500,CONVERT(date, GETDATE())),
		'1',
		''
	)

Insert USERs
	(
		Ergo.dbo.USER_Name,
		USER_PW,
		USER_Sec,
		USER_Val_dat,
		USER_Made_Work,
		USER_email
	)
	VALUES
	(
		'Henk',
		'Knabbel',
		4,
		DATEADD(day,500,CONVERT(date, GETDATE())),
		'1',
		''
	)

--Security level: 3    Student
Insert USERs
	(
		Ergo.dbo.USER_Name,
		USER_PW,
		USER_Sec,
		USER_Val_dat,
		USER_Made_Work,
		USER_email
	)
	VALUES
	(
		'Student',
		'Student12',
		3,
		DATEADD(day,500,CONVERT(date, GETDATE())),
		'1',
		''
	)

--Security level: 2   leverancier / ergotherapeuten / externen
Insert USERs
	(
		Ergo.dbo.USER_Name,
		USER_PW,
		USER_Sec,
		USER_Val_dat,
		USER_Made_Work,
		USER_email
	)
	VALUES
	(
		'Peter',
		'Henk12',
		2,
		DATEADD(day,500,CONVERT(date, GETDATE())),
		'1',
		''
	)

--Security level: 1
Insert USERs
	(
		Ergo.dbo.USER_Name,
		USER_PW,
		USER_Sec,
		USER_Val_dat,
		USER_Made_Work,
		USER_email
	)
	VALUES
	(
		'Sjors',
		'Sjors12',
		1,
		DATEADD(day,500,CONVERT(date, GETDATE())),
		'1',
		''
	)

Select * from USERs
		