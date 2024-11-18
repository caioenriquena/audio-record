# AudioRecorderApp

**AudioRecorderApp** é um aplicativo simples de gravação de áudio em C# que utiliza a biblioteca **NAudio** para capturar o áudio da saída do sistema (loopback). Ele permite gravar tudo o que está sendo reproduzido no computador, como músicas, vídeos e outros sons do sistema, e salvar o áudio em um arquivo no formato WAV.

## Funcionalidades

- Captura de áudio da saída do sistema (loopback), ou seja, grava qualquer áudio sendo reproduzido no computador.
- Interface gráfica simples, construída com **Windows Forms**.
- Gravação de áudio em tempo real e salvamento do arquivo em formato **WAV**.
- Controle fácil para iniciar e parar a gravação via interface.
- Exibição do status da gravação (como "Gravando..." e "Gravação finalizada").

## Tecnologias Utilizadas

- **C#**: Linguagem de programação utilizada para o desenvolvimento do aplicativo.
- **NAudio**: Biblioteca que facilita a captura de áudio no Windows.
- **Windows Forms**: Framework para criar a interface gráfica.

## Como Usar

1. **Clone o repositório**:

```bash
git clone  https://github.com/caioenriquena/audio-record.git
