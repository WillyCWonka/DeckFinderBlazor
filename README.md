# DeckFinderBlazor

This Web app uses a Neo4j graph database to find Magic the gathering decks that contain two given cards.

Database Class: 
Creates a server side connection to the Neo4j database.
Queries using the input cards to get the decks.

DeckService Class:
Basically the middle man between the browser and the Database Class.

Neo4j Database:
I've put cards and decks as nodes, and the relationships are cards being in decks.
Using the Cypher language to write the queries it's pretty simple to find whatever deck with whatever cards you want. 
