USE [tp2_net]
GO
SET IDENTITY_INSERT [dbo].[personas] ON 

INSERT [dbo].[personas] ([id_persona], [nombre], [apellido], [direccion], [email], [telefono], [fecha_nac], [legajo], [tipo_persona], [id_plan]) VALUES (2, N'a', N'a', N'p jerman wallavy 42 sidney', N'a@a.com.ar', N'08812345', CAST(N'1810-06-01T00:00:00.000' AS DateTime), 1111, 1, 1)
INSERT [dbo].[personas] ([id_persona], [nombre], [apellido], [direccion], [email], [telefono], [fecha_nac], [legajo], [tipo_persona], [id_plan]) VALUES (3, N'Raton', N'Rodriguez', N'la cueva del otoño 123', N'rperez@gmail.com', N'0800raton', CAST(N'1815-04-04T00:00:00.000' AS DateTime), 1112, 1, 2)
INSERT [dbo].[personas] ([id_persona], [nombre], [apellido], [direccion], [email], [telefono], [fecha_nac], [legajo], [tipo_persona], [id_plan]) VALUES (4, N'Ragnar', N'Lodbrok', N'el valala', N'rlodbrok@gmail.com', N'0900hacha', CAST(N'1753-05-02T00:00:00.000' AS DateTime), 1113, 1, 3)
INSERT [dbo].[personas] ([id_persona], [nombre], [apellido], [direccion], [email], [telefono], [fecha_nac], [legajo], [tipo_persona], [id_plan]) VALUES (6, N'Darth', N'Vader', N'espacio intergalactico', N'dvader@gmail.com', N'0700space', CAST(N'2000-08-09T00:00:00.000' AS DateTime), 1114, 1, 1)
INSERT [dbo].[personas] ([id_persona], [nombre], [apellido], [direccion], [email], [telefono], [fecha_nac], [legajo], [tipo_persona], [id_plan]) VALUES (7, N'Hermione', N'Granger', N'howarts 1', N'hgranger@gmail.com', N'0600magico', CAST(N'1900-08-01T00:00:00.000' AS DateTime), 1115, 1, 4)
INSERT [dbo].[personas] ([id_persona], [nombre], [apellido], [direccion], [email], [telefono], [fecha_nac], [legajo], [tipo_persona], [id_plan]) VALUES (8, N'Han', N'Solo', N'espacio interestelar 2', N'hsolo@gmail.com', N'0800starwars', CAST(N'1950-12-02T00:00:00.000' AS DateTime), 1116, 1, 5)
INSERT [dbo].[personas] ([id_persona], [nombre], [apellido], [direccion], [email], [telefono], [fecha_nac], [legajo], [tipo_persona], [id_plan]) VALUES (9, N'b', N'b', N'b', N'b@b.com.ar', N'0900bebe', CAST(N'1980-12-05T00:00:00.000' AS DateTime), 1117, 1, 6)
SET IDENTITY_INSERT [dbo].[personas] OFF
GO
SET IDENTITY_INSERT [dbo].[usuarios] ON 

INSERT [dbo].[usuarios] ([id_usuario], [nombre_usuario], [clave], [habilitado], [nombre], [apellido], [email], [cambia_clave], [id_persona]) VALUES (1, N'a', N'a', 1, N'a', N'a', N'a@a.com.ar', NULL, 2)
INSERT [dbo].[usuarios] ([id_usuario], [nombre_usuario], [clave], [habilitado], [nombre], [apellido], [email], [cambia_clave], [id_persona]) VALUES (2, N'rperez', N'12345678', 1, N'Raton', N'Rodriguez', N'rperez@gmail.com', NULL, 3)
INSERT [dbo].[usuarios] ([id_usuario], [nombre_usuario], [clave], [habilitado], [nombre], [apellido], [email], [cambia_clave], [id_persona]) VALUES (3, N'rlodbrok', N'12345678', 1, N'Ragnar', N'Lodbrok', N'rlodbrok@gmail.com', NULL, 4)
INSERT [dbo].[usuarios] ([id_usuario], [nombre_usuario], [clave], [habilitado], [nombre], [apellido], [email], [cambia_clave], [id_persona]) VALUES (5, N'dvader', N'12345678', 1, N'Darth', N'Vader', N'dvader@gmail.com', NULL, 6)
INSERT [dbo].[usuarios] ([id_usuario], [nombre_usuario], [clave], [habilitado], [nombre], [apellido], [email], [cambia_clave], [id_persona]) VALUES (6, N'hgranger', N'12345678', 1, N'Hermione', N'Granger', N'hgranger@gmail.com', NULL, 7)
INSERT [dbo].[usuarios] ([id_usuario], [nombre_usuario], [clave], [habilitado], [nombre], [apellido], [email], [cambia_clave], [id_persona]) VALUES (7, N'hsolo', N'12345678', 1, N'Han', N'Solo', N'hsolo@gmail.com', NULL, 8)
INSERT [dbo].[usuarios] ([id_usuario], [nombre_usuario], [clave], [habilitado], [nombre], [apellido], [email], [cambia_clave], [id_persona]) VALUES (8, N'b', N'b', 1, N'b', N'b', N'b@b.com.ar', NULL, 9)
SET IDENTITY_INSERT [dbo].[usuarios] OFF
GO
