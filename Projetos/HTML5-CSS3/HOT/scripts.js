// Dados das posições do Kamasutra
const positions = [
    { title: "Bailarina agachada", image: "images/bailarina.jpg" },
    { title: "Beijo do súdito", image: "images/beijo-sudito.jpg" , category: "oral" },
    { title: "Dança das borboletas", image: "images/danca-borboleta.jpg" },
    { title: "A Dominadora", image: "images/dominadora.jpg" },
    { title: "Dominando o Garanhão", image: "images/dominando.jpg" },
    { title: "Flexão Invertida", image: "images/flexao.webp" },
    { title: "Gangorra", image: "images/gangorra.webp" },
    { title: "Garanhão profundo", image: "images/garanhao.webp" },
    { title: "Mergulhador", image: "images/mergulhador.webp" },
    { title: "Moisés Abre o Mar Vermelho", image: "images/moises.webp" },
    { title: "Pouso Forçado", image: "images/pouso-forcado.webp" },
    { title: "Aos Pés da Rainha", image: "images/rainha.webp" },
    { title: "Tesoura Aberta", image: "images/tesoura-aberta.webp" },
    { title: "Trono da princesa", image: "images/trono-princesa.webp" },
    { title: "69", image: "images/69.webp", category: "oral"  },
    { title: "De Ladinho", image: "images/ladinho.webp" },
    { title: "Cachorrinho", image: "images/cachorrinho.jpg" },
    { title: "Cachorrinho", image: "images/cachorrinho.webp" },
    { title: "Encaixada", image: "images/encaixada.webp" },
    { title: "Sonho Erótico", image: "images/sonho.webp" },
    { title: "Chupada Profunda", image: "images/23.jpg" , category: "oral" },
    { title: "Glória do Dominador", image: "images/gloria-dominador.jpg" },
    { title: "Cavalgada de Costas", image: "images/cavalga-costas.jpg" },
    { title: "Encaixada Sentada", image: "images/encaixada-sentada.jpg" },
    { title: "Nó dos Amantes", image: "images/no-amantes.jpg" },
    { title: "Pirâmide do Faraó", image: "images/piramide.jpg" },
    { title: "Encantadora de Serpentes", image: "images/encantador-seperntes.png", category: "oral"  },
    { title: "Beba na Fonte", image: "images/fonte.png", category: "oral" },    
    { title: "Para Engolir", image: "images/para-engolir.png", category: "oral" },
    { title: "Encanador", image: "images/encanador.png", category: "oral"  },
    { title: "69", image: "images/69-2.png", category: "oral"  },
    { title: "Zeus", image: "images/zeus.png", category: "oral"  },
    { title: "Mestre Lambedor", image: "images/mestre-lambedor.png", category: "oral"  },
    { title: "Toda Aberta", image: "images/toda-aberta.png", category: "oral"  },
    { title: "Docinho", image: "images/doce.png", category: "oral"  },
    { title: "Barbie", image: "images/barbie.png", category: "oral"  },
    { title: "Com Fome", image: "images/comfome.png" , category: "oral" },
    { title: "Completo", image: "images/completo.png", category: "oral"  },
    { title: "Virada", image: "images/virada.png" },
    { title: "CowGirl", image: "images/cowgirl.png" },
    { title: "Titanic", image: "images/titanic.png" },
    { title: "Full", image: "images/full.png" },
    { title: "Oásis", image: "images/oasis.png" },
    { title: "Zodiáco", image: "images/zodiaco.png" },
    { title: "Queda", image: "images/queda.png" },
];


// Referência aos elementos HTML
const imageElement = document.getElementById('position-image');
const titleElement = document.getElementById('position-title');
const randomizeButton = document.getElementById('randomize-button');
const includeCheckboxes = document.querySelectorAll('.include-checkbox');
const excludeCheckboxes = document.querySelectorAll('.exclude-checkbox');

// Função para sortear uma posição aleatória com base nos filtros
function randomizePosition() {
    // Obter categorias de inclusão e exclusão
    const includedCategories = Array.from(includeCheckboxes)
        .filter(checkbox => checkbox.checked)
        .map(checkbox => checkbox.value);

    const excludedCategories = Array.from(excludeCheckboxes)
        .filter(checkbox => checkbox.checked)
        .map(checkbox => checkbox.value);

    // Filtrar as posições
    let filteredPositions = positions;

    // Aplicar filtro de inclusão (se houver)
    if (includedCategories.length > 0) {
        filteredPositions = filteredPositions.filter(position =>
            includedCategories.includes(position.category)
        );
    }

    // Aplicar filtro de exclusão
    if (excludedCategories.length > 0) {
        filteredPositions = filteredPositions.filter(position =>
            !excludedCategories.includes(position.category)
        );
    }

    // Caso nenhuma posição reste, exibir alerta
    if (filteredPositions.length === 0) {
        alert('Nenhuma posição disponível para os filtros selecionados.');
        return;
    }

    // Sortear uma posição aleatória do conjunto filtrado
    const randomIndex = Math.floor(Math.random() * filteredPositions.length);
    const selectedPosition = filteredPositions[randomIndex];

    // Atualizar a imagem e o título
    imageElement.src = selectedPosition.image;
    imageElement.alt = selectedPosition.title;
    titleElement.textContent = selectedPosition.title;
}

// Configurar a imagem inicial
function setInitialImage() {
    imageElement.src = "images/inicio.webp"; // Caminho da imagem inicial
    imageElement.alt = "Bem-vindo ao Kamasutra";
    titleElement.textContent = "Bem-vindo! Clique para sortear uma posição.";
}

// Inicializar a página com a imagem padrão
setInitialImage();

// Adicionar evento ao botão "Sortear Posição"
randomizeButton.addEventListener('click', randomizePosition);