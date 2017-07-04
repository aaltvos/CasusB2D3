USE Ergo;
SELECT * FROM dbo.PRODs WHERE Prod_Validator = 0
UPDATE dbo.PRODs SET Prod_Val_Dat = DATEADD(DAY,1,26) WHERE Prod_Validator = 0

SELECT * FROM dbo.PRODs