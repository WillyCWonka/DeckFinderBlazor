namespace MTGBlazor.Data;

public class DeckService
{
    private readonly ILogger<DeckService> _logger;
    private readonly Database _database;

    public DeckService(ILogger<DeckService> logger, Database database)
    {
        _logger = logger;
        _database = database;
    }

    public async Task<IEnumerable<Card>> Get(string card1, string card2)
    {
        _logger.LogInformation($"card1:{card1} card2:{card2}");
        var result = await _database.GetDeckAsync(card1, card2);

        return result;
    }

    public async Task<List<string>> AutoComplete(string card1)
    {
        _logger.LogInformation($"autocomplete card1:{card1}");
        var result = await _database.AutoComplete(card1);
        return result;
    }

    public async Task<List<string>> AutoComplete(string card1, string card2)
    {
        _logger.LogInformation($"autocomplete card1:{card1} card2:{card2}");
        var result = await _database.AutoComplete(card1, card2);
        return result;
    }
}
