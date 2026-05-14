const api = "https://localhost:7073/Lanchonete";

const token = localStorage.getItem("token");

async function carregarProdutos() {

    const response = await fetch(api);

    const data = await response.json();

    const divProdutos = document.getElementById("produtos");

    divProdutos.innerHTML = "";

    for (const categoria in data) {

        data[categoria].forEach(produto => {

            divProdutos.innerHTML += `

                <div class="border rounded p-3 mb-3">

                    <h5>${produto.nome}</h5>

                    <p>${produto.tipo}</p>

                    <p>R$ ${produto.preco}</p>

                    <button 
                        class="btn btn-danger"
                        onclick="deletarProduto(${produto.id})"
                    >
                        Deletar
                    </button>

                </div>
            `;
        });
    }
}

carregarProdutos();

async function criarProduto() {

    const produto = {

        nome: document.getElementById("nome").value,

        tipo: document.getElementById("tipo").value,

        preco: parseFloat(document.getElementById("preco").value)
    };

    const response = await fetch(`${api}/produto`, {

        method: "POST",

        headers: {
            "Content-Type": "application/json",
            "Authorization": `Bearer ${token}`
        },

        body: JSON.stringify(produto)
    });

    if (!response.ok) {

        alert("Erro ao criar produto");
        return;

    }

    alert("Produto criado!");

    carregarProdutos();
}

async function deletarProduto(id) {

    const response = await fetch(`${api}/${id}`, {

        method: "DELETE",

        headers: {
            "Authorization": `Bearer ${token}`
        }

    });

    if (!response.ok) {

        alert("Erro ao deletar");
        return;

    }

    alert("Produto deletado!");

    carregarProdutos();
}