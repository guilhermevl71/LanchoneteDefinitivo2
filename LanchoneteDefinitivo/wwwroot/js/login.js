document.querySelector("form").addEventListener("submit", async function (e) {

    // impede recarregar página
    e.preventDefault();

    const email = document.getElementById("email").value;
    const password = document.getElementById("password").value;

    const loginData = {
        email: email,
        password: password
    };

    try {

        // requisição para API
        const response = await fetch("https://localhost:7073/Auth/login", {
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify(loginData)
        });

        // se login falhar
        if (!response.ok) {
            alert("Email ou senha inválidos");
            return;
        }

        // pega resposta
        const data = await response.json();

        // salva token
        localStorage.setItem("token", data.token);

        alert("Login realizado com sucesso!");

        console.log(data.token);

        // redireciona
        window.location.href = "cardapio.html";

    } catch (error) {

        console.log(error);

        alert("Erro ao conectar com API");

    }

});