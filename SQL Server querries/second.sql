BEGIN TRY
	BEGIN TRANSACTION
		UPDATE Users
		SET Roles = 1
		WHERE FirstName LIKE 'D%'
		
		UPDATE Products
		SET Quantity = Quantity + 10
		WHERE Tags LIKE '%Cards%'
		
		UPDATE Orders
		SET UserId = 1,
			States = 2
		WHERE ShippingAdress = 'Staudgasse 59'
		
		DELETE FROM OrderItems
		WHERE ID = 7

		DELETE FROM Orders
		WHERE Price < 100
	COMMIT TRANSACTION
END TRY

BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH

	