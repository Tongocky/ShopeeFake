/* cập nhật hàng trong kho sau khi đặt hàng hoặc cập nhật */
CREATE TRIGGER trg_Oreder ON dbo.OrderDetail  AFTER INSERT AS 
BEGIN
	UPDATE  dbo.Product 
	SET Product.Quantity = Product.Quantity - (
		SELECT inserted.Quantity
		FROM inserted
		WHERE ProductId = dbo.Product.ProductId
	), Product.Sold = inserted.Quantity
	FROM dbo.Product
	JOIN inserted ON dbo.Product.ProductId = inserted.ProductId
END

/* cập nhật hàng trong kho sau khi cập nhật đặt hàng */
CREATE TRIGGER trg_UpdateOrder on dbo.OrderDetail after update AS
BEGIN
   UPDATE dbo.Product SET Product.Quantity = Product.Quantity -
	   (SELECT inserted.Quantity FROM inserted WHERE inserted.ProductId = dbo.Product.ProductId) +
	   (SELECT deleted.Quantity FROM deleted WHERE deleted.ProductId = dbo.Product.ProductId)
   FROM dbo.Product 
   JOIN deleted ON dbo.Product.ProductId = deleted.ProductId
end


/* cập nhật hàng trong kho sau khi hủy đặt hàng */
create TRIGGER trg_RemoveOreder ON dbo.OrderDetail FOR DELETE AS 
BEGIN
	UPDATE dbo.Product
	SET Product.Quantity = Product.Quantity + (SELECT deleted.Quantity FROM deleted WHERE deleted.ProductId = Product.ProductId)
	FROM dbo.Product 
	JOIN deleted ON Product.ProductId = deleted.ProductId
END
