BEGIN TRANSACTION;
GO

CREATE TABLE [student] (
    [ID] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NOT NULL,
    [FatherName] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_student] PRIMARY KEY ([ID])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220614104957_Second', N'5.0.0');
GO

COMMIT;
GO

