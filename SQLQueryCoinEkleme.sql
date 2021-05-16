USE [StockMarketData]
GO
/****** Object:  StoredProcedure [dbo].[ItemEkleme]    Script Date: 16.05.2021 15:33:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[ItemEkleme] @UserID varchar(50),@ItemID int ,@ItemAmount int ,@ItemPrice decimal
as
if exists(select UserID from Tbl_UserItems Where UserID=@UserID and ItemID=@ItemID and ItemPrice=@ItemPrice and ItemAccept=0) 
begin 
update Tbl_UserItems set ItemAmount+=@ItemAmount
end
else
begin
insert into Tbl_UserItems(UserID,ItemID,ItemAmount,ItemPrice,ItemAccept) values(@UserID,@ItemID,@ItemAmount,@ItemPrice,0)
end
