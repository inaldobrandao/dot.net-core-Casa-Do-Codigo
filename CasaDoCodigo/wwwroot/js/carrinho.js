class Carrinho {
    clickIncremento(btn) {
        var data = this.getData(btn);
        data.Quantidade++;
        this.postQuantidade(data);
    }

    clickDecremento(btn) {
        var data = this.getData(btn);
        data.Quantidade--;
        this.postQuantidade(data);
    }

    updateQuantidade(input) {
        var data = this.getData(input);
        this.postQuantidade(data);
    }

    getData(elemento) {
        var linhaDoItem = $(elemento).parents('[item-id]');
        var itemId = linhaDoItem.attr('item-id');
        var quantidade = linhaDoItem.find('input').val();

        return {
            Id: itemId,
            Quantidade: quantidade
        }

    }

    postQuantidade(data) {

        var token = $('input[name=__RequestVerificationToken]').val();
        var header = {};
        header['RequestVerificationToken'] = token;
        $.ajax({
            url: '/Pedido/PostQuantidade',
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(data),
            headers: header
        }).done(function (response) {
            this.setQuantidade(response.itemPedido);
            this.setSubtotal(response.itemPedido);
            this.setTotal(response.carrinhoViewModel);
            this.setNumeroItens(response.carrinhoViewModel);
            if (response.itemPedido.quantidade == 0)
                this.removeItem(response.itemPedido);
        }.bind(this));
    }

    setQuantidade(itemPedido) {
        this.getLinhaDoItem(itemPedido).find('input').val(itemPedido.quantidade);
    }

    getLinhaDoItem(itemPedido) {
        return $('[item-id=' + itemPedido.id + ']');
    }

    setSubtotal(itemPedido) {
        this.getLinhaDoItem(itemPedido).find('[subtotal]').html(itemPedido.subtotal.duasCasas());
    }

    setTotal(carrinhoViewModel) {
        $('[total]').html(carrinhoViewModel.total.duasCasas());
    }

    removeItem(itemPedido) {
        this.getLinhaDoItem(itemPedido).remove();
    }

    setNumeroItens(carrinhoViewModel) {
        var texto = 'Total: ' + carrinhoViewModel.itens.length + (carrinhoViewModel.itens.length > 1 ? ' itens' : 'item');
        $('[numero-itens]').html(texto);
    }
}

var carrinho = new Carrinho();

Number.prototype.duasCasas = function () {
    return this.toFixed(2).replace('.', ',');
}