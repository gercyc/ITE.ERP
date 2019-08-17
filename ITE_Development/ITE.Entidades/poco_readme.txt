Referencia
http://www.eduardopires.net.br/2012/10/classes-poco/

O que é POCO?
Postado em 10 de outubro de 2012	

Olá pessoal, O que é POCO? O que seria uma classe POCO?

Hoje em dia utilizar um ORM como Entity Framework ou NHibernate é bem comum, aplicar conceitos do DDD também vem sido bem abordados e discutidos e em todas essas abordagens acaba surgindo o uso de POCO. Afinal o que é POCO?

Tentar decifrar esse nome vai ser bem difícil, POCO significa Plain OLD CLR Object, tentando traduzir isso eu gosto de chamar POCO de “Bom e velho objeto do CLR”.
POCO é um acrônimo de POJO Plain OLD Java Object, criado por Martin Fowler (um expert em OOP) como ele vem de Java acabou dando esse nome, então os especialistas em .Net fizeram uma pequena mudança para trazer esse conceito ao nosso mundo e surgiu o POCO (mas é o mesmo conceito, não muda nada).

Legal, mas ainda não entendi o que é POCO?

É fácil de entender, POCO é uma classe que segue o ideal do OOP, pois tem estado e comportamento, porém não depende e não conhece nenhum recurso externo além do Framework .Net.

Uma classe POCO é utilizada como classe de domínio (negócio) da sua aplicação, o que chamo de Modelo de Domínio. Um Modelo de Domínio é formado pelas classes que compõem a estrutura de negócio do mundo real.

Nós não desenvolvemos sistemas apenas baseados no Framework .Net, quase sempre necessitamos de uma ferramenta externa, por exemplo um ORM, que por sua vez impõe o uso de referências como classes, interfaces, decorações nos métodos etc…

Construir uma classe POCO é escrever uma classe que contenha atributos, construtores e métodos mas que não dependam de nada mais do que o próprio .Net Framework forneça.

Quem já utilizou o Entity Framework na forma Database First já viu como que fica a bagunça de uma classe? Acabamos gerando um único arquivo EDMX com muitas dependências, herdando de um objeto ObjectContext. Geralmente esse código é bastante poluído e dificíl de estender.

//Exemplo omitido

Veja que neste exemplo não dependemos de nada, é apenas uma classe, tratando de DDD o nosso domínio não pode depender de tecnologia, afinal a minha camada de domínio pode ser adaptada a um outro sistema que não utilizará o Entity Framework e tudo bem! Afinal minha classe POCO não depende disso.

Acredito que a vantagem de usar POCO é exatamente essa, podemos modelar nossas classes de domínio e portá-las para onde quiser, sem a dependência de nenhuma ferramenta externa.

Por isso recomendo que utilizem ferramentas que dê suporte a POCO, e isso não é difícil, por exemplo Entity Framework, NHibernate, WCF permitem trabalhar com POCO.

No Entity Framework, por exemplo, podemos trabalhar da forma Code First, ou seja, escrevemos primeiro classes POCO e no final a modelagem da base de dados é criada conforme a modelagem do nosso domínio.

Então uma classe POCO é uma classe anêmica?
– Não! Uma classe anêmica pode até ser uma classe POCO, mas nada diz que uma classe POCO deve ser anêmica, afinal ela pode possuir atributos e métodos.
Uma classe anêmica não possui métodos, e por alguns é considerada um anti-pattern, pois fere o conceito de orientação a objeto, mas isso é assunto para um outro artigo. 🙂

Uma classe POCO é como se fosse uma DTO então?
– Não! Uma DTO “Data Transfer Object” é outra coisa, pense em DTO como uma “sacola de dados”, ou seja, em um objeto DTO podemos ter dados das classes Pessoa, Endereço, Empresa.
DTO é um outro pattern desenhado justamente para reduzir o número de chamadas e a quantidade de dados necessários para trafegar entre camadas de sistemas, por exemplo, entre uma aplicação web e um serviço.
Uma classe POCO é sua classe de domínio e um DTO é o objeto para transitar dados apenas, podem possuir dados de mais de uma entidade e não possuem métodos, portanto não é POCO.

Se minha classe herda de uma classe base então não tenho uma classe POCO?
– Depende, desde que a classe base não tenha nenhuma dependência com outras camadas da aplicação e ferramentas externas, ainda é uma classe POCO.