USE [StockMarketData]
GO
/****** Object:  StoredProcedure [dbo].[AdminGoster]    Script Date: 16.05.2021 15:32:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Procedure [dbo].[AdminGoster]
as 
Select ui.UserID,ui.ItemID ,ui.ItemAmount,ui.ItemPrice,ui.ItemAccept from Tbl_UserItems ui 
Where ui.ItemAccept=0
