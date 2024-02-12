<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Zseb Szörnyek</title>
    <link rel="stylesheet" href="style.css">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
</head>
<body>
    <<div class="container mt-4">
        <h1 class="mb-4">Zseb Szörnyek</h1>
        
        <div class="form-group">
            <label for="pokemonType">Select Pokémon Type:</label>
            <select class="form-control" id="pokemonType">
                <option value="all">All Types</option>
                <option value="grass">Grass</option>
                <option value="fire">Fire</option>
                <option value="water">Water</option>
                <option value="bug">Bug</option>
                <option value="poison">Poison</option>
                <option value="normal">Normal</option>
                <option value="flying">Flying</option>
                <option value="electric">Electric</option>
            </select>
        </div>

        <div class="form-group">
            <label for="pokemonName">Search Pokémon:</label>
            <input type="text" class="form-control" id="pokemonName" placeholder="Enter Pokémon Name">
        </div>

        <div id="pokemonCards" class="row">
        </div>
    </div>


    <script>
    const pokemonData = [
        { name: 'Bulbasaur', types: ['Grass', 'Poison'] },
        { name: 'Charmander', types: ['Fire'] },
        { name: 'Squirtle', types: ['Water'] },
        { name: 'Caterpie', types: ['Bug'] },
        { name: 'Weedle', types: ['Bug', 'Poison'] },
        { name: 'Pidgey', types: ['Normal', 'Flying'] },
        { name: 'Pikachu', types: ['Electric'] },
        { name: 'Muk', types: ['Poison'] },
        { name: 'Paras', types: ['Grass', 'Bug'] }
    ];

    updatePokemonCards();

    function updatePokemonCards() {
        const typeFilter = document.getElementById('pokemonType').value.toLowerCase();
        const nameFilter = document.getElementById('pokemonName').value.toLowerCase();

        const filteredPokemon = pokemonData.filter(pokemon => {
            const matchesType = typeFilter === 'all' || pokemon.types.some(type => type.toLowerCase() === typeFilter);
            const matchesName = nameFilter === '' || pokemon.name.toLowerCase().includes(nameFilter);

            return matchesType && matchesName;
        });

        const pokemonCardsContainer = document.getElementById('pokemonCards');
        pokemonCardsContainer.innerHTML = '';

        filteredPokemon.forEach(pokemon => {
            const card = `
                <div class="col-md-4 mb-4">
                    <div class="card">
                        <img src="img/${pokemon.name.toLowerCase()}.webp" class="card-img-top" alt="${pokemon.name}">
                        <div class="card-body">
                            <h5 class="card-title">${pokemon.name}</h5>
                            <p class="card-text">Type: ${pokemon.types.join(', ')}</p>
                            <a href="https://www.google.com/search?q=${pokemon.name}" class="btn btn-primary" target="_blank">Search on Google</a>
                        </div>
                    </div>
                </div>
            `;
            pokemonCardsContainer.innerHTML += card;
        });
    }

    document.getElementById('pokemonType').addEventListener('change', function() {
        updatePokemonCards();
    });

    document.getElementById('pokemonName').addEventListener('input', function() {
        updatePokemonCards();
    });
</script>

    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.1/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
</body>
</html>
