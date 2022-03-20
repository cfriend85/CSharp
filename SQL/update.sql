USE DBNAME 
GO

DECLARE @ScriptName varchar(256),@DeveloperName varchar(256),@Success varchar(50)
SELECT @ScriptName='SDLC-JIRA# - Description'+'.sql',@DeveloperName='Charles Friend'
PRINT replace(@ScriptName,'.sql.sql','.sql')+' ('+@DeveloperName+') '+@@servername+'/'+upper(db_name())
    +' on '+convert(varchar(10), current_timestamp,112)
    ----===============================================================================================
    ----####################################Start Main Code ###########################################
Declare @old int, @new int
SELECT @old = ColumnNameID FROM TableName WHERE Name = 'Original name to be updated'
SELECT @new = ColumnNameID FROM TableName WHERE Name = 'Name to be updated to'

If Exists (Select 1 from TableName Where ColumnNameID = @old)
Begin
    Update TableName SET ColumnNameID = @new Where ColumnNameID = @old
End 
GO