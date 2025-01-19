document.getElementById('addPeso').addEventListener('click', () => {
    const container = document.getElementById('pesosDisponiveis');
    const div = document.createElement('div');
    div.className = 'input-group';
    div.innerHTML = `
        <label>Peso (ex: 15.9):</label>
        <input type="number" step="0.1" class="pesoInput">
        <label>Quantidade de Pares:</label>
        <input type="number" min="0" class="quantidadeInput">
        <label>
            <input type="checkbox" class="unidadeInput"> LB?
        </label>
    `;
    container.appendChild(div);
});

document.getElementById('montadorForm').addEventListener('submit', (e) => {
    e.preventDefault(); // Impede o envio do formulário padrão

    // Captura as entradas
    const considerarBarra = document.querySelector('input[name="considerarBarra"]:checked').value === 'sim';
    const pesoAlvo = parseFloat(document.getElementById('pesoAlvo').value);
    const pesos = Array.from(document.querySelectorAll('.input-group')).map(group => {
        const pesoInput = group.querySelector('.pesoInput');
        const quantidadeInput = group.querySelector('.quantidadeInput');
        const unidadeInput = group.querySelector('.unidadeInput');
        
        // Verifica se os campos existem e tem valor
        if (!pesoInput || !quantidadeInput) return null;

        const peso = parseFloat(pesoInput.value);
        const quantidade = parseInt(quantidadeInput.value);
        const isLB = unidadeInput ? unidadeInput.checked : false;

        return { peso: isLB ? peso * 0.453592 : peso, quantidade };
    }).filter(item => item !== null);  // Filtra entradas vazias

    // Adiciona o peso da barra
    let pesoInicial = considerarBarra ? 20 : 0;
    let restante = pesoAlvo - pesoInicial;

    // Ordena pesos em ordem decrescente
    pesos.sort((a, b) => b.peso - a.peso);

    // Calcula os pares usados
    let usado = [];
    for (let { peso, quantidade } of pesos) {
        let paresUsados = Math.min(Math.floor(restante / (2 * peso)), quantidade);
        if (paresUsados > 0) {
            usado.push({ peso, pares: paresUsados });
            restante -= paresUsados * 2 * peso;
        }
    }

    // Determina os valores mais próximos
    const resultado = document.getElementById('resultado');
    resultado.innerHTML = '';

    if (restante > 0) {
        resultado.innerHTML = `<p>Não foi possível atingir o peso exato.</p>`;
    }

    const totalUsado = pesoAlvo - restante;
    resultado.innerHTML += `<p>Peso total montado: ${totalUsado.toFixed(1)} kg</p>`;

    // Lista os pesos usados
    resultado.innerHTML += `<h3>Montagem:</h3><ul>`;
    usado.forEach(({ peso, pares }) => {
        resultado.innerHTML += `<li>${pares * 2} anilhas de ${peso.toFixed(1)} kg (${pares} por lado)</li>`;
    });
    resultado.innerHTML += `</ul>`;
});
