# CorreioProj
Projeto de Modelagem e Simulação.

# Objetivo
Desenvolver um software de modelagem e simulação que simule entregas de produtos para seus respectivos CEPs. Este projeto de `Modelagem e Simulação` visa encontrar uma melhor `logística` (que não seja `FIFO`) para a decisão de entrega destes produtos. 

# Informações do sotware
 * O software é desenvolvido em C# e sua UI foi criada utilizando o [Windows Forms](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/overview/?view=netdesktop-6.0)
 * A `logística de entrega dos produtos` criada para melhorar a simulação consome uma API desenvolvida em `Python` disponível na pasta `ModSimTripTimeAPI` neste mesmo repositório.

# Informações da API
> Mais informações sobre a API estão disponíveis na documentação dos arquivos na pasta `ModSimTripTimeAPI`.

> A API criada _(disponível na pasta ModSimTripTimeAPI)_ foi desenvolvida `especificamente` para este projeto. 

A API foi desenvolvida em Python utilizando [Flask](https://flask.palletsprojects.com/en/2.0.x/). A API utiliza uma outra [API dos correios](https://buscacepinter.correios.com.br/app/endereco/index.php) para validação do CEP e faz uso do [Nominatim](https://nominatim.org/) para adquirir as coordenadas do CEP e o [OpenStreetMap](https://www.openstreetmap.org/) para adquirir informações sobre a rotas.

A API está hospedada no [Glitch](https://glitch.com/) com o link https://sun-superficial-balloon.glitch.me e possui atualmente duas rotas: `/gettripinfo&de=<cepfrom>&para=<cepto>` e `/getcepvalidation&cep=<cep>`. Ex: https://sun-superficial-balloon.glitch.me/gettripinfo&de=01503010&para=03101004

*Protótipo*:
![image](https://i.imgur.com/FTHiqlq.gif)

# Editar
 - Baixe o projeto e a abra o arquivo `CorreioProj.csproj` no [Visual Studio](https://visualstudio.microsoft.com/pt-br/thank-you-downloading-visual-studio/?sku=Community&rel=16)

# Executar 
- Baixe o projeto e abra o executável que está em [CorreioProj/CorreioProj/bin/Debug/netcoreapp3.1/](CorreioProj/bin/Debug/netcoreapp3.1)
