-- =============================================
-- Author:		Michael Secord
-- Create date: 05/11/2012
-- Description:	A simple script to test DB mail functionality.
-- =============================================
USE msdb
GO

DECLARE @count INT
SET @count = 1
--WHILE (@count < 16350) --Haha, spamming could ensue...
WHILE (@count < 10)
BEGIN

EXEC sp_send_dbmail @profile_name='eoStar', --Enter your profile name here
@recipients='msecord@eostar.com',
@subject='Muahahahah!',
@body='This is the body of the test message.
Congrats Database Mail has been successfully configured!!' 

SET @count = (@count + 1)	

END