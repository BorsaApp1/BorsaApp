USE [StockMarketData]
GO
/****** Object:  StoredProcedure [dbo].[Satis]    Script Date: 16.05.2021 15:35:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Proc [dbo].[Satis] @ItemID int, @UserID varchar(50) ,@ItemAmount int
as
declare @TopAmount int
declare @TopPrice decimal
declare @SellerID varchar(50)

Set @SellerID=(Select Top 1 UserID From Tbl_UserItems Where ItemID=@ItemID order by ItemPrice)
Set @TopPrice=(Select Top 1 ItemPrice From Tbl_UserItems Where ItemID=@ItemID and UserID= @SellerID order by ItemPrice)
Set @TopAmount=(Select Top 1 ItemAmount From Tbl_UserItems Where ItemID=@ItemID and UserID=@SellerID order by ItemPrice )


if (@TopAmount>@ItemAmount)
begin		
	update Tbl_UserItems set ItemAmount-=@ItemAmount  Where UserID=@SellerID and ItemID=@ItemID and ItemAccept=1 and ItemPrice=@TopPrice
	update Tbl_Money set MoneyAmount-=@ItemAmount*@TopPrice Where UserID=@UserID and MoneyAccept=1

	if exists(Select * From Tbl_Money Where @SellerID=UserID)
	begin
    update Tbl_Money set MoneyAmount+=@TopPrice*@ItemAmount Where UserID=@SellerID and MoneyAccept=1
	end
	else
	begin
	insert into Tbl_Money(UserID,MoneyAmount,MoneyAccept) values (@SellerID,@TopPrice*@TopAmount,1)	
	end
end
else if(@TopAmount=@ItemAmount)
begin
	Delete Tbl_UserItems Where ItemPrice=@TopPrice and UserID=@SellerID and ItemID=@ItemID and ItemAccept=1 and ItemPrice=@TopPrice
	update Tbl_Money set MoneyAmount-=@ItemAmount*@TopPrice Where UserID=@UserID and MoneyAccept=1
	if exists(Select * From Tbl_Money Where @SellerID=UserID)
	begin
    update Tbl_Money set MoneyAmount+=@TopPrice*@ItemAmount Where UserID=@SellerID and MoneyAccept=1
	end
	else
	begin
	insert into Tbl_Money(UserID,MoneyAmount,MoneyAccept) values (@SellerID,@TopPrice*@TopAmount,1)	
	end
end
else if(@TopAmount<@ItemAmount)
begin
	Delete Tbl_UserItems Where ItemPrice=@TopPrice and UserID=@SellerID and ItemID=@ItemID and ItemAccept=1 and ItemPrice=@TopPrice
	update Tbl_Money set MoneyAmount-=@TopAmount*@TopPrice Where UserID=@UserID and MoneyAccept=1 
	if exists(Select * From Tbl_Money Where @SellerID=UserID)
	begin
    update Tbl_Money set MoneyAmount+=@TopPrice*@TopAmount Where UserID=@SellerID and MoneyAccept=1
	end
	else
	begin
	insert into Tbl_Money(UserID,MoneyAmount,MoneyAccept) values (@SellerID,@TopPrice*@TopAmount,1)	
	end
	Set @ItemAmount-=@TopAmount

if exists(Select * From Tbl_UserItems Where ItemID=@ItemID and ItemAccept=1)
begin
Execute Satis @ItemID ,@UserID ,@ItemAmount
end
end

