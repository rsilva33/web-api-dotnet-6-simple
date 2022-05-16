namespace API.Models{
        public class Product {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        //relacionando com Id de Categoria e deve ser do mesmo tipo
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        //Produto pode ter varias Tags
        public List<Tag> Tags { get; set; }
    }
}