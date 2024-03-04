# Ponderada SonarQube

## Tecnologias Usadas

Foi usado Dotnet para a aplicação a ser examinada e SonarQube para a análise estática.

Aprendi bastante sobre SonarQube com a instrução, já havia aprendido sobre análise estática de um código com uso de ferramentas, porém nunca tinha visto na prática.

Com a instrução e os autoestudos fui capaz de implementá-lo na prática, foi um aprendizado que poderei utilizar em qualquer projeto daqui para a frente.

## Executando as etapas do código

Resultado da análise inicial:
![image](https://github.com/FelipeSaadi/Ponderada-SonarQube/assets/54749257/271c7920-d88a-429e-af3e-3635ccc401d8)

Ao rodar o teste é possível identificar diversos erros no código, desde construtores criadas e não usadas no código à falhas de segurança por atributos não devidamente protegidos.

Resultado após correções:
![image](https://github.com/FelipeSaadi/Ponderada-SonarQube/assets/54749257/5824bdef-9512-47bd-bc7a-51d2e5e33f26)

Com isso reduzimos os principais problemas encontrados pelo SonarQube, porém ainda restou um security hotspots que precisará ser tratado.

Resultado após correção do uso de random number:
![image](https://github.com/FelipeSaadi/Ponderada-SonarQube/assets/54749257/d144cc29-4b32-4f90-a759-5c068a800c76)
