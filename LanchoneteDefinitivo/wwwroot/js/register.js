document.getElementById("registerForm")
    .addEventListener("submit", async function (e) {

        e.preventDefault();

        const userData = {

            name: document.getElementById("name").value,

            email: document.getElementById("email").value,

            password: document.getElementById("password").value,

            role: document.getElementById("role").value
        };

        try {

            const response = await fetch("https://localhost:7073/Auth/register", {

                method: "POST",

                headers: {
                    "Content-Type": "application/json"
                },

                body: JSON.stringify(userData)

            });

            if (!response.ok) {

                alert("Erro ao registrar");
                return;

            }

            alert("Usuário criado com sucesso!");

            window.location.href = "login.html";

        } catch (error) {

            console.log(error);

            alert("Erro ao conectar API");

        }

    });