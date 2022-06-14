BEGIN TRANSACTION;
GO

ALTER TABLE [student] ADD [Fee] nvarchar(max) NULL;
GO

ALTER TABLE [student] ADD [Gender] nvarchar(max) NOT NULL DEFAULT N'';
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220614105238_TFour', N'5.0.0');
GO

COMMIT;
GO

