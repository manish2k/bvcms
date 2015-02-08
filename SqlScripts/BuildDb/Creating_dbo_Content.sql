CREATE TABLE [dbo].[Content]
(
[Name] [nvarchar] (400) NOT NULL,
[Title] [nvarchar] (500) NULL,
[Body] [nvarchar] (max) NULL,
[DateCreated] [datetime] NULL,
[Id] [int] NOT NULL IDENTITY(1, 1),
[TextOnly] [bit] NULL,
[TypeID] [int] NOT NULL CONSTRAINT [DF_Content_Type] DEFAULT ((0)),
[ThumbID] [int] NOT NULL CONSTRAINT [DF_Content_ThumbID] DEFAULT ((0)),
[RoleID] [int] NOT NULL CONSTRAINT [DF_Content_RoleID] DEFAULT ((0)),
[OwnerID] [int] NOT NULL CONSTRAINT [DF_Content_OwnerID] DEFAULT ((0)),
[CreatedBy] [nvarchar] (50) NULL,
[Archived] [datetime] NULL,
[ArchivedFromId] [int] NULL,
[UseTimes] [int] NULL,
[Snippet] [bit] NULL
)
GO
IF @@ERROR<>0 AND @@TRANCOUNT>0 ROLLBACK TRANSACTION
GO
IF @@TRANCOUNT=0 BEGIN INSERT INTO #tmpErrors (Error) SELECT 1 BEGIN TRANSACTION END
GO
