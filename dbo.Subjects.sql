CREATE TABLE [dbo].[Subjects] (
    [SubjectID] INT           IDENTITY (1, 1) NOT NULL,
    [Group]     VARCHAR (30)  NULL,
    [Name]      VARCHAR (30)  NULL,
    [Link]      VARCHAR (500) NULL,
    [Lesson]    VARCHAR (20)  NULL,
    [GroupID]   VARCHAR (20)  NULL,
    [NameID]    VARCHAR (20)  NULL,
    CONSTRAINT [PK_Subjects] PRIMARY KEY CLUSTERED ([SubjectID] ASC)
);

