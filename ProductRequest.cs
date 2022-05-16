//Responsavel por criar a aplicação WEB -> Representando a model Product
public record ProductRequest(string Code, string Name, string Description, int CategoryId, List<string> Tags);