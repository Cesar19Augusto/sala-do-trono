using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Estrutura dos livros, capítulos e versículos
        var livros = new Dictionary<string, Dictionary<int, List<string>>>
        {
            {
                "Genesis", new Dictionary<int, List<string>>
                {
                    { 1, new List<string>
                        {
                            "No princípio, Deus criou os céus e a terra.",
                            "A terra era sem forma e vazia; havia trevas sobre as águas profundas, e o Espírito de Deus se movia sobre a face das águas.",
                            "Deus disse: ― Haja luz.E houve luz.",
                            "Deus viu que a luz era boa e fez separação entre a luz e as trevas.",
                            "Deus chamou à luz “dia”, e às trevas chamou “noite”. Passaram‑se a tarde e a manhã; esse foi o primeiro dia."
                        }
                    },
                    { 2, new List<string>
                        {
                            "Assim, foram concluídos os céus e a terra e tudo o que neles há.",
                            "No sétimo dia, Deus já havia concluído o trabalho que realizara; assim, nesse dia, descansou de todo o seu trabalho. ",
                            "Então, Deus abençoou o sétimo dia e o santificou, porque foi nesse dia que ele descansou de todo o trabalho que realizara.",
                            "Este é o registro das origens dos céus e da terra, quando foram criados, no tempo em que o Senhor Deus fez a terra e os céus.",
                            "Ainda não havia nenhum arbusto no campo, e nenhuma planta havia brotado, porque o Senhor Deus ainda não tinha feito chover sobre a terra, e não havia homem para cultivar o solo."
                        }
                    }
                }
            },
            {
                "Exodo", new Dictionary<int, List<string>>
                {
                    { 1, new List<string>
                        {
                            "Estes são os nomes dos filhos de Israel que entraram com Jacó no Egito, cada um com a sua respectiva família:",
                            "Rúben, Simeão, Levi e Judá;",
                            "Issacar, Zebulom e Benjamim;",
                            "Dã, Naftali, Gade e Aser.",
                            "Ao todo, os descendentes de Jacó eram setenta; José, porém, já estava no Egito."
                        }
                    },
                    { 2, new List<string>
                        {
                            "Ora, um homem da tribo de Levi casou‑se com uma mulher da mesma tribo,",
                            "e ela engravidou e deu à luz um filho. Vendo que era bonito, ela o escondeu por três meses.",
                            "Quando não podia mais escondê‑lo, pegou um cesto feito de papiro e o vedou com betume e piche. Colocou nele o menino e deixou o cesto entre os juncos, à margem do Nilo.",
                            "A irmã do menino permaneceu a distância para ver o que lhe aconteceria.",
                            "A filha do faraó desceu ao Nilo para tomar banho. Enquanto isso, as suas servas andavam pela margem do rio. Então, ela viu o cesto entre os juncos e mandou a sua criada apanhá‑lo. "
                        }
                    }
                }
            },
            {
                "Levitico", new Dictionary<int, List<string>>
                {
                    { 1, new List<string>
                    {
                        "Da tenda do encontro, o Senhor chamou Moisés, falou com ele e lhe ordenou:",
                        "― Diga o seguinte aos israelitas: “Quando alguém dentre vocês trouxer uma oferta ao Senhor, escolha um animal dos rebanhos de gado bovino, ovino ou caprino.",
                        "“Se o holocausto for de gado, oferecerá um macho sem defeito. Ele o apresentará à entrada da tenda do encontro para que seja aceito diante do Senhor. ",
                        "Ele porá a mão sobre a cabeça do animal para o holocausto, e este será aceito para fazer expiação por ele.",
                        "Então, o novilho será imolado diante do Senhor, e os sacerdotes, filhos de Arão, trarão o sangue e o aspergirão em todos os lados do altar, que está à entrada da tenda do encontro."
                    }
                    },
                    { 2, new List<string>
                    {
                        "“Quando alguém trouxer uma oferta de cereal ao Senhor, deverá ser da melhor farinha. Sobre ela, derramará óleo, colocará incenso",
                        "e a levará aos filhos de Arão, os sacerdotes. Um deles apanhará um punhado da melhor farinha com azeite e com todo o incenso e os queimará no altar como porção memorial. É oferta preparada no fogo, de aroma agradável ao Senhor. ",
                        "O restante da oferta de cereal pertence a Arão e aos seus filhos; é porção santíssima das ofertas preparadas no fogo, dedicadas ao Senhor.",
                        "“Quando você trouxer uma oferta de cereal assada no forno, que seja da melhor farinha: roscas sem fermento, amassadas com azeite, ou pães finos sem fermento, untados com azeite.",
                        "Se a sua oferta de cereal for preparada em uma assadeira, que seja da melhor farinha amassada com azeite e sem fermento."
                    }
                    }
                }
            }
        };

        // Criar um objeto Random
        Random random = new Random();

        // Escolher aleatoriamente qual livro usar
        var livrosKeys = new List<string>(livros.Keys);
        string livroEscolhido = livrosKeys[random.Next(livrosKeys.Count)];

        // Escolher aleatoriamente qual capítulo usar
        var capitulosKeys = new List<int>(livros[livroEscolhido].Keys);
        int capituloEscolhido = capitulosKeys[random.Next(capitulosKeys.Count)];

        // Escolher um versículo aleatório do capítulo selecionado
        List<string> versiculos = livros[livroEscolhido][capituloEscolhido];
        int versiculoEscolhido = random.Next(versiculos.Count);
        string fraseAleatoria = versiculos[versiculoEscolhido];

        // Exibir o nome do livro, capítulo, versículo e a frase aleatória
        Console.WriteLine($"{livroEscolhido} {capituloEscolhido}:{versiculoEscolhido + 1} \"{fraseAleatoria}\"");
    }
}


//Estrutura dos livros e capitulos
//            {
//                "Livro", new Dictionary<int, List<string>>
//                {
//                    { capitulo, new List<string>
//                      {
//                        "",
//                        ""
//                      }
//                    },
//                    { capitulo, new List<string>
//                      {
//                        "",
//                        ""
//                      }
//                    }
//                }
//            }