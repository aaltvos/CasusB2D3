Insert USERs
	(
		USER_ID,
		USER_Name,
		USER_PW,
		USER_Sec,
		USER_Val_dat
	)
	VALUES
	(
		1,
		'Kay',
		'lol',
		4,
		DATEADD(day,500,CONVERT(date, GETDATE()))
	)