/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [matricula]
      ,[propietario]
      ,[fecha_ingreso]
      ,[DPI]
      ,[telefono]
      ,[colorAuto]
  FROM [DBPARQUEO].[dbo].[Tb_Propietario]
  delete from Tb_Propietario
  select *from Tb_Propietario