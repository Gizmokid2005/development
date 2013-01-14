-- =============================================
-- Author:		Michael Secord
-- Create date: 8/8/2012
-- Description:	Just some fun!
-- =============================================

BEGIN TRAN

declare @Part1 int = floor(6 * RAND(convert(varbinary, newid())))
declare @Part2 int = floor(6 * RAND(convert(varbinary, newid())))
declare @Part3 int = floor(6 * RAND(convert(varbinary, newid())))
declare @Part4 int = floor(6 * RAND(convert(varbinary, newid())))
select case @Part1 when 0 then 'The llama ' when 1 then 'All of earth ' when 2 then 'This one guy '
                   when 3 then 'Emperor Edwardo ' when 4 then 'A previous tech''s ghost ' when 5 then 'Nobody ' end       
     + case @Part2 when 0 then 'humbly requests that ' when 1 then 'demands that ' when 2 then 'was thinking about if '
                   when 3 then 'often fantisizes that ' when 4 then 'tells people ' when 5 then 'has nightmares where ' end  
     + case @Part3 when 0 then 'you drink ' when 1 then 'gnomes wear ' when 2 then 'support staff calls '
                   when 3 then 'Elvis returns to sing about ' when 4 then 'the secret to happiness is ' when 5 then 'no one loves ' end  
     + case @Part4 when 0 then 'hats.' when 1 then 'banana peels.' when 2 then 'canadian money.'
                   when 3 then 'sasquatch fur.' when 4 then 'spooky stories.' when 5 then 'retro video games.' end  


ROLLBACK TRAN