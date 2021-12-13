using System;
using System.ComponentModel.DataAnnotations;

namespace Sergio.Business.Models
{
    public class Produto : Entity
    {

        //forneig Key , este produto pertence a um fornecedor
        public Guid FornecedorId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(1000, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Imagem { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public decimal Valor { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }


        //Relacao para este produto um fornecedor indicando para o EF
        // fornecedor tem uma relacao comigo, neste caso um produto tem um fornecedor
        // nao basta a chave informada la em cima, precisa informar aqui  
        public Fornecedor Fornecedor { get; set; }

    }


    public enum TipoFornecedor
    {
        PessoaFisica = 1,
        PessoaJuridica =2
    }
}
