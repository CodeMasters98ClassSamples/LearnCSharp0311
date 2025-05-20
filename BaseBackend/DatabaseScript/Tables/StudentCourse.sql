CREATE TABLE [dbo].StudentCourse
(
	[Id]			INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[CourseId]		INT NOT NULL,
	[StudentId]		INT NOT NULL,
	[CurrentAmount]	DECIMAL(18,2) NOT NULL,
	CreatedAt		DATETIME DEFAULT GETDATE(),
	IsDeleted		BIT NOT NULL DEFAULT 0,
	DeletedAt		DATETIME,
	DeletedByUserId	INT
)
