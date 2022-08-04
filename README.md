# CRUD_CLASS_SQL
Projeto Inicial de Crud usando classes
Segue roteiro de criação abaixo para gravar


1ºCrio a classe Conexão
Instancio a conexão ();
Crio o contrutor da classe onde passo a string de conexão
Crio o metodo SqlConect () usando if
(nome da conexão acima .State==System.Data.Connections.Close) mando abrir e retorno o nome da SqlConection
Faço 1 void para desconectar

2º Crio a Classe Cadastro
Instancio SqlComand e Instancio conexão usando a classe criada
*String de mensagem
Crio o construtor cadastro passando os parametros que serão gravados (string *nome da coluna do bancoSQL)
Executo a SqlComand .CommantText -->Passo as instruções para o banco e passo os parametros (nome das strigs)+Try
Try sqlComand .Connection = nome da instancia conexao .nome do metodo da classe conectar
ExecuteNonQuery para enviar dados ao banco
Chamo a desconectar e posso colocar a mensagem usando a string catch a mensagem

3ºEvento do Botão
Instancio o botão com novo nome Cadastro cad = new Ca (passando os textBox) e coloco algum tratamento
