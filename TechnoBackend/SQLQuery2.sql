Select * from SUB_GEB
Where Sub_ID in 
	(Select SUB_GEB_Sub_ID from HAND_SUB_GEB_PROD
	 Where HAND_GEB_Hand_ID = 0)

