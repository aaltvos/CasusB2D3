Select * from SUB_GEB
Where Sub_ID in 
	(Select SUB_GEB_Sub_ID from HAND_SUB_GEB_PROD
	 Where HAND_GEB_Hand_ID = 0)

select * from HAND_SUB_GEB_PROD

select * from PRODs

Select * from PRODs

where Prod_ID in 
   (select PROD_Prod_ID from HAND_SUB_GEB_PROD
   where SUB_GEB_Sub_ID = 0)
