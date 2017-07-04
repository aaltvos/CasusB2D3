Insert USERs
	(
		Ergo.dbo.USER_Name,
		USER_PW,
		USER_Sec,
		USER_Val_dat,
		USER_Made_Work,
		USER_Email
		
	)
	VALUES
	(
		'Henk',
		'Knabbel',
		3,
		DATEADD(day,500,CONVERT(date, GETDATE())),
		'1',
		'example@example.com'
	)
