<?php

class Pokemon
{
    private static $pokemons = [
        ["Bulbasaur",318,["grass","poison"]],
        ["Charmander",280, ["fire"]],
        ["Squirtle",270,["water"]],
        ["Caterpie",125,["bug"]],
        ["Weedle",130,["bug","poison"]],
        ["Pidgey",135,["normal","flying"]],
        ["Pikachu",142,["electric"]],
        ["Muk",120,["poison"]],
        ["Paras",118,["grass","bug"]]
    ];

    public static function getAllPokemon()
    {
        return self::$pokemons;
    }

    public static function getTypes()
    {
        $types = [];
        foreach (self::$pokemons as $pokemon) {
            foreach ($pokemon['types'] as $type) {
                if (!in_array($type, $types)) {
                    $types[] = $type;
                }
            }
        }
        return $types;
    }
}

$pokemons = Pokemon::getAllPokemon();

header('Content-Type: application/json');
echo json_encode(['types' => Pokemon::getTypes()]);
?>
