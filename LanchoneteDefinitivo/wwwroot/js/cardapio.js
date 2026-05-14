const cardapioDiv = document.getElementById("cardapio");

async function carregarCardapio() {

    try {

        const response = await fetch("https://localhost:7073/Lanchonete");

        const data = await response.json();

        console.log(data);

        // percorre categorias
        for (const categoria in data) {

            // título categoria
            cardapioDiv.innerHTML += `
                <h2 class="mt-5">${categoria}</h2>
            `;

            // percorre produtos
            data[categoria].forEach(produto => {

                cardapioDiv.innerHTML += `
                    <div class="col-md-4">

                        <div class="card shadow-sm h-100">

                            <div class="card-body">

                                <h5 class="card-title">
                                    ${produto.nome}
                                </h5>

                                <p class="card-text">
                                    Tipo: ${produto.tipo}
                                </p>

                                <p class="fw-bold">
                                    R$ ${produto.preco}
                                </p>

                                <button 
                                    class="btn btn-primary"
                                    onclick="adicionarCarrinho(${produto.id})"
                                >
                                    Adicionar
                                </button>

                            </div>

                        </div>

                    </div>
                `;
            });
        }

    } catch (error) {

        console.log(error);

        alert("Erro ao carregar cardápio");

    }

}

carregarCardapio();

async function adicionarCarrinho(produtoId) {

    const token = localStorage.getItem("token");

    if (!token) {

        alert("Você precisa estar logado");
        return;

    }

    const carrinho = {
        produtoId: produtoId,
        pedidoId: 1,
        quantidade: 1
    };

    try {

        const response = await fetch("https://localhost:7073/Lanchonete/carrinho", {

            method: "POST",

            headers: {
                "Content-Type": "application/json",
                "Authorization": `Bearer ${token}`
            },

            body: JSON.stringify(carrinho)

        });

        if (!response.ok) {

            alert("Erro ao adicionar no carrinho");
            return;

        }

        alert("Produto adicionado!");

    } catch (error) {

        console.log(error);

    }

}