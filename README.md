# Verificador de Palíndromos – C#

## 🧾 Descrição
Projeto em C# que verifica se uma palavra ou frase é um **palíndromo**.  
O programa remove espaços, coloca tudo em minúsculo, remove acentos manualmente,
inverte o texto e compara com a versão tratada.

---

## 🧠 Fluxo do Programa
1. Usuário digita uma frase.
2. Remove espaços.
3. Converte tudo para minúsculo.
4. Remove acentos.
5. Inverte o texto.
6. Compara texto limpo com o invertido.
7. Exibe o resultado.

---

## 🗂 Estrutura das Classes

### **Program**
Controla o fluxo principal:
- recebe entrada  
- chama classes de processamento  
- exibe o resultado  

### **RemoverAcentos**
Remove manualmente:
```
á à â ã → a
é è ê → e
í ì î → i
ó ò ô õ → o
ú ù û → u
ç → c
```

### **InverterTexto**
Inverte o texto caractere por caractere usando:
- array de char  
- laço `for` decrescente  

### **Palindromo**
Compara caractere por caractere:
- texto limpo  
- texto invertido  

Retorna **true** ou **false**.

---

## 🟩 Exemplo — É palíndromo
**Entrada:**
```
Socorram me subi no onibus em Marrocos
```

**Saída:**
```
Original: Socorram me subi no onibus em Marrocos
Limpo: socorrammesubinoonibusemmarrocos
Invertido: socorrammesubinoonibusemmarrocos
Resultado: É palíndromo ✔
```

---

## 🟥 Exemplo — Não é palíndromo
**Entrada:**
```
Gustavo Canhan
```

**Saída:**
```
Original: Gustavo Canhan
Limpo: gustavocanhan
Invertido: nahnacovatsug
Resultado: Não é palíndromo ✘
```

---

## ▶️ Como Executar
1. Abrir o projeto no Visual Studio  
2. Pressionar **F5**  
3. Digitar uma frase  
4. Conferir o resultado  

---

## ⭐ Pontos Aprendidos
- manipulação de strings  
- arrays  
- for reverso  
- comparação caractere por caractere  
- dividir lógica em várias classes  

---

## 📌 Melhorias Futuras
- validação de entrada vazia  
- remoção de caracteres especiais adicionais  
- interface mais amigável  
- testes automatizados  
