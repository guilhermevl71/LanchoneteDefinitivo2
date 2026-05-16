const carrinhoDiv = document.getElementById("carrinho");

async function carregarCarrinho() {

    const token = localStorage.getItem("token");

    if (!token) {

        alert("Você precisa estar logado");

        window.location.href = "login.html";

        return;
    }

    try {

        const response = await fetch("https://localhost:7073/Lanchonete/MostrarCarrinho", {

            headers: {
                "Authorization": `Bearer ${token}`
            }

        });

        if (response.status == 404) {

                carrinhoDiv.innerHTML = `
            <h3 class="text-center">
                Carrinho vazio
            </h3>
           `;

            return;
        }

        if (!response.ok) {

            const erro = await response.text();

            console.log(erro);

            alert("Erro ao carregar carrinho");

            return;
        }

        const itens = await response.json();

        carrinhoDiv.innerHTML = "";

        let total = 0;

        itens.forEach(item => {

            const subtotal = item.precoUnitario * item.quantidade;

            total += subtotal;

            carrinhoDiv.innerHTML += `

                <div class="col-md-4">

                    <div class="card shadow-sm h-100">

                        <div class="card-body">

                            <h5 class="card-title">
                                Produto ID: ${item.produtoId}
                            </h5>

                            <p>
                                Quantidade: ${item.quantidade}
                            </p>

                            <p>
                                Preço unitário: R$ ${item.precoUnitario}
                            </p>

                            <p class="fw-bold">
                                Subtotal: R$ ${subtotal}
                            </p>

                        </div>

                    </div>

                </div>
            `;
        });

        carrinhoDiv.innerHTML += `

            <div class="col-12">

                <div class="alert alert-success text-center">

                    <h4>
                        Total: R$ ${total}
                    </h4>

                </div>

            </div>
        `;

    } catch (error) {

        console.log(error);

        alert("Erro ao carregar carrinho");

    }
}

carregarCarrinho();